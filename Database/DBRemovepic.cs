using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace SMARTLEARN.Database
{
    public class DBRemovepic
    {
        MySqlConnection connection = Host.connection;

        public void removepic(Guna2ComboBox  dropdownID, Guna2MessageDialog messageDialog)
        {
            if (dropdownID.SelectedItem != null)
            {
                try
                {
                    string query = $"DELETE FROM dashboard WHERE id = '{dropdownID.Text}' AND role = 'Dashboard';";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    messageDialog.Show("Image deleted successfully!");

                    dropdownID.Items.Clear();
                    connection.Close();
                    showid(dropdownID, messageDialog);
                }
                catch (Exception ex)
                {
                    messageDialog.Show("Error deleting image: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                messageDialog.Show("Please select an image ID.");
            }
            connection.Close();
        }

        public void showid(Guna2ComboBox dropdownID, Guna2MessageDialog messageDialog)
        {
            string IDPIC = "SELECT id from dashboard WHERE role = 'Dashboard'";
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(IDPIC, connection);
                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {

                        dropdownID.Items.Add(row["id"].ToString());
                    }
                }
                else
                {
                    // Handle case where no rows are found
                }
            }
            catch (Exception ex)
            {
                messageDialog.Show("Error fetching IDs: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            connection.Close();
        }

        public void showimageinid(Guna2ComboBox dropdownID, PictureBox showpicture, Guna2MessageDialog messageDialog)
        {
            try
            {
                if (dropdownID.SelectedItem != null)
                {
                    string selectedID = dropdownID.SelectedItem.ToString(); // Get the selected ID from the ComboBox

                    string query = $"SELECT image FROM dashboard WHERE id = '{selectedID}' AND role = 'Dashboard'";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(reader.GetOrdinal("image")))
                            {
                                byte[] imgData = (byte[])reader["image"]; // Retrieve image bytes

                                // Convert byte array to image and display it in PictureBox
                                using (MemoryStream ms = new MemoryStream(imgData))
                                {
                                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                                    showpicture.Image = image;
                                }
                            }
                            else
                            {
                                // Handle case where the image column contains NULL for the selected ID
                                showpicture.Image = null; // Clear the PictureBox
                            }
                        }
                    }
                    else
                    {
                        // Handle case where no image is found for the selected ID
                        showpicture.Image = null; // Clear the PictureBox
                    }
                }
                else
                {
                    // Handle scenario when no item is selected in the ComboBox
                    showpicture.Image = null; // Clear the PictureBox
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                messageDialog.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            connection.Close();
        }
    }
}
