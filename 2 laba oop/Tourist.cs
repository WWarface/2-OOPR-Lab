using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    public sealed class Tourist: Human
    {
        public Tourist() : base("Clone", "Clone", 0)
        {
            Card = new CreditCard("0000 0000 0000 0000", 000, 0);
            Voucher = new Voucher();
            Count++;
        }

        public Tourist(string name, string surname, int age) : base(name, surname, age)
        {
            Card = new CreditCard("4444 4444 4444 4444", 314, 30000);
            Count++;
        }
        public static int Count { get; set; }

        private static int k = 0;
        public static string Path { get; set; }
        public Voucher Voucher { get; set; }
        public CreditCard Card { get; set; }
        public void WriteData(string path)
        {
            Path = path;
            bool IfFirst = false;            
            if (k>=2)
            {
                IfFirst = true;
            }
            //for (int i = 0; i < count; i++)
            //{
                using (StreamWriter writer = new StreamWriter(path, IfFirst))
                {
                    writer.WriteLine(this.Name);
                    writer.WriteLine(this.Surname);
                    writer.WriteLine(this.Age);
                    writer.WriteLine(this.Card.Number);
                    writer.WriteLine(this.Card.CVC);
                    writer.WriteLine(this.Card.MoneyCount);
                    writer.WriteLine(this.Card.PayHistory);
                }
            //}

            k++;
            
        }


        public void ReadData()
        {
            
                using (StreamReader reader = new StreamReader(Path))
                {
                  for (int i = 0; i < Tourist.Count; i++)
                   {
                    this.Name = reader.ReadLine();
                    this.Surname = reader.ReadLine();
                    this.Age = Convert.ToInt32(reader.ReadLine());
                    this.Card.Number = reader.ReadLine();
                    this.Card.CVC = Int32.Parse(reader.ReadLine());
                    this.Card.MoneyCount = Int32.Parse(reader.ReadLine());
                    this.Card.PayHistory = Int32.Parse(reader.ReadLine());
                   }
                }

        }

        public override void Work()
        {
            Card.MoneyCount += 15000;
        }


    }
}
