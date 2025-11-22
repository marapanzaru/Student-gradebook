using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace atestat1
{
    public partial class ElevForm : Form
    {
        private int IDelev,IDmaterie;
      
        
        public ElevForm(int IDelev)
        {
            InitializeComponent();
            this.IDelev=IDelev;

            DataTable dt = eLEVITableAdapter.GetData();
            numelb.Text = (dt.Rows[IDelev-1]["nume"]).ToString();
            prenumelb.Text = (dt.Rows[IDelev-1]["prenume"]).ToString();
        }

        private void ElevForm_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'baza_catalogDataSet.UTILIZATORI' table. You can move, or remove it, as needed.
this.uTILIZATORITableAdapter.Fill(this.baza_catalogDataSet.UTILIZATORI);
// TODO: This line of code loads data into the 'baza_catalogDataSet.PROFESORI' table. You can move, or remove it, as needed.
this.pROFESORITableAdapter.Fill(this.baza_catalogDataSet.PROFESORI);
// TODO: This line of code loads data into the 'baza_catalogDataSet.NOTE' table. You can move, or remove it, as needed.
this.nOTETableAdapter.Fill(this.baza_catalogDataSet.NOTE);
// TODO: This line of code loads data into the 'baza_catalogDataSet.MATERII' table. You can move, or remove it, as needed.
this.mATERIITableAdapter.Fill(this.baza_catalogDataSet.MATERII);
// TODO: This line of code loads data into the 'baza_catalogDataSet.ELEVI' table. You can move, or remove it, as needed.
this.eLEVITableAdapter.Fill(this.baza_catalogDataSet.ELEVI);
// TODO: This line of code loads data into the 'baza_catalogDataSet.CLASE' table. You can move, or remove it, as needed.
this.cLASETableAdapter.Fill(this.baza_catalogDataSet.CLASE);
// TODO: This line of code loads data into the 'baza_catalogDataSet.ABSENTE' table. You can move, or remove it, as needed.
this.aBSENTETableAdapter.Fill(this.baza_catalogDataSet.ABSENTE);
baza_catalogDataSet.EnforceConstraints = false;
             
        }

       
        private void aBSENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aBSENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza_catalogDataSet);

        }

        private void numelb_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void logoutbt_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            DataTable dt = baza_catalogDataSet.MATERII;
            if (comboBox1.Items.Count == 0)
            {
                comboBox1.Items.Add("All");
                for (int i = 0; i < dt.Rows.Count; i++)
                    comboBox1.Items.Add(dt.Rows[i]["denumire"]);

            }
           

        }
        

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            richTextBox1.Text = "";
         

            if (comboBox1.Text != "All")
            {
                IDmaterie = Convert.ToInt32(mATERIITableAdapter.id_mat(comboBox1.SelectedItem.ToString()));
                medieGlb.Text = nOTETableAdapter.MedieG_mat(IDelev, IDmaterie).ToString();
                nOTETableAdapter.Gridview_note1(baza_catalogDataSet.NOTE, IDelev, IDmaterie);
                DataTable dt = baza_catalogDataSet.NOTE;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string s = dt.Rows[i]["Data_nota"].ToString();
                    string[] sir = s.Split(' ');
                    richTextBox1.Text += dt.Rows[i]["Nota"] + "      " +sir[0] + "     " + dt.Rows[i]["Materie"] + "\n";
                }
            }
            else
            {
                medieGlb.Text = nOTETableAdapter.MediaG(IDelev).ToString();
                nOTETableAdapter.toatenotele(baza_catalogDataSet.NOTE, IDelev);
                DataTable dt = baza_catalogDataSet.NOTE;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string s = dt.Rows[i]["Data_nota"].ToString();
                    string[] sir = s.Split(' ');
                    richTextBox1.Text += dt.Rows[i]["nota"] + "    " + sir[0] + "     " + dt.Rows[i]["Materie"] + "\n";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            tabControl1.SelectedTab = tabPage3;
            DataTable dt = baza_catalogDataSet.MATERII;
            if (comboBox2.Items.Count == 0)
            {
                comboBox2.Items.Add("All");
                for (int i = 0; i < dt.Rows.Count; i++)
                    comboBox2.Items.Add(dt.Rows[i]["denumire"]);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) 
        {
            richTextBox2.Text = "";
            nr_ab_lb.Text = "";
          
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)  
        {
            int nr = 0;
           
            richTextBox2.Text = "";
            nr_ab_lb.Text = "";
            if (comboBox2.SelectedItem != null)
            {
                if (comboBox2.SelectedItem.ToString() != "All")
                {
                    IDmaterie = Convert.ToInt32(mATERIITableAdapter.id_mat(comboBox2.SelectedItem.ToString()));
                    aBSENTETableAdapter.abs_mat(baza_catalogDataSet.ABSENTE, IDelev, IDmaterie);
                        DataTable dt = baza_catalogDataSet.ABSENTE;
                    if (comboBox3.SelectedItem.ToString() == "all")
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            nr++;
                            string s = dt.Rows[i]["Data_absenta"].ToString();
                            string[] sir = s.Split(' ');
                          
                            richTextBox2.Text += sir[0] + "    " + dt.Rows[i]["statut"] + "    " + dt.Rows[i]["Materie"] + "\n";
                        }
                       

                    }
                    else if (comboBox3.SelectedItem.ToString() != "all")
                    {

                        for (int i = 0; i < dt.Rows.Count; i++)
                            if (comboBox3.Text.ToString() == dt.Rows[i]["statut"].ToString().Trim())
                            {
                                nr++;
                                string s = dt.Rows[i]["Data_absenta"].ToString();
                                string[] sir = s.Split(' ');
                                
                                richTextBox2.Text += sir[0]+ "    " + dt.Rows[i]["statut"] + "    " + dt.Rows[i]["Materie"] + "\n";
                            }
                       }
                }
                else
                {

                     aBSENTETableAdapter.toate_abs(baza_catalogDataSet.ABSENTE, IDelev);
                            DataTable dt = baza_catalogDataSet.ABSENTE;

                            if (comboBox3.SelectedItem.ToString() == "all")
                            {

                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    nr++;
                                    string s = dt.Rows[i]["Data_absenta"].ToString();
                                    string[] sir = s.Split(' ');
                                    
                                    richTextBox2.Text += sir[0] + "    " + dt.Rows[i]["statut"] + "    " + dt.Rows[i]["Materie"] + "\n";
                                }
                               
                            }
                            else if (comboBox3.SelectedItem.ToString() != "all")
                            {

                                for (int i = 0; i < dt.Rows.Count; i++)
                                    if (comboBox3.Text.ToString() == dt.Rows[i]["statut"].ToString().Trim())
                                    {
                                        nr++;
                                        string s = dt.Rows[i]["Data_absenta"].ToString();
                                        string[] sir = s.Split(' ');
                                        
                                        richTextBox2.Text += sir[0] + "    " + dt.Rows[i]["statut"] + "    " + dt.Rows[i]["Materie"] + "\n";
                                    }
                                 }
                    
                }
                nr_ab_lb.Text = nr.ToString();
            }
        }
    }
}
