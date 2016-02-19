using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;

using System.Data.SqlClient; //dodano za rad sa SQL Server bazom
using System.Data.OleDb;
using emRec_project;
using emRec_project.PulsDBDataSetTableAdapters;

namespace emRec_project
{
    public partial class importExcelForm : Form
    {
        public importExcelForm()
        {
            InitializeComponent();
        }

        //metoda za dobivanje imena excel komentara, sprema se u 'textBoxPathKomentari'
        private void bttnOdaberiKomentari_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogImportExcel = new OpenFileDialog();

            if (openFileDialogImportExcel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBoxPathKomentari.Text = openFileDialogImportExcel.FileName;
            }
        }

        //metoda za dobivanje imena excel statistike, sprema se u 'txtboxPathStatistika'
        private void bttnOdaberiStatistika_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogImportExcel = new OpenFileDialog();

            if (openFileDialogImportExcel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtboxPathStatistika.Text = openFileDialogImportExcel.FileName;
            }
        }

        private void bttnUcitaj_Click(object sender, EventArgs e)
        {
            try
            {
                //učitavanje Excel komentara u tablicu za komentare 'tblImportKomentari'
                string PathConn1 = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + textBoxPathKomentari.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
                OleDbConnection oleDBkonekcija = new OleDbConnection(PathConn1);

                SqlConnection konekcija = new SqlConnection(@"Data Source=LOVRA-PC;Initial Catalog=PulsDB;Integrated Security=True"); //konekcijski string za povezivanje na bazu 'PulsDB' na mom lokalnom serveru 'LOVRA-PC'
                konekcija.Open(); //otvaramo konekciju na bazu

                SqlCommand command1 = new SqlCommand("DELETE FROM tblImportStatistics", konekcija); //Query za brisanje podataka iz tablice 'tblImportKomentari'.
                command1.ExecuteNonQuery(); //izvršavanje query-a zapisanog u 'command1'

                SqlCommand command2 = new SqlCommand("DELETE FROM tblImportKomentari", konekcija); //Query za brisanje podataka iz tablice 'tblImportStatistics'.
                command2.ExecuteNonQuery(); //izvršavanje query-a zapisanog u 'command2'

                OleDbCommand selection = new OleDbCommand("SELECT * FROM [Sheet1$]", oleDBkonekcija);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = selection;

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                komentariKontroleForm kkF = new komentariKontroleForm();
                kkF.tblImportKomentariDataGridView.DataSource = ds.Tables[0];
                oleDBkonekcija.Close();

                SqlBulkCopy import = new SqlBulkCopy(konekcija);
                import.DestinationTableName = "tblImportKomentari";
                import.WriteToServer(ds.Tables[0]);

                //učitavanje Excel statistike u tablicu za statistiku 'tblImportStatistics'
                string PathConn2 = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + txtboxPathStatistika.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
                OleDbConnection oleDbkonekcija2 = new OleDbConnection(PathConn2);

                OleDbCommand selection2 = new OleDbCommand("SELECT * FROM [List1$]", oleDbkonekcija2);
                OleDbDataAdapter adapter2 = new OleDbDataAdapter();
                adapter2.SelectCommand = selection2;

                DataSet ds2 = new DataSet();
                adapter2.Fill(ds2);

                statistikaForm sF = new statistikaForm();
                sF.tblImportStatisticsDataGridView.DataSource = ds2.Tables[0];
                oleDbkonekcija2.Close();


                SqlBulkCopy import2 = new SqlBulkCopy(konekcija);
                import2.DestinationTableName = "tblImportStatistics";
                import2.WriteToServer(ds2.Tables[0]); 
                konekcija.Close(); //zatvaramo konekciju na bazu 

                //Opening second form
                this.Hide();
                kompletnaStatistikaForm f5 = new kompletnaStatistikaForm();
                f5.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Došlo je do pogreške prilikom učitavanja.\n\nProvjerite sve i pokušajte ponovno.");
            }
        }


    }
}