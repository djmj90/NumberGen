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

namespace NumberGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // desktop
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // progress bar according to the loop
            progressBar1.Visible = true;
            progressBar1.Maximum = Convert.ToInt32(tbLimit.Text);
            progressBar1.Step = Convert.ToInt32(tbLimit.Text)/ Convert.ToInt32(tbStart.Text);
            progressBar1.Value = 0;

            // Create the file
            FileStream fs = File.Create(path + "\\" + tbStart.Text + "To" + tbLimit.Text + ".txt");
            using (StreamWriter sw = new StreamWriter(fs))
            {
                for (int i = Convert.ToInt32(tbStart.Text); i <= Convert.ToInt32(tbLimit.Text); i++)
                {
                    sw.WriteLine(i.ToString());
                    progressBar1.Value = i;
                }
                MessageBox.Show("Successfully Created on the Desktop!");
                progressBar1.Visible = false;
            } 
        }


    }
}
