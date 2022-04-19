using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using DevExpress;
using Newtonsoft.Json;
using System.Globalization;
using System.Net.Mail;

namespace Interface_Street_Light
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            listView5.Columns[0].ImageIndex = 2;
            listView2.Columns[0].ImageIndex = 4;
            listView1.Columns[0].ImageIndex = 1; 
            listView4.Columns[0].ImageIndex = 3; 
            listView3.Columns[0].ImageIndex = 0; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 1000; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();


            //1. read json file
            var path = @"C:\Users\emrec\Desktop\WORKSPACES\vs_workspace\Interface_Street_Light\deneme.json";

            string jsonFile = File.ReadAllText(path);

            //2. Deserialize

            var ObjOrderList = new List<Root>();
            if (jsonFile != " ")
            {
                ObjOrderList = JsonConvert.DeserializeObject<List<Root>>(jsonFile);
            }

            foreach (Root bone in ObjOrderList)
            {
                // base 64 to byte
                byte[] newBytes = Convert.FromBase64String(bone.payload__data);

                //byte parcalandi
                var data_hum = newBytes.Skip(0).Take(1).ToArray();
                var data_tem = newBytes.Skip(1).Take(1).ToArray();
                var data_bri = newBytes.Skip(2).Take(1).ToArray();
                var data_mot = newBytes.Skip(3).Take(1).ToArray();

                //byte to hex
                string hex_hum = BitConverter.ToString(data_hum);
                string hex_tem = BitConverter.ToString(data_tem);
                string hex_bri = BitConverter.ToString(data_bri);
                string hex_mot = BitConverter.ToString(data_mot);

                //hex to decimal
                long dec_datahum = Int64.Parse(hex_hum, System.Globalization.NumberStyles.HexNumber);
                long dec_datatem = Int64.Parse(hex_tem, System.Globalization.NumberStyles.HexNumber);
                long dec_databri = Int64.Parse(hex_bri, System.Globalization.NumberStyles.HexNumber);
                long dec_datamot = Int64.Parse(hex_mot, System.Globalization.NumberStyles.HexNumber);

                //decimal to string and show the panel
                Date.ListView.Items.Add(bone.payload__rxInfo__time);
                Temperature.ListView.Items.Add(String.Format("{0:0}", dec_datatem));
                Brightness.ListView.Items.Add(String.Format("{0:0}", dec_databri));
                Humidity.ListView.Items.Add(String.Format("{0:0}", dec_datahum));
                Motion.ListView.Items.Add(String.Format("{0:0}", dec_datamot));

                //var fromAddress = new MailAddress("emrecevdetyilmaz@gmail.com", "Cevdet");
                //var toAddress = new MailAddress("percinfurkan1999@gmail.com", "Furkan");
                //const string fromPassword = "emre4574";
                //const string subject = "test";
                //const string body = "Hey now!!";

                //var smtp = new SmtpClient
                //{
                //    Host = "smtp.gmail.com",
                //    Port = 587,
                //    EnableSsl = true,
                //    DeliveryMethod = SmtpDeliveryMethod.Network,
                //    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                //    Timeout = 20000
                //};
                //using (var message = new MailMessage(fromAddress, toAddress)
                //{
                //    Subject = subject,
                //    Body = body
                //})
                //{
                //    smtp.Send(message);
                //}

            }
        }
        

        void timer_Tick(object sender, EventArgs e)
        {

            label3.Text = "";
            label3.Text = DateTime.Now.ToString("dddd , MMM dd yyyy\nhh:mm:ss"); ;


        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView5_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();
            listView5.Items.Clear();
            Form1_Load(sender, e);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                    i--;
                }
            }

            for (int i = 0; i < listView2.Items.Count; i++)
            {
                if (listView2.Items[i].Selected)
                {
                    listView2.Items[i].Remove();
                    i--;
                }
            }

            for (int i = 0; i < listView3.Items.Count; i++)
            {
                if (listView3.Items[i].Selected)
                {
                    listView3.Items[i].Remove();
                    i--;
                }
            }

            for (int i = 0; i < listView4.Items.Count; i++)
            {
                if (listView4.Items[i].Selected)
                {
                    listView4.Items[i].Remove();
                    i--;
                }
            }

            for (int i = 0; i < listView5.Items.Count; i++)
            {
                if (listView5.Items[i].Selected)
                {
                    listView5.Items[i].Remove();
                    i--;
                }
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
