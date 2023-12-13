using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBSTCustomDownload
    {
        MySqlConnection connection = Host.connection;

        public void DownloadSelectedHandout(System.Windows.Forms.ListBox listBoxHandout, Guna2MessageDialog messageDialog)
        {
            if (listBoxHandout.SelectedItem != null)
            {
                string selectedHandout = listBoxHandout.SelectedItem.ToString(); // Get the selected item from the ListBox
                string filenameToDownload = selectedHandout; // Filename to download

                // Query to retrieve file data based on the filename
                string selectQuery = "SELECT Files FROM custom_files WHERE Filename = @selectedFileName"; // Adjust to your table structure

                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                    cmd.Parameters.Add("@selectedFileName", MySqlDbType.VarChar).Value = filenameToDownload; // Pass the filename

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve file data
                            byte[] fileData = (byte[])reader["Files"];

                            // Ask user for download location
                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.FileName = filenameToDownload; // Set the default filename for download

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                string filePath = saveFileDialog.FileName;

                                // Save the file to the specified location
                                File.WriteAllBytes(filePath, fileData);
                                MessageBox.Show("File downloaded successfully!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("File not found!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to download.");
            }
        }
    }
}
