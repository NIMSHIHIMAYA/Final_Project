using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Login_Form_Application
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-81UFGNVR\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();

                    // Debugging statement to check the selected item value
                   // Console.WriteLine("Selected Item: " + cmbRegno.SelectedItem?.ToString());

                    int regNo;
                    if (int.TryParse(cmbRegno.SelectedItem?.ToString(), out regNo))
                    {
                        string query = @"INSERT INTO [dbo].[Registration Form]
                                    ([regNo]
                                    ,[firstName]
                                    ,[lastName]
                                    ,[dateOfBirth]
                                    ,[gender]
                                    ,[address]
                                    ,[email]
                                    ,[mobilePhone]
                                    ,[homePhone]
                                    ,[parentName]
                                    ,[nic]
                                    ,[contactNo])
                                VALUES
                                    (@regNo, @firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@regNo", regNo);
                            cmd.Parameters.AddWithValue("@firstName", txtFirstname.Text);
                            cmd.Parameters.AddWithValue("@lastName", txtLastname.Text);
                            cmd.Parameters.AddWithValue("@dateOfBirth", dateTimePicker.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@gender", radioButtonmale.Checked ? "Male" : "Female");
                            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@mobilePhone", txtMobilephone.Text);
                            cmd.Parameters.AddWithValue("@homePhone", txtHomephone.Text);
                            cmd.Parameters.AddWithValue("@parentName", txtParentname.Text);
                            cmd.Parameters.AddWithValue("@nic", txtNic.Text);
                            cmd.Parameters.AddWithValue("@contactNo", txtConnumber.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record Added Successfully");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
        
    

        
    

