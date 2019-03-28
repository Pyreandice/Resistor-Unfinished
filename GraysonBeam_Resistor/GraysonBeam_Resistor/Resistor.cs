using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraysonBeam_Resistor
{
    public partial class Resistor : Form
    {
        public Resistor()
        {
            this.InitializeComponent();
        }

        private void MakeList()
        {
            string currentLine = string.Empty;
            System.IO.StreamReader ReadFile = new System.IO.StreamReader(@"BandInfo.txt");
            while ((currentLine = File.ReadLine()) != null)
            {
                
            }
        }
    }
}
