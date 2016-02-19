using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient; //dodano za rad sa SQL Server bazom

namespace emRec_project
{
    public partial class loginForm : Form
    {
        SqlConnection konekcija = new SqlConnection();
        public loginForm()
        {
            InitializeComponent();
            konekcija.ConnectionString = @"Data Source=LOVRA-PC;Initial Catalog=PulsDB;Integrated Security=True";
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = "";
                konekcija.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = konekcija;
                command.CommandText = "SELECT * FROM tblUsers WHERE UserName ='"+ txtUserName.Text+"' AND Password ='"+ txtPassword.Text+"'";

                SqlDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    user = txtUserName.Text;                                        
                    MessageBox.Show("Dobrodošao " + user);
                    konekcija.Close();
                    konekcija.Dispose();
                    this.Hide();
                    mainForm f2 = new mainForm(user);
                    f2.ShowDialog();
                    this.Close();
                }
                else if (count > 1)
                    MessageBox.Show("Dupli User Name i Password");
                else
                    MessageBox.Show("Greška prilikom prijave! \n\nProvjerite 'User Name' i 'Password'");

                konekcija.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Greška prilikom spajanja s bazom!");
            }
        }
    }
}
