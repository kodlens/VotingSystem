using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using DPFP.Verification;

using MySql.Data.MySqlClient;


delegate void Function();

namespace VotingSystem
{
    public partial class VotersAdd : Form, DPFP.Capture.EventHandler
    {

        MySqlConnection con;
        MySqlCommand cmd;
        string query;

        VotersMainform _frm;

        string temp = "";

        public int id;

        delegate void Function();

        bool canEnrol;

        private Enrollment Enroller;

      

        private Capture Capturer;


        //------------------------SIGNATURE------------------------------
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;

        Bitmap bmap;
        //------------------------SIGNATURE------------------------------



        //====================WEBCAM DECLARATION==========================
        Webcam webcam;

        //====================WEBCAM DECLARATION==========================


        //=================FINGER PRINT SECTION< DECLARATIONS============================

        void Init()
        {
            try
            {
                Capturer = new Capture();               // Create a capture operation.
                Enroller = new Enrollment();


                if (null != Capturer)
                    Capturer.EventHandler = this;					// Subscribe for capturing events.
                else
                    SetPrompt("Can't initiate capture operation!");
            }
            catch
            {
                MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Process(Sample Sample)
        {
            // Draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));
            // DrawPicture(ConvertSampleToBitmap(Sample));
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Using the fingerprint reader, scan your fingerprint.");
                    
                }
                catch
                {
                    SetPrompt("Can't initiate capture!");
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("Can't terminate capture!");
                    
                }
            }
        }

        

        #region Form Event Handlers:


        private void CaptureForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Stop();
            
        }



        #endregion


        //=================FINGER PRINT SECTION< DECLARATIONS============================





       


        public VotersAdd(VotersMainform _frm)
        {
            InitializeComponent();
            this._frm = _frm;

            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 2);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            bmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.Paint += panel1_Paint;

        }

        public VotersAdd()
        {
            InitializeComponent();

            //-------------------SIGNATURE-------------------------
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 2);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            bmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.Paint += panel1_Paint;

            //g.Clear(Color.White);
            //panel1.Invalidate();

            //-------------------SIGNATURE-------------------------
        }


        void processSave()
        {

            int progid = returnProgramID(cmbProgram.Text);
          


            if (id > 0)
            {
                con = Connection.con();
                con.Open();
                int insid = Helper.returnIDperConnection(con, "institute", "code", cmbInstitute.Text, "instituteID");
                query = @"UPDATE voters SET 
                        agencyNo=?agencyNo,
                        lname=?lname,
                        fname=?fname,
                        mname=?mname,
                        gender=?gender,
                        programID=?progID,  
                        yearlvl=?yrlvl,
                        bdate=?bdate,
                        bProvince=?bProv,
                        bCityTown=?bCity,
                        bBarangay=?bBrgy,
                        bUnitSt=?bUnit,
                        bZipcode=?bZip,
                        hProvince=?hProv,
                        hCityTown=?hCity,
                        hBarangay=?hBrgy,
                        hUnitSt=?hUnit,
                        hZipcode=?hZip,
                        cProvince=?cProv,
                        cCityTown=?cCity,
                        cBarangay=?cBrgy,
                        cUnitSt=?cUnit,
                        cZipcode=?cZip,
                        religion=?rel,
                        email=?email,
                        contactNo=?contact,
                        instituteID=?insid
                        WHERE votersID=?id
                        ";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?agencyNo", txtAgencyNo.Text);
                cmd.Parameters.AddWithValue("?lname", txtlname.Text);
                cmd.Parameters.AddWithValue("fname", txtfname.Text);
                cmd.Parameters.AddWithValue("mname", txtmname.Text);
                cmd.Parameters.AddWithValue("?gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("?progID", progid);
                cmd.Parameters.AddWithValue("yrlvl", txtnumYrLvl.Value);
                cmd.Parameters.AddWithValue("?bdate", dtBdate.Value);
                cmd.Parameters.AddWithValue("?bProv", cmbbProv.Text);
                cmd.Parameters.AddWithValue("?bCity", cmbbCity.Text);
                cmd.Parameters.AddWithValue("?bBrgy", cmbbBrgy.Text);
                cmd.Parameters.AddWithValue("?bUnit", txtbUnit.Text);
                cmd.Parameters.AddWithValue("?bZip", txtbZip.Text);
                cmd.Parameters.AddWithValue("?hProv", cmbhProv.Text);
                cmd.Parameters.AddWithValue("?hCity", cmbhCity.Text);
                cmd.Parameters.AddWithValue("?hBrgy", cmbhBrgy.Text);
                cmd.Parameters.AddWithValue("?hUnit", txthUnit.Text);
                cmd.Parameters.AddWithValue("?hZip", txthZip.Text);
                cmd.Parameters.AddWithValue("?cProv", cmbcProv.Text);
                cmd.Parameters.AddWithValue("?cCity", cmbcCity.Text);
                cmd.Parameters.AddWithValue("?cBrgy", cmbcBrgy.Text);
                cmd.Parameters.AddWithValue("?cUnit", txtcUnit.Text);
                cmd.Parameters.AddWithValue("?cZip", txtcZip.Text);
                cmd.Parameters.AddWithValue("?rel", txtreligion.Text);
                cmd.Parameters.AddWithValue("?email", txtreligion.Text);
                cmd.Parameters.AddWithValue("?contact", txtcontact.Text);
                cmd.Parameters.AddWithValue("?insid", insid);
               // cmd.Parameters.AddWithValue("?img", captureWebcamImage(imgCapture));
               // cmd.Parameters.AddWithValue("?nfinger", fingerPrintByte(Enroller.Template));
                cmd.Parameters.AddWithValue("?id", id);
                int n = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.successUpdate();
                }
                else
                {
                    Box.errBox("Save failed. Please contact administrator.");
                }
            }
            else
            {
                con = Connection.con();
                con.Open();
                int insid = Helper.returnIDperConnection(con, "institute", "code", cmbInstitute.Text, "instituteID");
                query = @"INSERT INTO voters SET 
                        agencyNo=?agencyNo,
                        lname=?lname,
                        fname=?fname,
                        mname=?mname,
                        gender=?gender,
                        programID=?progID,  
                        yearlvl=?yrlvl,
                        bdate=?bdate,
                        bProvince=?bProv,
                        bCityTown=?bCity,
                        bBarangay=?bBrgy,
                        bUnitSt=?bUnit,
                        bZipcode=?bZip,
                        hProvince=?hProv,
                        hCityTown=?hCity,
                        hBarangay=?hBrgy,
                        hUnitSt=?hUnit,
                        hZipcode=?hZip,
                        cProvince=?cProv,
                        cCityTown=?cCity,
                        cBarangay=?cBrgy,
                        cUnitSt=?cUnit,
                        cZipcode=?cZip,
                        religion=?rel,
                        email=?email,
                        contactNo=?contact,
                        nSignature=?sign,
                        nImage=?img,
                        nFingerPrint=?nfinger,
                        user=?user,
                        pwd=?pwd,
                        instituteID=?insid
                        ";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?agencyNo", txtAgencyNo.Text);
                cmd.Parameters.AddWithValue("?lname", txtlname.Text);
                cmd.Parameters.AddWithValue("fname", txtfname.Text);
                cmd.Parameters.AddWithValue("mname", txtmname.Text);
                cmd.Parameters.AddWithValue("?gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("?progID", progid);
                cmd.Parameters.AddWithValue("yrlvl", txtnumYrLvl.Value);
                cmd.Parameters.AddWithValue("?bdate", dtBdate.Value);
                cmd.Parameters.AddWithValue("?bProv", cmbbProv.Text);
                cmd.Parameters.AddWithValue("?bCity", cmbbCity.Text);
                cmd.Parameters.AddWithValue("?bBrgy", cmbbBrgy.Text);
                cmd.Parameters.AddWithValue("?bUnit", txtbUnit.Text);
                cmd.Parameters.AddWithValue("?bZip", txtbZip.Text);
                cmd.Parameters.AddWithValue("?hProv", cmbhProv.Text);
                cmd.Parameters.AddWithValue("?hCity", cmbhCity.Text);
                cmd.Parameters.AddWithValue("?hBrgy", cmbhBrgy.Text);
                cmd.Parameters.AddWithValue("?hUnit", txthUnit.Text);
                cmd.Parameters.AddWithValue("?hZip", txthZip.Text);
                cmd.Parameters.AddWithValue("?cProv", cmbcProv.Text);
                cmd.Parameters.AddWithValue("?cCity", cmbcCity.Text);
                cmd.Parameters.AddWithValue("?cBrgy", cmbcBrgy.Text);
                cmd.Parameters.AddWithValue("?cUnit", txtcUnit.Text);
                cmd.Parameters.AddWithValue("?cZip", txtcZip.Text);
                cmd.Parameters.AddWithValue("?rel", txtreligion.Text);
                cmd.Parameters.AddWithValue("?email", txtreligion.Text);
                cmd.Parameters.AddWithValue("?contact", txtcontact.Text);
                cmd.Parameters.AddWithValue("?sign", returnSignatureImage(panel1));
                cmd.Parameters.AddWithValue("?img", captureWebcamImage(imgCapture));
                cmd.Parameters.AddWithValue("?nfinger", fingerPrintByte(Enroller.Template));
                cmd.Parameters.AddWithValue("?user",txtUser.Text.Trim());
                cmd.Parameters.AddWithValue("?pwd", txtPwd.Text.Trim());
                cmd.Parameters.AddWithValue("?insid", insid);
                int n = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (n > 0)
                {
                    Box.infoBox("Student successfully saved!");
                }
                else
                {
                    Box.errBox("Save failed. Please contact administrator.");
                }
            }

            _frm.LoadData();
        }



        int returnProgramID(string pCode)
        {
            int pcodeID = 0;
            con = Connection.con();
            con.Open();
            query = @"select * from programs where programCode=?pCode";
            cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?pCode", pCode);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pcodeID = Convert.ToInt32(dr["programID"]);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();

            return pcodeID;
        }


        void getData()
        {
            try
            {
                con = Connection.con();
                con.Open();
                query = "SELECT * FROM vw_votersinfo WHERE votersID = ?id";
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?id", id);
                DataTable dt = new DataTable();
                MySqlDataAdapter adptr = new MySqlDataAdapter(cmd);
                adptr.Fill(dt);
                adptr.Dispose();
                cmd.Dispose();
                con.Close();
                con.Dispose();

                if (dt.Rows.Count > 0)
                {
                    txtAgencyNo.Text = Convert.ToString(dt.Rows[0]["agencyNo"]);
                    temp = Convert.ToString(dt.Rows[0]["agencyNo"]);
                    //  txtBarcode.Text = Convert.ToString(dt.Rows[0]["barCode"]);
                    txtlname.Text = Convert.ToString(dt.Rows[0]["lname"]);
                    txtfname.Text = Convert.ToString(dt.Rows[0]["fname"]);
                    txtmname.Text = Convert.ToString(dt.Rows[0]["mname"]);
                    cmbGender.Text = Convert.ToString(dt.Rows[0]["gender"]);
                    cmbInstitute.Text = Convert.ToString(dt.Rows[0]["code"]);
                    cmbProgram.Text = Convert.ToString(dt.Rows[0]["programCode"]);
                    txtnumYrLvl.Value = Convert.ToInt32(dt.Rows[0]["yearlvl"]);
                    dtBdate.Value = Convert.ToDateTime(dt.Rows[0]["bdate"]);

                    cmbbProv.Text = Convert.ToString(dt.Rows[0]["bProvince"]);
                    cmbbCity.Text = Convert.ToString(dt.Rows[0]["bCityTown"]);
                    cmbbBrgy.Text = Convert.ToString(dt.Rows[0]["bBarangay"]);
                    txtbUnit.Text = Convert.ToString(dt.Rows[0]["bUnitSt"]);
                    txtbZip.Text = Convert.ToString(dt.Rows[0]["bZipcode"]);

                    cmbhProv.Text = Convert.ToString(dt.Rows[0]["hProvince"]);
                    cmbhCity.Text = Convert.ToString(dt.Rows[0]["hCityTown"]);
                    cmbhBrgy.Text = Convert.ToString(dt.Rows[0]["hBarangay"]);
                    txthUnit.Text = Convert.ToString(dt.Rows[0]["hUnitSt"]);
                    txthZip.Text = Convert.ToString(dt.Rows[0]["hZipcode"]);

                    cmbcProv.Text = Convert.ToString(dt.Rows[0]["cProvince"]);
                    cmbcCity.Text = Convert.ToString(dt.Rows[0]["cCityTown"]);
                    cmbcBrgy.Text = Convert.ToString(dt.Rows[0]["cBarangay"]);
                    txtcUnit.Text = Convert.ToString(dt.Rows[0]["cUnitSt"]);
                    txtcZip.Text = Convert.ToString(dt.Rows[0]["cZipcode"]);

                    txtreligion.Text = Convert.ToString(dt.Rows[0]["religion"]);
                    txtemail.Text = Convert.ToString(dt.Rows[0]["email"]);
                    txtcontact.Text = Convert.ToString(dt.Rows[0]["contactNo"]);
                    txtUser.Text = Convert.ToString(dt.Rows[0]["user"]);

                    if (!DBNull.Value.Equals(dt.Rows[0]["nImage"]))
                    {
                        byte[] result = (byte[])dt.Rows[0]["nImage"];

                        int ArraySize = result.GetUpperBound(0);
                        MemoryStream ms = new MemoryStream(result, 0, ArraySize);
                        imgCapture.Image = Image.FromStream(ms);
                    }

                    if (!DBNull.Value.Equals(dt.Rows[0]["nFingerPrint"]))
                    {
                      
                        byte[] result = (byte[])dt.Rows[0]["nFingerPrint"];

                        int ArraySize = result.GetUpperBound(0);
                        MemoryStream ms = new MemoryStream(result, 0, ArraySize);
                        Template template = new Template(ms);
                        OnTemplate(template);
                       // btnEnrol.Visible = false;
                    }

                }

            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
            }
        }



        void LoadBrgy(TextBox tb, ComboBox cmb, ComboBox paramCity, ComboBox paramProv)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            // string query;
            cmb.Items.Clear();
            con = Connection.con();
            con.Open();
            cmd = new MySqlCommand("select * from vw_brgy where cityTown=?cty and province=?prov group by brgy, cityTown, province", con);
            cmd.Parameters.AddWithValue("?cty", paramCity.Text);
            cmd.Parameters.AddWithValue("?prov", paramProv.Text);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb.Items.Add(Convert.ToString(dr["brgy"]));
               // tb.Text = Convert.ToString(dr["zipCode"]);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        void GetZipCode(TextBox tb, ComboBox paramCity, ComboBox paramProv)
        {
            MySqlConnection con;
            MySqlCommand cmd;
            // string query;
           // cmb.Items.Clear();
            con = Connection.con();
            con.Open();
            cmd = new MySqlCommand("select * from vw_cityTown where cityTown=?cty and province=?prov", con);
            cmd.Parameters.AddWithValue("?cty", paramCity.Text);
            cmd.Parameters.AddWithValue("?prov", paramProv.Text);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               // cmb.Items.Add(Convert.ToString(dr["brgy"]));
                tb.Text = Convert.ToString(dr["zipCode"]);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        void LoadCity(ComboBox paramProv, ComboBox paramCity)
        {
            Helper.LoadCmb("select distinct(cityTown) from vw_citytown where province='" + paramProv.Text.Trim().Replace("'", "'") + "' order by cityTown asc", paramCity);
        }

        private void cmbbProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Helper.LoadCmb("select distinct(cityTown) from vw_citytown where province='" + cmbbProv.Text.Trim().Replace("'", "'") + "' order by cityTown asc", cmbbCity);
        }

        private void cmbbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBrgy(txtbZip, cmbbBrgy, cmbbCity, cmbbProv);
            GetZipCode(txtbZip, cmbbCity, cmbbProv);
        }

        private void cmbhProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCity(cmbhProv, cmbhCity);
        }

        private void cmbhCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBrgy(txthZip, cmbhBrgy, cmbhCity, cmbhProv);
        }

        private void cmbcProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCity(cmbcProv, cmbcCity);
        }

        private void cmbcCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBrgy(txtcZip, cmbcBrgy, cmbcCity, cmbcProv);
            GetZipCode(txtcZip, cmbcCity, cmbcProv);
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtlname.Text))
            {
                Box.warnBox("Please input lastname.");
                txtlname.Focus();
                return;
            }
            if (String.IsNullOrEmpty(txtfname.Text))
            {
                Box.warnBox("Please input firstname.");
                txtfname.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cmbProgram.Text))
            {
                Box.warnBox("Please select program.");
                cmbProgram.Focus();
                return;
            }

           

            if (id == 0)
            {
                if (String.IsNullOrEmpty(txtUser.Text))
                {
                    Box.warnBox("Please provide username.");
                    txtUser.Focus();
                    return;
                }

                if (String.IsNullOrEmpty(txtPwd.Text))
                {
                    Box.warnBox("Please provide password.");
                    txtUser.Focus();
                    return;
                }
                if (txtPwd.Text != txtRpwd.Text)
                {
                    Box.warnBox("Password not match.");
                    return;
                }



                bool isNullFingerPrint = Picture == null || Picture.Image == null;
                if (isNullFingerPrint) { Box.warnBox("Please add some finger print."); return; }

                bool isNullImgCapture = imgCapture == null || imgCapture.Image == null;
                if (isNullImgCapture) { Box.warnBox("Please capture image."); return; }
            }


            //  bool isNullSignature = picBoxSignature == null || picBoxSignature.Image == null;
            //   if (isNullSignature) { Box.warnBox("Please add signature print."); return; }


            //if (temp != txtAgencyNo.Text)
            //{
            //    if (Helper.isExistString("voters", "agencyNo", txtAgencyNo.Text))
            //    {
            //        Box.warnBox("Duplicate  ID No.");
            //        txtAgencyNo.Text = "";
            //        txtAgencyNo.Focus();
            //        return;
            //    }
            //}

            if (!canEnrol)
            { Box.warnBox("Fingerprint owned by another registered user."); return; }
            if (Helper.isExistString("voters", "agencyNo", txtAgencyNo.Text))
            {
                if (!Box.questionBox("Agency No. already in the database. Are you sure you want to continue?", "CONTINUE?"))
                {
                    return;
                }
            }


            processSave();
            this.Close();
        }

        private void StudentAdd_Load(object sender, EventArgs e)
        {
            webcam = new Webcam();
            webcam.InitializeWebCam(ref imgVideo);



           // Helper.LoadCmb("select distinct(programCode) from programs order by programCode asc", cmbProgram);
            Helper.LoadCmb("select distinct(province) from vw_citytown order by province asc", cmbbProv);
            Helper.LoadCmb("select distinct(province) from vw_citytown order by province asc", cmbhProv);
            Helper.LoadCmb("select distinct(province) from vw_citytown order by province asc", cmbcProv);
            Helper.LoadCmb("select distinct(code) from institute order by code asc", cmbInstitute);


            if (id > 0)
            {
                getData();

                btnEnrol.Visible = false;
               // btnStartSignature.Visible = false;
                btnClear.Visible = false;
                btnCapture.Visible = false;
                canEnrol = true;
            }
        }


        //==---------------------FINGER PRINT SECTION-----------------------------------

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            // throw new NotImplementedException();
            MakeReport("The fingerprint sample was captured.");
            SetPrompt("Scan the same fingerprint again.");
            Process(Sample);
            ProcessFingerPrint(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the fingerprint reader.");
            //throw new NotImplementedException();
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            // throw new NotImplementedException();
            MakeReport("The fingerprint reader was touched.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            //throw new NotImplementedException();
            MakeReport("The fingerprint reader was connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            // throw new NotImplementedException();
            MakeReport("The fingerprint reader was disconnected.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == CaptureFeedback.Good)
                MakeReport("The quality of the fingerprint sample is good.");
            else
                MakeReport("The quality of the fingerprint sample is poor.");
            //throw new NotImplementedException();
        }

        private Bitmap ConvertSampleToBitmap(Sample Sample)
        {
            SampleConversion Convertor = new SampleConversion();  // Create a sample convertor.
            Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);                                 // TODO: return bitmap as a result
            return bitmap;
        }

        private FeatureSet ExtractFeatures(Sample Sample, DataPurpose Purpose)
        {
            FeatureExtraction Extractor = new FeatureExtraction();  // Create a feature extractor
            CaptureFeedback feedback = CaptureFeedback.None;
            FeatureSet features = new FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        protected void SetStatus(string status)
        {
            this.Invoke(new Function(delegate () {
                StatusLine.Text = status;
            }));
        }

        protected void SetPrompt(string prompt)
        {
            this.Invoke(new Function(delegate () {
                Prompt.Text = prompt;
            }));
        }
        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate () {
                StatusText.AppendText(message + "\r\n");
            }));
        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate () {
                Picture.Image = new Bitmap(bitmap, Picture.Size);   // fit the image into the picture box
            }));
        }

        private void OnTemplate(Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                if (template != null) {
                    //  if(isUpdateFingerPrint  == false)
                    if (id == 0)
                    {
                        MessageBox.Show("The fingerprint is verified.", "Fingerprint Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnEnrol.Visible = false;
                    }

                }
                else
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }));
        }



        void ProcessFingerPrint(Sample Sample)
        {
           
             // Process the sample and create a feature set for the enrollment purpose.
                FeatureSet features = ExtractFeatures(Sample, DataPurpose.Enrollment);
            // Check quality of the sample and add to enroller if it's good
            if (features != null) try
                {
                    MakeReport("The fingerprint feature set was created.");
                    Enroller.AddFeatures(features);     // Add feature set to template.
                }
                finally
                {
                    UpdateStatus();

                    // Check if template has been created.
                    switch (Enroller.TemplateStatus)
                    {
                        case Enrollment.Status.Ready:   // report success and stop capturing
                            if (!isExistFingerPrint(Sample))
                            {
                                OnTemplate(Enroller.Template);
                                SetPrompt("Template Fingerprint done.");
                                Stop();
                                canEnrol = true;
                            }
                            else
                            {
                                Box.warnBox("Fingerprint already enrolled. This fingerprint cannot be accepted.");
                                Stop();
                                canEnrol = false;
                            }
                           
                            break;

                        case Enrollment.Status.Failed:  // report failure and restart capturing
                            Enroller.Clear();
                            Stop();
                            UpdateStatus();
                            OnTemplate(null);
                            Start();
                            break;
                    }
                }
        }


        private void UpdateStatus()
        {
            // Show number of samples needed.
            SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));

        
        }


        //--------------------------FINGER PRINT SECTION-----------------------------------


        private void cmbhProv_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Helper.LoadCmb("select distinct(cityTown) from vw_citytown where province='" + cmbbProv.Text.Trim().Replace("'", "'") + "' order by cityTown asc", cmbbCity);
            LoadCity(cmbhProv, cmbhCity);
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                if(!Box.questionBox("Do you want to overwrite existing fingerprint template?", "OVERWRITE?"))
                {
                    return;
                }
            }

            Init();
            Start();
          //  isUpdateFingerPrint = true;
        }

        private void StudentAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Stop();

        }

        private byte[] fingerPrintByte(Template template)
        {
            //Byte[] bytes;

            //MemoryStream fingerprintData = new MemoryStream();
            //template.Serialize(fingerprintData);
            //fingerprintData.Position = 0;
            //BinaryReader br = new BinaryReader(fingerprintData);
            //bytes = br.ReadBytes((Int32)fingerprintData.Length);

            MemoryStream fingerprintData = new MemoryStream();
            template.Serialize(fingerprintData);
          

            //var str = System.Text.Encoding.Default.GetString(bytes);
            //Box.infoBox(str);

            return fingerprintData.ToArray();
        }

        private byte[] captureWebcamImage(PictureBox picBox)
        {
            bool isNullOrEmptyPictureBox = picBox == null || picBox.Image == null;
            if (isNullOrEmptyPictureBox)
                return null;
            else
            {
                Image image = picBox.Image;
                MemoryStream memoryStream = new MemoryStream();
                image.Save(memoryStream, ImageFormat.Jpeg);
                return memoryStream.ToArray();
            }
        }

        private byte[] returnSignatureImage(Panel panel)
        {
            MemoryStream memoryStream = new MemoryStream();
            bmap.Save(memoryStream, ImageFormat.Bmp);
            return memoryStream.ToArray();
        }

        private void cmbhCity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadBrgy(txthZip, cmbhBrgy, cmbhCity, cmbhProv);
            GetZipCode(txthZip, cmbhCity, cmbhProv);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            webcam.Start();
            btnStop.Enabled = true;
            btnStart.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webcam.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            imgCapture.Image = imgVideo.Image;
            webcam.Stop();
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        //==========================SIGNATURE -=============================
        void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmap, Point.Empty);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            g = Graphics.FromImage(bmap);
            moving = true;
            x = e.X;
            y = e.Y;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {

                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;


                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            panel1.Invalidate();
        }

        private void VotersAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            webcam.Stop();
        }
        //============================SIGNATURE============================================


        bool isExistFingerPrint( Sample sample)
        {
            Byte[] byts;
            Template template;
            MemoryStream ms;
            List<Template> listTemplate = new List<Template>();

            con = Connection.con();
            con.Open();
            query = "SELECT * FROM voters WHERE nFingerPrint IS NOT NULL";
            cmd = new MySqlCommand(query, con);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            listTemplate.Clear();
            while (dr.Read())
            {
                // byts = Helper.ObjectToByteArray(dr["nFingerPrint"]);
                byts = (byte[])(dr["nFingerPrint"]);
                ms = new MemoryStream(byts);
                template = new Template();
                template.DeSerialize(ms);

               // Box.infoBox(template.ToString());
                listTemplate.Add(template);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            con.Dispose();

           // Box.infoBox(listTemplate.Count.ToString());

            //  Box.infoBox(listTemplate.Count.ToString());
            bool flag = false;

            FeatureSet features = ExtractFeatures(sample, DataPurpose.Verification);
            Verification ver = new Verification();
            Verification.Result result = new Verification.Result();

            if (features != null)
            {
                foreach (Template tempValue in listTemplate)
                {
                  
                    if (tempValue != null)
                    {
                        ver.Verify(features, tempValue, ref result);
                        //UpdateStatus(result.FARAchieved);
                        if (result.Verified)
                        {
                            flag = true;
                          
                            break;
                        }
                        else
                            flag = false;
                    }
                }
            }
            
            return flag;
        }

        private void cmbInstitute_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Helper.getProgramByInstitute(cmbInstitute, cmbProgram);
            }
            catch (Exception er)
            {
                Box.errBox(er.Message);
               // throw;
            }
        }

        private void txtAgencyNo_TextChanged(object sender, EventArgs e)
        {
            txtUser.Text = txtAgencyNo.Text;
        }

        //private void btnCopyAddress_Click(object sender, EventArgs e)
        //{
        //    //cmbcProv.Text = cmbhProv.Text;
        //    //cmbcCity.Text = cmbhCity.Text;
        //    //cmbcBrgy.Text = cmbhBrgy.Text;
        //}
    }
}
