using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_laba_oop
{
    public delegate void listHandler(string message);
    class ShowingList
    {


        static public listHandler? taken;

        static public void Registerhandler(listHandler from)
        {
            taken = from;
        }
        static public void Init(Form1 form)
        {
            foreach (var item in form.agency.tourists)
            {
                taken?.Invoke("Initialization info of tourist");
                form.richTextBox1.AppendText("Name: "+item.Name+"\n");
                form.richTextBox1.AppendText("Surname: " + item.Surname + "\n");
                //form.richTextBox1.AppendText("Voucher country: " + item.Voucher.Country + "\n");
                //form.richTextBox1.AppendText("Voucher Day: " + item.Voucher.Day + "| Month: " + item.Voucher.Month + "\n");
                //form.richTextBox1.AppendText("Voucher Duration: " + item.Voucher.Duration + "\n\n");
            }
        }

    }
}
