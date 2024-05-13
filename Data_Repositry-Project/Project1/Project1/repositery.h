#include<string>
#include<sstream>
#include<fstream>
using namespace std;
const int TABLE_SIZE = 100;
void clearScreen();
void sleepSeconds(int seconds);
class User
{
public:
	string username;
	string password;
	User* next;
	bool loggedIn;
	User(string uname, string pass);
};

// Define the HashTable class
class HashTable {
private:
	User** table;  // Array of pointers to User, each represents a bucket in the hash table

	int hashFunction(const string& key);

public:
	string* users; // Dynamic array of users
	bool** followMatrix; // Follow matrix, dynamic 2D array
	int userCapacity; // Total capacity of the user list
	int userCount; // Current number of users

	HashTable();

	~HashTable();

	void expandUserMatrix();
	void follow(string follower, string following);
	void unfollow(string follower, string following);

	int findUserIndex(string username);
	void printFollowers(const string& username);
	void printFollowGraph();

	void registerUser(const string& username, const string& password);

	bool loginUser(const string& username, const string& password);

	void logoutUser(const string& username);

	bool findUser(const string& username);
	void printUsers();
	void saveUserToCSV(const string& username, const string& password, const string& repositories, const string& files, const string& commits, const string& following);
	// Function to read user information from CSV file
	bool readUsersFromCSV(HashTable& userTable);

};


class commitnode
{
public:
	string comcode;
	commitnode* next;
	commitnode(string comcode);

};
class filenode
{
public:
	string filename;
	string filedata;
	filenode* next;
	filenode(string filename, string filedata);
};
class repnode
{
public:
	string username;
	string reponame;
	int forkcount;
	bool ispublic;
	commitnode* comhead;
	filenode* filehead;
	repnode* left;
	repnode* right;
	repnode(string uname, string repname, bool ispublic);
};

class repositery
{
private:
	HashTable userTable;
	repnode* root;
	string* users;

	bool** followMatrix;
	int userCapacity;
	int userCount;
	void insertcommit(commitnode*& commithead, string comcode);


	void insertfile(filenode*& filehead, string filename, string filedata);


	void deletecommit(commitnode*& commithead);
	void deletefile(filenode*& filehead, string filename);
	repnode* find(repnode* root, string reponame);
	int height(repnode* root);

	int getbalancefactor(repnode* root);

	repnode* rightRotate(repnode* root);

	repnode* leftRotate(repnode* root);

	void deletetree(repnode* root);

public:
	repositery(HashTable& usertable);
	~repositery();
	repnode* insert(repnode* root, string username, string reponame, bool ispublic);


	void registerUser(const string& username, const string& password);

	bool loginUser(const string& username, const string& password);

	void createrepo(string& username, string& reponame, bool ispublic);

	void deleteRepositery(string& username, string& reponame);


	repnode* deletrepo(repnode* root, string& username, string& reponame);

	repnode* minval(repnode* root);

	void addfilerep(string reponame, string filename);

	void deletefilerep(string reponame, string filename);
	void removefile(string filename);
	void addcomrep(string reponame, string filename);

	void deletecomrep(string reponame, string commitFilename, string comcode);

	string trim(const string& str);
	void setvisibility(string reponame, bool ispublic);
	void viewrepostats(const string& username, const string& reponame, repositery& r);
	void displayUserProfile(HashTable& userTable, repositery& repo, const string& username);


	void forkRepo(string username, string sourcerepo, string newrepo, bool ispublic);
	string readFileData(const string& filename);
	void writeFileData(const string& filename, const string& filedata);
	void deleteFileData(const string& filename);
	void saveRepoToCSV(const string& username, const string& reponame, bool ispublic);
	// Function to read repository information from CSV file
	bool readReposFromCSV(repositery& repo);
};