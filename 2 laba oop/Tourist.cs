using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    public delegate void TouristHandler(string path);
    public sealed class Tourist: Human, IAgencyInfo
    {
        public Tourist() : base("Clone", "Clone", 0)
        {
            Card = new CreditCard("0000 0000 0000 0000", 000, 0);
            Voucher = new Voucher();
            Count++;
            Tour = delegate (string path)
              {
                  using (StreamWriter writer = new StreamWriter(path, true))
                  {
                      writer.WriteLine(this.Name);
                      writer.WriteLine(this.Surname);
                      writer.WriteLine(this.Age);
                      writer.WriteLine(this.Card.Number);
                      writer.WriteLine(this.Card.CVC);
                      writer.WriteLine(this.Card.MoneyCount);
                      writer.WriteLine(this.Card.PayHistory);
                  }
              };
        }

        public Tourist(string name, string surname, int age) : base(name, surname, age)
        {
            Card = new CreditCard("4444 4444 4444 4444", 314, 30000);
            Count++;
            Tour = delegate (string path)
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(this.Name);
                    writer.WriteLine(this.Surname);
                    writer.WriteLine(this.Age);
                    writer.WriteLine(this.Card.Number);
                    writer.WriteLine(this.Card.CVC);
                    writer.WriteLine(this.Card.MoneyCount);
                    writer.WriteLine(this.Card.PayHistory);
                }
            };
        }
        public static int Count { get; set; }

        private TouristHandler Tour;

        private static int k = 0;
        public static string Path { get; set; }
        public Voucher Voucher { get; set; }
        public CreditCard Card { get; set; }
        public string Label { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IAgencyInfo this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void WriteData(string path)
        {
            Path = path;

            Tour(path);

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
