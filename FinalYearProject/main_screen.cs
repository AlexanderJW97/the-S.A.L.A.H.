using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace theSALAH
{
    public partial class main_screen : Form
    {
        public main_screen()
        {
            InitializeComponent();
            main_screen_tmr.Start();
            
            welcome_text_lbl.Text = "Welcome, "; //displays the username at the top of the main screen
        }

        private void main_screen_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// displays clock on main screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.home_screen_time_lbl.Text = dateTime.ToString();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void new_scout_bttn_Click(object sender, EventArgs e)
        {
            addNewScout openScreen = new addNewScout();
            openScreen.Show();
            Visible = false;
        }
    }
    
}
