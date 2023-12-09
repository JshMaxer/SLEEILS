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
                messageDialog.Show("Error: " + ex.Message);
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
                            messageDialog.Show("File uploaded!");
                            connection.Close();
                            ShowCustom(listBoxCustom, messageDialog);
                        }
                        else
                        {
                            messageDialog.Show("File upload failed!");
                        }
                    }
                    catch (Exception ex)
                    {
                        messageDialog.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    messageDialog.Show("Please upload a PDF or DOC file.");
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
                        messageDialog.Show("File deleted!");
                        ShowCustom(listBoxCustom, messageDialog); // Refresh the ListBox after deletion
                    }
                    else
                    {
                        messageDialog.Show("No file deleted!");
                    }
                }
                catch (Exception ex)
                {
                    messageDialog.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                messageDialog.Show("Please select an item to delete.");
            }
        }
    }
}
