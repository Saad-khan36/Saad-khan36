//#include<iostream>
//#include<fstream>
//#include<string>
//using namespace std;
//class commitnode
//{
//public:
//	string comcode;
//	commitnode* next;
//	commitnode(string comcode)
//	{
//		this->comcode = comcode;
//		this->next = NULL;
//	}
//};
//class filenode
//{
//public:
//	string filename;
//	string filedata;
//	filenode* next;
//	filenode(string filename, string filedata)
//	{
//		this->filename = filename;
//		this->filedata = filedata;
//		this->next = NULL;
//	}
//};
//class repnode
//{
//public:
//	string reponame;
//	int forkcount;
//	bool ispublic;
//	commitnode* comhead;
//	filenode* filehead;
//	repnode* left;
//	repnode* right;
//	repnode(string repname, bool ispublic = true)
//	{
//		this->reponame = repname;
//		this->ispublic = ispublic;
//		forkcount = 0;
//		comhead = NULL;
//		filehead = NULL;
//		left = NULL;
//		right = NULL;
//	}
//};
//
//class repositery
//{
//private:
//	repnode* root;
//
//	void insertcommit(commitnode*& commithead, string comcode)
//	{
//		commitnode* newcomnode = new commitnode(comcode);
//		newcomnode->next = commithead;
//		commithead = newcomnode;
//	}
//
//	void insertfile(filenode*& filehead, string filename, string filedata)
//	{
//		filenode* newfilenode = new filenode(filename, filedata);
//		newfilenode->next = filehead;
//		filehead = newfilenode;
//	}
//
//	void deletecommit(commitnode*& commithead)
//	{
//		if (commithead == NULL)
//		{
//			return;
//		}
//
//		commitnode* temp = commithead;
//		cout << "Commit Content " << temp->comcode << " is to be Deleted " << endl;
//		commithead = commithead->next;
//		delete temp;
//	}
//	void deletefile(filenode*& filehead, string filename)
//	{
//		if (filehead == NULL)
//		{
//			return;
//		}
//		if (filehead->filename == filename)
//		{
//			filenode* temp = filehead;
//			filehead = filehead->next;
//			delete temp;
//			return;
//		}
//		filenode* current = filehead;
//		while (current->next != NULL && current->next->filename != filename)
//		{
//			current = current->next;
//		}
//
//		if (current->next != NULL)
//		{
//			filenode* temp = current->next;
//			current->next = current->next->next;
//			delete temp;
//		}
//	}
//	repnode* find(repnode* root, string reponame)
//	{
//		if (root == NULL || root->reponame == reponame)
//			return root;
//
//		if (reponame < root->reponame)
//			return find(root->left, reponame);
//		else
//			return find(root->right, reponame);
//	}
//
//	int height(repnode* root)
//	{
//		if (root == NULL)
//			return -1;
//		else
//		{
//			int lheight = height(root->left);
//			int rheight = height(root->right);
//			if (lheight > rheight)
//				return (lheight + 1);
//			else
//				return (rheight + 1);
//		}
//	}
//
//	int getbalancefactor(repnode* root)
//	{
//		if (root == NULL)
//			return 0;
//		return height(root->left) - height(root->right);
//	}
//
//	repnode* rightRotate(repnode* root)
//	{
//		repnode* root1 = root->left;
//		repnode* root2 = root1->right;
//
//		root1->right = root;
//		root->left = root2;
//
//		return root1;
//	}
//
//	repnode* leftRotate(repnode* root)
//	{
//		repnode* root1 = root->right;
//		repnode* root2 = root1->left;
//
//		root1->left = root;
//		root->right = root2;
//
//		return root1;
//	}
//
//	void deletetree(repnode* root)
//	{
//		if (root == NULL)
//			return;
//
//		deletetree(root->left);
//		deletetree(root->right);
//		delete root;
//	}
//
//public:
//	repositery()
//	{
//		root = NULL;
//	}
//
//	repnode* insert(repnode* root, string reponame, bool ispublic = true)
//	{
//		if (root == NULL)
//		{
//			root = new repnode(reponame, ispublic);
//			return root;
//		}
//
//		if (reponame < root->reponame)
//			root->left = insert(root->left, reponame, ispublic);
//		else if (reponame > root->reponame)
//			root->right = insert(root->right, reponame, ispublic);
//		else
//			return root;
//
//		int bf = getbalancefactor(root);
//
//		//Left Left Case  
//		if (bf > 1 && reponame < root->left->reponame)
//			return rightRotate(root);
//
//		//Right Right Case  
//		if (bf < -1 && reponame > root->right->reponame)
//			return leftRotate(root);
//
//		//Left Right Case  
//		if (bf > 1 && reponame > root->left->reponame)
//		{
//			root->left = leftRotate(root->left);
//			return rightRotate(root);
//		}
//
//		//Right Left Case  
//		if (bf < -1 && reponame < root->right->reponame)
//		{
//			root->right = rightRotate(root->right);
//			return leftRotate(root);
//		}
//
//		return root;
//	}
//
//	void createrepo(string reponame, bool ispublic)
//	{
//		root = insert(root, reponame, ispublic);
//		root->ispublic = ispublic;
//		cout << "Repository '" << reponame << "' created successfully." << endl;
//	}
//
//	void deleteRepositery(string reponame)
//	{
//		root = deletrepo(root, reponame);
//		cout << "Repository '" << reponame << "' deleted successfully." << endl;
//	}
//
//	repnode* deletrepo(repnode* root, string& reponame)
//	{
//		if (root == NULL)
//			return root;
//
//		if (reponame < root->reponame)
//			root->left = deletrepo(root->left, reponame);
//		else if (reponame > root->reponame)
//			root->right = deletrepo(root->right, reponame);
//		else
//		{
//			if (root->right == NULL)
//			{
//				repnode* temp = root->left;
//				delete root;
//				return temp;
//			}
//			if (root->left == NULL)
//			{
//				repnode* temp = root->right;
//				delete root;
//				return temp;
//			}
//
//			repnode* temp = minval(root->right);
//			root->reponame = temp->reponame;
//			root->right = deletrepo(root->right, temp->reponame);
//		}
//
//		int bf = getbalancefactor(root);
//
//		//LL
//		if (bf == 2 && getbalancefactor(root->left) >= 0)
//			return rightRotate(root);
//
//		//lR
//		if (bf == 2 && getbalancefactor(root->left) == -1)
//		{
//			root->left = leftRotate(root->left);
//			return rightRotate(root);
//		}
//
//		//RR 
//		if (bf == -2 && getbalancefactor(root->right) <= 0)
//			return leftRotate(root);
//
//		//RL
//		if (bf == -2 && getbalancefactor(root->right) == 1)
//		{
//			root->right = rightRotate(root->right);
//			return leftRotate(root);
//		}
//
//		return root;
//	}
//
//	repnode* minval(repnode* root)
//	{
//		repnode* curr = root;
//		while (curr->left != NULL)
//		{
//			curr = curr->left;
//		}
//		return curr;
//	}
//
//	void addfilerep(string reponame, string filename)
//	{
//		repnode* foundrepo = find(root, reponame);
//		if (foundrepo != NULL)
//		{
//			string filedata = readFileData(filename);
//			insertfile(foundrepo->filehead, filename, filedata);
//			cout << "File : " << filename << " Added to Repository " << reponame << endl;
//		}
//		else
//		{
//			cout << "Repository Not Found " << endl;
//		}
//	}
//
//	void deletefilerep(string reponame, string filename)
//	{
//		repnode* foundrepo = find(root, reponame);
//		if (foundrepo != NULL)
//		{
//			deletefile(foundrepo->filehead, filename);
//			removefile(filename);
//			cout << "File : " << filename << " deleted from Repository " << reponame << endl;
//		}
//		else
//		{
//			cout << "Repository Not Found " << endl;
//		}
//	}
//	void removefile(string filename)
//	{
//		if (remove(filename.c_str()) != 0)
//		{
//			perror("Error deleting file");
//		}
//		else
//		{
//			cout << "File deleted successfully" << endl;
//		}
//	}
//	void addcomrep(string reponame, string filename)
//	{
//
//		repnode* addrepo = find(root, reponame);
//		if (addrepo != NULL)
//		{
//
//			ofstream file(filename, ios::app);
//			if (file.is_open())
//			{
//				string comcode;
//
//				cout << "Enter commit message (type 'end' to stop):" << endl;
//				while (true)
//				{
//					getline(cin, comcode);
//					if (comcode == "end")
//						break;
//					file << comcode << endl;
//					insertcommit(addrepo->comhead, comcode);
//					cout << "Commit Added Successfully: " << comcode << endl;
//				}
//				file.close();
//			}
//			else
//			{
//
//				cout << "File does not exist. Do you want to create a new file? (1 for Yes, 0 for No): ";
//				int createFileChoice;
//				cin >> createFileChoice;
//
//				if (createFileChoice == 1)
//				{
//					ofstream newfile(filename);
//					if (newfile.is_open())
//					{
//						cout << "New file created successfully." << endl;
//						newfile.close();
//					}
//					else
//					{
//						cout << "Error: Unable to create new file." << endl;
//					}
//				}
//				else
//				{
//					cout << "Commit not added. File does not exist." << endl;
//				}
//			}
//		}
//		else
//		{
//			cout << "Repository Not Found " << endl;
//		}
//	}
//	void deletecomrep(string reponame, string commitFilename, string comcode)
//	{
//		repnode* foundrepo = find(root, reponame);
//		if (foundrepo != NULL)
//		{
//			ifstream file(commitFilename);
//			if (file.is_open())
//			{
//				string line;
//				string tempFilename = "temp.txt";
//				ofstream tempFile(tempFilename);
//				bool found = false;
//				cout << "Commit to delete: " << comcode << endl;
//				while (getline(file, line))
//				{
//					// Trim both the line read from the file and the comcode
//					string trimmedLine = trim(line);
//					string trimmedComcode = trim(comcode);
//					cout << "Line read from file: [" << trimmedLine << "]" << endl;
//					cout << "Comcode to match: [" << trimmedComcode << "]" << endl;
//
//					if (trimmedLine != trimmedComcode)
//					{
//						tempFile << line << endl;
//					}
//					else
//					{
//						found = true;
//					}
//				}
//				file.close();
//				tempFile.close();
//				remove(commitFilename.c_str());
//				rename(tempFilename.c_str(), commitFilename.c_str());
//				if (found)
//				{
//					cout << "Commit : " << comcode << " deleted from Repository " << reponame << endl;
//				}
//				else
//				{
//					cout << "Commit not found in repository." << endl;
//				}
//			}
//			else
//			{
//				cout << "Error: Unable to open commit file." << endl;
//			}
//		}
//		else
//		{
//			cout << "Repository Not Found " << endl;
//		}
//	}
//	string trim(const string& str) {
//		size_t first = str.find_first_not_of(' ');
//		if (string::npos == first) {
//			return str;
//		}
//		size_t last = str.find_last_not_of(' ');
//		return str.substr(first, (last - first + 1));
//	}
//	void setvisibility(string reponame, bool ispublic)
//	{
//		repnode* repo = find(root, reponame);
//		if (!repo)
//		{
//			cout << "Repositery Not found " << endl;
//			return;
//		}
//		else
//		{
//			repo->ispublic = ispublic;
//			string visibility = (ispublic ? "public" : "private");
//			cout << "Repository '" << reponame << "' viisibility set to " << visibility << "." << endl;
//		}
//	}
//
//	void viewrepostats(string reponame) {
//		repnode* repo = find(root, reponame);
//		if (!repo) {
//			cout << "Repository not found." << endl;
//			return;
//		}
//
//		cout << "Repository Name: " << repo->reponame << endl;
//
//		if (repo->ispublic) {
//			cout << "Repository Files: ";
//			filenode* files = repo->filehead;
//			if (!files) {
//				cout << "No Files Exist" << endl;
//			}
//			else {
//				while (files) {
//					cout << files->filename << ", ";
//					files = files->next;
//				}
//				cout << endl;
//			}
//
//			cout << "Repository Commits: ";
//			commitnode* commits = repo->comhead;
//			if (!commits) {
//				cout << "No Commits Exist" << endl;
//			}
//			else {
//				while (commits) {
//					cout << commits->comcode << ", ";
//					commits = commits->next;
//				}
//				cout << endl;
//			}
//
//			cout << "Repository Fork Count: " << repo->forkcount << endl;
//			string visibility = (repo->ispublic ? "Public" : "Private");
//			cout << "Repository Visibility: " << visibility << endl;
//		}
//		else {
//			cout << "Repository is private. No stats available." << endl;
//		}
//	}
//
//
//	void forkRepo(string sourcerepo, string newrepo, bool ispublic)
//	{
//		repnode* source = find(root, sourcerepo);
//		if (!source)
//		{
//			cout << "Source repository not found." << endl;
//			return;
//		}
//
//		root = insert(root, newrepo, ispublic);
//		repnode* newRoot = find(root, newrepo);
//
//		newRoot->ispublic = source->ispublic;
//		newRoot->forkcount++;
//		newRoot->filehead = source->filehead;
//		newRoot->comhead = source->comhead;
//
//		cout << "Repository '" << sourcerepo << "' forked successfully as '" << newrepo << "'." << endl;
//	}
//	string readFileData(const string& filename)
//	{
//		string filedata;
//		ifstream file(filename);
//		if (file.is_open())
//		{
//			string line;
//			while (getline(file, line))
//			{
//				filedata += line + "\n";
//			}
//			file.close();
//		}
//		return filedata;
//	}
//	void writeFileData(const string& filename, const string& filedata)
//	{
//		ofstream file(filename);
//		if (file.is_open())
//		{
//			file << filedata;
//			file.close();
//		}
//	}
//	void deleteFileData(const string& filename)
//	{
//		ofstream file(filename, ofstream::trunc);
//		if (file.is_open())
//		{
//			file.close();
//			cout << "File data deleted successfully." << endl;
//		}
//		else
//		{
//			cout << "Error: Unable to delete file data. File may not exist." << endl;
//		}
//	}
//
//};
//int main()
//{
//	repositery repo;
//	int choice;
//
//	do {
//		cout << "\n=== Repository Management System ===" << endl;
//		cout << "1. Create Repository" << endl;
//		cout << "2. Delete Repository" << endl;
//		cout << "3. Fork Repository" << endl;
//		cout << "4. Set Repository Visibility" << endl;
//		cout << "5. File Operations" << endl;
//		cout << "6. Commit Operations " << endl;
//		cout << "7. View Repository Stats" << endl;
//		cout << "8. Exit" << endl;
//		cout << "Enter your choice: ";
//		cin >> choice;
//
//		switch (choice)
//		{
//		case 1:
//		{
//			string reponame;
//			bool ispublic;
//			cout << "Enter repository name: ";
//			cin >> reponame;
//			cout << "Is the repository public? (1 for Yes, 0 for No): ";
//			cin >> ispublic;
//			repo.createrepo(reponame, ispublic);
//			break;
//		}
//		case 2:
//		{
//			string reponame;
//			cout << "Enter repository name to delete: ";
//			cin >> reponame;
//			repo.deleteRepositery(reponame);
//			break;
//		}
//		case 3:
//		{
//			string sourcerepo, newrepo;
//			bool ispublic;
//			cout << "Enter source repository name to fork: ";
//			cin >> sourcerepo;
//			cout << "Enter new repository name: ";
//			cin >> newrepo;
//			cout << "Set repository visibility (1 for public, 0 for private): ";
//			cin >> ispublic;
//			repo.forkRepo(sourcerepo, newrepo, ispublic);
//			break;
//		}
//		case 4:
//		{
//			string reponame;
//			bool ispublic;
//			cout << "Enter repository name: ";
//			cin >> reponame;
//			cout << "Set repository visibility (1 for public, 0 for private): ";
//			cin >> ispublic;
//			repo.setvisibility(reponame, ispublic);
//			break;
//		}
//		case 5:
//		{
//			int fileopchoice;
//			cout << "\n=== File Operations ===" << endl;
//			cout << "1. Add File" << endl;
//			cout << "2. Delete File" << endl;
//			cout << "3. Read File" << endl;
//			cout << "4. Write to File" << endl;
//			cout << "5. Delete File Data" << endl;
//			cout << "Enter your choice: ";
//			cin >> fileopchoice;
//
//			switch (fileopchoice)
//			{
//			case 1:
//			{
//				string reponame, filename;
//				cout << "Enter repository name: ";
//				cin >> reponame;
//				cout << "Enter file name: ";
//				cin >> filename;
//				repo.addfilerep(reponame, filename);
//				break;
//			}
//			case 2:
//			{
//				string reponame, filename;
//				cout << "Enter repository name: ";
//				cin >> reponame;
//				cout << "Enter file name to delete: ";
//				cin >> filename;
//				repo.deletefilerep(reponame, filename);
//				break;
//			}
//			case 3:
//			{
//				string filename;
//				cout << "Enter file name to read data from: ";
//				cin >> filename;
//				string filedata = repo.readFileData(filename);
//				cout << "File Data: " << endl;
//				cout << filedata << endl;
//				break;
//			}
//			case 4:
//			{
//				string filename, filedata;
//				cout << "Enter file name to write data to: ";
//				cin >> filename;
//				cin.ignore();
//				cout << "Enter file data: ";
//				getline(cin, filedata);
//				repo.writeFileData(filename, filedata);
//				cout << "Data written to file successfully." << endl;
//				break;
//			}
//			case 5:
//			{
//				string filename;
//				cout << "Enter file name to delete data from: ";
//				cin >> filename;
//				repo.deleteFileData(filename);
//				cout << "File data deleted successfully." << endl;
//				break;
//			}
//			default:
//				cout << "Invalid file operation choice. Please try again." << endl;
//				break;
//			}
//			break;
//		}
//		case 6:
//		{
//			int comopchoice;
//			cout << "\n=== Commit Operations ===" << endl;
//			cout << "1. Add Commit" << endl;
//			cout << "2. Delete Commit Message From Commit File" << endl;
//			cout << "Enter your choice: ";
//			cin >> comopchoice;
//			if (comopchoice == 1) {
//				string reponame, filename;
//				cout << "Enter repository name: ";
//				cin >> reponame;
//				cout << "Enter file name : ";
//				cin.ignore();
//				getline(cin, filename);
//				repo.addcomrep(reponame, filename);
//				break;
//			}
//			else if (comopchoice == 2) {
//				string reponame, comcode, filename;
//				cout << "Enter repository name: ";
//				cin >> reponame;
//				cout << "Enter file name : ";
//				cin.ignore();
//				getline(cin, filename);
//				cout << "Enter commit message: ";
//				getline(cin, comcode);
//				repo.deletecomrep(reponame, filename, comcode);
//				break;
//			}
//			else {
//				cout << "Invalid choice. Please try again." << endl;
//				break;
//			}
//		}
//		case 7:
//		{
//			string reponame;
//			cout << "Enter repository name: ";
//			cin >> reponame;
//			repo.viewrepostats(reponame);
//			break;
//		}
//		default:
//			cout << "Invalid choice. Please try again." << endl;
//		}
//	} while (choice != 8);
//
//	system("pause");
//	return 0;
//}