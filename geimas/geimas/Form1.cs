using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geimas
{
    public partial class Form1 : Form
    {
        Game zaidimas;
        Timer Taimeris;
        double laikas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            laikas = 0;
            zaidimas = new Game(txtGame.Text);
            txtGame.ReadOnly = true;
            txtInput.Text = String.Empty;
            Taimeris = new Timer
            {
                Interval = 100
            };
            Taimeris.Tick += new EventHandler(Taimeris_Tick);
            Taimeris.Start();
            txtGame.Text = zaidimas.playerText;
            txtInput.ReadOnly = false;
            this.ActiveControl = txtInput;
        }

        private void Taimeris_Tick(object sender, EventArgs e)
        {
            laikas += 0.1;
            lblTimer.Text = laikas.ToString();
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            if(zaidimas.isGame == true)
            {
                string input = txtInput.Text;
                if(input != "" && input !=null)zaidimas.PlayerInput(input);
                txtInput.Text = "";
                txtGame.Text = zaidimas.playerText;
                if (zaidimas.isGame == false)
                {
                    Taimeris.Stop();
                    txtGame.ReadOnly = false;
                    txtInput.ReadOnly = true;
                    txtInput.Text = "Zaidimas baigtas";
                }
            }
        }
    }
}
