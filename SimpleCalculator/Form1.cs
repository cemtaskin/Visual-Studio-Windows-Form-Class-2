using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public int FirstNumber { 
            get {
                int r = 0;
                try
                {
                    r=Convert.ToInt32(txtFirstNumber.Text);
                }
                catch { }
                return r;
            } 
        }

        public int SecondNumber { 
            get
            {
                int r = 0;
                try
                {
                    r = Convert.ToInt32(txtSecondNumber.Text);
                }
                catch { }
                return r;
            } 
        }
        public int Result { 
            set { 
                lblResult.Text = value.ToString(); 
            } 
        }
        public Form1()         {
            InitializeComponent();
        }
       
        private void btnOperation(object sender,EventArgs e)
        {
            Button btn = (Button)sender;
            switch (Convert.ToInt32(btn.Tag))
            {
                case 1:
                    Result = FirstNumber + SecondNumber;
                    break;
                case 2:
                    Result = FirstNumber - SecondNumber;
                    break;
                case 3:
                    Result = FirstNumber * SecondNumber;
                    break;
                case 4:
                    Result = FirstNumber / SecondNumber;
                    break;
            }
        }
    }
}
