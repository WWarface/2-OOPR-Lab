using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace _2_laba_oop
{
    public partial class Modification : Form
    {
        

        Form1 form1=null;
        public Modification(Form1 frm1)
        {
            InitializeComponent();
            form1 = frm1;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textName.Text!=""&& textSurname.Text != ""&& textAge.Text != "")
            {
                Tourist1 sanya = null;
                using (var db =new DataContext())///////UPDATE
                {
                    sanya = db.Tourists.FirstOrDefault(p => p.Name == form1.textBox1.Text);
                    if (textName.Text != "")
                    {
                        sanya.Name = textName.Text;
                    }
                    if (textSurname.Text != "")
                    {
                        sanya.Surname = textSurname.Text;
                    }
                    if (textAge.Text != "")
                    {
                        sanya.Age = Int32.Parse(textAge.Text);
                    }
                    db.Entry(sanya).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        private void Modification_Load(object sender, EventArgs e)
        {

        }
    }
}
