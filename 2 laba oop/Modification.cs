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
        List<PictureBox> pictures;
        List<Panel> panels;
        public Modification(Form1 frm1)
        {
            InitializeComponent();
            form1 = frm1;
            pictures = new List<PictureBox>() { pictureBox1, pictureBox2, pictureBox3 };
            panels = new List<Panel>() { panel1, panel2, panel3 };
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textName.Text!=""&& textSurname.Text != ""&& textAge.Text != "")
            {
                Tourist1 sanya = null;
                using (var db =new DataContext())///////UPDATE
                {
                    sanya = db.Tourists.FirstOrDefault(p => p.User.Login==form1.textBoxLogin.Text);
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
                    labelName.Text = sanya.Name;
                    labelSurname.Text = sanya.Surname;
                    labelAge.Text =(sanya.Age).ToString();
                    form1.buttonProfile.Text = sanya.Name;
                }
            }
        }

        private void Modification_Load(object sender, EventArgs e)
        {
            using (var db = new DataContext())///read
            {
                labelName.Text = db.Tourists.FirstOrDefault(p => p.User.Login == form1.textBoxLogin.Text).Name.ToString();
                labelSurname.Text = db.Tourists.FirstOrDefault(p => p.User.Login == form1.textBoxLogin.Text).Surname.ToString();
                labelAge.Text = db.Tourists.FirstOrDefault(p => p.User.Login == form1.textBoxLogin.Text).Age.ToString();

                Tourist1 tourist = db.Tourists.FirstOrDefault(p => p.User.Login == form1.textBoxLogin.Text);
                List<CreditCard> m = tourist.Cards.ToList();
                int count = m.Count;
                if (count > 3) count = 3;
                for (int i = 0; i < count; i++)
                {
                    pictures[i].Visible = true;
                    panels[i].Visible = true;
                    foreach (var item in panels[i].Controls)
                    {
                        if (item is Label)
                        {
                            if (((Label)item).Name==labelCardNum1.Name|| ((Label)item).Name == labelCardNum2.Name
                                || ((Label)item).Name == labelCardNum3.Name)
                            {
                                ((Label)item).Text = m[i].Number;
                            }
                            if (((Label)item).Name == labelCardCVC1.Name || ((Label)item).Name == labelCardCVC2.Name
                                || ((Label)item).Name == labelCardCVC3.Name)
                            {
                                ((Label)item).Text = m[i].CVC.ToString();
                            }
                            if (((Label)item).Name == labelCardMoney1.Name || ((Label)item).Name == labelCardMoney2.Name
                                || ((Label)item).Name == labelCardMoney3.Name)
                            {
                                ((Label)item).Text = m[i].MoneyCount.ToString()+"$";
                            }
                            
                        }
                    }
                }
            }
        }
        private void buttonApplyPassword_Click(object sender, EventArgs e)
        {
            if (textBoxCurrentPassword.Text!=""&&textBoxNewPassword.Text!=""&&
                textBoxAgainPassword.Text!="")
            {
                using (var db = new DataContext())///read
                {
                    User user = new User();
                    user = db.Users.FirstOrDefault(p => p.Login == form1.textBoxLogin.Text);
                    if (textBoxCurrentPassword.Text==user.Password&&
                        textBoxNewPassword.Text==textBoxAgainPassword.Text)
                    {
                        DialogResult dres;

                        dres = MessageBox.Show("Are you sure?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        if (dres==DialogResult.OK)
                        {
                            user.Password = textBoxNewPassword.Text;

                            db.Entry(user).State = EntityState.Modified;
                            db.SaveChanges();
                            textBoxAgainPassword.Clear();
                            textBoxCurrentPassword.Clear();
                            textBoxNewPassword.Clear();
                        }                        
                    }
                }
            }            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using(DataContext db=new DataContext())
            {
                User user=db.Users.FirstOrDefault(p=>p.Login==form1.textBoxLogin.Text);
                Tourist1 tourist = user.Tourist1;
                if (user !=null)
                {
                    DialogResult result= MessageBox.Show("Delete your account", "Are you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                    if (result==DialogResult.Yes)
                    {
                        db.Tourists.Remove(tourist);
                        db.Users.Remove(user);
                        db.SaveChanges();
                        Application.Exit();
                        
                    }                    
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(DataContext db=new DataContext())
            {
                User user = db.Users.FirstOrDefault(p => p.Login == form1.textBoxLogin.Text);

                CreditCard card = new CreditCard
                {
                    Number = textBoxCardNumber.Text,
                    type = textBoxTypeCard.Text,
                    CVC = Int32.Parse(textBoxCVC.Text),
                    TouristId = user.Tourist1.Id
                };

                if (db.Cards.FirstOrDefault(p=>p.Number==card.Number)==null)///означає, що немає більше такої картки
                {                    
                    db.Cards.Add(card);
                    db.SaveChanges();                    
                }

                List<CreditCard> m = user.Tourist1.Cards.ToList();
                int count = m.Count;
                if (count > 3) count = 3;

                for (int i = 0; i < count; i++)
                {
                    pictures[i].Visible = true;
                    panels[i].Visible = true;
                    foreach (var item in panels[i].Controls)
                    {
                        if (item is Label)
                        {
                            if (((Label)item).Name == labelCardNum1.Name || ((Label)item).Name == labelCardNum2.Name
                                || ((Label)item).Name == labelCardNum3.Name)
                            {
                                ((Label)item).Text = m[i].Number;
                            }
                            if (((Label)item).Name == labelCardCVC1.Name || ((Label)item).Name == labelCardCVC2.Name
                                || ((Label)item).Name == labelCardCVC3.Name)
                            {
                                ((Label)item).Text = m[i].CVC.ToString();
                            }
                            if (((Label)item).Name == labelCardMoney1.Name || ((Label)item).Name == labelCardMoney2.Name
                                || ((Label)item).Name == labelCardMoney3.Name)
                            {
                                ((Label)item).Text = m[i].MoneyCount.ToString() + "$";
                            }

                        }
                    }
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            using(var db =new DataContext()) 
            {
                //ICollection<CreditCard> m = db.Cards.ToList();
                //int count = m.Count;
                //for (int i = 0; i < count; i++)
                //{
                //    pictures[i].Visible = true;
                //}
            }
            
        }
    }
}
