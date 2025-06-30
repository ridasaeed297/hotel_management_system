using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace hotel_management_system10
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Dummy data — in real case, pull from Guest and Room tables
            comboBox1.Items.AddRange(new string[] { "Ali", "Sara", "rafia","maida" ,"layba" ," ilsa"});       // Guests
            comboBox2.Items.AddRange(new string[] { "101", "102", "103", "104", "105" });         // Rooms

            // Setup DataGridView
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Guest";
            dataGridView1.Columns[1].Name = "Room No";
            dataGridView1.Columns[2].Name = "Check-In";
            dataGridView1.Columns[3].Name = "Check-Out";
            dataGridView1.Columns[4].Name = "Status";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Book Room
            dataGridView1.Rows.Add(comboBox1.Text, comboBox2.Text,
                dtpCheckIn.Value.ToShortDateString(),
                dtpCheckOut.Value.ToShortDateString(),
                textBoxStatus.Text);

            ClearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cancel Booking (Delete row)
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                ClearFields();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear fields
            ClearFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Go Back to Dashboard
            this.Hide();
            Form2 dashboard = new Form2();
            dashboard.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Fill fields from selected row
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dtpCheckIn.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                dtpCheckOut.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                textBoxStatus.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }
            private void ClearFields()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;
            textBoxStatus.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
