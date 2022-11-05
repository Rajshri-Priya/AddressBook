using static AddressBook.ContactBook;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            Contact contact = new Contact(); // object of Contact Class
            Addressbook addressBook = new Addressbook();

            while (flag)
            {
                Console.WriteLine("Welcome to the Address Book Program");
                Console.WriteLine("Enter what you want to do : \n 1. Add Contacts \n 2. Edit Contacts \n 3. Delete Contact \n 4. Add Multiple Contact \n 5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact Information to Add, in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email, Uniquename");
                        contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            MobileNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                            Uniquename = Console.ReadLine(),
                        };
                        addressBook.AddContact(contact);
                        addressBook.Display();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Unique Name to  Edit: ");
                        string name = Console.ReadLine();
                        addressBook.EditContact(name);
                        Console.WriteLine("Contact is Edited Sucsessfully");
                        addressBook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Unique name of contact you want to delete :");
                        string detail = Console.ReadLine();
                      //  Contact cont = new Contact();
                        Addressbook delete = new Addressbook();
                        delete.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the Contact Information to Add, in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email,  Uniquename");
                        contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            MobileNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                            Uniquename = Console.ReadLine(),
                        };
                        addressBook.AddContact(contact);
                        Console.WriteLine("Contact is Saved");
                        addressBook.Display();
                        break;
                       
                    
                     
                    case 5: 
                        flag = false;
                        break;
                }
               
            }
        }
    }
}