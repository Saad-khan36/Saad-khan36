#include "repositery.h"
#include<iostream>
#include<string>
#include<sstream>
#include<fstream>
#include<string>
#include<iomanip>
using namespace std;
int main()
{
	HashTable userTable;
	repositery repo(userTable);
	int choice;

	// Loop for user interaction
	do {
		clearScreen();
		cout << "\n=== Git-Hub Simulation System ===" << endl;
		cout << "\n=== Main Menu ===" << endl;
		cout << "1. Register" << endl;
		cout << "2. Login" << endl;
		cout << "3. Logout" << endl;
		cout << "4. View User Profile" << endl;
		cout << "5.Read User From CSV " << endl;
		cout << "6. Exit" << endl;
		cout << "Enter your choice: ";
		cin >> choice;
		if (choice == 1)
		{
			string username, password;
			cout << "Enter username: ";
			cin >> username;
			cout << "Enter password: ";
			cin >> password;
			// Register the user
			userTable.registerUser(username, password);

		}
		else if (choice == 2) {
			string username, password;
			cout << "Enter username: ";
			cin >> username;
			cout << "Enter password: ";
			cin >> password;
			// Check login credentials
			if (userTable.loginUser(username, password)) {
				cout << "Login successful. Welcome, " << username << "!" << endl;

				// Provide access to additional functionalities
				do {
					clearScreen();
					cout << "\n=== Repository Management System ===" << endl;
					cout << "1. Create Repository" << endl;
					cout << "2. Delete Repository" << endl;
					cout << "3. Fork Repository" << endl;
					cout << "4. Set Repository Visibility" << endl;
					cout << "5. File Operations" << endl;
					cout << "6. Commit Operations " << endl;
					cout << "7. View Repository Stats" << endl;
					cout << "8. User Management " << endl;
					cout << "9. Exit " << endl;
					cout << "Enter your choice: ";
					cin >> choice;

					switch (choice) {
					case 1:
					{
						string username;
						string reponame;
						bool ispublic;
						cout << "Enter User name: " << endl;
						cin >> username;
						cout << "Enter repository name: " << endl;
						cin >> reponame;
						cout << "Is the repository public? (1 for Yes, 0 for No): ";
						cin >> ispublic;
						repo.createrepo(username, reponame, ispublic);
						break;
					}
					case 2:
					{
						string username;
						string reponame;
						cout << "Enter User name: " << endl;
						cin >> username;
						cout << "Enter repository name to delete: " << endl;
						cin >> reponame;
						repo.deleteRepositery(username, reponame);
						break;
					}
					case 3:
					{
						string username;
						string sourcerepo, newrepo;
						bool ispublic;
						cout << "Enter Username " << endl;
						cin >> username;
						cout << "Enter source repository name to fork: ";
						cin >> sourcerepo;
						cout << "Enter new repository name: ";
						cin >> newrepo;
						cout << "Set repository visibility (1 for public, 0 for private): ";
						cin >> ispublic;
						repo.forkRepo(username, sourcerepo, newrepo, ispublic);
						break;
					}
					case 4:
					{
						string reponame;
						bool ispublic;
						cout << "Enter repository name: ";
						cin >> reponame;
						cout << "Set repository visibility (1 for public, 0 for private): ";
						cin >> ispublic;
						repo.setvisibility(reponame, ispublic);
						break;
					}
					case 5:
					{
						int fileopchoice;
						clearScreen();
						cout << "\n=== File Operations ===" << endl;
						cout << "1. Add File" << endl;
						cout << "2. Delete File" << endl;
						cout << "3. Read File" << endl;
						cout << "4. Write to File" << endl;
						cout << "5. Delete File Data" << endl;
						cout << "Enter your choice: ";
						cin >> fileopchoice;

						switch (fileopchoice)
						{
						case 1:
						{
							string reponame, filename;
							cout << "Enter repository name: ";
							cin >> reponame;
							cout << "Enter file name: ";
							cin >> filename;
							repo.addfilerep(reponame, filename);
							break;
						}
						case 2:
						{
							string reponame, filename;
							cout << "Enter repository name: ";
							cin >> reponame;
							cout << "Enter file name to delete: ";
							cin >> filename;
							repo.deletefilerep(reponame, filename);
							break;
						}
						case 3:
						{
							string filename;
							cout << "Enter file name to read data from: ";
							cin >> filename;
							string filedata = repo.readFileData(filename);
							cout << "File Data: " << endl;
							cout << filedata << endl;
							break;
						}
						case 4:
						{
							string filename, filedata;
							cout << "Enter file name to write data to: ";
							cin >> filename;
							cin.ignore();
							cout << "Enter file data: ";
							getline(cin, filedata);
							repo.writeFileData(filename, filedata);
							cout << "Data written to file successfully." << endl;
							break;
						}
						case 5:
						{
							string filename;
							cout << "Enter file name to delete data from: ";
							cin >> filename;
							repo.deleteFileData(filename);
							cout << "File data deleted successfully." << endl;
							break;
						}
						default:
							cout << "Invalid file operation choice. Please try again." << endl;
							break;
						}
						break;
					}
					case 6:
					{
						int comopchoice;
						cout << "\n=== Commit Operations ===" << endl;
						cout << "1. Add Commit" << endl;
						cout << "2. Delete Commit Message From Commit File" << endl;
						cout << "Enter your choice: ";
						cin >> comopchoice;
						if (comopchoice == 1) {
							string reponame, filename;
							cout << "Enter repository name: ";
							cin >> reponame;
							cout << "Enter file name : ";
							cin.ignore();
							getline(cin, filename);
							repo.addcomrep(reponame, filename);
							break;
						}
						else if (comopchoice == 2) {
							string reponame, comcode, filename;
							cout << "Enter repository name: ";
							cin >> reponame;
							cout << "Enter file name : ";
							cin.ignore();
							getline(cin, filename);
							cout << "Enter commit message: ";
							getline(cin, comcode);
							repo.deletecomrep(reponame, filename, comcode);
							break;
						}
						else {
							cout << "Invalid choice. Please try again." << endl;
							break;
						}
						break;
					}
					case 7:
					{
						string username;
						string reponame;
						cout << "Enter Userrname " << endl;
						cin >> username;
						cout << "Enter repository name: ";
						cin >> reponame;
						repo.viewrepostats(username, reponame, repo);
						break;
					}
					case 8:
					{
						int userChoice;
						string username, follower, following;
						clearScreen();
						cout << "\n=== User Management ===" << endl;

						cout << "1. Follow User" << endl;
						cout << "2. Unfollow User" << endl;
						cout << "3. Print Followers" << endl;
						cout << "4. Print Follow Graph" << endl;
						cout << "Enter your choice: ";
						cin >> userChoice;

						switch (userChoice) {
						case 1:
							cout << "Enter follower username: ";
							cin >> follower;
							cout << "Enter following username: ";
							cin >> following;
							userTable.follow(follower, following);
							break;
						case 2:
							cout << "Enter follower username: ";
							cin >> follower;
							cout << "Enter following username: ";
							cin >> following;
							userTable.unfollow(follower, following);
							break;
						case 3:
							cout << "Enter the username: ";
							cin >> username;
							cout << "Print followers:" << endl;
							userTable.printFollowers(username);
							break;
						case 4:
							userTable.printFollowGraph();
							break;
						default:
							cout << "Invalid user management choice. Please try again." << endl;
							break;
						}
						break;
					}
					case 9:
					{
						cout << "Exit..." << endl;
						break;
					}
					default:
						cout << "Invalid choice. Please try again." << endl;
						break;
					}

				} while (choice != 9);
			}
			else {
				cout << "Login failed. Invalid username or password." << endl;
				break;
			}
		}
		else if (choice == 3)
		{

			string logoutUsername;
			cout << "Enter username to logout: ";
			cin >> logoutUsername;
			userTable.logoutUser(logoutUsername);
			cout << "Logged out successfully!" << endl;

		}
		else if (choice == 4)
		{
			string username;
			cout << "Enter username to view profile: ";
			cin >> username;
			repo.displayUserProfile(userTable, repo, username);

		}
		else if (choice == 5)
		{
			repo.readReposFromCSV(repo);
		}
		cout << "Processing... Please wait." << endl;
		sleepSeconds(2); // Delay to simulate processing time
	} while (choice != 5);

	return 0;
}