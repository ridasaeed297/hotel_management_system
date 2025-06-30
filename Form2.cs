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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 guestForm = new Form3();  // Guest Registration Form
            guestForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 roomForm = new Form4();  // Room Management Form
            roomForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 bookingForm = new Form5();  // Booking Form
            bookingForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 billingForm = new Form6();  // Billing Form
            billingForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
