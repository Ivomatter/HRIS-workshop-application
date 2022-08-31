using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRIS_UserInterface
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=password;database=hris;allowuservariables=True;persistsecurityinfo=True;");
        MySqlDataReader myReader;
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO employee(first_name,last_name,email,phone_number)Values('"+fNameInput.Text+"','"+lNameInput.Text+"','"+emailInput.Text+"','"+phoneInput.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Save Successful!");
            con.Close();
            employeeListBox.Items.Clear();
            FillListBox1();
        }
        void FillListBox1()
        {
            string Query = "select * from hris.employee";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, con);
            try
            {
                con.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string fName = myReader.GetString("first_name");
                    string lName = myReader.GetString("last_name");
                    employeeListBox.Items.Add(fName + ' ' + lName);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            con.Close();
        }

        void FillListBox2()
        {
            string Query = "select * from hris.jobs";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, con);
            try
            {
                con.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    string title = myReader.GetString("job_title");
                    jobListBox.Items.Add(title);
                }
            }
            
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.ForeColor = Color.Black;
            FillListBox1();
            FillListBox2();
            
            

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            currentScrolledSalary.Text =  (100*salaryScrollBar.Value).ToString();
        }

       

        private void employeeListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            jobListBox.Enabled = true;
            
            string Query = "select * from hris.employee";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, con);
            try
            {
                con.Open();
                myReader = cmdDataBase.ExecuteReader();
                string fName = null;
                string lName = null;
                int salary = 0;
                while (myReader.Read() && (fName + ' ' + lName != (string)employeeListBox.SelectedItem))
                {
                    fName = myReader.GetString("first_name");
                    lName = myReader.GetString("last_name");
                    salary = myReader.GetInt32("salary");
                }
                selectedName.Text = fName + ' ' +  lName;
                currentSalary.Text = "Salary: " + salary;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            con.Close();
        }

        private void jobListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            salaryScrollBar.Enabled = true;
            string Query = "select * from hris.jobs";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, con);
            try
            {
                con.Open();
                myReader = cmdDataBase.ExecuteReader();
                string jobTitle = null;
                int minSalary = 0;
                int maxSalary = 0;
                while (myReader.Read() && jobTitle != (string)jobListBox.SelectedItem)
                {
                    jobTitle = myReader.GetString("job_title");
                    minSalary = myReader.GetInt32("min_salary");
                    maxSalary = myReader.GetInt32("max_salary");
                }
                labelMaxSalary.Text = maxSalary.ToString();
                labelMinSalary.Text = minSalary.ToString();
                currentScrolledSalary.Text = minSalary.ToString();
                salaryScrollBar.Minimum = minSalary / 100;
                salaryScrollBar.Maximum = maxSalary / 100;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            con.Close();
        }

        private void setJobSalary_Click(object sender, EventArgs e)
        {
            int id = 0;
            string Query = "select * from hris.employee";
            MySqlCommand cmdDataBase = new MySqlCommand(Query, con);
            MySqlCommand cmdSalary = new MySqlCommand("UPDATE hris.employee SET salary = '"+int.Parse(currentScrolledSalary.Text)+"' WHERE employee_id = '"+(placeholderLabel.Text)+"'", con);

            try
            {
                con.Open();
                myReader = cmdDataBase.ExecuteReader();
                string fName = null;
                string lName = null;
                while (myReader.Read() && (fName + ' ' + lName != (string)employeeListBox.SelectedItem))
                {
                    id = myReader.GetInt32("employee_id");
                    fName = myReader.GetString("first_name");
                    lName = myReader.GetString("last_name");
                    placeholderLabel.Text = id.ToString();
                }
               
                
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            
            currentSalary.Text = "Salary: " + currentScrolledSalary.Text;
            con.Close();
            con.Open();
            cmdSalary.ExecuteNonQuery();
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
