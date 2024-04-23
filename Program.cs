using System.Reflection.Metadata.Ecma335;

namespace ScaryScoopShop2
{
    public class Program
    {
        public static List<Icecream> IceList{get;set;} = new List<Icecream>();
        public static void Main()
        {

            IcecreamUtility iu = new IcecreamUtility();
            Console.WriteLine("Branch testing in git");
            bool temp = true;
            while (temp)
            {
                Console.WriteLine("1.Add icecream details\n2.update icecream price\n3.Sort by price\n4.Exit\nEnter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                switch(choice)
                {
                    case 1:
                    Console.WriteLine("Enter the icecream name");
                    string? name = Console.ReadLine();

                    Console.WriteLine("Enter the price");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Icecream ice = new Icecream()
                    {
                        Name = name,
                        Price = price
                    };
                    iu.AddIceDetails(ice);
                    break;

                    case 2:
                    Console.WriteLine("Enter the icecream name");
                    string? name1 = Console.ReadLine();

                    Console.WriteLine("Enter price to update");
                    int updatedPrice = Convert.ToInt32(Console.ReadLine());
                    iu.UpdateIcePrice(name1,updatedPrice);
                    break;

                    case 3:
                    iu.SortByPrice();
                    break;
                    case 4:
                    temp = false;

                    break;
                }
            }

        }
    }
}