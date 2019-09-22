using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class TextBook : Book
    {
        private string status;

        public string Status { get => status; set => status = value; }

        public TextBook() { }

        public TextBook(string id, string doi, int price, int amount, string writer, string status)
        {
            this.id = id;
            this.doi = doi;
            this.price = price;
            this.amount = amount;
            this.writer = writer;
            this.status = status;
        }

        public override void input()
        {
            base.input();
            Console.Write("Status (New/Old): ");
            this.status = Console.ReadLine();
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("Status: {0}\n", this.status);
        }
    }
}
