#include "repositery.h"
#include<iostream>
#include<sstream>
#include<fstream>
#include<string>
#include<iomanip>
#include<cstdlib>
#include<Windows.h>
using namespace std;
void clearScreen() {
#if defined _WIN32
	system("cls");
#endif
}
void sleepSeconds(int seconds) {
#if defined(_WIN32)
	Sleep(seconds * 1000);
#endif
}
User::User(string uname, string pass) : username(uname), password(pass), loggedIn(false), next(nullptr) {};
int HashTable::hashFunction(const string& key) {
	unsigned long hashVal = 0;
	for (char c : key) {
		hashVal = 37 * hashVal + c;
	}
	return hashVal % TABLE_SIZE;
}
HashTable::HashTable() : userCapacity(10), userCount(0) {
	table = new User * [TABLE_SIZE] {};
	users = new string[userCapacity];
	followMatrix = new bool*[userCapacity];
	for (int i = 0; i < userCapacity; ++i) {
		followMatrix[i] = new bool[userCapacity] {false};
	}
}

HashTable::~HashTable() {
	for (int i = 0; i < TABLE_SIZE; ++i) {
		User* entry = table[i];
		while (entry != nullptr) {
			User* prev = entry;
			entry = entry->next;
			delete prev;
		}
	}
	delete[] table;
	for (int i = 0; i < userCapacity; ++i) {
		delete[] followMatrix[i];
	}
	delete[] followMatrix;
	delete[] users;
}

void HashTable::expandUserMatrix() {
	if (userCount >= userCapacity) {
		int newCapacity = userCapacity * 2;
		string* newUsers = new string[newCapacity];
		bool** newFollowMatrix = new bool*[newCapacity];
		for (int i = 0; i < newCapacity; ++i) {
			newFollowMatrix[i] = new bool[newCapacity] {false};
		}
		// Copy old matrix data
		for (int i = 0; i < userCapacity; i++) {
			newUsers[i] = users[i];
			for (int j = 0; j < userCapacity; j++) {
				newFollowMatrix[i][j] = followMatrix[i][j];
			}
			delete[] followMatrix[i];
		}
		delete[] followMatrix;
		delete[] users;

		users = newUsers;
		followMatrix = newFollowMatrix;
		userCapacity = newCapacity;
	}
}
void HashTable::follow(string follower, string following) {
	int followerIndex = findUserIndex(follower);
	int followingIndex = findUserIndex(following);
	if (followerIndex == -1 || followingIndex == -1) {
		cout << "User not found." << endl;
		return;
	}
	followMatrix[followerIndex][followingIndex] = true;
	cout << follower << " now follows " << following << endl;
}
void HashTable::unfollow(string follower, string following) {
	int followerIndex = findUserIndex(follower);
	int followingIndex = findUserIndex(following);
	if (followerIndex == -1 || followingIndex == -1) {
		cout << "User not found." << endl;
		return;
	}
	followMatrix[followerIndex][followingIndex] = false;
	cout << follower << " has unfollowed " << following << endl;
}

int HashTable::findUserIndex(string username) {
	for (int i = 0; i < userCount; i++) {
		if (users[i] == username) {
			return i;
		}
	}
	return -1;
}
void HashTable::printFollowers(const string& username) {
	int userIndex = findUserIndex(username);
	if (userIndex == -1) {
		cout << "User not found." << endl;
		return;
	}
	bool hasFollowers = false;
	cout << "Followers of " << username << ":" << endl;
	for (int i = 0; i < userCount; i++) {
		if (followMatrix[i][userIndex]) {
			cout << users[i] << " ";
			hasFollowers = true;
		}
	}
	if (!hasFollowers) {
		cout << "No followers found.";
	}
	cout << endl;
}
void HashTable::printFollowGraph() {
	cout << "Follow Matrix (Adjacency Graph):" << endl;
	cout << "  ";
	for (int j = 0; j < userCount; j++) {
		cout << setw(10) << users[j] << " ";
	}
	cout << endl;
	for (int i = 0; i < userCount; i++) {
		cout << setw(10) << users[i] << " ";
		for (int j = 0; j < userCount; j++) {
			cout << setw(10) << (followMatrix[i][j] ? "1" : "0") << "  ";
		}
		cout << endl;
	}
}

void HashTable::registerUser(const string& username, const string& password) {
	int index = hashFunction(username);
	User* newUser = new User(username, password);
	User* current = table[index];

	if (current == nullptr) {

		table[index] = newUser;
		expandUserMatrix();
		users[userCount++] = username;
	}
	else {

		while (current->next != nullptr) {
			if (current->username == username) {

				cout << "User already exists!" << endl;
				delete newUser;
				return;
			}
			current = current->next;
		}
		if (current->username == username) {

			cout << "User already exists!" << endl;
			delete newUser;
			return;
		}

		current->next = newUser;
	}


	string repositories, files, commits, following;
	saveUserToCSV(username, password, "", "", "", "");
}

bool HashTable::loginUser(const string& username, const string& password) {
	int index = hashFunction(username);
	User* current = table[index];

	while (current != nullptr) {
		if (current->username == username && current->password == password) {
			// Save user information to CSV file
			string repositories, files, commits, following;
			saveUserToCSV(username, password, "", "", "", "");
			return true;
		}
		current = current->next;
	}
	return false;
}

void HashTable::logoutUser(const string& username) {
	int index = hashFunction(username);
	User* current = table[index];

	while (current != nullptr) {
		if (current->username == username) {
			current->loggedIn = false;

			string repositories, files, commits, following;
			saveUserToCSV(username, "", "", "", "", "");
			return;
		}
		current = current->next;
	}
}

bool HashTable::findUser(const string& username) {
	int index = hashFunction(username);
	User* current = table[index];

	while (current != nullptr) {
		if (current->username == username) {
			return true;
		}
		current = current->next;
	}
	return false;
}

void HashTable::printUsers() {
	cout << "Current users in the hash table:" << endl;
	for (int i = 0; i < TABLE_SIZE; ++i) {
		User* current = table[i];
		if (current == nullptr) continue;
		cout << "Bucket " << i << ": ";
		while (current != nullptr) {
			cout << current->username << " -> ";
			current = current->next;
		}
		cout << "NULL" << endl;
	}
}
void HashTable::saveUserToCSV(const string& username, const string& password, const string& repositories, const string& files, const string& commits, const string& following) {
	ofstream file("users.csv", ios::app);
	if (file.is_open()) {
		file << username << "," << password << "," << repositories << "," << files << "," << commits << "," << following << endl;
		file.close();
	}
	else {
		cout << "Error: Unable to open users.csv for writing." << endl;
	}
}

bool HashTable::readUsersFromCSV(HashTable& userTable) {
	ifstream file("users.csv");
	if (file.is_open()) {
		string line;
		while (getline(file, line)) {
			stringstream ss(line);
			string username, password, repositories, files, commits, following;

			if (getline(ss, username, ',') &&
				getline(ss, password, ',') &&
				getline(ss, repositories, ',') &&
				getline(ss, files, ',') &&
				getline(ss, commits, ',') &&
				getline(ss, following)) {


				userTable.registerUser(username, password);


				cout << "Username: " << username << ", Password: " << password << ", Repositories: " << repositories << ", Files: " << files << ", Commits: " << commits << ", Following: " << following << endl;
			}
		}
		file.close();
		return true;
	}
	else {
		cout << "Error: Unable to open users.csv for reading." << endl;
		return false;
	}
}

commitnode::commitnode(string comcode)
{
	this->comcode = comcode;
	this->next = NULL;
}
filenode::filenode(string filename, string filedata)
{
	this->filename = filename;
	this->filedata = filedata;
	this->next = NULL;
}
repnode::repnode(string uname, string repname, bool ispublic)
{
	username = uname;
	this->reponame = repname;
	this->ispublic = ispublic;
	forkcount = 0;
	comhead = NULL;
	filehead = NULL;
	left = NULL;
	right = NULL;
}

void repositery::insertcommit(commitnode*& commithead, string comcode)
{
	commitnode* newcomnode = new commitnode(comcode);
	newcomnode->next = commithead;
	commithead = newcomnode;
}

void  repositery::insertfile(filenode*& filehead, string filename, string filedata)
{
	filenode* newfilenode = new filenode(filename, filedata);
	newfilenode->next = filehead;
	filehead = newfilenode;
}

void  repositery::deletecommit(commitnode*& commithead)
{
	if (commithead == NULL)
	{
		return;
	}

	commitnode* temp = commithead;
	cout << "Commit Content " << temp->comcode << " is to be Deleted " << endl;
	commithead = commithead->next;
	delete temp;
}
void  repositery::deletefile(filenode*& filehead, string filename)
{
	if (filehead == NULL)
	{
		return;
	}
	if (filehead->filename == filename)
	{
		filenode* temp = filehead;
		filehead = filehead->next;
		delete temp;
		return;
	}
	filenode* current = filehead;
	while (current->next != NULL && current->next->filename != filename)
	{
		current = current->next;
	}

	if (current->next != NULL)
	{
		filenode* temp = current->next;
		current->next = current->next->next;
		delete temp;
	}
}
repnode* repositery::find(repnode* root, string reponame)
{
	if (root == NULL || root->reponame == reponame)
		return root;

	if (reponame < root->reponame)
		return find(root->left, reponame);
	else
		return find(root->right, reponame);
}

int repositery::height(repnode* root)
{
	if (root == NULL)
		return -1;
	else
	{
		int lheight = height(root->left);
		int rheight = height(root->right);
		if (lheight > rheight)
			return (lheight + 1);
		else
			return (rheight + 1);
	}
}

int  repositery::getbalancefactor(repnode* root)
{
	if (root == NULL)
		return 0;
	return height(root->left) - height(root->right);
}

repnode* repositery::rightRotate(repnode* root)
{
	repnode* root1 = root->left;
	repnode* root2 = root1->right;

	root1->right = root;
	root->left = root2;

	return root1;
}

repnode* repositery::leftRotate(repnode* root)
{
	repnode* root1 = root->right;
	repnode* root2 = root1->left;

	root1->left = root;
	root->right = root2;

	return root1;
}

void  repositery::deletetree(repnode* root)
{
	if (root == NULL)
		return;

	deletetree(root->left);
	deletetree(root->right);
	delete root;
}
repositery::repositery(HashTable& usertable)
{
	userTable = usertable;
	root = NULL;
	userCapacity = 10;
	userCount = 0;
	users = new string[userCapacity];
	followMatrix = new bool*[userCapacity];
	for (int i = 0; i < userCapacity; i++) {
		followMatrix[i] = new bool[userCapacity] {false};
	}
}
repositery::~repositery()
{
	for (int i = 0; i < userCapacity; i++) {
		delete[] followMatrix[i];
	}
	delete[] followMatrix;
	delete[] users;
}
repnode* repositery::insert(repnode* root, string username, string reponame, bool ispublic)
{
	if (root == NULL)
	{
		root = new repnode(username, reponame, ispublic);
		return root;
	}

	if (reponame < root->reponame)
		root->left = insert(root->left, username, reponame, ispublic);
	else if (reponame > root->reponame)
		root->right = insert(root->right, username, reponame, ispublic);
	else
		return root;

	int bf = getbalancefactor(root);

	/*Left Left Case  */
	if (bf > 1 && reponame < root->left->reponame)
		return rightRotate(root);

	/*Right Right Case  */
	if (bf < -1 && reponame > root->right->reponame)
		return leftRotate(root);

	/*Left Right Case  */
	if (bf > 1 && reponame > root->left->reponame)
	{
		root->left = leftRotate(root->left);
		return rightRotate(root);
	}

	/*Right Left Case */
	if (bf < -1 && reponame < root->right->reponame)
	{
		root->right = rightRotate(root->right);
		return leftRotate(root);
	}

	return root;
}

void repositery::registerUser(const string& username, const string& password) {
	userTable.registerUser(username, password);
}

bool  repositery::loginUser(const string& username, const string& password) {
	return userTable.loginUser(username, password);
}

void  repositery::createrepo(string& username, string& reponame, bool ispublic) {
	if (!userTable.findUser(username)) {
		cout << "User '" << username << "' not found. Cannot create repository." << endl;
		return;
	}
	root = insert(root, username, reponame, ispublic);
	cout << "Repository '" << reponame << "' created successfully." << endl;
	saveRepoToCSV(username, reponame, ispublic);
}

void  repositery::deleteRepositery(string& username, string& reponame) {
	if (!userTable.findUser(username)) {
		cout << "User '" << username << "' not found. Cannot delete repository." << endl;
		return;
	}
	root = deletrepo(root, username, reponame);
	cout << "Repository '" << reponame << "' deleted successfully." << endl;
}


repnode* repositery::deletrepo(repnode* root, string& username, string& reponame)
{
	if (root == NULL)
		return root;

	if (reponame < root->reponame)
		root->left = deletrepo(root->left, username, reponame);
	else if (reponame > root->reponame)
		root->right = deletrepo(root->right, username, reponame);
	else
	{
		if (root->right == NULL)
		{
			repnode* temp = root->left;
			delete root;
			return temp;
		}
		if (root->left == NULL)
		{
			repnode* temp = root->right;
			delete root;
			return temp;
		}

		repnode* temp = minval(root->right);
		root->reponame = temp->reponame;
		root->right = deletrepo(root->right, username, temp->reponame);
	}

	int bf = getbalancefactor(root);

	/*	LL*/
	if (bf == 2 && getbalancefactor(root->left) >= 0)
		return rightRotate(root);

	//lR
	if (bf == 2 && getbalancefactor(root->left) == -1)
	{
		root->left = leftRotate(root->left);
		return rightRotate(root);
	}

	/*	RR */
	if (bf == -2 && getbalancefactor(root->right) <= 0)
		return leftRotate(root);

	/*	RL*/
	if (bf == -2 && getbalancefactor(root->right) == 1)
	{
		root->right = rightRotate(root->right);
		return leftRotate(root);
	}

	return root;
}

repnode* repositery::minval(repnode* root)
{
	repnode* curr = root;
	while (curr->left != NULL)
	{
		curr = curr->left;
	}
	return curr;
}

void  repositery::addfilerep(string reponame, string filename)
{
	repnode* foundrepo = find(root, reponame);
	if (foundrepo != NULL)
	{
		string filedata = readFileData(filename);
		insertfile(foundrepo->filehead, filename, filedata);
		cout << "File : " << filename << " Added to Repository " << reponame << endl;

	}
	else
	{
		cout << "Repository Not Found " << endl;
	}
}

void  repositery::deletefilerep(string reponame, string filename)
{
	repnode* foundrepo = find(root, reponame);
	if (foundrepo != NULL)
	{
		deletefile(foundrepo->filehead, filename);
		removefile(filename);
		cout << "File : " << filename << " deleted from Repository " << reponame << endl;
	}
	else
	{
		cout << "Repository Not Found " << endl;
	}
}
void  repositery::removefile(string filename)
{
	if (remove(filename.c_str()) != 0)
	{
		perror("Error deleting file");
	}
	else
	{
		cout << "File deleted successfully" << endl;
	}
}
void  repositery::addcomrep(string reponame, string filename)
{

	repnode* addrepo = find(root, reponame);
	if (addrepo != NULL)
	{

		ofstream file(filename, ios::app);
		if (file.is_open())
		{
			string comcode;

			cout << "Enter commit message (type 'end' to stop):" << endl;
			while (true)
			{
				getline(cin, comcode);
				if (comcode == "end")
					break;
				file << comcode << endl;
				insertcommit(addrepo->comhead, comcode);
				cout << "Commit Added Successfully: " << comcode << endl;
			}
			file.close();
		}
		else
		{

			cout << "File does not exist. Do you want to create a new file? (1 for Yes, 0 for No): ";
			int createFileChoice;
			cin >> createFileChoice;

			if (createFileChoice == 1)
			{
				ofstream newfile(filename);
				if (newfile.is_open())
				{
					cout << "New file created successfully." << endl;
					newfile.close();
				}
				else
				{
					cout << "Error: Unable to create new file." << endl;
				}
			}
			else
			{
				cout << "Commit not added. File does not exist." << endl;
			}
		}
	}
	else
	{
		cout << "Repository Not Found " << endl;
	}
}
void  repositery::deletecomrep(string reponame, string commitFilename, string comcode)
{
	repnode* foundrepo = find(root, reponame);
	if (foundrepo != NULL)
	{
		ifstream file(commitFilename);
		if (file.is_open())
		{
			string line;
			string tempFilename = "temp.txt";
			ofstream tempFile(tempFilename);
			bool found = false;
			cout << "Commit to delete: " << comcode << endl;
			while (getline(file, line))
			{

				string trimmedLine = trim(line);
				string trimmedComcode = trim(comcode);
				cout << "Line read from file: [" << trimmedLine << "]" << endl;
				cout << "Comcode to match: [" << trimmedComcode << "]" << endl;

				if (trimmedLine != trimmedComcode)
				{
					tempFile << line << endl;
				}
				else
				{
					found = true;
				}
			}
			file.close();
			tempFile.close();
			remove(commitFilename.c_str());
			rename(tempFilename.c_str(), commitFilename.c_str());
			if (found)
			{
				cout << "Commit : " << comcode << " deleted from Repository " << reponame << endl;
			}
			else
			{
				cout << "Commit not found in repository." << endl;
			}
		}
		else
		{
			cout << "Error: Unable to open commit file." << endl;
		}
	}
	else
	{
		cout << "Repository Not Found " << endl;
	}
}
string  repositery::trim(const string& str) {
	size_t first = str.find_first_not_of(' ');
	if (string::npos == first) {
		return str;
	}
	size_t last = str.find_last_not_of(' ');
	return str.substr(first, (last - first + 1));
}
void  repositery::setvisibility(string reponame, bool ispublic)
{
	repnode* repo = find(root, reponame);
	if (!repo)
	{
		cout << "Repositery Not found " << endl;
		return;
	}
	else
	{
		repo->ispublic = ispublic;
		string visibility = (ispublic ? "public" : "private");
		cout << "Repository '" << reponame << "' viisibility set to " << visibility << "." << endl;
	}
}
void  repositery::viewrepostats(const string& username, const string& reponame, repositery& r) {

	if (!r.userTable.findUser(username)) {
		cout << "Username not found." << endl;
		return;
	}


	repnode* repo = r.find(r.root, reponame);

	if (!repo) {
		cout << "Repository not found." << endl;
		return;
	}

	cout << "Repository Name: " << repo->reponame << endl;

	if (repo->ispublic) {
		cout << "Repository Files: ";
		filenode* files = repo->filehead;
		if (!files) {
			cout << "No Files Exist" << endl;
		}
		else {
			while (files) {
				cout << files->filename << ", ";
				files = files->next;
			}
			cout << endl;
		}

		cout << "Repository Commits: ";
		commitnode* commits = repo->comhead;
		if (!commits) {
			cout << "No Commits Exist" << endl;
		}
		else {
			while (commits) {
				cout << commits->comcode << ", ";
				commits = commits->next;
			}
			cout << endl;
		}

		cout << "Repository Fork Count: " << repo->forkcount << endl;
		string visibility = (repo->ispublic ? "Public" : "Private");
		cout << "Repository Visibility: " << visibility << endl;
	}
	else {
		cout << "Repository is private. No stats available." << endl;
	}
}
void  repositery::displayUserProfile(HashTable& userTable, repositery& repo, const string& username) {
	if (!userTable.findUser(username)) {
		cout << "Username not found." << endl;
		return;
	}
	repnode* userRepos = repo.find(repo.root, username);
	if (!userRepos) {
		cout << "User does not have any repositories." << endl;
		return;
	}

	cout << "User Profile Information" << endl;
	cout << "------------------------" << endl;
	cout << "Username: " << username << endl;


	cout << "Followers: ";
	userTable.printFollowers(username);

	cout << "Repositories:" << endl;
	while (userRepos) {
		cout << "- " << userRepos->reponame << endl;
		userRepos = userRepos->right;
	}
}


void  repositery::forkRepo(string username, string sourcerepo, string newrepo, bool ispublic)
{
	repnode* source = find(root, sourcerepo);
	if (!source)
	{
		cout << "Source repository not found." << endl;
		return;
	}

	root = insert(root, username, newrepo, ispublic);
	repnode* newRoot = find(root, newrepo);

	newRoot->ispublic = source->ispublic;
	newRoot->forkcount++;
	newRoot->filehead = source->filehead;
	newRoot->comhead = source->comhead;

	cout << "Repository '" << sourcerepo << "' forked successfully as '" << newrepo << "'." << endl;
}
string  repositery::readFileData(const string& filename)
{
	string filedata;
	ifstream file(filename);
	if (file.is_open())
	{
		string line;
		while (getline(file, line))
		{
			filedata += line + "\n";
		}
		file.close();
	}
	return filedata;
}
void  repositery::writeFileData(const string& filename, const string& filedata)
{
	ofstream file(filename);
	if (file.is_open())
	{
		file << filedata;
		file.close();
	}
}
void  repositery::deleteFileData(const string& filename)
{
	ofstream file(filename, ofstream::trunc);
	if (file.is_open())
	{
		file.close();
		cout << "File data deleted successfully." << endl;
	}
	else
	{
		cout << "Error: Unable to delete file data. File may not exist." << endl;
	}
}
void  repositery::saveRepoToCSV(const string& username, const string& reponame, bool ispublic) {
	ofstream file("users.csv", ios::app);
	if (file.is_open()) {
		file << username << "," << reponame << "," << (ispublic ? "public" : "private") << endl;
		file.close();
	}
	else {
		cout << "Error: Unable to open repositories.csv for writing." << endl;
	}
	string repoFileName = reponame + "_files.csv";
	ofstream repoFile(repoFileName, ios::app);
	if (repoFile.is_open()) {
		repoFile << "File Name,Commit Message" << endl;
		repnode* repo = find(root, reponame);
		if (repo) {
			filenode* filePtr = repo->filehead;
			commitnode* commitPtr = repo->comhead;
			while (filePtr && commitPtr) {
				repoFile << filePtr->filename << "," << commitPtr->comcode << endl;
				filePtr = filePtr->next;
				commitPtr = commitPtr->next;
			}
		}
		repoFile.close();
	}
	else {
		cout << "Error: Unable to open " << repoFileName << " for writing." << endl;
	}
}


bool  repositery::readReposFromCSV(repositery& repo) {
	ifstream file("users.csv");
	if (file.is_open()) {
		string line;
		while (getline(file, line)) {
			stringstream ss(line);
			string username, reponame, visibility;
			if (getline(ss, username, ',') &&
				getline(ss, reponame, ',') &&
				getline(ss, visibility)) {

				bool ispublic = (visibility == "public" ? true : false);
				cout << "Username: " << username << ", Repository: " << reponame << ", Visibility: " << visibility << endl;
				repo.insert(repo.root, username, reponame, ispublic);

				string repoFileName = reponame + "_files.csv";
				ifstream repoFile(repoFileName);
				if (repoFile.is_open()) {
					string repoLine;

					getline(repoFile, repoLine);
					while (getline(repoFile, repoLine)) {
						stringstream repoSS(repoLine);
						string filename, comcode;
						if (getline(repoSS, filename, ',') && getline(repoSS, comcode, ',')) {

							cout << "File Name: " << filename << ", Commit: " << comcode << endl;

						}
					}
					repoFile.close();
				}
				else {
					cout << "Error: Unable to open " << repoFileName << " for reading." << endl;
				}
			}
		}
		file.close();
		return true;
	}
	else {
		cout << "Error: Unable to open repositories.csv for reading." << endl;
		return false;
	}
}