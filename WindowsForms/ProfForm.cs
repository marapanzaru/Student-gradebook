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
    public partial class ProfForm : Form
    {
        private int IDprof,y,IDelev,IDclasa,IDmaterie,IDnota,IDabsenta;
        public ProfForm(int IDprof)
        {
            InitializeComponent();
            this.IDprof = IDprof;
            DataTable dt = pROFESORITableAdapter.GetData();
            numelb.Text = (dt.Rows[IDprof - 1]["nume"]).ToString();
            prenumelb.Text = (dt.Rows[IDprof - 1]["prenume"]).ToString();
            
        }

        private void ProfForm_Load(object sender, EventArgs e)
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
             nOTEDataGridView.ClearSelection();
          
            aBSENTEDataGridView.ClearSelection();
           
        }

        private void aBSENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aBSENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.baza_catalogDataSet);

        }

        private void button1_Click(object sender, EventArgs e) //STUDENTS BUTTON
        {
            IDelev = 0;
            IDmaterie = 0;
            tabControl1.SelectedTab = tabPage2;
            DataTable dt = baza_catalogDataSet.CLASE;
            for (int i = 0; i < dt.Rows.Count; i++)
                comboBox1.Items.Add(dt.Rows[i]["denumire_clasa"]);
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

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) ///CLASS COMBOBOX
        {
            IDclasa = Convert.ToInt32(cLASETableAdapter.id_clasa(comboBox1.SelectedItem.ToString()));
            eLEVITableAdapter.FillBy(baza_catalogDataSet.ELEVI, comboBox1.SelectedItem.ToString());
            eLEVIDataGridView.DataSource = baza_catalogDataSet.ELEVI;
            medietxt.Text = nOTETableAdapter.Media_clasa(IDclasa).ToString();
            absentetxt.Text = aBSENTETableAdapter.abs_clasa(IDclasa).ToString();


        }

        private void button2_Click(object sender, EventArgs e) ///GRADE BUTTON
        {
            tabControl1.SelectedTab = tabPage3;
            nOTEDataGridView.ClearSelection();
            IDnota = 0;
            IDmaterie = 0;
            IDelev = 0;
            numetx.Text = "";
            prenumetx.Text = "";
            if (comboBox3.Items.Count == 0)
            {
                DataTable dt2 = baza_catalogDataSet.MATERII;
                for (int i = 0; i < dt2.Rows.Count; i++)
                    comboBox3.Items.Add(dt2.Rows[i]["denumire"]);

            }
           

        }

        private void button4_Click(object sender, EventArgs e) ///SERACH BUTTON
        { 
            IDelev=Convert.ToInt32(eLEVITableAdapter.Id_elev(numetx.Text,prenumetx.Text));


            if (IDelev!=0 &&IDmaterie!=0 && numetx.Text != "" && prenumetx.Text != "" && comboBox3.SelectedItem.ToString() != "" && notatx.Text != "")
            {
                nOTETableAdapter.adaug_nota(Convert.ToInt32(notatx.Text), dateTimePicker1.Value.ToString(), IDelev, IDmaterie);
                nOTETableAdapter.Update(baza_catalogDataSet);
                nOTETableAdapter.Fill(baza_catalogDataSet.NOTE);
            }
            else MessageBox.Show("The data you entered is invalid. Please try again.");
           
        }

       

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDmaterie = Convert.ToInt32(mATERIITableAdapter.id_mat(comboBox3.SelectedItem.ToString()));
        }

        private void button7_Click(object sender, EventArgs e) ///SERACH BUTTON
        {
            IDelev = Convert.ToInt32(eLEVITableAdapter.Id_elev(numetx.Text, prenumetx.Text));
            if (IDelev != 0 && IDmaterie != 0)
            {
                nOTETableAdapter.FillBy2(baza_catalogDataSet.NOTE, IDelev, IDmaterie);
                nOTEDataGridView.DataSource = baza_catalogDataSet.NOTE;
                medielb.Text = nOTETableAdapter.MedieG_mat(IDelev, IDmaterie).ToString();
            }
            else MessageBox.Show("The data you entered is invalid. Please try again.");
           
        }

        private void button5_Click(object sender, EventArgs e) ///DELETE BUTTON
        {
            if (IDnota != 0)
            {
                nOTETableAdapter.Delete_nota(IDnota);
                nOTETableAdapter.Update(baza_catalogDataSet);
                nOTETableAdapter.Fill(baza_catalogDataSet.NOTE);
                IDnota = 0;
                notatx.Text ="";
                IDelev =0;
                numetx.Text = "";
                prenumetx.Text ="";
                nOTEDataGridView.DataSource = nOTETableAdapter.GetData();
                

            }
            else MessageBox.Show("Please select the grade you want to delete from the table.");

        }


        private void nOTEDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && nOTEDataGridView.CurrentCell!=null) 
            {
                DataGridViewCell selectedCell = nOTEDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewRow selectedRow = nOTEDataGridView.Rows[e.RowIndex];

                IDnota = Convert.ToInt32(selectedRow.Cells[0].Value);
                notatx.Text = selectedRow.Cells[1].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells[2].Value);
                IDelev = Convert.ToInt32(selectedRow.Cells[3].Value);
                IDmaterie = Convert.ToInt32(selectedRow.Cells[4].Value);
                DataTable dt2 = mATERIITableAdapter.GetData();
                comboBox3.SelectedItem = dt2.Rows[IDmaterie-1]["denumire"].ToString();
                DataTable dt3 = eLEVITableAdapter.GetData();
                numetx.Text = dt3.Rows[IDelev - 1]["nume"].ToString();
                prenumetx.Text = dt3.Rows[IDelev - 1]["prenume"].ToString();
                medielb.Text = "";
            }
            
        }

        private void button6_Click(object sender, EventArgs e) //UPDATE BUTTON
        {
            IDelev = Convert.ToInt32(eLEVITableAdapter.Id_elev(numetx.Text, prenumetx.Text));
            if (IDelev!=0 && IDnota != 0 &&  numetx.Text != "" && prenumetx.Text != "" && comboBox3.SelectedItem != null && notatx.Text != "")
            {
                nOTETableAdapter.Update_nota(Convert.ToInt32(notatx.Text), dateTimePicker1.Value.ToString(), IDelev, IDmaterie, IDnota);
                nOTETableAdapter.Update(baza_catalogDataSet);
                nOTETableAdapter.Fill(baza_catalogDataSet.NOTE);
                nOTEDataGridView.DataSource = nOTETableAdapter.GetData();
                
                
                
            }
            else MessageBox.Show("Select the grade from the table you wish to modify and verify your input.");
        }
         private void button2_Click_1(object sender, EventArgs e)  //RESET TABEL BUTTON
        {
            nOTEDataGridView.DataSource = nOTETableAdapter.GetData();
            nOTEDataGridView.ClearSelection();
            IDnota = 0;
            
            IDelev = 0;
            numetx.Text = "";
            prenumetx.Text = "";
            medielb.Text = "";
        }
    //ABSENCES
        private void button3_Click(object sender, EventArgs e) //ABSENCES BUTTON
         { 
            tabControl1.SelectedTab = tabPage4;
            
             aBSENTEDataGridView.ClearSelection();
             IDabsenta = 0;
            IDmaterie = 0;
             IDelev = 0;
             numetxt2.Text = "";
             prenumetxt2.Text = "";
            if (comboBox2.Items.Count == 0)
            {
                DataTable dt2 = baza_catalogDataSet.MATERII;
                for (int i = 0; i < dt2.Rows.Count; i++)
                    comboBox2.Items.Add(dt2.Rows[i]["denumire"]);

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDmaterie = Convert.ToInt32(mATERIITableAdapter.id_mat(comboBox2.SelectedItem.ToString()));
        }

        

        private void cautabt2_Click(object sender, EventArgs e) ///SEARCH BUTTON
        {
            IDelev = Convert.ToInt32(eLEVITableAdapter.Id_elev(numetxt2.Text, prenumetxt2.Text));
            if (IDelev != 0 && IDmaterie!=0)
            {
                if (radioButton1.Checked)
                {  aBSENTETableAdapter.tabel_ab2(baza_catalogDataSet.ABSENTE, IDelev, IDmaterie);
                aBSENTEDataGridView.DataSource = baza_catalogDataSet.ABSENTE;
                }
                else
                    if (radioButton2.Checked)
                    {aBSENTETableAdapter.tabel_ab(baza_catalogDataSet.ABSENTE, IDelev, IDmaterie, "excused");
                    aBSENTEDataGridView.DataSource = baza_catalogDataSet.ABSENTE;
                    }
                    else if (radioButton3.Checked)
                    {  aBSENTETableAdapter.tabel_ab(baza_catalogDataSet.ABSENTE, IDelev, IDmaterie, "unexcused");
                    aBSENTEDataGridView.DataSource = baza_catalogDataSet.ABSENTE;
                    }
                    else MessageBox.Show("Select the absence type.");
            }
            else MessageBox.Show("The data you entered is invalid. Please try again.");
}

        private void button1_Click_1(object sender, EventArgs e) //ADD BUTTON
        {
            IDelev = Convert.ToInt32(eLEVITableAdapter.Id_elev(numetxt2.Text, prenumetxt2.Text));
            if (IDelev != 0 && IDmaterie != 0 && (radioButton2.Checked || radioButton3.Checked))
            {
                string tipul;
                if (radioButton2.Checked) tipul = "excused";
                else tipul = "unexcused";
                aBSENTETableAdapter.adauga_absenta(dateTimePicker2.Value.ToString(), tipul.ToString(), IDelev, IDmaterie);
                aBSENTETableAdapter.Update(baza_catalogDataSet.ABSENTE);
                aBSENTETableAdapter.Fill(baza_catalogDataSet.ABSENTE);
                aBSENTEDataGridView.DataSource = aBSENTETableAdapter.GetData();
            }
            else MessageBox.Show("The data you entered is invalid. Please try again.");

        }

        

        private void aBSENTEDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && aBSENTEDataGridView.CurrentCell != null)
            {
                DataGridViewCell selectedCell = aBSENTEDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                DataGridViewRow selectedRow = aBSENTEDataGridView.Rows[e.RowIndex];

                IDabsenta = Convert.ToInt32(selectedRow.Cells[0].Value);
                dateTimePicker2.Value = Convert.ToDateTime(selectedRow.Cells[1].Value);
                IDelev = Convert.ToInt32(selectedRow.Cells[3].Value);
                IDmaterie = Convert.ToInt32(selectedRow.Cells[4].Value);
                DataTable dt2 = mATERIITableAdapter.GetData();
                comboBox2.SelectedItem = dt2.Rows[IDmaterie - 1]["denumire"].ToString();
                DataTable dt3 = eLEVITableAdapter.GetData();
                numetxt2.Text = dt3.Rows[IDelev - 1]["nume"].ToString();
                prenumetxt2.Text = dt3.Rows[IDelev - 1]["prenume"].ToString();
                string tipul = selectedRow.Cells[2].Value.ToString();
                if (tipul.Contains("unexcused")) radioButton3.Checked = true;
                else radioButton2.Checked = true;
            }
        }

        private void stergebt2_Click(object sender, EventArgs e) ///DELETE BUTTON
        {
            if (IDabsenta != 0 && IDmaterie!=0 && IDelev!=0)
            {
                aBSENTETableAdapter.Delete_absenta(IDabsenta);
                aBSENTETableAdapter.Update(baza_catalogDataSet.ABSENTE);
                aBSENTETableAdapter.Fill(baza_catalogDataSet.ABSENTE);
                numetxt2.Text = "";
                prenumetxt2.Text = "";
               
                aBSENTEDataGridView.DataSource = aBSENTETableAdapter.GetData();

            }
            else MessageBox.Show("Please select the absence you want to delete from the table.");
        }

        private void modificabt2_Click(object sender, EventArgs e) ///UPDATE BUTTON
        {
                   string tipul="";
                if (radioButton2.Checked) tipul = "excused";
                else
                    if(radioButton3.Checked)
                 tipul = "unexcused";
                IDelev = Convert.ToInt32(eLEVITableAdapter.Id_elev(numetxt2.Text, prenumetxt2.Text));
                if (IDabsenta != 0 && IDelev != 0 && IDmaterie != 0 && tipul != "" && numetxt2.Text!="" && prenumetxt2.Text!="")
                {
                    aBSENTETableAdapter.Update_absenta(dateTimePicker2.Value.ToString(), tipul, IDelev, IDmaterie, IDabsenta);
                    aBSENTETableAdapter.Update(baza_catalogDataSet.ABSENTE);
                    aBSENTETableAdapter.Fill(baza_catalogDataSet.ABSENTE);
                     aBSENTEDataGridView.DataSource = aBSENTETableAdapter.GetData();
                }
                else MessageBox.Show("Please select the absence you want to edit from the table and check the entered data.");
                
        }

        private void Resetare_abt_Click(object sender, EventArgs e) //RESET TABEL BUTTON
        {
            aBSENTEDataGridView.DataSource = aBSENTETableAdapter.GetData();

            aBSENTEDataGridView.ClearSelection();
            IDabsenta = 0;
           
            IDelev = 0;
            numetxt2.Text = "";
            prenumetxt2.Text = "";
        }
      //STATISTICI
        private void statistici_bt_Click(object sender, EventArgs e) //STATISTICS BUTTON
        {
            tabControl1.SelectedTab = tabPage5;
            richTextBox1.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            eLEVITableAdapter.MediaG_ce(baza_catalogDataSet.ELEVI);
            DataTable dt = baza_catalogDataSet.ELEVI;
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox1.Text += (dt.Rows[i]["Nume"]).ToString().Trim() + "  " + dt.Rows[i]["Prenume"].ToString().Trim() + "   " + dt.Rows[i]["denumire_clasa"].ToString().Trim() + "  "+dt.Rows[i]["media_generala"] + "\n";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
          eLEVITableAdapter.Nrabs(baza_catalogDataSet.ELEVI);
            DataTable dt = baza_catalogDataSet.ELEVI;
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox1.Text += dt.Rows[i]["Nume"].ToString().Trim() + "   " + dt.Rows[i]["Prenume"].ToString().Trim()+ "  " + dt.Rows[i]["denumire_clasa"].ToString().Trim()+"  " + dt.Rows[i]["totalabs"] + "\n";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {richTextBox1.Text="";
            cLASETableAdapter.mediepeste5(baza_catalogDataSet.CLASE);
            DataTable dt = baza_catalogDataSet.CLASE;
            for(int i=0;i<dt.Rows.Count;i++)
            richTextBox1.Text+=dt.Rows[i]["denumire_clasa"].ToString().Trim()+"   "+dt.Rows[i]["NumarElevi"]+"\n";


        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            cLASETableAdapter.mediasub5(baza_catalogDataSet.CLASE);
            DataTable dt = baza_catalogDataSet.CLASE;
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox1.Text += dt.Rows[i]["denumire_clasa"] + " " + dt.Rows[i]["NumarElevi"] + "\n";
        }

        private void button4_Click_1(object sender, EventArgs e) 
        {
            richTextBox1.Text = "";
            eLEVITableAdapter.top5(baza_catalogDataSet.ELEVI);
            DataTable dt = baza_catalogDataSet.ELEVI;
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox1.Text += dt.Rows[i]["Nume"] + " " + dt.Rows[i]["Prenume"] + " " + dt.Rows[i]["mg"] + "\n";
        }

        

       
        
    }
}
