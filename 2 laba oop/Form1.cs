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

namespace _2_laba_oop
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(0, 115, 230);
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
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox4.MaxLength = 19;
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


       

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
            button1.BackColor = Color.FromArgb(0, 0, 128);
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
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
            button1.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
        }


        public Agency agency = new Agency();


        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            if (textBox1.Text!=""&& textBox2.Text != ""&& textBox2.Text != "")
            {
                Tourist sanya = new Tourist(textBox1.Text, textBox2.Text, Int16.Parse(textBox3.Text));
                button2.Enabled = true;
                button3.Enabled = true;
                sanya.WriteData("info_Tourist.txt");





                label13.Text = Convert.ToString(sanya.Card.MoneyCount);
                button7.Enabled = true;
                label8.Visible = true;
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
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.FromArgb(0, 0, 128);
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
        }



        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (Char.IsDigit(e.KeyChar)) return;
                else
                    e.Handled = true;         
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)&&e.KeyChar!=' ') return;
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

        private void button6_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked|| radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)&& (radioButton5.Checked || radioButton6.Checked || radioButton7.Checked || radioButton8.Checked)&&textBox8.Text!=""&&textBox9.Text!="" && textBox10.Text != "")
            {
                label1.Text = "PURCHASE";
                panelPlane.Visible = false;
                panelPay.Visible = true;
                panelInfo.Visible = false;
                panelMenu.Visible = false;
                button4.Enabled = true;
                button1.BackColor = Color.Transparent;
                button4.BackColor = Color.FromArgb(0, 0, 128);
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
                        }
                    }
                }
                info.Price = Int32.Parse(label6.Text);

                info.Day = Int32.Parse(textBox9.Text);
                info.Month = Int32.Parse(textBox8.Text);
                info.Duration = Int32.Parse(textBox10.Text);



                info.WriteData("Tourist_Price.txt");///////////////

            }


        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
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
            button1.BackColor = Color.Transparent;
            button4.BackColor = Color.FromArgb(0, 0, 128);
            button3.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button5.Enabled = true;
            richTextBox1.Clear();
            Tourist clone = new Tourist();
            Tourist.Count--;
            clone.ReadData();///// card number need to be compered as 1234 1234 1234 1234 with blanks
            if (clone.Name==textBox6.Text&&clone.Surname==textBox7.Text&&clone.Card.Number==textBox4.Text&&clone.Card.CVC==Int16.Parse(textBox5.Text))
            {
                TouristTravelInfo info = new TouristTravelInfo();
                info.ReadData();
                clone.Card.MoneyCount = clone.Card.MoneyCount - info.Price;
                if (clone.Card.MoneyCount<0)
                {
                    MessageBox.Show("Not enough money");
                    clone.Card.MoneyCount = clone.Card.MoneyCount + info.Price;
                }
                MessageBox.Show("Your payment was successful");
                button7.Enabled = false;
                label13.Text = Convert.ToString(clone.Card.MoneyCount);
                clone.Voucher.Country = info.ToCountry;
                clone.Voucher.Day = info.Day;
                clone.Voucher.Duration = info.Duration;
                agency.Add(clone);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;


                clone.Card.PayHistory++;
               ////// clone.WriteData(Tourist.Path);
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if (Char.IsDigit(e.KeyChar)) return;
            //else
            //    e.Handled = true;
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
                    richTextBox1.AppendText("Name: " + ((Tourist)agency[num - 1]).Name + "\n");
                    richTextBox1.AppendText("Surname: " + ((Tourist)agency[num - 1]).Surname + "\n");
                    richTextBox1.AppendText("Voucher country: " + ((Tourist)agency[num - 1]).Voucher.Country + "\n");
                    richTextBox1.AppendText("Voucher Day: " + ((Tourist)agency[num - 1]).Voucher.Day + "| Month: " + ((Tourist)agency[num - 1]).Voucher.Month + "\n");
                    richTextBox1.AppendText("Voucher Duration: " + ((Tourist)agency[num - 1]).Voucher.Duration + "\n\n");
                }
                else
                {
                    MessageBox.Show("Try another number");
                }
            }
        }

        private void panelInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("info_Tourist.txt", false))
            {              
            }
        }
    }
}
