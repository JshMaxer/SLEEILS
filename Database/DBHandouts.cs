using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBHandouts
    {
        MySqlConnection connection = Host.connection;
        public static string whatweek;

        public void showhandout(ListBox listhandouts)
        {
            listhandouts.Items.Clear(); // Clear previous items

            string sqlQuery = $"SELECT * FROM handout_{whatweek}";
            connection.Close();
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);
            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                while (row.Read())
                {
                    string originalFilename = row["filename"].ToString();
                    listhandouts.Items.Add($"{whatweek}: {originalFilename}");
                }
            }
            else
            {
                // Handle case when no rows are returned
            }

            connection.Close();
        }

        public void inserthandout(System.Windows.Forms.ListBox listboxhandout)
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

                    string insertQuery = $"INSERT INTO handout_{whatweek} (Files, Filename) VALUES (@files, @originalFileName)";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertQuery, connection);

                    cmd.Parameters.Add("@files", MySqlDbType.VarBinary).Value = fileBytes;
                    cmd.Parameters.Add("@originalFileName", MySqlDbType.VarChar).Value = originalFileName;

                    try
                    {
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("File uploaded!");
                            connection.Close();
                            showhandout(listboxhandout);
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

        public void deleteSelectedHandout(System.Windows.Forms.ListBox listboxhandout)
        {
            if (listboxhandout.SelectedItem != null)
            {
                string selectedHandout = listboxhandout.SelectedItem.ToString(); // Get the selected item from the ListBox
                string filenameToRemove = selectedHandout.Substring(selectedHandout.IndexOf(":") + 2); // Extract filename

                string deleteQuery = $"DELETE FROM handout_{whatweek} WHERE Filename = @selectedFileName"; // Adjust to your table structure

                connection.Open();
                MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);

                cmd.Parameters.Add("@selectedFileName", MySqlDbType.VarChar).Value = filenameToRemove; // Pass the extracted filename

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("File deleted!");
                        showhandout(listboxhandout); // Refresh the ListBox after deletion
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



    }
}
