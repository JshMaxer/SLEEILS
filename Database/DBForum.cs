using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBForum
    {
        MySqlConnection connection = Host.connection;

        public void forum(Guna2DataGridView forum)
        {
            using (MySqlConnection connection = Host.connection)
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM forum"; // Retrieve all columns from the 'forum' table

                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    forum.DataSource = dataTable;

                    // If the 'Image' column is present in the table, display it as an image in the DataGridView
                    if (dataTable.Columns.Contains("Image"))
                    {
                        DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                        imageColumn.HeaderText = "Image";
                        imageColumn.Name = "ImageColumn";
                        forum.Columns.Add(imageColumn);

                        foreach (DataGridViewRow row in forum.Rows)
                        {
                            byte[] imageBytes = row.Cells["Image"].Value as byte[];
                            if (imageBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image image = Image.FromStream(ms);
                                    row.Cells["ImageColumn"].Value = image;
                                }
                            }
                        }

                        // Remove the original 'Image' column if you don't want it displayed as raw bytes
                        forum.Columns.Remove("Image");
                    }
                }
                catch (MySqlException ex)
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
