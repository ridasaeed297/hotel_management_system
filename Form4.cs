using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management_system10
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Add Room Type and Status options
            comboBox1.Items.AddRange(new string[] { "Single", "Double", "Suite" }); // Room Type
            comboBox2.Items.AddRange(new string[] { "Available", "Booked", "Maintenance" }); // Room Status

            // Set up DataGridView
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Room No";
            dataGridView1.Columns[1].Name = "Room Type";
            dataGridView1.Columns[2].Name = "Room Status";
            dataGridView1.Columns[3].Name = "Price";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add Room
            dataGridView1.Rows.Add(textBox1.Text, comboBox1.Text, comboBox2.Text, textBox2.Text);
            ClearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Update Room
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells[1].Value = comboBox1.Text;
                dataGridView1.CurrentRow.Cells[2].Value = comboBox2.Text;
                dataGridView1.CurrentRow.Cells[3].Value = textBox2.Text;
                ClearFields();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete Room
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                ClearFields();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Clear Form
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }
            private void ClearFields()
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox2.Clear();
        }

    }
}
