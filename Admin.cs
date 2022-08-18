using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            DisplayAdmin();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\loren\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (TCodeTb.Text == "" || TnombreTb.Text == "" || TcorreoTb.Text == "" || tTelefonoTb.Text == "" || TPosicionTb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AdminTbl(CodeId,Anombre, Acorreo,Atelefono, AMateria) values (@Tcode,@Tnombre, @TCorreo,@TTelefono, @Tposicion)", Con);
                    cmd.Parameters.AddWithValue("@Tcode", TCodeTb.Text);
                    cmd.Parameters.AddWithValue("@Tnombre", TnombreTb.Text);
                    cmd.Parameters.AddWithValue("@TCorreo", TcorreoTb.Text);
                    cmd.Parameters.AddWithValue("@TTelefono", tTelefonoTb.Text);
                    cmd.Parameters.AddWithValue("@Tposicion", TPosicionTb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin Agregado");
                    Con.Close();
                    DisplayAdmin();
                    //Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DisplayAdmin()
        {
            Con.Open();
            string Query = "Select * from AdminTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AdminDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Anombrelbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void code_Click(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            Key = 0;
            TCodeTb.Text = "";
            TnombreTb.Text = "";
            TcorreoTb.Text = "";
            tTelefonoTb.Text = "";
            TPosicionTb.SelectedItem = -1;
        }
        int Key = 0;
        private void AdminDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TCodeTb.Text = AdminDGV.SelectedRows[0].Cells[0].Value.ToString();
            TnombreTb.Text = AdminDGV.SelectedRows[0].Cells[1].Value.ToString();
            TcorreoTb.Text = AdminDGV.SelectedRows[0].Cells[2].Value.ToString();
            tTelefonoTb.Text = AdminDGV.SelectedRows[0].Cells[3].Value.ToString();
            TPosicionTb.SelectedItem = AdminDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (TCodeTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AdminDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TCodeTb.Text == "" || TnombreTb.Text == "" || TcorreoTb.Text == "" || tTelefonoTb.Text == "" || TPosicionTb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AdminTbl set CodeId=@Tcode,Anombre=@Tnombre,Acorreo=@TCorreo,Atelefono=@TTelefono,AMateria=@Tposicion where CodeId=@Tcode", Con);
                    cmd.Parameters.AddWithValue("@Tcode", TCodeTb.Text);
                    cmd.Parameters.AddWithValue("@Tnombre", TnombreTb.Text);
                    cmd.Parameters.AddWithValue("@TCorreo", TcorreoTb.Text);
                    cmd.Parameters.AddWithValue("@TTelefono", tTelefonoTb.Text);
                    cmd.Parameters.AddWithValue("@Tposicion", TPosicionTb.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Actualizado");
                    Con.Close();
                    DisplayAdmin();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Staff");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AdminTbl where CodeId= @Tcode", Con);
                    cmd.Parameters.AddWithValue("@Tcode", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Staff Eliminado");
                    Con.Close();
                    DisplayAdmin();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
