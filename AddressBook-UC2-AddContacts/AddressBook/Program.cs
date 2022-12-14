using static AddressBook.ContactBook;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the Address Book");
                Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2. Add Contacts \n 3. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Ph.no, Email : ");
                        Contact contact = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            MobileNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information to Add in phoneBook in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        Console.WriteLine("Enter the Contact to Add: ");
                        Addressbook addressBook = new Addressbook();
                        Contact cont = new Contact()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            MobileNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        addressBook.AddContact(cont);
                        addressBook.Display();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}