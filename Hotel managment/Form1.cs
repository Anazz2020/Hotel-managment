using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_managment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        SqlCommand cmd ;
        SqlDataAdapter da;
        DataSet ds;
        int RowNumber = 0;
        DataTable dt_hotel;
        DataRow dr;

        SqlCommandBuilder cmdBuild;

        public DataTable GetImage(string rqt)
        {
            cn= new SqlConnection(@"Data Source=LAST-PC\SQLEXPRESS;Initial Catalog=gestion_hotel;Integrated Security=True");
            cmd = new SqlCommand(rqt, cn);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "hotel");
            return ds.Tables["hotel"];
        }
        
        private void Afficher(int row)
        {
            this.textBoxNumerohotel.Text = dt_hotel.Rows[row].ItemArray[0].ToString();
            this.textBoxNomH.Text = dt_hotel.Rows[row].ItemArray[1].ToString();
            this.textBoxVille.Text = dt_hotel.Rows[row].ItemArray[2].ToString();
            if (dt_hotel.Rows[row].ItemArray[0].ToString() == "*")
            { radioButton1.Checked = true; }
            else if (dt_hotel.Rows[row].ItemArray[3].ToString() == "**")
            { radioButton2.Checked = true; }
            else if (dt_hotel.Rows[row].ItemArray[3].ToString() == "***")
            { radioButton3.Checked = true; }
            else if (dt_hotel.Rows[row].ItemArray[3].ToString() == "****")
            { radioButton4.Checked = true; }
            else if (dt_hotel.Rows[row].ItemArray[3].ToString() == "*****")
            { radioButton5.Checked = true; }
            this.dataGridView1.Rows[row].Selected = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt_hotel = new DataTable();
            dt_hotel = GetImage("SELECT * FROM hotel");
            this.dataGridView1.DataSource = dt_hotel;

            if (dt_hotel.Rows.Count > 0)
            {
                Afficher(RowNumber);

            }
           
        }

        private void textBoxLibelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPremier_Click(object sender, EventArgs e)
        {
            RowNumber = 0;
            Afficher(RowNumber);
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            if (RowNumber == dt_hotel.Rows.Count - 1)
            {
                RowNumber = 0;
            }
            else
            {
                RowNumber++;
            }
            Afficher(RowNumber);
        }

        private void buttonPrecedent_Click(object sender, EventArgs e)
        {
            if (RowNumber == 0)
            {
                RowNumber = dt_hotel.Rows.Count - 1;
            }
            else
            {
                RowNumber--;
            }
            Afficher(RowNumber);
        }

        private void buttonDernier_Click(object sender, EventArgs e)
        {
            RowNumber = dt_hotel.Rows.Count - 1;
            Afficher(RowNumber);
        }

        private void buttonNouveau_Click(object sender, EventArgs e)
        {
            this.textBoxNumerohotel.Text= "";
            this.textBoxNomH.Text = "";
            this.textBoxVille.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                RowNumber = e.RowIndex;
                Afficher(RowNumber);
                this.dataGridView1.Rows[RowNumber].Selected = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                RowNumber = e.RowIndex;
                Afficher(RowNumber);
                this.dataGridView1.Rows[RowNumber].Selected = true;
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            dr = dt_hotel.NewRow();
            dr[0] = this.textBoxNumerohotel.Text;
            dr[1] = this.textBoxNomH.Text;
            if (radioButton1.Checked == true)
            {
                dr[3] = "*"; 
            }
            else if (radioButton2.Checked == true)
            {
                dr[3] = "**";
            }
            MessageBox.Show("Bien ajouter ");
        }
    }
}
