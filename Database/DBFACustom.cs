using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBFACustom
    {
        private MySqlConnection connection = Host.connection;

        public void ShowCustom(System.Windows.Forms.ListBox listBoxCustom, Guna2MessageDialog messageDialog)
        {
            listBoxCustom.Items.Clear(); // Clear previous items

            string sqlQuery = "SELECT filename FROM custom_files";

            try
            {
                connection.Close();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string originalFilename = reader["filename"].ToString();
                        listBoxCustom.Items.Add(originalFilename);
                    }
                }
                else
                {
                    // Handle case when no rows are returned
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

        public void InsertCustom(System.Windows.Forms.ListBox listBoxCustom, Guna2MessageDialog messageDialog)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf|Word Documents|*.doc;*.docx"; // Filter for PDF and DOC files

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileExtension = Path.GetExtension(filePath).ToLower();
                string originalFileName = Path.GetFileName(filePath); // Get the original file name

                if (fileExtension == ".pdf" || fileExtension == ".doc" || fileExtension == ".docx")
                {
                    byte[] fileBytes;
                    using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = new BinaryReader(stream))
                        {
                            fileBytes = reader.ReadBytes((int)stream.Length);
                        }
                    }

                    string insertQuery = "INSERT INTO custom_files (Files, Filename) VALUES (@files, @originalFileName)";

                    try
                    {
                        connection.Close();
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand(insertQuery, connection);

                        cmd.Parameters.Add("@files", MySqlDbType.VarBinary).Value = fileBytes;
                        cmd.Parameters.Add("@originalFileName", MySqlDbType.VarChar).Value = originalFileName;

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("File uploaded!");
                            connection.Close();
                            ShowCustom(listBoxCustom, messageDialog);
                        }
                        else
                        {
                            MessageBox.Show("File upload failed!");
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
                    MessageBox.Show("Please upload a PDF or DOC file.");
                }
            }
        }

        public void DeleteSelectedCustom(System.Windows.Forms.ListBox listBoxCustom, Guna2MessageDialog messageDialog)
        {
            if (listBoxCustom.SelectedItem != null)
            {
                string selectedHandout = listBoxCustom.SelectedItem.ToString(); // Get the selected item from the ListBox
                string deleteQuery = "DELETE FROM custom_files WHERE Filename = @selectedFileName";

                try
                {
                    connection.Close();
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);
                    cmd.Parameters.Add("@selectedFileName", MySqlDbType.VarChar).Value = selectedHandout;

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("File deleted!");
                        ShowCustom(listBoxCustom, messageDialog); // Refresh the ListBox after deletion
                    }
                    else
                    {
                        MessageBox.Show("No file deleted!");
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
                MessageBox.Show("Please select an item to delete.");
            }
        }

        public void ViewPDF(System.Windows.Forms.ListBox listboxhandout)
        {
            if (listboxhandout.SelectedItem != null)
            {
                try
                {
                    connection.Open();
                    string selectedItem = listboxhandout.SelectedItem.ToString();
                    string query = $"SELECT Files FROM custom_files WHERE Filename = @selectedItem"; // Adjust table name and column names
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@selectedItem", selectedItem);

                    object fileDataObj = cmd.ExecuteScalar();

                    if (fileDataObj != null)
                    {
                        byte[] fileData = (byte[])fileDataObj;

                        // Save the retrieved file temporarily
                        string tempFilePath = Path.GetTempFileName();
                        File.WriteAllBytes(tempFilePath, fileData);

                        // Open the file with the default application associated with PDF files
                        System.Diagnostics.Process.Start(tempFilePath);
                    }
                    else
                    {
                        MessageBox.Show("File data is null or empty.");
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
        }


    }
}
