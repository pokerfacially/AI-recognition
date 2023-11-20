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
using System.Net.Http;
using System.Net;
using System.Web;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Reflection.Emit;

namespace AI_recognition
{
    public partial class Form1 : Form
    {
        // string APP_ID = "42661156";
        string API_KEY = "rBlyFbsibdWmC2pFXEZVPBZM";
        string SECRET_KEY = "DeG0AVPsBY5jfbdO1UMUWQ0p8M9vASyb";
        Baidu.Aip.ImageProcess.ImageProcess client;
        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0.9;
            comboBox1.SelectedIndex = 0;
            pictureBox_origin.BackColor = System.Drawing.Color.Transparent;
            pictureBox_process.BackColor = System.Drawing.Color.Transparent;
            pictureBox_origin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_process.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                client = new Baidu.Aip.ImageProcess.ImageProcess(API_KEY, SECRET_KEY);
                client.Timeout = 60000;
            }
            catch
            {
                MessageBox.Show("初始化百度接口出错", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void SelfieAnime() {
            var image = File.ReadAllBytes(textbox_pictureAddress.Text);
            // 人像动漫化接口，可能会抛出网络等异常，请使用try/catch捕获
            var result = client.SelfieAnime(image);
            Console.WriteLine(result);
            // 文件url
            var url = "http://host/test.jpeg";
            result = client.SelfieAnimeUrl(url);
            // 如果有可选参数
            var options = new Dictionary<string, object> { };
            // 带参数调用人像动漫化接口
            result = client.SelfieAnime(image, options);
            Console.WriteLine(result);
            pictureBox_process.Image = ConvertBase64ToImage(result["image"].ToString());
        }

        public void Colourize() {
            var image = File.ReadAllBytes(textbox_pictureAddress.Text);
            // 调用黑白图像上色，可能会抛出网络等异常，请使用try/catch捕获
            var result = client.Colourize(image);
            Console.WriteLine(result);
            pictureBox_process.Image = ConvertBase64ToImage(result["image"].ToString());
        }


        public void ImageStyleTransDemo(int num)
        {
            var image = File.ReadAllBytes(textbox_pictureAddress.Text);
            // 图像风转换，可能会抛出网络等异常，请使用try/catch捕获
            string[] selectStyle = {
            "cartoon",
            "pencil",
            "color_pencil",
            "warm",
            "wave",
            "lavender",
            "mononoke",
            "scream",
            "gothic"
        };
            var option = selectStyle[num];
            var result = client.ImageStyleTrans(image, option);
            Console.WriteLine(result);
            // 文件url
            //var url = "http://host/test.jpeg";
            //result = client.ImageStyleTransUrl(url, option);
            Console.WriteLine(result);

            
            pictureBox_process.Image = ConvertBase64ToImage(result["image"].ToString());

        }

        private void btn_setPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "图片(*.png;*.jpg)|*.png;*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textbox_pictureAddress.Text = ofd.FileName;
                    pictureBox_origin.Image = new Bitmap(ofd.FileName);
                    
                }
            }
            catch
            {
                MessageBox.Show("选择图片出错", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_getPicture_Click(object sender, EventArgs e)
        {
            // 检查 PictureBox 是否有图片
            if (pictureBox_process.Image != null)
            {
                // 选择保存文件的位置
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png";
                saveFileDialog.Title = "Save Image";
                saveFileDialog.ShowDialog();

                // 如果用户选择了文件路径，则保存图片
                if (saveFileDialog.FileName != "")
                {
                    // 获取文件扩展名
                    string extension = System.IO.Path.GetExtension(saveFileDialog.FileName);

                    // 保存图片
                    if (extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase) || extension.Equals(".jpeg", StringComparison.OrdinalIgnoreCase))
                    {
                        pictureBox_process.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else if (extension.Equals(".png", StringComparison.OrdinalIgnoreCase))
                    {
                        pictureBox_process.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }

                    MessageBox.Show("Image exported successfully!");
                }
            }
            else
            {
                MessageBox.Show("PictureBox has no image.");
            }
        }

        private void btn_SelfieAnime_Click(object sender, EventArgs e)
        {
            SelfieAnime();
        }

        private void btn_ImageStyleTrans_Click(object sender, EventArgs e)
        {

            ImageStyleTransDemo(comboBox1.SelectedIndex);
        }

        private void btn_Colourize_Click(object sender, EventArgs e)
        {
            Colourize();
        }

        public Image ConvertBase64ToImage(string base64String)
        {
            // 将 Base64 字符串转换为字节数组
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }
    }
}
