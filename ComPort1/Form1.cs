using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComPort1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Button dinamikButon = new Button();
            dinamikButon.Text = "Dinamik Buton";
            dinamikButon.Location = new System.Drawing.Point(150, 50);
            this.Controls.Add(dinamikButon);
        }
    }
}
