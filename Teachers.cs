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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            DisplayTeachers();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\loren\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayTeachers()
        {
            Con.Open();
            string Query = "Select * from TeacherTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TeachersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            TnombreTb.Text = "";
            TcorreoTb.Text = "";
            tTelefonoTb.Text = "";
            TMateriaTb.Text = "";




        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TnombreTb.Text == "" || TcorreoTb.Text == "" || tTelefonoTb.Text == "" || TMateriaTb.Text == "")
            {
                MessageBox.Show("Falta De Información");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TeacherTbl(TId,Tname, Tcorreo,Ttelefono, TMateria) values (@Tcode,@Tnombre, @TCorreo,@TTelefono,@Tmateriaa)", Con);
                    cmd.Parameters.AddWithValue("@Tcode", TCodeTb.Text);
                    cmd.Parameters.AddWithValue("@Tnombre", TnombreTb.Text);
                    cmd.Parameters.AddWithValue("@TCorreo", TcorreoTb.Text);
                    cmd.Parameters.AddWithValue("@TTelefono", tTelefonoTb.Text);
                    cmd.Parameters.AddWithValue("@Tmateriaa", TMateriaTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Profesor Agregado");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int Key = 0;
        private void TeachersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TCodeTb.Text = TeachersDGV.SelectedRows[0].Cells[0].Value.ToString();
            TnombreTb.Text = TeachersDGV.SelectedRows[0].Cells[1].Value.ToString();
            TcorreoTb.Text = TeachersDGV.SelectedRows[0].Cells[2].Value.ToString();
            tTelefonoTb.Text = TeachersDGV.SelectedRows[0].Cells[3].Value.ToString();
            TMateriaTb.Text = TeachersDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (TnombreTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TeachersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Seleccionar Profesor");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from TeacherTbl where TId= @TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Profesor Eliminado");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TnombreTb.Text == "" || TcorreoTb.Text == "" || tTelefonoTb.Text == "" || TMateriaTb.Text == "")
                {
                MessageBox.Show("Falta De Información");
            }
            else
            {
                try  
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update TeacherTbl set Tname=@Tnombre,Tcorreo=@TCorreo,Ttelefono=@TTelefono,TMateria=@Tmateriaa where Tid=@Tcode", Con);
                    cmd.Parameters.AddWithValue("@Tcode", TCodeTb.Text);
                    cmd.Parameters.AddWithValue("@Tnombre", TnombreTb.Text);
                    cmd.Parameters.AddWithValue("@TCorreo", TcorreoTb.Text);
                    cmd.Parameters.AddWithValue("@TTelefono", tTelefonoTb.Text);
                    cmd.Parameters.AddWithValue("@Tmateriaa", TMateriaTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Profesor Actualizado");
                    Con.Close();
                    DisplayTeachers();
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
