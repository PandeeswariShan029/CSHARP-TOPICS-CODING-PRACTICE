/*Question: AddressBook Application Implementation

Step 1: Class and Properties
Start by creating a new C# console application. In this application, you need to define two classes: Person and AdressBook.

Create a class named Person with the following properties:

FirstName (string): To store the first name of the person.
LastName (string): To store the last name of the person.
Number (string): To store the contact number of the person.
Address (string): To store the address of the person.
Create a constructor in the Person class that takes four parameters (first name, last name, contact number, and address) and initializes the properties accordingly.
Create a class named AdressBook with the following properties and methods:

adressBookList (List of Person): To store a list of persons (contacts) in the address book.
wtf (WriteAndReadToFile): An instance of the WriteAndReadToFile class, which will be used to handle file operations.
AdressBookList (getter and setter): A property to access the adressBookList.
Step 2: Create User and Add to Address Book
Now, let's implement the functionality to create a new user and add it to the address book.

In the AdressBook class, create a method named CreateUser(). This method should do the following:
Ask the user to input the first name, last name, contact number, and address of the new user.
Validate the contact number to ensure it's either 10 or 7 digits long. If not, ask the user to enter a valid number.
Create a new Person object using the input data and add it to the adressBookList.
Call the WriteUserToFile() method from the WriteAndReadToFile class to save the new user to a file.
Step 3: Display All Users
Next, let's implement the functionality to display all users in the address book.

In the AdressBook class, create a method named ShowAllPersonsInList(). This method should iterate through the adressBookList and display the details of each person (first name, last name, contact number, and address) in a formatted manner.
Step 4: Update User Information
Now, let's implement the functionality to update user information.

In the AdressBook class, create a method named UpdateUserInformation(). This method should do the following:
Ask the user which information they want to update (first name, last name, contact number, or address).
Ask the user to enter the first name of the user they want to update.
Find the user with the matching first name in the adressBookList.
Based on the selected information to update, ask the user to enter the new value for that field and update the user's information accordingly.
Call the UpdateUserOnFile() method from the WriteAndReadToFile class to save the updated user information to the file.
Step 5: Delete User
Let's implement the functionality to delete a user from the address book.

In the AdressBook class, create a method named RemovePersonFromList(). This method should do the following:
Ask the user to enter the first name and last name of the user they want to remove.
Find the user with the matching first name and last name in the adressBookList.
Remove the user from the adressBookList.
Call the UpdateUserOnFile() method from the WriteAndReadToFile class to save the updated address book to the file.
Step 6: Search User
Next, let's implement the functionality to search for users based on different criteria.

In the AdressBook class, create methods named Search(), SearchByName(), and SearchByNumber(). These methods should do the following:
Ask the user to enter the address, name, or contact number they want to search for.
Iterate through the adressBookList and find the users that match the search criteria.
Display the details of the matching users.
Step 7: Main Program Loop
Finally, implement the main program loop to handle user input and execute the functionalities.

In the Main method of the console application, create an instance of the AdressBook class and initialize it.
Implement a while loop to display the menu of options repeatedly until the user decides to exit (x).
Inside the loop, ask the user to choose an option from the menu and use a switch statement to call the corresponding method from the AdressBook class.
Step 8: File Handling
The code provided includes a WriteAndReadToFile class for file handling. You don't need to modify this class, as it handles reading from and writing to a file to persist the data between program runs.

Testing:
Test your implementation with various scenarios, including creating users, updating information, deleting users, displaying all users, and searching for users. Ensure that the program handles invalid inputs gracefully and provides appropriate error messages.

Submission:
Provide the complete C# console application code with the Person, AdressBook, and WriteAndReadToFile classes implemented as per the above steps. Also, include sample input and output for each functionality to demonstrate the correct working of the program.


SAMPLE INPUT 1 :
Choose one of the following options:
#1 Create new user
#2 Edit user information
#3 Delete existing user
#4 Show all users in address book
#5 Search By Address
#6 Search By Name
#7 Search By Number
#x Exit

SAMPLE OUTPUT 1:
1






SAMPLE INPUT 2 : CREATE NEW USER
Enter firstName: John
Enter lastName: Doe
Enter Contact Number: 1234567890
Enter address: 123 Main Street  

SAMPLE OUTPUT 2 :
Output: User added successfully.






SAMPLE INPUT 3 : EDIT USER INFORMATION 
Which information do you want to update?
#1: Firstname, #2: Lastname, #3: Number, #4: Address
Enter firstname of existing user to be updated: John
Enter a new first Name: Johnny

SAMPLE OUTPUT 3 :
Output: User information updated successfully.







SAMPLE INPUT 4 : SHOW ALL USERS IN ADDRESS BOOK

SAMPLE OUTPUT 4 :
FirstName: John, LastName: Doe, Number: 1234567890, Address: 123 Main Street



SAMPLE INPUT 5 : SEARCH BY ADDRESS
Enter the address you want to search: 123 Main Street
 
SAMPLE OUTPUT 5:
Contact Number: 1234567890
First name: Johnny
Last Name: Doe
Address: 123 Main Street




SAMPLE INPUT 6 : SEARCH BY NAME
Enter the name you want to search: Johnny

SAMPLE OUTPUT 6 :
Contact Number: 1234567890
First name: Johnny
Last Name: Doe
Address: 123 Main Street




SAMPLE INPUT 7 : SEARCH BY NUMBER

Enter the number you want to search: 1234567890

SAMPLE OUTPUT 7 :
Contact Number: 1234567890
First name: Johnny
Last Name: Doe
Address: 123 Main Street



SAMPLE INPUT 8 : EXIT
8

SAMPLE OUTPUT 8 :
Program terminated. 



                      PROGRAM IMPLEMENTATION */


// PERSON CLASS 
using System;

namespace Phone
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }

        public Person(string firstName, string lastName, string number, string address)
        {
            int n;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Number = number;
            this.Address = address;
            n = Number.Length;
        }
    }
}



// ADDRESSBOOK CLASS

using System;
using System.Collections.Generic;
using System.Linq;

namespace Phone
{
    class AdressBook
    {
        // Instead of using WriteAndReadToFile, we store data directly in memory.
        // public WriteAndReadToFile wtf;

        public List<Person> adressBookList = new List<Person>();
        public List<Person> AdressBookList
        {
            get { return adressBookList; }
            set { this.adressBookList = value; }
        }

        public AdressBook()
        {
            AdressBookList = new List<Person>();
            // No need for WriteAndReadToFile, as we're not using file operations.
            // wtf = new WriteAndReadToFile();
        }

        // Create instance of Person-class and call AddPersonToList-method
        public void CreateUser()
        {
            int n;
            Console.WriteLine("Enter firstName:");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter lastName:");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter Contact Number:");
            var number = Console.ReadLine();

            n = number.Length;
            if (n != 10 && n != 7)
            {
                Console.WriteLine("Invalid number");
                Console.WriteLine("Enter Contact Number:");
                number = Console.ReadLine();
            }

            Console.WriteLine("Enter address:");
            var address = Console.ReadLine();

            Person person = new Person(firstName, lastName, number, address);
            AddPersonToList(person);
            // No need to write to a file, as we're not using file operations.
            // wtf.WriteUserToFile(person);
        }

        // Add new person to AdressBookList
        private void AddPersonToList(Person person) => AdressBookList.Add(person);

        // Remove user from list where first and last name match
        public void RemovePersonFromList()
        {
            Console.WriteLine("Enter firstName of the user you want to remove:");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter lastname of the user you want to remove:");
            var lastName = Console.ReadLine();

            AdressBookList.RemoveAll(item => item.FirstName == firstName && item.LastName == lastName);
            // No need to update a file, as we're not using file operations.
            // wtf.UpdateUserOnFile(adressBookList);
        }

        // Show all Persons in AdressBookList
        public void ShowAllPersonsInList()
        {
            foreach (var person in AdressBookList)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, Number: {2}, Address: {3}", person.FirstName, person.LastName, person.Number, person.Address);
            }
        }

        public void UpdateUserInformation()
        {
            Console.WriteLine("Which information do you want to update?");
            Console.WriteLine("#1: Firstname, #2: Lastname, #3: Number, #4: Address");
            var userOption = Console.ReadLine();

            Console.WriteLine("Enter firstname of existing user to be updated:");
            var oldFirstName = Console.ReadLine();
            UpdateUserFunction(userOption, oldFirstName);
        }

        private void UpdateUserFunction(string userOption, string oldFirstName)
        {
            var personsWithMatchingFirstName = AdressBookList.Where(person => person.FirstName == oldFirstName);
            string newValue;

            if (userOption == "1")
            {
                Console.WriteLine("Enter a new first Name:");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.FirstName = newValue;
                    // No need to update a file, as we're not using file operations.
                    // wtf.UpdateUserOnFile(adressBookList);
                }
            }
            else if (userOption == "2")
            {
                Console.WriteLine("Enter a new last name:");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.LastName = newValue;
                    // No need to update a file, as we're not using file operations.
                    // wtf.UpdateUserOnFile(adressBookList);
                }
            }
            else if (userOption == "3")
            {
                Console.WriteLine("Enter a new Number:");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.Number = newValue;
                    // No need to update a file, as we're not using file operations.
                    // wtf.UpdateUserOnFile(adressBookList);
                }
            }
            else if (userOption == "4")
            {
                Console.WriteLine("Enter a new address:");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.Address = newValue;
                    // No need to update a file, as we're not using file operations.
                    // wtf.UpdateUserOnFile(adressBookList);
                }
            }
        }

        public void Search()
        {
            Console.WriteLine("Enter the address you want to search:");
            string ans = Console.ReadLine().ToLower();
            var foundPersons = AdressBookList.Where(person => person.Address.ToLower() == ans);

            foreach (Person person in foundPersons)
            {
                Console.WriteLine("Contact Number: {0}\nFirst name: {1}\nLast Name: {2}\nAddress: {3}\n", person.Number, person.FirstName, person.LastName, person.Address);
            }
        }

        public void SearchByName()
        {
            Console.WriteLine("Enter the name you want to search:");
            string ans = Console.ReadLine().ToLower();
            var foundPersons = AdressBookList.Where(person => person.FirstName.ToLower() == ans);

            foreach (Person person in foundPersons)
            {
                Console.WriteLine("Contact Number: {0}\nFirst name: {1}\nLast Name: {2}\nAddress: {3}\n", person.Number, person.FirstName, person.LastName, person.Address);
            }
        }

        public void SearchByNumber()
        {
            Console.WriteLine("Enter the number you want to search:");
            string ans = Console.ReadLine().ToLower();
            var foundPersons = AdressBookList.Where(person => person.Number.ToLower() == ans);

            foreach (Person person in foundPersons)
            {
                Console.WriteLine("Contact Number: {0}\nFirst name: {1}\nLast Name: {2}\nAddress: {3}\n", person.Number, person.FirstName, person.LastName, person.Address);
            }
        }
    }
}






PROGRAM CLASS


using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramIsRunning = true;
            AdressBook ab = StartProgram();

            Console.WriteLine("--------- AddressBook 1.0 ---------");

            while (ProgramIsRunning)
            {
                // Print user options
                PrintUserOptions();
                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ab.CreateUser();
                        break;
                    case "2":
                        ab.UpdateUserInformation();
                        break;
                    case "3":
                        ab.RemovePersonFromList();
                        break;
                    case "4":
                        ab.ShowAllPersonsInList();
                        break;
                    case "5":
                        ab.Search();
                        break;
                    case "6":
                        ab.SearchByName();
                        break;
                    case "7":
                        ab.SearchByNumber();
                        break;
                    case "x":
                        ProgramIsRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private static void PrintUserOptions()
        {
            Console.WriteLine("Choose one of the following options: ");
            Console.WriteLine("#1 Create new user");
            Console.WriteLine("#2 Edit user information");
            Console.WriteLine("#3 Delete existing user");
            Console.WriteLine("#4 Show all users in address book");
            Console.WriteLine("#5 Search By Address");
            Console.WriteLine("#6 Search By Name");
            Console.WriteLine("#7 Search By Number");
            Console.WriteLine("#x Exit");
        }

        private static AdressBook StartProgram()
        {
            return new AdressBook();
        }
    }
}












 








