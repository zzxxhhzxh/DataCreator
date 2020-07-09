namespace SimplePainter
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.picImg = new System.Windows.Forms.PictureBox();
            this.grpSetting = new System.Windows.Forms.GroupBox();
            this.txtDY = new System.Windows.Forms.TextBox();
            this.txtDX = new System.Windows.Forms.TextBox();
            this.txtMaxY = new System.Windows.Forms.TextBox();
            this.txtMinY = new System.Windows.Forms.TextBox();
            this.txtMaxX = new System.Windows.Forms.TextBox();
            this.txtMinX = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.btnNewCoord = new System.Windows.Forms.Button();
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.rdoLog = new System.Windows.Forms.RadioButton();
            this.rdoTime = new System.Windows.Forms.RadioButton();
            this.rdoReg = new System.Windows.Forms.RadioButton();
            this.grpGroup = new System.Windows.Forms.GroupBox();
            this.rdoGrp5 = new System.Windows.Forms.RadioButton();
            this.rdoGrp4 = new System.Windows.Forms.RadioButton();
            this.rdoGrp2 = new System.Windows.Forms.RadioButton();
            this.rdoGrp3 = new System.Windows.Forms.RadioButton();
            this.rdoGrp1 = new System.Windows.Forms.RadioButton();
            this.rdoGrp0 = new System.Windows.Forms.RadioButton();
            this.rtxData = new System.Windows.Forms.RichTextBox();
            this.btnLoadPic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.grpSetting.SuspendLayout();
            this.grpCreate.SuspendLayout();
            this.grpGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImg
            // 
            this.picImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImg.Location = new System.Drawing.Point(12, 12);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(519, 537);
            this.picImg.TabIndex = 2;
            this.picImg.TabStop = false;
            this.picImg.Paint += new System.Windows.Forms.PaintEventHandler(this.picImg_Paint);
            this.picImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picImg_MouseDown);
            this.picImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picImg_MouseUp);
            // 
            // grpSetting
            // 
            this.grpSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSetting.Controls.Add(this.txtDY);
            this.grpSetting.Controls.Add(this.txtDX);
            this.grpSetting.Controls.Add(this.txtMaxY);
            this.grpSetting.Controls.Add(this.txtMinY);
            this.grpSetting.Controls.Add(this.txtMaxX);
            this.grpSetting.Controls.Add(this.txtMinX);
            this.grpSetting.Controls.Add(this.lbl1);
            this.grpSetting.Controls.Add(this.btnSet);
            this.grpSetting.Location = new System.Drawing.Point(537, 12);
            this.grpSetting.Name = "grpSetting";
            this.grpSetting.Size = new System.Drawing.Size(154, 201);
            this.grpSetting.TabIndex = 3;
            this.grpSetting.TabStop = false;
            this.grpSetting.Text = "Set Coordinate";
            // 
            // txtDY
            // 
            this.txtDY.Location = new System.Drawing.Point(46, 146);
            this.txtDY.Name = "txtDY";
            this.txtDY.Size = new System.Drawing.Size(102, 20);
            this.txtDY.TabIndex = 1;
            this.txtDY.Text = "5";
            // 
            // txtDX
            // 
            this.txtDX.Location = new System.Drawing.Point(46, 120);
            this.txtDX.Name = "txtDX";
            this.txtDX.Size = new System.Drawing.Size(102, 20);
            this.txtDX.TabIndex = 1;
            this.txtDX.Text = "5";
            // 
            // txtMaxY
            // 
            this.txtMaxY.Location = new System.Drawing.Point(46, 94);
            this.txtMaxY.Name = "txtMaxY";
            this.txtMaxY.Size = new System.Drawing.Size(102, 20);
            this.txtMaxY.TabIndex = 1;
            this.txtMaxY.Text = "100";
            // 
            // txtMinY
            // 
            this.txtMinY.Location = new System.Drawing.Point(46, 68);
            this.txtMinY.Name = "txtMinY";
            this.txtMinY.Size = new System.Drawing.Size(102, 20);
            this.txtMinY.TabIndex = 1;
            this.txtMinY.Text = "0";
            // 
            // txtMaxX
            // 
            this.txtMaxX.Location = new System.Drawing.Point(46, 42);
            this.txtMaxX.Name = "txtMaxX";
            this.txtMaxX.Size = new System.Drawing.Size(102, 20);
            this.txtMaxX.TabIndex = 1;
            this.txtMaxX.Text = "100";
            // 
            // txtMinX
            // 
            this.txtMinX.Location = new System.Drawing.Point(46, 16);
            this.txtMinX.Name = "txtMinX";
            this.txtMinX.Size = new System.Drawing.Size(102, 20);
            this.txtMinX.TabIndex = 1;
            this.txtMinX.Text = "0";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(7, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(33, 143);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "minX\r\n\r\nmaxX\r\n\r\nminY\r\n\r\nmaxY\r\n\r\ndX\r\n\r\ndY";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(73, 172);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveData.Location = new System.Drawing.Point(697, 104);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveData.TabIndex = 7;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowData.Location = new System.Drawing.Point(697, 78);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(75, 23);
            this.btnShowData.TabIndex = 2;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.Click += new System.EventHandler(this.BtnCreateData_Click);
            // 
            // btnNewCoord
            // 
            this.btnNewCoord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCoord.Location = new System.Drawing.Point(697, 26);
            this.btnNewCoord.Name = "btnNewCoord";
            this.btnNewCoord.Size = new System.Drawing.Size(75, 23);
            this.btnNewCoord.TabIndex = 0;
            this.btnNewCoord.Text = "New Coord";
            this.btnNewCoord.Click += new System.EventHandler(this.BtnNewCoord_Click);
            // 
            // grpCreate
            // 
            this.grpCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCreate.Controls.Add(this.rdoLog);
            this.grpCreate.Controls.Add(this.rdoTime);
            this.grpCreate.Controls.Add(this.rdoReg);
            this.grpCreate.Location = new System.Drawing.Point(537, 275);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(235, 69);
            this.grpCreate.TabIndex = 7;
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Create Data";
            // 
            // rdoLog
            // 
            this.rdoLog.AutoSize = true;
            this.rdoLog.Location = new System.Drawing.Point(120, 19);
            this.rdoLog.Name = "rdoLog";
            this.rdoLog.Size = new System.Drawing.Size(61, 17);
            this.rdoLog.TabIndex = 1;
            this.rdoLog.Text = "Logistic";
            this.rdoLog.UseVisualStyleBackColor = true;
            // 
            // rdoTime
            // 
            this.rdoTime.AutoSize = true;
            this.rdoTime.Location = new System.Drawing.Point(6, 42);
            this.rdoTime.Name = "rdoTime";
            this.rdoTime.Size = new System.Drawing.Size(80, 17);
            this.rdoTime.TabIndex = 0;
            this.rdoTime.Text = "Time Series";
            this.rdoTime.UseVisualStyleBackColor = true;
            // 
            // rdoReg
            // 
            this.rdoReg.AutoSize = true;
            this.rdoReg.Checked = true;
            this.rdoReg.Location = new System.Drawing.Point(6, 19);
            this.rdoReg.Name = "rdoReg";
            this.rdoReg.Size = new System.Drawing.Size(78, 17);
            this.rdoReg.TabIndex = 0;
            this.rdoReg.TabStop = true;
            this.rdoReg.Text = "Regression";
            this.rdoReg.UseVisualStyleBackColor = true;
            // 
            // grpGroup
            // 
            this.grpGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGroup.Controls.Add(this.rdoGrp5);
            this.grpGroup.Controls.Add(this.rdoGrp4);
            this.grpGroup.Controls.Add(this.rdoGrp2);
            this.grpGroup.Controls.Add(this.rdoGrp3);
            this.grpGroup.Controls.Add(this.rdoGrp1);
            this.grpGroup.Controls.Add(this.rdoGrp0);
            this.grpGroup.Location = new System.Drawing.Point(537, 219);
            this.grpGroup.Name = "grpGroup";
            this.grpGroup.Size = new System.Drawing.Size(235, 50);
            this.grpGroup.TabIndex = 4;
            this.grpGroup.TabStop = false;
            this.grpGroup.Text = "Point Group";
            // 
            // rdoGrp5
            // 
            this.rdoGrp5.AutoSize = true;
            this.rdoGrp5.BackColor = System.Drawing.Color.SlateBlue;
            this.rdoGrp5.Location = new System.Drawing.Point(194, 20);
            this.rdoGrp5.Name = "rdoGrp5";
            this.rdoGrp5.Size = new System.Drawing.Size(31, 17);
            this.rdoGrp5.TabIndex = 0;
            this.rdoGrp5.Text = "5";
            this.rdoGrp5.UseVisualStyleBackColor = false;
            this.rdoGrp5.Click += new System.EventHandler(this.ClickGroupRadios);
            // 
            // rdoGrp4
            // 
            this.rdoGrp4.AutoSize = true;
            this.rdoGrp4.BackColor = System.Drawing.Color.Gold;
            this.rdoGrp4.Location = new System.Drawing.Point(157, 20);
            this.rdoGrp4.Name = "rdoGrp4";
            this.rdoGrp4.Size = new System.Drawing.Size(31, 17);
            this.rdoGrp4.TabIndex = 0;
            this.rdoGrp4.Text = "4";
            this.rdoGrp4.UseVisualStyleBackColor = false;
            this.rdoGrp4.Click += new System.EventHandler(this.ClickGroupRadios);
            // 
            // rdoGrp2
            // 
            this.rdoGrp2.AutoSize = true;
            this.rdoGrp2.BackColor = System.Drawing.Color.LimeGreen;
            this.rdoGrp2.Location = new System.Drawing.Point(83, 20);
            this.rdoGrp2.Name = "rdoGrp2";
            this.rdoGrp2.Size = new System.Drawing.Size(31, 17);
            this.rdoGrp2.TabIndex = 0;
            this.rdoGrp2.Text = "2";
            this.rdoGrp2.UseVisualStyleBackColor = false;
            this.rdoGrp2.Click += new System.EventHandler(this.ClickGroupRadios);
            // 
            // rdoGrp3
            // 
            this.rdoGrp3.AutoSize = true;
            this.rdoGrp3.BackColor = System.Drawing.Color.DodgerBlue;
            this.rdoGrp3.Location = new System.Drawing.Point(120, 20);
            this.rdoGrp3.Name = "rdoGrp3";
            this.rdoGrp3.Size = new System.Drawing.Size(31, 17);
            this.rdoGrp3.TabIndex = 0;
            this.rdoGrp3.Text = "3";
            this.rdoGrp3.UseVisualStyleBackColor = false;
            this.rdoGrp3.Click += new System.EventHandler(this.ClickGroupRadios);
            // 
            // rdoGrp1
            // 
            this.rdoGrp1.AutoSize = true;
            this.rdoGrp1.BackColor = System.Drawing.Color.Tomato;
            this.rdoGrp1.Location = new System.Drawing.Point(46, 20);
            this.rdoGrp1.Name = "rdoGrp1";
            this.rdoGrp1.Size = new System.Drawing.Size(31, 17);
            this.rdoGrp1.TabIndex = 0;
            this.rdoGrp1.Text = "1";
            this.rdoGrp1.UseVisualStyleBackColor = false;
            this.rdoGrp1.Click += new System.EventHandler(this.ClickGroupRadios);
            // 
            // rdoGrp0
            // 
            this.rdoGrp0.AutoSize = true;
            this.rdoGrp0.BackColor = System.Drawing.Color.DimGray;
            this.rdoGrp0.Checked = true;
            this.rdoGrp0.Location = new System.Drawing.Point(9, 20);
            this.rdoGrp0.Name = "rdoGrp0";
            this.rdoGrp0.Size = new System.Drawing.Size(31, 17);
            this.rdoGrp0.TabIndex = 0;
            this.rdoGrp0.TabStop = true;
            this.rdoGrp0.Text = "0";
            this.rdoGrp0.UseVisualStyleBackColor = false;
            this.rdoGrp0.Click += new System.EventHandler(this.ClickGroupRadios);
            // 
            // rtxData
            // 
            this.rtxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxData.Location = new System.Drawing.Point(537, 350);
            this.rtxData.Name = "rtxData";
            this.rtxData.Size = new System.Drawing.Size(235, 199);
            this.rtxData.TabIndex = 3;
            this.rtxData.Text = "";
            // 
            // btnLoadPic
            // 
            this.btnLoadPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPic.Location = new System.Drawing.Point(697, 52);
            this.btnLoadPic.Name = "btnLoadPic";
            this.btnLoadPic.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPic.TabIndex = 8;
            this.btnLoadPic.Text = "Load Pic";
            this.btnLoadPic.Click += new System.EventHandler(this.BtnLoadPic_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLoadPic);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.btnNewCoord);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.grpCreate);
            this.Controls.Add(this.grpSetting);
            this.Controls.Add(this.picImg);
            this.Controls.Add(this.grpGroup);
            this.Controls.Add(this.rtxData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Data Creator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.grpSetting.ResumeLayout(false);
            this.grpSetting.PerformLayout();
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.grpGroup.ResumeLayout(false);
            this.grpGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.GroupBox grpSetting;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox txtMaxY;
        private System.Windows.Forms.TextBox txtMinY;
        private System.Windows.Forms.TextBox txtMaxX;
        private System.Windows.Forms.TextBox txtMinX;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox grpGroup;
        private System.Windows.Forms.RadioButton rdoGrp5;
        private System.Windows.Forms.RadioButton rdoGrp4;
        private System.Windows.Forms.RadioButton rdoGrp2;
        private System.Windows.Forms.RadioButton rdoGrp3;
        private System.Windows.Forms.RadioButton rdoGrp1;
        private System.Windows.Forms.RadioButton rdoGrp0;
        private System.Windows.Forms.RichTextBox rtxData;
        private System.Windows.Forms.Button btnNewCoord;
        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.RadioButton rdoLog;
        private System.Windows.Forms.RadioButton rdoReg;
        private System.Windows.Forms.RadioButton rdoTime;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnLoadPic;
        private System.Windows.Forms.TextBox txtDY;
        private System.Windows.Forms.TextBox txtDX;
    }
}

