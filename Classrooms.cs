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
    public partial class Classrooms : Form
    {
        public Classrooms()
        {
            InitializeComponent();
            DisplayClassRooms();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\loren\Documents\SchoolDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (classnamelbl.Text == "" || Capacitylbl.Text == "")
            {
                MessageBox.Show("Falta De Información");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ClassRooms(Cid,Nombre, Capacidad) values (@ide,@name, @capacity)", Con);
                    cmd.Parameters.AddWithValue("@ide", IdCode.Text);
                    cmd.Parameters.AddWithValue("@name", classnamelbl.Text);
                    cmd.Parameters.AddWithValue("@capacity", Capacitylbl.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aula Agregada");
                    Con.Close();
                    DisplayClassRooms();
                    //Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DisplayClassRooms()
        {
            Con.Open();
            string Query = "Select * from ClassRooms";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ClassRoomsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Key = 0;
            IdCode.Text = "";
            classnamelbl.Text = "";
            Capacitylbl.Text = "";
        }
        int Key = 0;
        private void ClassRoomsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdCode.Text = ClassRoomsDGV.SelectedRows[0].Cells[0].Value.ToString();
            classnamelbl.Text = ClassRoomsDGV.SelectedRows[0].Cells[1].Value.ToString();
            Capacitylbl.Text = ClassRoomsDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (IdCode.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ClassRoomsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (classnamelbl.Text == "" || Capacitylbl.Text == "")
            {
                MessageBox.Show("Falta De Información");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update ClassRooms set Cid=@ide,Nombre=@name,Capacidad=@Capacity where Cid=@ide", Con);      
                    cmd.Parameters.AddWithValue("@ide", IdCode.Text);
                    cmd.Parameters.AddWithValue("@name", classnamelbl.Text);
                    cmd.Parameters.AddWithValue("@Capacity", Capacitylbl.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aula Actualizada");
                    Con.Close();
                    DisplayClassRooms();
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Seleccionar Aulas");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ClassRooms where CId= @CKey", Con);
                    cmd.Parameters.AddWithValue("@CKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aula Eliminada");
                    Con.Close();
                    DisplayClassRooms();
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
