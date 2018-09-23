using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Logic.BoxOfMatches box = new BoxOfMatches("Фирма1", 40, 40);
            Logic.BoxOfMatches box1 = new BoxOfMatches("Фирма7", 38, 24);
            Logic.Matches boxm1 = new Matches(30,box);
            textBox1.Text = box.ToString() + box1.ToString() +boxm1.ToString();
        }
    }
}
