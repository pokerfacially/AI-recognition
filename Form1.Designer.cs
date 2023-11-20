namespace AI_recognition
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_origin = new System.Windows.Forms.PictureBox();
            this.btn_getPicture = new System.Windows.Forms.Button();
            this.textbox_pictureAddress = new System.Windows.Forms.TextBox();
            this.btn_ImageStyleTrans = new System.Windows.Forms.Button();
            this.btn_SelfieAnime = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox_process = new System.Windows.Forms.PictureBox();
            this.btn_Colourize = new System.Windows.Forms.Button();
            this.btn_setPicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_origin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_process)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_origin
            // 
            this.pictureBox_origin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_origin.Location = new System.Drawing.Point(21, 51);
            this.pictureBox_origin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox_origin.Name = "pictureBox_origin";
            this.pictureBox_origin.Size = new System.Drawing.Size(618, 775);
            this.pictureBox_origin.TabIndex = 0;
            this.pictureBox_origin.TabStop = false;
            // 
            // btn_getPicture
            // 
            this.btn_getPicture.Location = new System.Drawing.Point(1178, 12);
            this.btn_getPicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_getPicture.Name = "btn_getPicture";
            this.btn_getPicture.Size = new System.Drawing.Size(138, 23);
            this.btn_getPicture.TabIndex = 2;
            this.btn_getPicture.Text = "提取图片";
            this.btn_getPicture.UseVisualStyleBackColor = true;
            this.btn_getPicture.Click += new System.EventHandler(this.btn_getPicture_Click);
            // 
            // textbox_pictureAddress
            // 
            this.textbox_pictureAddress.Location = new System.Drawing.Point(21, 12);
            this.textbox_pictureAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbox_pictureAddress.Name = "textbox_pictureAddress";
            this.textbox_pictureAddress.Size = new System.Drawing.Size(514, 21);
            this.textbox_pictureAddress.TabIndex = 3;
            // 
            // btn_ImageStyleTrans
            // 
            this.btn_ImageStyleTrans.Location = new System.Drawing.Point(1200, 849);
            this.btn_ImageStyleTrans.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ImageStyleTrans.Name = "btn_ImageStyleTrans";
            this.btn_ImageStyleTrans.Size = new System.Drawing.Size(142, 23);
            this.btn_ImageStyleTrans.TabIndex = 5;
            this.btn_ImageStyleTrans.Text = "图像风格转换";
            this.btn_ImageStyleTrans.UseVisualStyleBackColor = true;
            this.btn_ImageStyleTrans.Click += new System.EventHandler(this.btn_ImageStyleTrans_Click);
            // 
            // btn_SelfieAnime
            // 
            this.btn_SelfieAnime.Location = new System.Drawing.Point(392, 849);
            this.btn_SelfieAnime.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_SelfieAnime.Name = "btn_SelfieAnime";
            this.btn_SelfieAnime.Size = new System.Drawing.Size(142, 23);
            this.btn_SelfieAnime.TabIndex = 6;
            this.btn_SelfieAnime.Text = "人物动漫化";
            this.btn_SelfieAnime.UseVisualStyleBackColor = true;
            this.btn_SelfieAnime.Click += new System.EventHandler(this.btn_SelfieAnime_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "卡通画",
            "铅笔画",
            "彩色铅笔画",
            "彩色糖块油画",
            "神奈川冲浪里油画",
            "薰衣草油画",
            "奇异油画",
            "呐喊油画",
            "哥特油画"});
            this.comboBox1.Location = new System.Drawing.Point(937, 852);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // pictureBox_process
            // 
            this.pictureBox_process.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_process.Location = new System.Drawing.Point(680, 51);
            this.pictureBox_process.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox_process.Name = "pictureBox_process";
            this.pictureBox_process.Size = new System.Drawing.Size(662, 775);
            this.pictureBox_process.TabIndex = 8;
            this.pictureBox_process.TabStop = false;
            // 
            // btn_Colourize
            // 
            this.btn_Colourize.Location = new System.Drawing.Point(35, 849);
            this.btn_Colourize.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Colourize.Name = "btn_Colourize";
            this.btn_Colourize.Size = new System.Drawing.Size(142, 23);
            this.btn_Colourize.TabIndex = 9;
            this.btn_Colourize.Text = "黑白图像上色";
            this.btn_Colourize.UseVisualStyleBackColor = true;
            this.btn_Colourize.Click += new System.EventHandler(this.btn_Colourize_Click);
            // 
            // btn_setPicture
            // 
            this.btn_setPicture.Location = new System.Drawing.Point(937, 12);
            this.btn_setPicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_setPicture.Name = "btn_setPicture";
            this.btn_setPicture.Size = new System.Drawing.Size(138, 23);
            this.btn_setPicture.TabIndex = 10;
            this.btn_setPicture.Text = "选择图片";
            this.btn_setPicture.UseVisualStyleBackColor = true;
            this.btn_setPicture.Click += new System.EventHandler(this.btn_setPicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 880);
            this.Controls.Add(this.btn_setPicture);
            this.Controls.Add(this.btn_Colourize);
            this.Controls.Add(this.pictureBox_process);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_SelfieAnime);
            this.Controls.Add(this.btn_ImageStyleTrans);
            this.Controls.Add(this.textbox_pictureAddress);
            this.Controls.Add(this.btn_getPicture);
            this.Controls.Add(this.pictureBox_origin);
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "图片增强工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_origin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_process)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_origin;
        private System.Windows.Forms.Button btn_getPicture;
        private System.Windows.Forms.TextBox textbox_pictureAddress;
        private System.Windows.Forms.Button btn_ImageStyleTrans;
        private System.Windows.Forms.Button btn_SelfieAnime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox_process;
        private System.Windows.Forms.Button btn_Colourize;
        private System.Windows.Forms.Button btn_setPicture;
    }
}

