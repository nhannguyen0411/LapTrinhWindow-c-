using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> liBook = new List<Book>();
            List<TextBook> liTeBook = new List<TextBook>();
            List<ReBook> liReBook = new List<ReBook>();

            TextBook tb1 = new TextBook("REACTJS", "18/09/2019", 5000, 20, "KD", "New");
            TextBook tb2 = new TextBook("NODEJS", "18/09/2019", 3000, 50, "NN", "Old");
            TextBook tb3 = new TextBook("HTML", "18/09/2019", 1000, 5, "TT", "New");


            ReBook rb1 = new ReBook("GIT", "18/09/2019", 4000, 150, "KD", 400);
            ReBook rb2 = new ReBook("ANGULAR", "18/09/2019", 10000, 100, "NN", 500);
            ReBook rb3 = new ReBook("VUEJS", "18/09/2019", 7000, 200, "HT", 150);
            ReBook rb4 = new ReBook("CSS", "18/09/2019", 1500, 50, "KD", 800);
            ReBook rb5 = new ReBook("JAVASCRIPT", "18/09/2019", 5500, 10, "KA", 1000);

            liTeBook.Add(tb1);
            liTeBook.Add(tb2);
            liTeBook.Add(tb3);

            liReBook.Add(rb1);
            liReBook.Add(rb2);
            liReBook.Add(rb3);
            liReBook.Add(rb4);
            liReBook.Add(rb5);

            int option;

            do
            {
                Console.WriteLine();
                Console.WriteLine("1. INPUT TEXTBOOK.");
                Console.WriteLine("2. INPUT REFER BOOK.");
                Console.WriteLine("3. OUTPUT TEXTBOOK.");
                Console.WriteLine("4. OUTPUT REFER BOOK.");
                Console.WriteLine("5. TOTAL TEXTBOOK.");
                Console.WriteLine("6. TOTAL REFER BOOK.");
                Console.WriteLine("7. OUTPUT BOOKS OF WRITER X.");
                Console.WriteLine("8. OUTPUT LIST OF WRITER WITH MANY OF REBOOK.");
                Console.WriteLine("9. FIND 1 IDBOOK AND OUTPUT TOTAL PRICE.");
                Console.WriteLine("0. LUU VA THOAT");
                Console.Write("> ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            TextBook tb = new TextBook();
                            tb.input();
                            liTeBook.Add(tb);
                            break;
                        }
                    case 2:
                        {
                            ReBook rb = new ReBook();
                            rb.input();
                            liReBook.Add(rb);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\n=============== INPUT TEXTBOOK ===============");
                            foreach (TextBook item in liTeBook)
                            {
                                item.output();
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\n=============== INFO TEXTBOOK ===============");
                            foreach (ReBook item in liReBook)
                            {
                                item.output();
                            }
                            break;
                        }
                    case 5:
                        {
                            double totalPrice = 0;
                            foreach (TextBook item in liTeBook)
                            {
                                if(item.Status.ToLower() == "new")
                                {
                                    totalPrice += (item.Amount * item.Price);
                                }
                                else
                                {
                                    totalPrice += (item.Amount * item.Price * 0.5);
                                }
                            }
                            Console.WriteLine("Total price of textbook: {0}", totalPrice);
                            break;
                        }

                    case 6:
                        {
                            double totalPrice = 0;
                            foreach (ReBook item in liReBook)
                            {
                                totalPrice = (item.Amount * item.Price + item.Tax);
                            }
                            Console.WriteLine("Total price of Rebook: {0}", totalPrice);
                            break;
                        }

                    case 7:
                        {
                            string wFind;
                            Boolean truth = true;
                            Console.WriteLine("Input writer who want to find: ");
                            wFind = Console.ReadLine();
                            foreach (TextBook item in liTeBook)
                            {
                                if (item.Writer == wFind)
                                {
                                    item.output();
                                    truth = false;
                                }
                            }
                            if(truth != false)
                                Console.WriteLine("404 Error");
                            break;
                        }
                    case 8:
                        {
                            var obj = from s in liReBook
                                  group s by new { s.Writer, s.Doi } into g
                                  select new { g.Key.Writer, g.Key.Doi, Sum = g.Sum(s => s.Amount) };
                            int objSum = 0;
                            string objWriter = "";
                            foreach (var item in obj)
                            {
                                if (objSum < item.Sum)
                                {
                                    objSum = item.Sum;
                                }
                            }

                            foreach (var item in obj)
                            {
                                if(objSum == item.Sum)
                                {
                                    objWriter = objWriter + item.Writer + "\t";
                                }
                            }
                            Console.WriteLine("Sum amount: {0}", objSum);
                            Console.WriteLine("Writer: {0}", objWriter);
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Input ID of Book");
                            string iob = Console.ReadLine();
                            double totalPrice = 0;
                            foreach (TextBook item in liTeBook)
                            {
                                if (item.Id.ToLower() == iob.ToLower())
                                {
                                    if (item.Status.ToLower() == "new")
                                    {
                                        totalPrice = item.Amount * item.Price;
                                    }
                                    else
                                    {
                                        totalPrice = item.Amount * item.Price * 0.5;
                                    }
                                }
                                
                            }

                            foreach (ReBook item in liReBook)
                            {
                                if (item.Id.ToLower() == iob.ToLower())
                                {
                                    totalPrice = item.Amount * item.Price + item.Tax;
                                }
                            }
                            if(totalPrice > 0)
                                Console.WriteLine("Total price: {0}", totalPrice);
                            else
                                Console.WriteLine("Don't have IDBook");
                            break;
                        }
                    default: break;
                }
            } while (option != 0);
            Console.ReadLine();
        }
    }
}
