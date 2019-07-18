using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CultureResource
{
    public partial class MainForm : Form
    {

        string xmlPath;
        public MainForm()
        {
            InitializeComponent();
            xmlPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).ToString();
            xmlPath = xmlPath.Replace("\\bin", string.Empty);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            appData.WriteXml(string.Format("{0}/culture.xml", xmlPath));

            //writing resource file
            ResourceWriter ren = new ResourceWriter(xmlPath + "/resource.en-US.resources");
            ResourceWriter rjp = new ResourceWriter(xmlPath + "/resource.ja-JP.resources");
            foreach(AppData.LanguagesRow row in appData.Languages.Rows)
            {
                ren.AddResource(row.ID, row.English);
                rjp.AddResource(row.ID, row.Japanese);
            }

            ren.Generate();
            ren.Close();
            rjp.Generate();
            rjp.Close();
            MessageBox.Show("Successfully saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            appData.ReadXml(string.Format("{0}/culture.xml", xmlPath));
            CultureInfo ci = new CultureInfo("ja-JP");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            ResourceManager rm = ResourceManager.CreateFileBasedResourceManager("resource", xmlPath, null);
            if(rm.GetString("test") != null) { label_test.Text = rm.GetString("test"); };
        }
    }
}
