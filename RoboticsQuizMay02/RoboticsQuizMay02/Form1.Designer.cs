namespace RoboticsQuizMay02
{
    partial class Robotics_Arduino_GUI2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robotics_Arduino_GUI2));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ApplyServoBT = new System.Windows.Forms.Button();
            this.buzzerCB = new System.Windows.Forms.ComboBox();
            this.resetServoBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.blueLEDChkBox = new System.Windows.Forms.CheckBox();
            this.redLEDChckBox = new System.Windows.Forms.CheckBox();
            this.yellowLEDChckBox = new System.Windows.Forms.CheckBox();
            this.buzzerlabel = new System.Windows.Forms.Label();
            this.stopBuzzerBT = new System.Windows.Forms.Button();
            this.playBuzzerBT = new System.Windows.Forms.Button();
            this.staticRB = new System.Windows.Forms.RadioButton();
            this.blinkLEDRB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ServoTB = new System.Windows.Forms.TextBox();
            this.ledBrightnessTB = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.ledConfirmBT = new System.Windows.Forms.Button();
            this.redConfirmBT = new System.Windows.Forms.Button();
            this.yellowConfirmBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ledBrightnessTB)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // ApplyServoBT
            // 
            resources.ApplyResources(this.ApplyServoBT, "ApplyServoBT");
            this.ApplyServoBT.Name = "ApplyServoBT";
            this.ApplyServoBT.UseVisualStyleBackColor = true;
            this.ApplyServoBT.Click += new System.EventHandler(this.ApplyServoBT_Click);
            // 
            // buzzerCB
            // 
            this.buzzerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buzzerCB.FormattingEnabled = true;
            this.buzzerCB.Items.AddRange(new object[] {
            resources.GetString("buzzerCB.Items"),
            resources.GetString("buzzerCB.Items1")});
            resources.ApplyResources(this.buzzerCB, "buzzerCB");
            this.buzzerCB.Name = "buzzerCB";
            this.buzzerCB.SelectedIndexChanged += new System.EventHandler(this.buzzerCB_SelectedIndexChanged);
            // 
            // resetServoBT
            // 
            resources.ApplyResources(this.resetServoBT, "resetServoBT");
            this.resetServoBT.Name = "resetServoBT";
            this.resetServoBT.UseVisualStyleBackColor = true;
            this.resetServoBT.Click += new System.EventHandler(this.resetServoBT_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // blueLEDChkBox
            // 
            resources.ApplyResources(this.blueLEDChkBox, "blueLEDChkBox");
            this.blueLEDChkBox.Name = "blueLEDChkBox";
            this.blueLEDChkBox.UseVisualStyleBackColor = true;
            this.blueLEDChkBox.CheckedChanged += new System.EventHandler(this.blueLEDChkBox_CheckedChanged);
            // 
            // redLEDChckBox
            // 
            resources.ApplyResources(this.redLEDChckBox, "redLEDChckBox");
            this.redLEDChckBox.Name = "redLEDChckBox";
            this.redLEDChckBox.UseVisualStyleBackColor = true;
            this.redLEDChckBox.CheckedChanged += new System.EventHandler(this.redLEDChckBox_CheckedChanged);
            // 
            // yellowLEDChckBox
            // 
            resources.ApplyResources(this.yellowLEDChckBox, "yellowLEDChckBox");
            this.yellowLEDChckBox.Name = "yellowLEDChckBox";
            this.yellowLEDChckBox.UseVisualStyleBackColor = true;
            this.yellowLEDChckBox.CheckedChanged += new System.EventHandler(this.yellowLEDChckBox_CheckedChanged);
            // 
            // buzzerlabel
            // 
            resources.ApplyResources(this.buzzerlabel, "buzzerlabel");
            this.buzzerlabel.BackColor = System.Drawing.Color.Transparent;
            this.buzzerlabel.ForeColor = System.Drawing.Color.Black;
            this.buzzerlabel.Name = "buzzerlabel";
            // 
            // stopBuzzerBT
            // 
            resources.ApplyResources(this.stopBuzzerBT, "stopBuzzerBT");
            this.stopBuzzerBT.Name = "stopBuzzerBT";
            this.stopBuzzerBT.UseVisualStyleBackColor = true;
            this.stopBuzzerBT.Click += new System.EventHandler(this.stopBuzzerBT_Click);
            // 
            // playBuzzerBT
            // 
            resources.ApplyResources(this.playBuzzerBT, "playBuzzerBT");
            this.playBuzzerBT.Name = "playBuzzerBT";
            this.playBuzzerBT.UseVisualStyleBackColor = true;
            this.playBuzzerBT.Click += new System.EventHandler(this.playBuzzerBT_Click);
            // 
            // staticRB
            // 
            resources.ApplyResources(this.staticRB, "staticRB");
            this.staticRB.Name = "staticRB";
            this.staticRB.TabStop = true;
            this.staticRB.UseVisualStyleBackColor = true;
            this.staticRB.CheckedChanged += new System.EventHandler(this.staticRB_CheckedChanged);
            // 
            // blinkLEDRB
            // 
            resources.ApplyResources(this.blinkLEDRB, "blinkLEDRB");
            this.blinkLEDRB.Name = "blinkLEDRB";
            this.blinkLEDRB.TabStop = true;
            this.blinkLEDRB.UseVisualStyleBackColor = true;
            this.blinkLEDRB.CheckedChanged += new System.EventHandler(this.blinkLEDRB_CheckedChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // ServoTB
            // 
            resources.ApplyResources(this.ServoTB, "ServoTB");
            this.ServoTB.Name = "ServoTB";
            this.ServoTB.TextChanged += new System.EventHandler(this.ServoTB_TextChanged);
            // 
            // ledBrightnessTB
            // 
            this.ledBrightnessTB.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.ledBrightnessTB, "ledBrightnessTB");
            this.ledBrightnessTB.Maximum = 255;
            this.ledBrightnessTB.Name = "ledBrightnessTB";
            this.ledBrightnessTB.TickFrequency = 10;
            this.ledBrightnessTB.Scroll += new System.EventHandler(this.ledBrightnessTB_Scroll);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ledConfirmBT
            // 
            this.ledConfirmBT.BackColor = System.Drawing.Color.Cyan;
            resources.ApplyResources(this.ledConfirmBT, "ledConfirmBT");
            this.ledConfirmBT.Name = "ledConfirmBT";
            this.ledConfirmBT.UseVisualStyleBackColor = false;
            this.ledConfirmBT.Click += new System.EventHandler(this.ledConfirmBT_Click);
            // 
            // redConfirmBT
            // 
            this.redConfirmBT.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.redConfirmBT, "redConfirmBT");
            this.redConfirmBT.Name = "redConfirmBT";
            this.redConfirmBT.UseVisualStyleBackColor = false;
            this.redConfirmBT.Click += new System.EventHandler(this.redConfirmBT_Click);
            // 
            // yellowConfirmBT
            // 
            this.yellowConfirmBT.BackColor = System.Drawing.Color.Khaki;
            resources.ApplyResources(this.yellowConfirmBT, "yellowConfirmBT");
            this.yellowConfirmBT.Name = "yellowConfirmBT";
            this.yellowConfirmBT.UseVisualStyleBackColor = false;
            this.yellowConfirmBT.Click += new System.EventHandler(this.yellowConfirmBT_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // selectedLabel
            // 
            resources.ApplyResources(this.selectedLabel, "selectedLabel");
            this.selectedLabel.Name = "selectedLabel";
            // 
            // lblValue
            // 
            resources.ApplyResources(this.lblValue, "lblValue");
            this.lblValue.Name = "lblValue";
            // 
            // Robotics_Arduino_GUI2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.selectedLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yellowConfirmBT);
            this.Controls.Add(this.redConfirmBT);
            this.Controls.Add(this.ledConfirmBT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ledBrightnessTB);
            this.Controls.Add(this.ServoTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.blinkLEDRB);
            this.Controls.Add(this.staticRB);
            this.Controls.Add(this.playBuzzerBT);
            this.Controls.Add(this.stopBuzzerBT);
            this.Controls.Add(this.buzzerlabel);
            this.Controls.Add(this.yellowLEDChckBox);
            this.Controls.Add(this.redLEDChckBox);
            this.Controls.Add(this.blueLEDChkBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetServoBT);
            this.Controls.Add(this.buzzerCB);
            this.Controls.Add(this.ApplyServoBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Robotics_Arduino_GUI2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ledBrightnessTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ApplyServoBT;
        private System.Windows.Forms.ComboBox buzzerCB;
        private System.Windows.Forms.Button resetServoBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox blueLEDChkBox;
        private System.Windows.Forms.CheckBox redLEDChckBox;
        private System.Windows.Forms.CheckBox yellowLEDChckBox;
        private System.Windows.Forms.Label buzzerlabel;
        private System.Windows.Forms.Button stopBuzzerBT;
        private System.Windows.Forms.Button playBuzzerBT;
        private System.Windows.Forms.RadioButton staticRB;
        private System.Windows.Forms.RadioButton blinkLEDRB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ServoTB;
        private System.Windows.Forms.TrackBar ledBrightnessTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ledConfirmBT;
        private System.Windows.Forms.Button redConfirmBT;
        private System.Windows.Forms.Button yellowConfirmBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.Label lblValue;
    }
}

