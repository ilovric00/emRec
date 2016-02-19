using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; //dodano za rad sa SQL Server bazom
using System.Data.Sql;

namespace emRec_project
{
    public partial class zaposleniciForm : Form
    {
        public zaposleniciForm()
        {
            InitializeComponent();
        }

        private void tblPulsiciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblPulsiciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pulsDBDataSet);

        }

        private void zaposleniciForm_Load(object sender, EventArgs e)
        {
            addPanel.Hide();
            this.tblPulsiciTableAdapter.Fill(this.pulsDBDataSet.tblPulsici); //This line of code loads data into the 'pulsDBDataSet.tblPulsici' table.

        }

        private void searchBttn_Click(object sender, EventArgs e) //pretraživanje po prezimenu
        {
            try
            {
                this.tblPulsiciTableAdapter.SearchQuery(this.pulsDBDataSet.tblPulsici, searchTxtBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void addBttn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection konekcija = new SqlConnection(@"Data Source=LOVRA-PC;Initial Catalog=PulsDB;Integrated Security=True"); //konekcijski string za povezivanje na bazu 'PulsDB' na mom lokalnom serveru 'LOVRA-PC'
                konekcija.Open(); //otvaramo konekciju na bazu
                SqlCommand command1 = new SqlCommand("INSERT INTO tblUsers(Pulsic, UserName, Password) VALUES(@Pulsic, @UserName, @Password)", konekcija); //Query za unos podataka u tablicu 'tblUsers'

                command1.Parameters.AddWithValue("@Pulsic", pulsicTextBox.Text); //vrijednost iz 'pulsicTextBox' se dodaje u @Pulsic
                command1.Parameters.AddWithValue("@UserName", userNameTextBox.Text); //vrijednost iz 'userNameTextBox' se dodaje u @UserName
                command1.Parameters.AddWithValue("@Password", passwordTextBox.Text); //vrijednost iz 'passwordTextBox' se dodaje u @Password
                command1.ExecuteNonQuery(); //izvršavanje query-a zapisanog u 'command1'

                SqlCommand command2 = new SqlCommand("INSERT INTO tblPulsici(Prezime, Ime, Mail, Pozicija, Telefon, Mobitel, Adresa, Grad, Ugovor, Pulsic) VALUES(@Prezime, @Ime, @Mail, @Pozicija, @Telefon, @Mobitel, @Adresa, @Grad, @Ugovor, @Pulsic)", konekcija); //Query za unos podataka u tablicu 'tblPulsici'

                command2.Parameters.AddWithValue("@Prezime", prezimeTextBox.Text); 
                command2.Parameters.AddWithValue("@Ime", imeTextBox.Text);
                command2.Parameters.AddWithValue("@Mail", mailTextBox.Text);
                command2.Parameters.AddWithValue("@Pozicija", pozicijaTextBox.Text);
                command2.Parameters.AddWithValue("@Telefon", telefonTextBox.Text);
                command2.Parameters.AddWithValue("@Mobitel", mobitelTextBox.Text);
                command2.Parameters.AddWithValue("@Adresa", adresaTextBox.Text);
                command2.Parameters.AddWithValue("@Grad", gradTextBox.Text);
                command2.Parameters.AddWithValue("@Ugovor", ugovorCheckBox.Checked); 
                command2.Parameters.AddWithValue("@Pulsic", pulsicTextBox.Text);
                command2.ExecuteNonQuery(); //izvršavanje query-a zapisanog u 'command2'

                konekcija.Close(); //zatvaramo konekciju na bazu 

                MessageBox.Show("\n Ime: " + imeTextBox.Text + "\n Prezime: " + prezimeTextBox.Text + "\n Osoba je uspješno unesena!"); //poruka uspješnog unosa i unesenih podataka
                addPanel.Hide(); //sakrij panel za unos
                this.tblPulsiciTableAdapter.Fill(this.pulsDBDataSet.tblPulsici); //"osvježi" DataSet
                tblPulsiciDataGridView.Show(); //prikaži mi DataGridView koji je bia sakriven tijekom unosa zaposlenika
                tblPulsiciBindingNavigator.Show(); //prikaži mi BindingNavigator koji je bia sakriven tijekom unosa zaposlenika
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); //u slučaju greške ispiši poruku o kakvom je greški riječ
            }
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            this.tblPulsiciTableAdapter.Fill(this.pulsDBDataSet.tblPulsici);
            addPanel.Hide();
            tblPulsiciDataGridView.Show();
            tblPulsiciBindingNavigator.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tblPulsiciDataGridView.Hide();
            tblPulsiciBindingNavigator.Hide();
            addPanel.Show();

            pulsicTextBox.Text = ""; //postavljamo sve TextBoxove kao prazne
            userNameTextBox.Text = "";          
            passwordTextBox.Text  ="";        
            prezimeTextBox.Text = "";
            imeTextBox.Text = "";
            mailTextBox.Text = "";
            pozicijaTextBox.Text = "";
            telefonTextBox.Text = "";
            mobitelTextBox.Text = "";
            adresaTextBox.Text = "";
            gradTextBox.Text = "";
            ugovorCheckBox.Checked = false; //postavimo CheckBox kao ne-checkiran
            pulsicTextBox.Text = "";
        }
    }
}
