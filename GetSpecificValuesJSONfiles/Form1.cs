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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace valus_from_JSONstrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            string strPageCode = client.DownloadString("https://jsonplaceholder.typicode.com/posts");

            txtWebPage.Text = strPageCode;

            dynamic obj = JsonConvert.DeserializeObject(strPageCode);

            string userId = obj["userId"].ToString();

            txtResult.Text = "userId: " + userId;

            //for (int i = 0; i < obj.Count; i++)
            //{
            //    txtResult.Text = "userId: " + userId;
            //}
        }
    }
}

    //dynamic obj = JObject.Parse(File.ReadAllText(strPageCode));
    //for (int i = 0; i < obj.value.Count; i++)
    //{
    //    for (int j = 0; j < obj.value[i].properties.aclRules.Count; j++)
    //    {
    //        Console.WriteLine(obj.value[i].properties.description);
    //    }
    //}
