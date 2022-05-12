using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Validation;


namespace _2_laba_oop
{
    public partial class Form1 : Form
    {
        DataContext db;
        protected internal Tourist1 GlobalTourist;
        public User GlobalUser;
        string CurrentDestination;
        string CurrentFromCity;
        public Agency agency;
        public Form1()
        {
            GlobalTourist = new Tourist1();
            InitializeComponent();
            panelLogo.BackColor = Color.FromArgb(0, 184, 230);
            panelTitle.BackColor = Color.FromArgb(0, 204, 255);
            panelMenu.Visible = false;
            panelPay.Visible = false;
            panelPlane.Visible = false;
            panelInfo.Visible = false;
            panelMenu.BackColor = Color.FromArgb(0, 102, 204);
            panelPlane.BackColor = Color.FromArgb(0, 102, 204);
            panelPay.BackColor = Color.FromArgb(0, 102, 204);
            buttonClose.Enabled = false;
            buttonClose.Visible = false;
            textBox5.MaxLength = 3;
            textBox9.MaxLength = 2;
            textBox8.MaxLength = 2;
            textBox10.MaxLength = 2;
            textBox10.KeyPress += (a, e) =>
              {
                  if (Char.IsDigit(e.KeyChar)) return;
                  else
                      e.Handled = true;
              };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            panelMenu.Visible = true;
            label1.Text = "MENU";
            buttonClose.Enabled = true;
            buttonClose.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelPlane.Visible = false;
            panelPay.Visible = false;
            panelInfo.Visible = false;
            buttonClose.Enabled = false;
            buttonClose.Visible = false;
            button3.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
        }





        private void button5_Click(object sender, EventArgs e)/////////Menu registr
        {
            button5.Enabled = false;
            if (textBox1.Text!=""&& textBox2.Text != ""&& textBox3.Text != "")
            {
                GlobalTourist = new Tourist1
                {
                    Name = textBox1.Text,
                    Surname = textBox2.Text,
                    Age = Int32.Parse(textBox3.Text),
                    Id = GlobalUser.Id,
                    UserNavigation = GlobalUser
                };
                using (db = new DataContext())//Добавити туриста за айдішніком його акаунта
                {
                    db.Users.Add(GlobalUser);
                    db.Tourists.Add(GlobalTourist);
                    db.SaveChanges();
                }

                panelMenu.Visible = false;
                panelLogin.Visible = true;////закрити меню НСА і відкрити логін меню

                label9.Visible = true;

            }   
        }        

        private void MessageShow(string mes)
        {
            label17.Visible = true;
            label17.Text = mes;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "AGENCY";
            panelMenu.Visible = false;
            panelPlane.Visible = true;
            panelInfo.Visible = false;
            panelPay.Visible = false;
            button2.BackColor = Color.FromArgb(0, 0, 128);
            button3.BackColor = Color.Transparent;
        }



        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (Char.IsDigit(e.KeyChar)) return;
                else
                    e.Handled = true;         
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)||e.KeyChar==' ') return;
            else
                e.Handled = true;
        }

        private void radioButton1_Enter(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton5.Text = "Kiev";
            radioButton6.Text = "Zaporizhie";
            radioButton7.Text = "Vinnitsa";
            radioButton8.Text = "Khmelnitsky";
            label6.Text = "23500";

        }

        private void radioButton2_Enter(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            radioButton5.Text = "Kiev";
            radioButton6.Text = "Zaporizhie";
            radioButton7.Text = "Vinnitsa";
            radioButton8.Text = "Khmelnitsky";
            label6.Text = "25800";
        }

        private void radioButton3_Enter(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            radioButton5.Text = "Kiev";
            radioButton6.Text = "Zaporizhie";
            radioButton7.Text = "Vinnitsa";
            radioButton8.Text = "Khmelnitsky";
            label6.Text = "40000";
        }

        private void radioButton4_Enter(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
            radioButton5.Text = "Kiev";
            radioButton6.Text = "Zaporizhie";
            radioButton7.Text = "Vinnitsa";
            radioButton8.Text = "Khmelnitsky";
            label6.Text = "18000";
        }

        private void button6_Click(object sender, EventArgs e)// accept button
        {
            if ((radioButton1.Checked|| radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)&& (radioButton5.Checked || radioButton6.Checked || radioButton7.Checked || radioButton8.Checked)&&textBox8.Text!=""&&textBox9.Text!="" && textBox10.Text != "")
            {
                label1.Text = "PURCHASE";
                panelPlane.Visible = false;
                panelPay.Visible = true;
                panelInfo.Visible = false;
                panelMenu.Visible = false;
                button3.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                TouristTravelInfo info = new TouristTravelInfo();

                foreach (Control control in groupBox2.Controls)
                {

                    if (control.GetType() == typeof(System.Windows.Forms.RadioButton))
                    {
                        
                        RadioButton rbControl = (RadioButton)control;
                       
                        if (rbControl.Checked)
                        {
                            info.From = rbControl.Text;
                            CurrentFromCity= rbControl.Text;
                        }
                    }
                }
                foreach (Control control in groupBox1.Controls)
                {
                    
                    if (control.GetType() == typeof(System.Windows.Forms.RadioButton))
                    {
                    
                        RadioButton rbControl = (RadioButton)control;
                       
                        if (rbControl.Checked)
                        {
                            info.ToCountry = rbControl.Text;
                            CurrentDestination= rbControl.Text;
                        }
                    }
                }
                info.Price = Int32.Parse(label6.Text);

                info.Day = Int32.Parse(textBox9.Text);
                info.Month = Int32.Parse(textBox8.Text);
                info.Duration = Int32.Parse(textBox10.Text);


                using (db = new DataContext())////CREATE
                {
                    var test = from b in db.Tourists
                               where b.Name.Equals(GlobalTourist.Name)
                               select b;
                    User user = db.Users.FirstOrDefault(p => p.Login == textBoxLogin.Text);
                    Voucher1 voucher1 = new Voucher1
                    {
                        Price = info.Price,
                        Destination = CurrentDestination,
                        FromCity = CurrentFromCity,
                        TouristId = user.Tourist1Navigation.Id,
                        IsPaid = false
                    };
                    if (db.Vouchers.FirstOrDefault(p=>p.Destination==CurrentDestination&&p.FromCity==CurrentFromCity)==null)//добавляємо тільки 1 путівку
                    {
                        db.Vouchers.Add(voucher1);
                        db.SaveChanges();
                    }                    
                    ICollection<CreditCard> cards = user.Tourist1Navigation.Cards;
                    if (cards.Count!=0)
                    {
                        foreach (var item in cards)
                        {
                            bool itemExists = false;
                            itemExists = comboBoxCards.Items.Contains(item.Number);             
                            if (!itemExists) comboBoxCards.Items.Add(item.Number);
                        }
                    }                    
                    else { comboBoxCards.Text = "No cards available"; };
                }
                labelVoucherPrice.Visible = true;
                labelVoucherPrice.Text = label6.Text+"$";
                panelPay.Visible = true;
            }          
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
        }

        private void panelPay_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "PURCHASE";
            panelMenu.Visible = false;
            panelPlane.Visible = false;
            panelPay.Visible = true;
            panelInfo.Visible = false;
            button3.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
        }

        private void button7_Click(object sender, EventArgs e)///////////////Зчитування даних з бази 
        {
            richTextBox1.Clear();

            Tourist1 sanya=null;
            using (var db = new DataContext())
            {
                sanya = db.Tourists.FirstOrDefault(x => x.Name == textBox1.Text);///READ
            }


            using (var db = new DataContext())
            {
                if (comboBoxCards.SelectedItem != null&&
                    db.Cards.FirstOrDefault(p=>p.Number == comboBoxCards.SelectedItem.ToString() &&
                    p.Tourist.Name==textBox6.Text&& p.Tourist.Surname == textBox7.Text) !=null)// Перевірка валідності карти
                {
                    CreditCard card = db.Cards.FirstOrDefault(p => p.Number == comboBoxCards.SelectedItem.ToString());
                    
                    Voucher1 voucher = db.Vouchers.FirstOrDefault(p => p.Destination == CurrentDestination && p.FromCity == CurrentFromCity);
                    card.MoneyCount = card.MoneyCount - voucher.Price;
                    if (card.MoneyCount < 0)
                    {
                        MessageBox.Show("Not enough money");
                        card.MoneyCount = card.MoneyCount + voucher.Price;
                        return;
                    }
                    MessageBox.Show("Your payment was successful");
                    db.Entry(card).State = EntityState.Modified;
                    db.Vouchers.Remove(voucher);
                    db.SaveChanges();
                    label13.Text = card.MoneyCount.ToString();// В залежності від вибраного комбобоксу, показувати к-ть грошей в 13лейбл
                    agency = new Agency();
                    Tourist1 tourist = db.Users.FirstOrDefault(p => p.Login == textBoxLogin.Text).Tourist1Navigation;
                    agency.Add(tourist);
                }
            }
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
        }
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "INFO";
            label19.Text =Convert.ToString(Agency.Count);
            panelMenu.Visible = false;
            panelPlane.Visible = false;
            panelPay.Visible = false;
            panelInfo.Visible = true;

                ShowingList.Registerhandler(MessageShow);
                ShowingList.Init(this);
            
        }
        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox11.Text!="")
            {
                int num = Int16.Parse(textBox11.Text);
                if (num<=Agency.Count)
                {
                    richTextBox1.Clear();
                    richTextBox1.AppendText("Name: " + ((Tourist1)agency[num - 1]).Name + "\n");
                    richTextBox1.AppendText("Surname: " + ((Tourist1)agency[num - 1]).Surname + "\n");                    
                }
                else
                {
                    MessageBox.Show("Try another number");
                }
            }
        }
        private void textBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ' '|| e.KeyChar == 8) return;
            else
                e.Handled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Admin Afomr = new Admin();
            Afomr.ShowDialog();
        }
         
        private void buttonModify_Click(object sender, EventArgs e)
        {
            Modification mform = new Modification(this);
            mform.ShowDialog();
        }

        private void buttonEnter_Click(object sender, EventArgs e)////основний логін
        {
            if (textBoxLogin.Text!=""&&maskedTextBoxPassword.Text!="")
            {
                using (db = new DataContext())
                {
                    User c = null;
                    try
                    {

                        c = db.Users.FirstOrDefault(p => p.Login == textBoxLogin.Text);
                    }
                    catch (Exception)
                    {
                        return;
                    }            
                    if (c != null&&maskedTextBoxPassword.Text == c.Password)
                    {
                        if (c.Tourist1Navigation != null)
                        {
                            foreach (var item in this.Controls)
                            {
                                if (item is Panel)
                                {
                                    ((Panel)item).Visible = false;
                                }
                            }
                            panelTitle.Visible = true;/////Це дві панелі управління(верхня і ліва)
                            panel1.Visible = true;
                            buttonProfile.Visible = true;
                            buttonProfile.Text = c.Tourist1Navigation.Name;
                            button2.Enabled = true;
                            button3.Enabled = true;
                        }
                        return;
                    }
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelLogin.Visible = false;
            panelRegistration.Visible = true;
        }

        private void buttonSubmitRegistration_Click(object sender, EventArgs e)
        {
            if (textBoxLoginRegistration.Text!=""&&maskedTextBoxPasswordRegistration1.Text!=""&&maskedTextBoxPasswordRegistration2.Text!="")
            {
                if (maskedTextBoxPasswordRegistration1.Text!=maskedTextBoxPasswordRegistration2.Text)
                {
                    MessageBox.Show("Password are not the same");
                    return;
                }
                GlobalUser = new User {Login = textBoxLoginRegistration.Text, Password = maskedTextBoxPasswordRegistration1.Text };
                panelRegistration.Visible = false;
                panelMenu.Visible = true;
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Modification mform = new Modification(this);
            mform.ShowDialog();
        }

        private void comboBoxCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(db = new DataContext())
            {

                CreditCard card = db.Users.FirstOrDefault(p => p.Login == textBoxLogin.Text).Tourist1Navigation.
                    Cards.FirstOrDefault(k=>k.Number==comboBoxCards.GetItemText(comboBoxCards.SelectedItem));
                label13.Text = card.MoneyCount.ToString();
            }
        }

        private void button5laba_Click(object sender, EventArgs e)
        {
            Form5Lab form = new Form5Lab();
            form.Show();
        }
    }
}
