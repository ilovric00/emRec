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
    public partial class anketaForm : Form
    {
        string q1, q2, q3, q4, q5, q6, q7,q8;
        public anketaForm()
        {
            InitializeComponent();
        }

        private void anketaForm_Load(object sender, EventArgs e)
        {
                    panel1.Hide(); //sve panele osim početnog (prvog) panela sakrijemo
                    panel2.Hide();
                    panel3.Hide();
                    panel4.Hide();
                    panel5.Hide();
                    panel6.Hide();
                    panel7.Hide();
                    panel8.Hide();

                    startPanel.Location = new Point(100, 70); //postavimo lokaciju svih panela na istu poziciju, zbog urednosti, centriranog dizajna i sl. :))
                    panel1.Location = new Point(110, 70);
                    panel2.Location = new Point(110, 70);
                    panel3.Location = new Point(110, 70);
                    panel4.Location = new Point(110, 95);
                    panel5.Location = new Point(110, 70);
                    panel6.Location = new Point(90, 70);
                    panel7.Location = new Point(90, 70);
                    panel8.Location = new Point(110, 70); 
        }
        private void startBttn_Click(object sender, EventArgs e)
        {
            if (userTxtBox.Text != "") //ako je unesena neka vrijednost u TextBox, tj. uneseno je ime anketara
            {
                panel1.Show(); //otvori mi panel 'panel1' na kojem se nalazi Pitanje 1)
                startPanel.Hide(); //sakrij trenutni panel tj 'startPanel'

            }
            else
                MessageBox.Show("Prvo unesite Vaše ime!"); //poruka
        }

        private void prevBttn1_Click(object sender, EventArgs e)
        {
            startPanel.Show();
            panel1.Hide();
        }

        private void nextBttn1_Click(object sender, EventArgs e)
        {
            panel2.Show(); //otvori 'panel2' na kojem se nalazi Pitanje 2)
            panel1.Hide(); //zatvori 'panel1' na kojem se nalazi Pitanje 1)
            if (radioButton1.Checked)
                q1 = radioButton1.Text; 
            else
                q1 = radioButton2.Text;     
        }

        private void prevBttn2_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void nextBttn2_Click(object sender, EventArgs e)
        {
            panel3.Show(); 
            panel2.Hide();

            q2 = q2TxtBox.Text;
        }

        private void prevBttn3_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel3.Hide();
        }

        private void nextBttn3_Click(object sender, EventArgs e) //treće pitanje
        {
            if (!radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked) //ako ništa nije označeno
                MessageBox.Show("Niste odgovorili na pitanje!");
            else
            {
                if (radioButton3.Checked) //ako je prvi odgovor označen
                    q3 = radioButton3.Text;
                else if (radioButton4.Checked) //ili ako je drugi odgovor označen
                    q3 = radioButton4.Text;
                else if (radioButton5.Checked) //ili ako je treći odgovor označen
                    q3 = radioButton5.Text;

                panel4.Show(); //prikaži sljedeće pitanje
                panel3.Hide(); //sakrij trenutno pitanje
            }
        }

        private void prevBttn4_Click(object sender, EventArgs e)
        {
            panel3.Show();
            panel4.Hide();
        }

        private void nextBttn4_Click(object sender, EventArgs e)
        {
            if (!radioButton6.Checked && !radioButton7.Checked && !radioButton8.Checked && !radioButton9.Checked && !radioButton10.Checked && !radioButton11.Checked) //ako ništa nije označeno
                MessageBox.Show("Niste odgovorili na pitanje!");
            else
            {
                if (radioButton6.Checked) //ako je prvi odgovor označen
                    q4 = radioButton6.Text;
                else if (radioButton7.Checked) //ili ako je drugi odgovor označen
                    q4 = radioButton7.Text;
                else if (radioButton8.Checked) //ili ako je treći odgovor označen
                    q4 = radioButton8.Text;
                else if (radioButton9.Checked) //ili ako je treći odgovor označen
                    q4 = radioButton9.Text;
                else if (radioButton10.Checked) //ili ako je treći odgovor označen
                    q4 = radioButton10.Text;
                else if (radioButton11.Checked) //ili ako je treći odgovor označen
                    q4 = radioButton11.Text;

                panel5.Show(); //prikaži sljedeće pitanje
                panel4.Hide(); //sakrij trenutno pitanje
            }
        }

        private void prevBttn5_Click(object sender, EventArgs e)
        {
            panel4.Show();
            panel5.Hide();
        }

        private void nextBttn5_Click(object sender, EventArgs e)
        {
            panel6.Show();
            panel5.Hide(); 
            if (radioButton12.Checked)
                q5 = radioButton12.Text; 
            else
                q5 = radioButton13.Text;
        }

        private void prevBttn6_Click(object sender, EventArgs e)
        {
            panel5.Show();
            panel6.Hide();
        }

        private void nextBttn6_Click(object sender, EventArgs e)
        {
            panel7.Show();
            panel6.Hide();

            if (radioButton14.Checked)
                q6 = "1"; 
            else if (radioButton15.Checked)
                q6 = "2";
            else if (radioButton16.Checked)
                q6 = "3";
            else if (radioButton17.Checked)
                q6 = "4";
            else if (radioButton18.Checked)
                q6 = "5";
            else if (radioButton19.Checked)
                q6 = "6";
            else if (radioButton20.Checked)
                q6 = "7";
            else if (radioButton21.Checked)
                q6 = "8";
            else if (radioButton22.Checked)
                q6 = "9";
            else
                q6 = "10";
        }

        private void prevBttn7_Click(object sender, EventArgs e)
        {
            panel6.Show();
            panel7.Hide();
        }

        private void nextBttn7_Click(object sender, EventArgs e)
        {
            panel8.Show();
            panel7.Hide();

            checkedListBox1_SelectedIndexChanged(this,null);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            q7 = "";

            foreach (string item in checkedListBox1.CheckedItems)
            {
                q7 += item;
            }        
        }

        private void prevBttn8_Click(object sender, EventArgs e)
        {
            panel7.Show();
            panel8.Hide();
        }

        private void finishBttn_Click(object sender, EventArgs e)
        {
            panel8.Hide();
            q8 = q8TxtBox.Text;

            try
            {
                SqlConnection konekcija = new SqlConnection(@"Data Source=LOVRA-PC;Initial Catalog=PulsDB;Integrated Security=True"); //konekcijski string za povezivanje na bazu 'PulsDB' na mom lokalnom serveru 'LOVRA-PC'
                konekcija.Open(); //otvaramo konekciju na bazu
                SqlCommand command = new SqlCommand("INSERT INTO tblAnketa(d1, d2, d3, p1, p2, p3, p4, p5, Pulsic) VALUES(@d1, @d2, @d3, @p1, @p2, @p3, @p4, @p5, @Pulsic)", konekcija); //Query za unos podataka u tablicu 'tblAnketa'.

                command.Parameters.AddWithValue("@d1", q1); //unosimo spremljena pitanja 
                command.Parameters.AddWithValue("@d2", q2);
                command.Parameters.AddWithValue("@d3", q3);
                command.Parameters.AddWithValue("@p1", q4);
                command.Parameters.AddWithValue("@p2", q5);
                command.Parameters.AddWithValue("@p3", q6);
                command.Parameters.AddWithValue("@p4", q7);
                command.Parameters.AddWithValue("@p5", q8);
                command.Parameters.AddWithValue("@Pulsic", int.Parse(userTxtBox.Text));
                command.ExecuteNonQuery(); //izvršavanje query-a zapisanog u 'command'

                konekcija.Close(); //zatvaramo konekciju na bazu
                MessageBox.Show("Anketa uspješno spremljena!"); 
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OKCancel); //u slučaju greške, npr. ne spajanja na bazu, javi mi grešku
            }
            //ispunjenu zatvaramo, a otvaramo novu anketu
            this.Hide(); 
            anketaForm aF = new anketaForm(); 
            this.Close();
            aF.ShowDialog();
        }



    }


    
}
