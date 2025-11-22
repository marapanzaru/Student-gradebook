using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace atestat1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (emailtext.Text != "" && parolatext.Text != "")
            {

                int exist = uTILIZATORITableAdapter.UserExists(emailtext.Text, parolatext.Text).Value;

                if (exist == 0)
                {
                    MessageBox.Show("The data you entered is invalid. Please try again.");
                    emailtext.Text = "";
                    parolatext.Text = "";
                }
                else
                {

                    string tip_user = uTILIZATORITableAdapter.TipUtilizator(emailtext.Text, parolatext.Text).ToString();
                    if (tip_user != null && tip_user.Contains("elev"))
                    {
                        int IDelev = Convert.ToInt32(eLEVITableAdapter.GasireElev(parolatext.Text, emailtext.Text));

                        ElevForm elevform = new ElevForm(IDelev);
                        elevform.Show();
                        this.Hide();

                    }
                    else
                    {
                        
                        int IDprof = Convert.ToInt32(pROFESORITableAdapter.GasireProf(emailtext.Text, parolatext.Text));
                        ProfForm profform = new ProfForm(IDprof);
                        profform.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }

        }

        private void uTILIZATORIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uTILIZATORIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza_catalogDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_catalogDataSet.ELEVI' table. You can move, or remove it, as needed.
            this.eLEVITableAdapter.Fill(this.baza_catalogDataSet.ELEVI);
            // TODO: This line of code loads data into the 'baza_catalogDataSet.PROFESORI' table. You can move, or remove it, as needed.
            this.pROFESORITableAdapter.Fill(this.baza_catalogDataSet.PROFESORI);
            // TODO: This line of code loads data into the 'baza_catalogDataSet.UTILIZATORI' table. You can move, or remove it, as needed.
            this.uTILIZATORITableAdapter.Fill(this.baza_catalogDataSet.UTILIZATORI);
            baza_catalogDataSet.EnforceConstraints = false;
        }
    }
}
