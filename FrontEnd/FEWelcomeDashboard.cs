using MySql.Data.MySqlClient;
using SMARTLEARN.Model;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SMARTLEARN.FrontEnd
{
    public partial class FEWelcomeDashboard : Form
    {
        MySqlConnection connection = Host.connection;
        
        DataTable imageDataTable = new DataTable();
        int imageIndex = 0;
        bool slideshowRunning = false;

        public FEWelcomeDashboard()
        {
            connection.Close();
            InitializeComponent();
            FetchImages(); // Fetch images from the database
            DisplayFirstImageForQuotes(); // Display the first image for Quotes
        }

        private void FetchImages()
        {
            try
            {
                using (MySqlConnection tempConnection = new MySqlConnection(connection.ConnectionString))
                {
                    string query = "SELECT image FROM dashboard WHERE role = 'Dashboard';"; // Query to retrieve image data
                    MySqlCommand cmd = new MySqlCommand(query, tempConnection);

                    tempConnection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(imageDataTable);
                }
            }
            catch (Exception ex)
            {
                MessageDialog1.Show("Error: " + ex.Message);
            }

            StartSlideshow(); // Start the slideshow after fetching images
        }

        private void StartSlideshow()
        {
            if (imageDataTable.Rows.Count > 0 && !slideshowRunning)
            {
                slideshowRunning = true;
                Timer slideshowTimer = new Timer();
                slideshowTimer.Interval = 7000; // Set the interval for image change (in milliseconds)
                slideshowTimer.Tick += (sender, e) => DisplayNextImage();
                slideshowTimer.Start(); // Start the timer
            }
        }

        private void DisplayNextImage()
        {
            byte[] imgData = (byte[])imageDataTable.Rows[imageIndex]["image"]; // Retrieve image bytes from DataTable

            // Convert byte array to image
            using (MemoryStream ms = new MemoryStream(imgData))
            {
                Image image = Image.FromStream(ms);

                // Display image in PictureBox control
                pictureboxslide.Image = image;
            }

            imageIndex = (imageIndex + 1) % imageDataTable.Rows.Count; // Move to the next image in a circular manner
        }

        private void DisplayFirstImageForQuotes()
        {
            try
            {
                string query = "SELECT image FROM dashboard WHERE role = 'Quotes' LIMIT 1;"; // Query to retrieve the first image for Quotes
                MySqlCommand cmd = new MySqlCommand(query, connection);

                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    byte[] imgData = (byte[])result; // Retrieve image bytes

                    // Convert byte array to image and display it in PictureBox
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        Image image = Image.FromStream(ms);
                        picturequotes.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageDialog1.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void btnaddimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Read the selected image file into a byte array
                    byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);

                    // Insert the image bytes into the database
                    InsertImageIntoDatabase(imageBytes);
                    MessageDialog1.Show("Image uploaded successfully!");

                    // Refresh imageDataTable after uploading a new image
                    FetchImages();
                }
                catch (Exception ex)
                {
                    MessageDialog1.Show("Error uploading image: " + ex.Message);
                }
            }
        }

        private void InsertImageIntoDatabase(byte[] imageBytes)
        {
            try
            {
                string query = "INSERT INTO dashboard (image, role) VALUES (@imageData, 'Dashboard');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@imageData", imageBytes);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            connection.Close();
        }

        private void btnremoveimage_Click(object sender, EventArgs e)
        {
            FERemoveImage fERemoveImage = new FERemoveImage();
            fERemoveImage.ShowDialog();
        }

        private void btnaddimagequotes_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Read the selected image file into a byte array
                    byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);

                    // Insert the image bytes into the database
                    InsertQuotesIntoDatabase(imageBytes);
                    MessageDialog1.Show("Image uploaded successfully!");

                    // Display the inserted image in the PictureBox
                    picturequotes.Image = Image.FromStream(new MemoryStream(imageBytes));
                }
                catch (Exception ex)
                {
                    MessageDialog1.Show("Error uploading and displaying image: " + ex.Message);
                }
            }
        }

        private void InsertQuotesIntoDatabase(byte[] imageBytes)
        {
            try
            {
                string query = "INSERT INTO dashboard (image, role) VALUES (@imageData, 'Quotes');";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@imageData", imageBytes);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            connection.Close();
        }

        private void btnremovequotes_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the PictureBox has an image
                if (picturequotes.Image != null)
                {
                    // Delete the corresponding image from the database based on some condition (e.g., an ID)
                    // Replace 'YourCondition' with your actual condition to identify the image to delete

                    string deleteQuery = "DELETE FROM dashboard WHERE role = 'Quotes';";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection);

                    connection.Open();
                    deleteCmd.ExecuteNonQuery();
                    MessageDialog1.Show("Image deleted from the database.");

                    // Clear the image from the PictureBox
                    picturequotes.Image = null;
                }
                else
                {
                    MessageDialog1.Show("No image to remove.");
                }
            }
            catch (Exception ex)
            {
                MessageDialog1.Show("Error removing image: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            connection.Close();
        }

        private void FEWelcomeDashboard_Load(object sender, EventArgs e)
        {
            if (Model.Accounts.role == "ADMIN")
            {
                btnaddimage.Visible = true;
                btnremoveimage.Visible = true;
                btnaddimagequotes.Visible = true;
                btnremovequotes.Visible = true;
            }
            else
            {
                btnaddimage.Visible = false;
                btnremoveimage.Visible = false;
                btnaddimagequotes.Visible = false;
                btnremovequotes.Visible = false;
            }
        }
    }
}
