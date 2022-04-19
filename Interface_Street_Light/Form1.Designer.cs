namespace Interface_Street_Light
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.Humidity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.Brightness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.Temperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.Motion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView5 = new System.Windows.Forms.ListView();
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 30.15F, System.Drawing.FontStyle.Bold);
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1005, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lighting System Monitoring";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView4
            // 
            this.listView4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView4.BackColor = System.Drawing.Color.LightBlue;
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Humidity});
            this.listView4.GridLines = true;
            this.listView4.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(601, 145);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(145, 353);
            this.listView4.SmallImageList = this.ımageList1;
            this.listView4.TabIndex = 6;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // Humidity
            // 
            this.Humidity.Text = "HUMIDITY";
            this.Humidity.Width = 140;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "mot.ico");
            this.ımageList1.Images.SetKeyName(1, "birt.ico");
            this.ımageList1.Images.SetKeyName(2, "date1.ico");
            this.ımageList1.Images.SetKeyName(3, "hum.ico");
            this.ımageList1.Images.SetKeyName(4, "tempe.ico");
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView1.BackColor = System.Drawing.Color.LightBlue;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Brightness});
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(450, 145);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(145, 353);
            this.listView1.SmallImageList = this.ımageList1;
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Brightness
            // 
            this.Brightness.Text = "BRIGHTNESS";
            this.Brightness.Width = 140;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView2.BackColor = System.Drawing.Color.LightBlue;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Temperature});
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(299, 145);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(145, 353);
            this.listView2.SmallImageList = this.ımageList1;
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // Temperature
            // 
            this.Temperature.Text = "TEMPERATURE";
            this.Temperature.Width = 140;
            // 
            // listView3
            // 
            this.listView3.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView3.BackColor = System.Drawing.Color.LightBlue;
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Motion});
            this.listView3.Cursor = System.Windows.Forms.Cursors.No;
            this.listView3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.listView3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView3.GridLines = true;
            this.listView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView3.HideSelection = false;
            this.listView3.HotTracking = true;
            this.listView3.HoverSelection = true;
            this.listView3.Location = new System.Drawing.Point(752, 145);
            this.listView3.Name = "listView3";
            this.listView3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView3.Size = new System.Drawing.Size(145, 353);
            this.listView3.SmallImageList = this.ımageList1;
            this.listView3.TabIndex = 9;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // Motion
            // 
            this.Motion.Text = "MOTION";
            this.Motion.Width = 140;
            // 
            // listView5
            // 
            this.listView5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView5.BackColor = System.Drawing.Color.LightBlue;
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Date});
            this.listView5.GridLines = true;
            this.listView5.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(148, 145);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(145, 353);
            this.listView5.SmallImageList = this.ımageList1;
            this.listView5.TabIndex = 10;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            this.listView5.SelectedIndexChanged += new System.EventHandler(this.listView5_SelectedIndexChanged_1);
            // 
            // Date
            // 
            this.Date.Text = "DATE";
            this.Date.Width = 140;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(315, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Tahoma", 15.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(540, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 48);
            this.button2.TabIndex = 12;
            this.button2.Text = "SPECIFIC CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(933, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(752, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 41);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lighting System Monitoring";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.ActiveGlowColor = System.Drawing.Color.White;
            this.Appearance.BackColor = System.Drawing.Color.SlateGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1053, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView5);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.label1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.Image")));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.LargeImage")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lighting System Monitoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Humidity;
        private System.Windows.Forms.ColumnHeader Motion;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ColumnHeader Temperature;
        private System.Windows.Forms.ImageList ımageList1;
        internal System.Windows.Forms.ListView listView3;
        public System.Windows.Forms.ColumnHeader Brightness;
        public System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

