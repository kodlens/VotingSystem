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
using WIA;
using System.IO;
using System.Drawing.Imaging;


namespace VotingSystem
{
    public partial class UploadCandidateDocuments : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;
        public int id;
        public bool isUpdate;

        public int votersID;
        public int reqsetupID;
   

        OpenFileDialog open;

        CheckCandidateRequirementsForm _frm;

  
        public UploadCandidateDocuments(CheckCandidateRequirementsForm _frm)
        {
            InitializeComponent();
            this._frm = _frm;
        }




        private void ListScanners()
        {
            // Clear the ListBox.
            listBox1.Items.Clear();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Add the device only if it's a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Add the Scanner device to the listbox (the entire DeviceInfos object)
                // Important: we store an object of type scanner (which ToString method returns the name of the scanner)
                listBox1.Items.Add(
                    new Scanner(deviceManager.DeviceInfos[i])
                );
            }
        }


        private void UploadCandidateDocuments_Load(object sender, EventArgs e)
        {
            ListScanners();

            txtoutput.Text = Path.GetTempPath();

            cmbImageFormat.SelectedIndex = 1;

            //if (accredGroupID > 0)
            //{
            //    try
            //    {
            //        setupData();
            //    }
            //    catch (Exception er)
            //    {
            //        Box.errBox(er.Message);
            //        // throw;
            //    }
            //}
        }


        void setupData()
        {
            con = Connection.con();
            con.Open();
            query = "select * from accred_group where accredGroupID=?id";
            cmd = new MySqlCommand(query, con);
           // cmd.Parameters.AddWithValue("?id", accredGroupID);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtTitle.Text = Convert.ToString(dr["title"]);
                txtDesc.Text = Convert.ToString(dr["description"]);

            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            // Box.infoBox("Upload picture is under maintenance. Thank you.");
            try
            {
                open.InitialDirectory = "C:\\Users\\...\\Pictures";
                open.Filter = "JPG Files (*.jpg)|*.jpg";
                open.Title = "Select Picture";
                open.FilterIndex = 1;
                //open.ShowDialog();

                if (open.ShowDialog() == DialogResult.OK)
                {
                    //  imgpath = open.FileName.ToString();
                    //  pictureBox1.ImageLocation = imgpath;
                    // Box.infoBox(open.SafeFileName.ToString());
                    pictureBox1.ImageLocation = open.FileName.ToString();
                }
                else
                {
                    // Box.warnBox("User cancel upload");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnScanDoc_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(StartScanning).ContinueWith(result => TriggerScan());
        }

        private void TriggerScan()
        {
            //Console.WriteLine("Image succesfully scanned");
            Box.infoBox("Image successfully scanned.");
        }


        private void btnSaveDoc_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtTitle.Text))
            {
                Box.warnBox("Title is required.");
                return;
            }
            if (String.IsNullOrEmpty(txtDesc.Text))
            {
                Box.warnBox("Description is required.");
                return;
            }


            try
            {
                int i = 0;


                if (isUpdate == true)
                {
                    bool isNullOrEmptyPictureBox = pictureBox1 == null || pictureBox1.Image == null;
                    if (isNullOrEmptyPictureBox)
                    {
                        Box.warnBox("Please provide document.");
                        btnBrowse_Click(sender, e);
                        return;
                        // cmd.Parameters.AddWithValue("?vImage", null);
                    }


                    con = Connection.con();
                    con.Open();



                    query = @"UPDATE uploaded_req SET title=?title, description=?desc, nFile=?nfile WHERE upreqID=?id";
                    cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("?title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("?desc", txtDesc.Text);

                    Image image = pictureBox1.Image;
                    MemoryStream memoryStream = new MemoryStream();
                    image.Save(memoryStream, ImageFormat.Jpeg);
                    byte[] ImageData = memoryStream.ToArray();
                    cmd.Parameters.AddWithValue("?nfile", ImageData);

                    cmd.Parameters.AddWithValue("?id", id);
                    i = cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    con.Close();
                    con.Dispose();




                    if (i > 0)
                    {
                        Box.infoBox("File successfully updated.");
                    }



                }
                else
                {
                    con = Connection.con();
                    con.Open();

                    query = @"INSERT INTO uploaded_req (reqsetupID, votersID, title, description, nFile) VALUES 
                        (?reqid, ?votersid, ?title, ?desc, ?nfile)";
                    cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("?reqid", reqsetupID);
                    cmd.Parameters.AddWithValue("?votersid", votersID);
                    cmd.Parameters.AddWithValue("?title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("?desc", txtDesc.Text);
                  //  cmd.Parameters.AddWithValue("?reqID", id);

                    bool isNullOrEmptyPictureBox = pictureBox1 == null || pictureBox1.Image == null;
                    if (isNullOrEmptyPictureBox)
                    {
                        cmd.Parameters.AddWithValue("?nfile", null);
                    }
                    else
                    {
                        Image image = pictureBox1.Image;
                        MemoryStream memoryStream = new MemoryStream();
                        image.Save(memoryStream, ImageFormat.Jpeg);
                        byte[] ImageData = memoryStream.ToArray();
                        cmd.Parameters.AddWithValue("?nfile", ImageData);
                    }
                    i = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    con.Dispose();

                    if (i > 0)
                    {
                        Box.infoBox("File successfully uploaded.");
                    }

                }



                _frm.LoadData();

            } //end try catch
            catch (Exception er)
            {
                Box.errBox(er.Message);
                //throw;
            }


        }

        public void StartScanning()
        {
            Scanner device = null;

            this.Invoke(new MethodInvoker(delegate ()
            {
                device = listBox1.SelectedItem as Scanner;
            }));

            if (device == null)
            {
                MessageBox.Show("You need to select first an scanner device from the list",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(txtfilename.Text))
            {
                MessageBox.Show("Provide a filename",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ImageFile image = new ImageFile();
            string imageExtension = "";

            this.Invoke(new MethodInvoker(delegate ()
            {
                switch (cmbImageFormat.SelectedIndex)
                {
                    case 0:
                        image = device.ScanPNG();
                        imageExtension = ".png";
                        break;
                    case 1:
                        image = device.ScanJPEG();
                        imageExtension = ".jpeg";
                        break;
                    case 2:
                        image = device.ScanTIFF();
                        imageExtension = ".tiff";
                        break;
                }
            }));


            // Save the image
            var path = Path.Combine(txtoutput.Text, txtfilename.Text + imageExtension);

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            image.SaveFile(path);

            pictureBox1.Image = new Bitmap(path);
        }


    }
}
