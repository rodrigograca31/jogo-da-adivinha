using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaAdivinha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Jogo j = new Jogo(int.Parse(inputSuperior.Text), int.Parse(inputSuperior.Text), int.Parse(inputTentativas.Text));

        }

        private void btTentar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
