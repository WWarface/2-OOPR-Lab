using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    class ShowingList
    {
        static public void Init(Form1 form)
        {
            foreach (var item in form.tourists)
            {
                form.richTextBox1.AppendText("Name: "+item.Name+"\n");
                form.richTextBox1.AppendText("Surname: " + item.Surname + "\n");
                form.richTextBox1.AppendText("Voucher country: " + item.Voucher.Country + "\n");
                form.richTextBox1.AppendText("Voucher Day: " + item.Voucher.Day + " Voucher Month: " + item.Voucher.Month + "\n");
                form.richTextBox1.AppendText("Voucher Duration: " + item.Voucher.Duration + "\n\n");
            }
        }
    }
}
