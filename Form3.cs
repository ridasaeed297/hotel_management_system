using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hotel_management_system10
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //add gender option
            comboBox1.Items.AddRange(new string[] { "Male", "Female", "Other" });

            // Setup DataGridView
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Address";
            dataGridView1.Columns[2].Name = "CNIC";
            dataGridView1.Columns[3].Name = "Contact";
            dataGridView1.Columns[4].Name = "Gender";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add
            dataGridView1.Rows.Add(textbox1.Text, textbox2.Text, textbox3.Text, textbox4.Text, comboBox1.Text);
            ClearFields();
        }
    
    private void ClearFields()
        {
            textbox1.Clear();
            textbox2.Clear();
            textbox3.Clear();
            textbox4.Clear();
            comboBox1.SelectedIndex = -1;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Update
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[0].Value = textbox1.Text;
                dataGridView1.CurrentRow.Cells[1].Value = textbox2.Text;
                dataGridView1.CurrentRow.Cells[2].Value = textbox3.Text;
                dataGridView1.CurrentRow.Cells[3].Value = textbox4.Text;
                dataGridView1.CurrentRow.Cells[4].Value = comboBox1.Text;
                ClearFields();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                ClearFields();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Clear
            textbox1.Text = "";
            textbox2.Text = "";
            textbox3.Text = "";
            textbox4.Text = "";
            comboBox1.SelectedIndex = -1;
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index != -1 && dataGridView1.CurrentRow.Cells[0].Value != null)
            {
                textbox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textbox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textbox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textbox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
    }
