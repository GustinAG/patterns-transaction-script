namespace TransactionScript.CheckOutGUI
{
    partial class CheckOutForm
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
            if (disposing && (components != null)) components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CodeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ScanButton = new System.Windows.Forms.Button();
            this.SummaryTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CodeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.Green;
            this.StartButton.Location = new System.Drawing.Point(12, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(95, 46);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // CloseButton
            // 
            this.CloseButton.Enabled = false;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton.Location = new System.Drawing.Point(113, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(95, 46);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // CodeNumericUpDown
            // 
            this.CodeNumericUpDown.Enabled = false;
            this.CodeNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeNumericUpDown.Location = new System.Drawing.Point(12, 64);
            this.CodeNumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.CodeNumericUpDown.Name = "CodeNumericUpDown";
            this.CodeNumericUpDown.Size = new System.Drawing.Size(196, 30);
            this.CodeNumericUpDown.TabIndex = 2;
            this.CodeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ScanButton
            // 
            this.ScanButton.Enabled = false;
            this.ScanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScanButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ScanButton.Location = new System.Drawing.Point(214, 12);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(95, 82);
            this.ScanButton.TabIndex = 3;
            this.ScanButton.Text = "Scan";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButtonClick);
            // 
            // SummaryTextBox
            // 
            this.SummaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SummaryTextBox.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTextBox.Location = new System.Drawing.Point(12, 100);
            this.SummaryTextBox.Multiline = true;
            this.SummaryTextBox.Name = "SummaryTextBox";
            this.SummaryTextBox.ReadOnly = true;
            this.SummaryTextBox.Size = new System.Drawing.Size(581, 586);
            this.SummaryTextBox.TabIndex = 4;
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 698);
            this.Controls.Add(this.SummaryTextBox);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.CodeNumericUpDown);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StartButton);
            this.Name = "CheckOutForm";
            this.Text = "Check-Out";
            ((System.ComponentModel.ISupportInitialize)(this.CodeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.NumericUpDown CodeNumericUpDown;
        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.TextBox SummaryTextBox;
    }
}

