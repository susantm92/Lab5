using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textBox1.Text);
            if(age>21)
            {
                label2.Text = "Alocohol in USA permitted";
                
            }
            else if(age>18)
            {
                label2.Text= "Alocohol in Canada permitted";
            }
            else if(age>16)
            {
                label2.Text = "Alocohol in Germany permitted";
            }
            else
            {
                label2.Text = "Not permitted";
            }

        }
    }
}
