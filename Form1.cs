using System;
using System.Windows.Forms;

namespace BEUATIFYULHUMANS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MustardCat.Visible = false;
            LblApology.Visible = false;


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Buttonofdeath_Click(object sender, EventArgs e)
        {

            MustardCat.Visible = true;
            TmrApology.Start();
        }
        //int Timer = 0;
        private void TmrApology_Tick(object sender, EventArgs e)
        {

            LblApology.Visible = true;


            //look at this actual idiotic bullshit that i tried to code
            //Timer++;

            //if (Timer == 4)
            //     LblApology.Visible = true;
            //else if (Timer == 8)
            //    Label1.Visible = true;
            //else
            //    TmrApology.Stop();
            //this.Close();


        }

        private void LblApology_Click(object sender, EventArgs e)
        {

        }

        private void Shutdown_Tick(object sender, EventArgs e)
        {
            Visible = false;

        }
    }
}
