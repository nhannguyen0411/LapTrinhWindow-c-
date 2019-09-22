using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class Book
    {
        protected string id;
        protected string doi;
        protected int price;
        protected int amount;
        protected string writer;

        public string Id { get => id; set => id = value; }
        public string Doi { get => doi; set => doi = value; }
        public int Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Writer { get => writer; set => writer = value; }

        public virtual void input()
        {
            Console.Write("ID Book: ");
            this.id = Console.ReadLine();
            Console.Write("Date of input: ");
            this.doi = Console.ReadLine();
            Console.Write("Price: ");
            this.price = int.Parse(Console.ReadLine());
            Console.Write("Amount: ");
            this.Amount = int.Parse(Console.ReadLine());
            Console.Write("Writer: ");
            this.writer = Console.ReadLine();
        }

        public virtual void output()
        {
            Console.Write("ID \tDate \t\tPrice \tAmount \tWriter");
            Console.WriteLine("\n{0} \t{1} \t{2} \t{3} \t{4}", this.id, this.doi, this.price, this.amount, this.writer);
        }
    }
}
