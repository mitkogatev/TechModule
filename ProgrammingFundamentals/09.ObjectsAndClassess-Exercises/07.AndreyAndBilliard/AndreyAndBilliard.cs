using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.AndreyAndBilliard
{
    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            int numEntities = int.Parse(Console.ReadLine());
            for (int i = 0; i < numEntities; i++)
            {
                string[] entArgs = Console.ReadLine().Split('-');
                if (!Entity.Ent.ContainsKey(entArgs[0]))
                    Entity.Ent.Add(entArgs[0], double.Parse(entArgs[1]));
                else
                    Entity.Ent[entArgs[0]] = double.Parse(entArgs[1]);
            }
            string line = Console.ReadLine();
            List<Customer> clients = new List<Customer>();
            while (line != "end of clients")
            {
                string[] custArgs = Regex.Split(line, @"-|,");
                //add client ???
                if (Entity.Ent.ContainsKey(custArgs[1]))
                {
                    int index = clients.FindIndex(c => c.Name == custArgs[0]);//Select((c,i)=>i);

                    if (index == -1)
                        clients.Add(new Customer(custArgs));
                    else
                        //////clients[index].Products.Add(custArgs[1], int.Parse(custArgs[2]));
                        clients[index].Update(custArgs);
                        
                }
                line = Console.ReadLine();
            }
            //Console.WriteLine("end");
            foreach (var client in clients.OrderBy(c=>c.Name))
            {
                Console.WriteLine(client.Name);
                foreach (var product in client.Products)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {client.Bill:F2}");
            }
            Console.WriteLine($"Total bill: {clients.Select(b=>b.Bill).Sum():F2}");
        }
    }
    public class Entity
    {
        public static Dictionary<string, double> Ent = new Dictionary<string, double>();//{ get; set; }
    }
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string,int> Products { get; set; }
        public double Bill { get; set; }
        public Customer(string[] input)
        {
            this.Name = input[0];
            this.Products = new Dictionary<string, int> { { input[1], int.Parse(input[2]) } };
            this.Bill = CalcBill();
        }
        public void Update(string[] input)
        {
            if (!this.Products.ContainsKey(input[1]))
                this.Products.Add(input[1], int.Parse(input[2]));
            else
                this.Products[input[1]] += int.Parse(input[2]);
            this.Bill=CalcBill();
        }
        private double CalcBill()
        {
            double sum = 0;
            foreach (var product in Products)
            {
                sum += product.Value * Entity.Ent[product.Key];
            }
            return sum;
        }
    }
}
