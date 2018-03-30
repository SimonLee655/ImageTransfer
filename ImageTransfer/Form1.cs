using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace ImageTransfer
{
    public partial class Form1 : Form
    {
        private string saveFilePath;
        private string seSaveFilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //se => nobase64 se and jpeg
        private void button1_Click(object sender, EventArgs e)
        {
            if(saveFilePath == null || saveFilePath.Trim().Length == 0)
            {
                MessageBox.Show("請先設定存放路徑");
                return;
            }
            OpenFileDialog upload = new OpenFileDialog();
            upload.CheckFileExists = true;
            upload.Multiselect = false;
            //upload.Filter = "html file (*.html)|*.html)";
            
            if(upload.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(upload.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string se = sr.ReadToEnd();
                se = getNoBase64Se(se);
                sr.Close();
                fs.Close();
                fs.Dispose();
                //存只有uid無base64的檔案
                saveTextFile(se, "NoBase64" + upload.SafeFileName, saveFilePath);
            }
        }
        //select a nobase64 se and get se with base64
        private void button2_Click(object sender, EventArgs e)
        {
            if (seSaveFilePath == null || seSaveFilePath.Trim().Length == 0)
            {
                MessageBox.Show("請先設定存放路徑");
                return;
            }
            OpenFileDialog upload = new OpenFileDialog();
            upload.CheckFileExists = true;
            upload.Multiselect = false;
            //upload.Filter = "html file (*.html)|*.html)";

            if (upload.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(upload.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string se = sr.ReadToEnd();
                se = getBase64Se(se);
                sr.Close();
                fs.Close();
                fs.Dispose();
                //存只有uid無base64的檔案
                saveTextFile(se, "Base64" + upload.SafeFileName, seSaveFilePath);
            }
        }


        //設定存檔路徑
        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = saveFilePath = fbd.SelectedPath;
                Environment.SpecialFolder root = fbd.RootFolder;
            }
        }
        //將base64圖片移除，留下div和uid
        private string getNoBase64Se(string seContent)
        {
            HtmlDocument html = new HtmlDocument();
            html.LoadHtml(seContent);
            foreach(var imageNode in html.DocumentNode.SelectNodes("//div/img"))
            {
                //div加上id，並移掉img
                var imageContainer = imageNode.ParentNode;
                string src = imageNode.GetAttributeValue("src", string.Empty);
                if(src != null && src.Trim().Length != 0)
                {
                    //移除<img>
                    imageContainer.RemoveAllChildren();
                    //div加上tag
                    var uid = Guid.NewGuid().ToString();
                    imageContainer.SetAttributeValue("image-uid", uid);
                    //轉換base64
                    saveBase64ToImage(src, uid);
                }
            }
            return html.DocumentNode.OuterHtml;
        }
        //取得含base64的se
        private string getBase64Se(string seContent)
        {
            HtmlDocument html = new HtmlDocument();
            html.LoadHtml(seContent);
            foreach (var imageNode in html.DocumentNode.SelectNodes("//*[@image-uid]"))
            {
                var uid = imageNode.Attributes["image-uid"].Value;
                var base64 = getImageBase64(uid + ".jpeg");
                var imgChildNode = HtmlNode.CreateNode("<img>");
                imgChildNode.SetAttributeValue("src", "data:image/jpeg;base64," + base64);
                imageNode.Attributes.Remove("image-uid");
                imageNode.AppendChild(imgChildNode);
            }
            return html.DocumentNode.OuterHtml;
        }

        //將base64存成圖檔
        private void saveBase64ToImage(string base64, string fileName)  
        {
            int index = base64.IndexOf("base64,") + 7;
            base64 = base64.Substring(index);
            var bytes = Convert.FromBase64String(base64);
            Image image;
            using(MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            image.Save(Path.Combine(saveFilePath, fileName + ".jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private string getImageBase64(string fileName)
        {
            Image image = Image.FromFile(Path.Combine(seSaveFilePath, fileName));
            string base64String = string.Empty;
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                var bytes = ms.ToArray();
                base64String = Convert.ToBase64String(bytes);
                ms.Close();
                ms.Dispose();
            }
            return base64String;
        }

        private void saveTextFile(string content, string fileName, string path)
        {
            File.WriteAllText(Path.Combine(path, fileName), content);
        }

        private void seFilePathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                seFilePath.Text = seSaveFilePath = fbd.SelectedPath;
                Environment.SpecialFolder root = fbd.RootFolder;
            }
        }
    }
}
