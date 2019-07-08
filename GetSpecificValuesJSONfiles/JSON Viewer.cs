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

namespace GetSpecificValuesJSONfiles
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

            dynamic dynJson = JsonConvert.DeserializeObject(strPageCode);

            //foreach (var item in dynJson)
            //{
            //    txtResult.Text = "userId: " + Environment.NewLine + "id: " + Environment.NewLine + "title: " + Environment.NewLine + "body" + Environment.NewLine;
            //}
            using (var reader = new JsonTextReader(new StringReader(strPageCode)))
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0} - {1} - {2}",
                                      reader.TokenType, reader.ValueType, reader.Value);
                }
            }



        }

    }

}

            
