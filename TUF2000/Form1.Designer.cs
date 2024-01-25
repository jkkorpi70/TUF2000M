
namespace TUF2000MainForm
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
            this.labelFlowRateValue = new System.Windows.Forms.Label();
            this.labelTemperatureValue = new System.Windows.Forms.Label();
            this.labelSignalQualityValue = new System.Windows.Forms.Label();
            this.labelFlowRateText = new System.Windows.Forms.Label();
            this.labelTemperatureText = new System.Windows.Forms.Label();
            this.labelSignalQualityText = new System.Windows.Forms.Label();
            this.labelSystemStatus = new System.Windows.Forms.Label();
            this.listBoxErrorCodes = new System.Windows.Forms.ListBox();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.buttonSetLogFile = new System.Windows.Forms.Button();
            this.labelLogging1 = new System.Windows.Forms.Label();
            this.labelLoggingStatus = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelLogFile = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFlowRateValue
            // 
            this.labelFlowRateValue.AutoSize = true;
            this.labelFlowRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlowRateValue.Location = new System.Drawing.Point(260, 42);
            this.labelFlowRateValue.Name = "labelFlowRateValue";
            this.labelFlowRateValue.Size = new System.Drawing.Size(73, 46);
            this.labelFlowRateValue.TabIndex = 5;
            this.labelFlowRateValue.Text = "FR";
            // 
            // labelTemperatureValue
            // 
            this.labelTemperatureValue.AutoSize = true;
            this.labelTemperatureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatureValue.Location = new System.Drawing.Point(260, 88);
            this.labelTemperatureValue.Name = "labelTemperatureValue";
            this.labelTemperatureValue.Size = new System.Drawing.Size(66, 46);
            this.labelTemperatureValue.TabIndex = 6;
            this.labelTemperatureValue.Text = "T1";
            // 
            // labelSignalQualityValue
            // 
            this.labelSignalQualityValue.AutoSize = true;
            this.labelSignalQualityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignalQualityValue.Location = new System.Drawing.Point(114, 149);
            this.labelSignalQualityValue.Name = "labelSignalQualityValue";
            this.labelSignalQualityValue.Size = new System.Drawing.Size(28, 17);
            this.labelSignalQualityValue.TabIndex = 7;
            this.labelSignalQualityValue.Text = "SQ";
            // 
            // labelFlowRateText
            // 
            this.labelFlowRateText.AutoSize = true;
            this.labelFlowRateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlowRateText.Location = new System.Drawing.Point(12, 42);
            this.labelFlowRateText.Name = "labelFlowRateText";
            this.labelFlowRateText.Size = new System.Drawing.Size(200, 46);
            this.labelFlowRateText.TabIndex = 8;
            this.labelFlowRateText.Text = "Flow Rate";
            // 
            // labelTemperatureText
            // 
            this.labelTemperatureText.AutoSize = true;
            this.labelTemperatureText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperatureText.Location = new System.Drawing.Point(12, 88);
            this.labelTemperatureText.Name = "labelTemperatureText";
            this.labelTemperatureText.Size = new System.Drawing.Size(246, 46);
            this.labelTemperatureText.TabIndex = 9;
            this.labelTemperatureText.Text = "Temperature";
            // 
            // labelSignalQualityText
            // 
            this.labelSignalQualityText.AutoSize = true;
            this.labelSignalQualityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignalQualityText.Location = new System.Drawing.Point(15, 149);
            this.labelSignalQualityText.Name = "labelSignalQualityText";
            this.labelSignalQualityText.Size = new System.Drawing.Size(99, 17);
            this.labelSignalQualityText.TabIndex = 10;
            this.labelSignalQualityText.Text = "Signal Quality:";
            // 
            // labelSystemStatus
            // 
            this.labelSystemStatus.AutoSize = true;
            this.labelSystemStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystemStatus.Location = new System.Drawing.Point(15, 166);
            this.labelSystemStatus.Name = "labelSystemStatus";
            this.labelSystemStatus.Size = new System.Drawing.Size(102, 17);
            this.labelSystemStatus.TabIndex = 11;
            this.labelSystemStatus.Text = "System Status:";
            // 
            // listBoxErrorCodes
            // 
            this.listBoxErrorCodes.FormattingEnabled = true;
            this.listBoxErrorCodes.Location = new System.Drawing.Point(18, 186);
            this.listBoxErrorCodes.Name = "listBoxErrorCodes";
            this.listBoxErrorCodes.Size = new System.Drawing.Size(207, 95);
            this.listBoxErrorCodes.TabIndex = 13;
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartStop.Location = new System.Drawing.Point(242, 186);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(125, 45);
            this.buttonStartStop.TabIndex = 15;
            this.buttonStartStop.Text = "STOP";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // buttonSetLogFile
            // 
            this.buttonSetLogFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetLogFile.Location = new System.Drawing.Point(421, 1);
            this.buttonSetLogFile.Name = "buttonSetLogFile";
            this.buttonSetLogFile.Size = new System.Drawing.Size(102, 25);
            this.buttonSetLogFile.TabIndex = 16;
            this.buttonSetLogFile.Text = "-> Set new";
            this.buttonSetLogFile.UseVisualStyleBackColor = true;
            this.buttonSetLogFile.Click += new System.EventHandler(this.buttonSetLogFile_Click);
            // 
            // labelLogging1
            // 
            this.labelLogging1.AutoSize = true;
            this.labelLogging1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogging1.Location = new System.Drawing.Point(255, 144);
            this.labelLogging1.Name = "labelLogging1";
            this.labelLogging1.Size = new System.Drawing.Size(98, 20);
            this.labelLogging1.TabIndex = 18;
            this.labelLogging1.Text = "Data Logger";
            this.labelLogging1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLoggingStatus
            // 
            this.labelLoggingStatus.AutoSize = true;
            this.labelLoggingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoggingStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLoggingStatus.Location = new System.Drawing.Point(263, 164);
            this.labelLoggingStatus.Name = "labelLoggingStatus";
            this.labelLoggingStatus.Size = new System.Drawing.Size(84, 20);
            this.labelLoggingStatus.TabIndex = 19;
            this.labelLoggingStatus.Text = "RUNNING";
            this.labelLoggingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(92, 3);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(325, 20);
            this.textBoxFileName.TabIndex = 20;
            this.textBoxFileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFileName_KeyPress);
            // 
            // labelLogFile
            // 
            this.labelLogFile.AutoSize = true;
            this.labelLogFile.Location = new System.Drawing.Point(1, 6);
            this.labelLogFile.Name = "labelLogFile";
            this.labelLogFile.Size = new System.Drawing.Size(85, 13);
            this.labelLogFile.TabIndex = 21;
            this.labelLogFile.Text = "TUF-200 log file:";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(4, 26);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(62, 13);
            this.labelDateTime.TabIndex = 22;
            this.labelDateTime.Text = "Date - Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 308);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelLogFile);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.labelLoggingStatus);
            this.Controls.Add(this.labelLogging1);
            this.Controls.Add(this.buttonSetLogFile);
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.listBoxErrorCodes);
            this.Controls.Add(this.labelSystemStatus);
            this.Controls.Add(this.labelSignalQualityText);
            this.Controls.Add(this.labelTemperatureText);
            this.Controls.Add(this.labelFlowRateText);
            this.Controls.Add(this.labelSignalQualityValue);
            this.Controls.Add(this.labelTemperatureValue);
            this.Controls.Add(this.labelFlowRateValue);
            this.Name = "Form1";
            this.Text = "TUF-2000 ultrasonic energy meter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFlowRateValue;
        private System.Windows.Forms.Label labelTemperatureValue;
        private System.Windows.Forms.Label labelSignalQualityValue;
        private System.Windows.Forms.Label labelFlowRateText;
        private System.Windows.Forms.Label labelTemperatureText;
        private System.Windows.Forms.Label labelSignalQualityText;
        private System.Windows.Forms.Label labelSystemStatus;
        private System.Windows.Forms.ListBox listBoxErrorCodes;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Button buttonSetLogFile;
        private System.Windows.Forms.Label labelLogging1;
        private System.Windows.Forms.Label labelLoggingStatus;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelLogFile;
        private System.Windows.Forms.Label labelDateTime;
    }
}

