using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ScaryScoopShop2
{
    public class IcecreamUtility
    {
        public void AddIceDetails(Icecream ice)
        {
            Program.IceList.Add(ice);
            Console.WriteLine("Inserted Successfully");

        }

        public List<Icecream> UpdateIcePrice(string icename,int price)
        {
            for(int i=0;i<Program.IceList.Count;i++)
            {
                if(Program.IceList[i].Name==icename)
                {
                    Program.IceList[i].Price=price;
                    foreach(var e in Program.IceList)
                    {
                        Console.WriteLine(e.Name+" "+e.Price);
                    }
                }

            }
            return Program.IceList;
        }

        public List<Icecream> SortByPrice()
        {
            List<Icecream> SortedList = Program.IceList;
            SortedList.Sort((x,y)=>x.Price.CompareTo(y.Price));
            foreach(var e in SortedList)
            {
                Console.WriteLine(e.Name+" "+e.Price);
            }
            return Program.IceList;
        }


        
    }
}