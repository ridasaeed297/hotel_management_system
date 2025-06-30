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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Generate Bill
            try
            {
                string guestName = textBox1.Text;
                string roomNo = textBox2.Text;
                int daysStayed = int.Parse(textBox3.Text);
                decimal chargesPerDay = decimal.Parse(textBox4.Text);
                decimal taxPercent = decimal.Parse(textBox5.Text);

                decimal subtotal = daysStayed * chargesPerDay;
                decimal taxAmount = subtotal * (taxPercent / 100);
                decimal totalBill = subtotal + taxAmount;

                textBox6.Text = totalBill.ToString("0.00");

                // Show Thank You Message
                MessageBox.Show("Bill generated successfully!\n\nTotal Amount: " + textBox6.Text +
                                "\n\nThank you for choosing our hotel!", "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid values.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(
                   
                    "♡ Thank you for staying with us!\n" +
                    "We hope you had a pleasant experience.\n\n" +
                    "♡ Shukriya ke aap ne hamare hotel ka intekhab kiya!\n" +
                    "Umeed hai ke aap ka stay khushgawar guzra.",
                    "Client Experience",
                    
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Back to Dashboard or previous form
            Form2 dashboard = new Form2();
            dashboard.Show();
            this.Hide();
        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
