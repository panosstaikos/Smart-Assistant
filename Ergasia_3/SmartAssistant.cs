using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Ergasia_3
{
    public partial class SmartAssistant : Form
    {
        public SmartAssistant()
        {
            InitializeComponent();
        }
        Bitmap gym_car = Properties.Resources.gym_car;
        Bitmap gym_foot = Properties.Resources.gym_foot;
        Bitmap uni_bus = Properties.Resources.uni_bus;

        //Για την δημηιουργία του πλάνου ημέρας χρησιμοποιήθηκε η sqlite
        //Σύνδεση project με sqlite
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void SmartAssistant_Load(object sender, EventArgs e)
        {
            //Αρχικοποίηση των επιλογών
            DestinationBox.SelectedItem = "Δουλειά";
            TransportBox.SelectedItem = "Μοτοσυκλέτα";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            LoadData();
        }

        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=day_plan.db;Version=3;New=False;Compress=True;");
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from day_plan";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        //Για την διαευκόκυνση της λειτουργίας edit πάνω στο πλάνο ημέρας, όταν ο χρήστης πατάει σε κάποιο cell, τότε τα αντίστοιχα Boxes παίρνουν τις τιμές αυτές
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DestinationBox.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TransportBox.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Yes")
                {
                    CoffeeBox.Checked = true;
                }
                else
                {
                    CoffeeBox.Checked = false;
                }
            }
        }


        //Insert into data base and load datas in dataGridView
        private void Instert_button_Click_1(object sender, EventArgs e)
        {
            string txtQuery = "insert into day_plan (Destination,Transport,Day_time,Coffee)values('" + DestinationBox.SelectedItem.ToString() + "', '" + TransportBox.SelectedItem.ToString() + "', '" + dateTimePicker1.Value + "', 'No')";

            if (CoffeeBox.Checked == true)
            {
                txtQuery = "insert into day_plan (Destination,Transport,Day_time,Coffee)values('" + DestinationBox.SelectedItem.ToString() + "', '" + TransportBox.SelectedItem.ToString() + "', '" + dateTimePicker1.Value + "',  'Yes')";
            }

            ExecuteQuery(txtQuery);
            MessageBox.Show("Πραγματοποιήθηκε προσθήκη συμβάντος στο πλάνο ημέρας");
            LoadData();
        }

        //Delete data base and load datas in dataGridView
        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            string txtQuery = "delete from day_plan where ID = '" + Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) + "'";
            ExecuteQuery(txtQuery);
            MessageBox.Show("Πραγματοποιήθηκε αλλαγή στο πλάνο ημέρας");
            LoadData();
        }

        //Edit data base and load datas in dataGridView
        private void EditButton_Click_1(object sender, EventArgs e)
        {
            string txtQuery;
            if (CoffeeBox.Checked == true)
            {
                txtQuery = "update day_plan set Destination = '" + DestinationBox.SelectedItem.ToString() + "', Transport = '" + TransportBox.SelectedItem.ToString() + "', " +
               "Day_time = '" + dateTimePicker1.Value.ToString() + "', Coffee = 'Υes' where ID = '" + Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) + "'";
            }
            else
            {
                txtQuery = "update day_plan set Destination = '" + DestinationBox.SelectedItem.ToString() + "', Transport = '" + TransportBox.SelectedItem.ToString() + "', " +
               "Day_time = '" + dateTimePicker1.Value.ToString() + "', Coffee = 'No' where ID = '" + Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) + "'";
            }
            ExecuteQuery(txtQuery);
            MessageBox.Show("Πραγματοποιήθηκε αλλαγή στο πλάνο ημέρας");
            LoadData();
        }

        //Insert into data base the dog feeding
        private void button_WOC1_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into day_plan (Destination,Transport,Day_time,Coffee)values('Dog Feeding', '-', '" + dateTimePicker1.Value + "', '-')";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }


        //Εμφάνιση χάρτη σε συγκεκριμένες περιπτώσεις
        private void ShowButton_Click(object sender, EventArgs e)
        {
            int image_code;
            if(DestinationBox.SelectedIndex == 1 && TransportBox.SelectedIndex == 4)
            {
                image_code = 1;
                Map map = new Map(image_code);
                map.Show();
                this.Hide();
            }else if(DestinationBox.SelectedIndex == 0 && (TransportBox.SelectedIndex == 1 || TransportBox.SelectedIndex == 0))
            {
                image_code = 2;
                Map map = new Map(image_code);
                map.Show();
                this.Hide();
            }
        }
    }
}
