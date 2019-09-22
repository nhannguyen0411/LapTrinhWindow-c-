using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class ReBook : Book
    {
        private int tax;

        public int Tax { get => tax; set => tax = value; }

        public ReBook() { }

        public ReBook(string id, string doi, int price, int amount, string writer, int tax)
        {

            this.id = id;
            this.doi = doi;
            this.price = price;
            this.amount = amount;
            this.writer = writer;
            this.tax = tax;
        }

        public override void input()
        {
            Console.WriteLine("\n=============== INPUT REBOOK ===============");
            base.input();
            Console.Write("TAX: ");
            this.tax = int.Parse(Console.ReadLine());
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("THUE: {0}\n", this.tax);
        }
    }
}
