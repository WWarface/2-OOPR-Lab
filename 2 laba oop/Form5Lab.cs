using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_laba_oop
{
    public partial class Form5Lab : Form
    {
        public Form5Lab()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "Id");
            dataGridView1.Columns.Add("TYPE", "TypeCard");
            dataGridView1.Columns.Add("NUMBER", "Number");
            dataGridView1.Columns.Add("MONEY", "Money");
            int rowNumber = dataGridView1.Rows.Add();
            using (DataContext db= new DataContext())
            {
                var cards = db.Cards.Where(p => p.MoneyCount >= 30000);////Where
                foreach (var item in cards)
                {
                    dataGridView1.Rows[rowNumber].Cells[0].Value = item.Id;
                    dataGridView1.Rows[rowNumber].Cells[1].Value = item.type;
                    dataGridView1.Rows[rowNumber].Cells[2].Value = item.Number;
                    dataGridView1.Rows[rowNumber].Cells[3].Value = item.MoneyCount;
                    dataGridView1.Rows.Add();
                    rowNumber++;
                }
            }
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "Id");
            dataGridView1.Columns.Add("TYPE", "TypeCard");
            dataGridView1.Columns.Add("NUMBER", "Number");
            dataGridView1.Columns.Add("MONEY", "Money");
            int rowNumber = dataGridView1.Rows.Add();
            using (DataContext db = new DataContext())
            {
                var groups = from p in db.Cards
                             group p by p.type;
                foreach (var item in groups)
                {

                    foreach (var item2 in item)
                    {
                        dataGridView1.Rows[rowNumber].Cells[0].Value = item2.Id;
                        dataGridView1.Rows[rowNumber].Cells[1].Value = item.Key;
                        dataGridView1.Rows[rowNumber].Cells[2].Value = item2.Number;
                        dataGridView1.Rows[rowNumber].Cells[3].Value = item2.MoneyCount;
                        dataGridView1.Rows.Add();
                        rowNumber++;
                    }
                }
            }
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("NAME", "Name");
            dataGridView1.Columns.Add("SURNAME", "Surname");
            dataGridView1.Columns.Add("LOGIN", "Login");
            dataGridView1.Columns.Add("PASSWORD", "Password");
            int rowNumber = dataGridView1.Rows.Add();
            using (DataContext db = new DataContext())
            {
                var infos = db.Tourists.Join(db.Users,
                    p => p.Id,
                    u => u.Id,
                    (p, u) => new
                    {
                        Name = p.Name,
                        Surname=p.Surname,
                        Login=u.Login,
                        Password=u.Password
                    });
                foreach (var i in infos)
                {
                    dataGridView1.Rows[rowNumber].Cells[0].Value = i.Name;
                    dataGridView1.Rows[rowNumber].Cells[1].Value = i.Surname;
                    dataGridView1.Rows[rowNumber].Cells[2].Value = i.Login;
                    dataGridView1.Rows[rowNumber].Cells[3].Value = i.Password;
                    dataGridView1.Rows.Add();
                    rowNumber++;
                }
            }

        }

        private void buttonOrderBy_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "Id");
            dataGridView1.Columns.Add("TYPE", "TypeCard");
            dataGridView1.Columns.Add("NUMBER", "Number");
            dataGridView1.Columns.Add("MONEY", "Money");
            int rowNumber = dataGridView1.Rows.Add();
            using (DataContext db = new DataContext())
            {
                var cards = db.Cards.OrderBy(p => p.MoneyCount);
                foreach (var item in cards)
                {
                    dataGridView1.Rows[rowNumber].Cells[0].Value = item.Id;
                    dataGridView1.Rows[rowNumber].Cells[1].Value = item.type;
                    dataGridView1.Rows[rowNumber].Cells[2].Value = item.Number;
                    dataGridView1.Rows[rowNumber].Cells[3].Value = item.MoneyCount;
                    dataGridView1.Rows.Add();
                    rowNumber++;
                }
            }

        }

        private void buttonUnion_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "Id");
            dataGridView1.Columns.Add("TYPE", "TypeCard");
            dataGridView1.Columns.Add("NUMBER", "Number");
            dataGridView1.Columns.Add("MONEY", "Money");
            int rowNumber = dataGridView1.Rows.Add();
            using (DataContext db = new DataContext())
            {
                var cards = db.Cards.Where(p => p.MoneyCount >= 40000)
                    .Union(db.Cards.Where(p => p.type == "Visa"));
                foreach (var item in cards)
                {
                    dataGridView1.Rows[rowNumber].Cells[0].Value = item.Id;
                    dataGridView1.Rows[rowNumber].Cells[1].Value = item.type;
                    dataGridView1.Rows[rowNumber].Cells[2].Value = item.Number;
                    dataGridView1.Rows[rowNumber].Cells[3].Value = item.MoneyCount;
                    dataGridView1.Rows.Add();
                    rowNumber++;
                }
               
            }
        }

        private void buttonIntersect_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "Id");
            dataGridView1.Columns.Add("TYPE", "TypeCard");
            dataGridView1.Columns.Add("NUMBER", "Number");
            dataGridView1.Columns.Add("MONEY", "Money");
            int rowNumber = dataGridView1.Rows.Add();
            using (DataContext db = new DataContext())
            {
                var cards = db.Cards.Where(p => p.MoneyCount >= 40000)
                    .Intersect(db.Cards.Where(p => p.type == "Visa"));
                foreach (var item in cards)
                {
                    dataGridView1.Rows[rowNumber].Cells[0].Value = item.Id;
                    dataGridView1.Rows[rowNumber].Cells[1].Value = item.type;
                    dataGridView1.Rows[rowNumber].Cells[2].Value = item.Number;
                    dataGridView1.Rows[rowNumber].Cells[3].Value = item.MoneyCount;
                    dataGridView1.Rows.Add();
                    rowNumber++;
                }

            }
        }

        private void buttonExcept_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "Id");
            dataGridView1.Columns.Add("TYPE", "TypeCard");
            dataGridView1.Columns.Add("NUMBER", "Number");
            dataGridView1.Columns.Add("MONEY", "Money");
            int rowNumber = dataGridView1.Rows.Add();
            using (DataContext db = new DataContext())
            {
                var cards = db.Cards.Where(p => p.type=="Visa")
                    .Except(db.Cards.Where(p => p.type == "MasterCard"));
                foreach (var item in cards)
                {
                    dataGridView1.Rows[rowNumber].Cells[0].Value = item.Id;
                    dataGridView1.Rows[rowNumber].Cells[1].Value = item.type;
                    dataGridView1.Rows[rowNumber].Cells[2].Value = item.Number;
                    dataGridView1.Rows[rowNumber].Cells[3].Value = item.MoneyCount;
                    dataGridView1.Rows.Add();
                    rowNumber++;
                }

            }
        }

        private void buttonAgregations_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("MIN", "Min");
            dataGridView1.Columns.Add("AVG", "Avg");
            dataGridView1.Columns.Add("MAX", "Max");
            using (DataContext db = new DataContext())
            {
                double Min = db.Cards.Min(p => p.MoneyCount);
                double Max = db.Cards.Max(p => p.MoneyCount);
                double Avg = db.Cards.Average(p => p.MoneyCount);
                dataGridView1.Rows[0].Cells[0].Value = Min;
                dataGridView1.Rows[0].Cells[1].Value = Avg;
                dataGridView1.Rows[0].Cells[2].Value = Max;

            }
        }

        private void buttonCount_Click(object sender, EventArgs e)///REWORK HARDCODE!
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("TYPE", "Type");
            dataGridView1.Columns.Add("COUNT", "Count");
            int rowNumber = dataGridView1.Rows.Add();
            using (DataContext db = new DataContext())
            {
                dataGridView1.Rows[0].Cells[0].Value = db.Cards.FirstOrDefault(p=>p.type=="MasterCard")?.type;
                dataGridView1.Rows[0].Cells[1].Value = db.Cards.Count(p=>p.type=="MasterCard");
                dataGridView1.Rows.Add();
                dataGridView1.Rows[1].Cells[0].Value = db.Cards.FirstOrDefault(p => p.type == "Visa")?.type;
                dataGridView1.Rows[1].Cells[1].Value = db.Cards.Count(p => p.type == "Visa");
            }
        }
    }
}
