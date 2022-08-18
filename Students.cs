using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            DisplayStudent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\loren\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Seleccionar Estudiante");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from StudentTbl where Stid= @StKey", Con);
                    cmd.Parameters.AddWithValue("@StKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Estudiante Eliminado");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || SCorreoTb.Text == "" || STelefonoTb.Text == "")
            {
                MessageBox.Show("Falta De Información");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update StudentTbl set Stid=@SSid,StNombre=@Snombre,Correo=@SSCorreo,StTelefono=@SSTelefono where Stid=@SSid", Con);
                    cmd.Parameters.AddWithValue("@SSid", SMatricula2.Text);
                    cmd.Parameters.AddWithValue("@Snombre", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SSCorreo", SCorreoTb.Text);
                    cmd.Parameters.AddWithValue("@SSTelefono", STelefonoTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Estudiante Actualizado");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DisplayStudent()
        {
            Con.Open();
            string Query = "Select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StudentsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if(StNameTb.Text == "" || SCorreoTb.Text == "" || STelefonoTb.Text == "") 
            {
                MessageBox.Show("Falta De Información");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentTbl(Stid,StNombre, Correo,StTelefono) values (@SSid,@Snombre, @SSCorreo,@SSTelefono)", Con);
                    cmd.Parameters.AddWithValue("@SSid", SMatricula2.Text);
                    cmd.Parameters.AddWithValue("@Snombre", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SSCorreo", SCorreoTb.Text);
                    cmd.Parameters.AddWithValue("@SSTelefono", STelefonoTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Estudiante Agregado");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            Key = 0;
            SMatricula2.Text = "";
            StNameTb.Text = "";
            SCorreoTb.Text = "";
            STelefonoTb.Text = "";
        }
        int Key = 0;
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SMatricula2.Text = StudentsDGV.SelectedRows[0].Cells[0].Value.ToString();
            StNameTb.Text = StudentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            SCorreoTb.Text = StudentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            STelefonoTb.Text = StudentsDGV.SelectedRows[0].Cells[3].Value.ToString();
            if (StNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(StudentsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
