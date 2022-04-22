using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_laba_oop
{
    public partial class Admin : Form
    {
        DataContext db;
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext())
            {
                //Tourist tur1 = new Tourist { Name = "Sana", Age = 15 };
                //Tourist tur2 = new Tourist { Name = "Oana", Age = 52 };

                //db.Tourists.AddRange(new List<Tourist> { tur1, tur2 });
                //db.SaveChanges();
            }
        }
    }
}
