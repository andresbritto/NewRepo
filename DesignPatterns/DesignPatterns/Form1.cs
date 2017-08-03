using DesignPatterns.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleFactory nameFact = new SimpleFactory();
            Namer nm = nameFact.getName(txName.Text);
            lbFirst.Text = nm.getFName();
            lbLast.Text = nm.getLName();
        }
    }
}
