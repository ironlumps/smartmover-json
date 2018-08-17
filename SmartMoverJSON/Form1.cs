using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SmartMoverJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int MaxArraySize = 100;
        private void btnProcessList_Click(object sender, EventArgs e)
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://smartmover.melissadata.net/v3/WEB/SmartMover/doSmartMover");
            request.Method = "GET";
            request.Accept = "application/json";

            String Fullname = "";
            String Address = "";
            String City = "";
            String State = "";
            String Zip = "";

            int counter = 0;
            

            List <Record> rec = new List<Record>();
            using(StreamReader sr = new StreamReader(File.Open(txtFilePath.Text, FileMode.Open)))
            {
                
                sr.ReadLine();
                String test = sr.ReadLine();
                String[] str = test.Split('|'); 
                while ((test = sr.ReadLine()) != null)
                {
                    rec.Add(new Record(str[0], str[1], str[2], str[3], str[4], str[5], str[6], str[7], str[8]));
                    Fullname = str[1] + " " + str[2];
                    Address = str[4];
                    City = str[5];
                    State = str[6];
                    Zip = str[7];
                    counter++;

                    using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
                    {
                        sw.Write(JsonConvert.SerializeObject(rec));

                        
                    }
                    
                    

                }
                
            }

            

            try
            {
                using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
                {
                    sw.Write(JsonConvert.SerializeObject(rec));
                }

                try
                {
                    WebResponse response = request.GetResponse();
                    StreamReader sr = new StreamReader(response.GetResponseStream());
                    string jsonResponse = sr.ReadToEnd();

                    sr.Close();
                    sr.Dispose();

                    try
                    {
                        Rootobject ro = JsonConvert.DeserializeObject<Rootobject>(jsonResponse);
                        Record[] records = ro.Records;

                        outputBox.Clear();
                        outputBox.AppendText(records[0].ToString());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          

        }
        
      /*  private String RestJson()
        {
            string temp = $"https://smartmover.melissadata.net/v3/WEB/SmartMover/doSmartMover ?t={ Transmission Reference}&id={txtCustomerID.Text}" +
            $"&jobid={txtJobID}&act={ Actions}&col={ Columns}&opt ={ Options}&List={txtListName}&comp={ Company}" +
            $"&full={ Name Full}&first={ Name First}&Middle ={ Name Middle}&Namepre={ Name Prefix}&Namesfx={ Name Suffix}&last={ Name Last}&u={ Urbanization}" +
            $"&a1={ Address Line 1}&a2={ Address Line 2}&ste={ Suite}&pmb={ Private Mailbox}&city ={ City}&state={ State}&postal={ Postal Code}" +
            $"&plus4={ Plus4}&ctry={ Country}&format=JSON";

            return temp;
        }
*/
        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            // Opens file browser in order to choose a file for the data set
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            fdlg.Title = "Browse File";

            if (fdlg.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                txtFilePath.Text = fdlg.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
        public string SetOptions()
        {
            string options = "";

            switch (cmbProcessingType.Text)
            {
                case "Business Only":
                    options += "ProcessingType:Business,";
                    break;
                case "Individuals Only":
                    options += "ProcessingType:Individual,";
                    break;
                case "Business and Individuals":
                    options += "ProcessingType:IndividualAndBusiness,";
                    break;
                case "Residential":
                    options += "ProcessingType:Residential,";
                    break;
                case "Standard":
                    options += "ProcessingType:Standard,";
                    break;
                default:
                    options += "ProcessingType:Standard,";
                    break;
            }

            options += "ListOwnerFreqProcessing:" + nudMailingFrequency.Value + ",";
            options += "NumberOfMonthsRequested:" + nudMonthsRequested.Value;

            return options;
        }

        public string SetColumns()
        {
            string columns = "";

            if (cb_dpv.Checked)
            {
                columns += "DPVFootNotes,";
            }
            if (cb_grpName.Checked)
            {
                columns += "grpName,";
            }
            if (cb_grpOriginal.Checked)
            {
                columns += "grpOriginal,";
            }
            if (cb_grpParsed.Checked)
            {
                columns += "grpParsed,";
            }
            if (cb_grpStandardized.Checked)
            {
                columns += "grpStandardized,";
            }
            if (cb_moveCode.Checked)
            {
                columns += "MoveReturnCode,";
            }
            if (cb_plus4.Checked)
            {
                columns += "Plus4,";
            }
            if (cb_pmb.Checked)
            {
                columns += "PrivateMailbox,";
            }
            if (cb_suite.Checked)
            {
                columns += "Suite";
            }

            return columns;
        }

        public string SetActions()
        {
            string actions = "";

            if(rb_NCOA.Checked)
            {
                actions += "NCOA,";
            }
            if (rb_CCOA.Checked)
            {
                actions += "CCOA,";
            }

            actions.TrimEnd();
            return actions;
        }

        public void InsertRecord(String inputLine, int recordCounter)
        {
            String FullName = "";
            String Address = "";
            String City = "";
            String State = "";
            String Zip = "";

            String[] values = inputLine.Split('|');

            FullName = values[1] + " " + values[2];
            Address = values[4];
            City = values[5];
            State = values[6];
            Zip = values[7];

            
        }
    }

}
