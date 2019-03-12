namespace miner
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
            this.square = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Change_button2 = new System.Windows.Forms.Button();
            this.Change_button1 = new System.Windows.Forms.Button();
            this.Numeric_Row = new System.Windows.Forms.NumericUpDown();
            this.Numeric_Col = new System.Windows.Forms.NumericUpDown();
            this.ResetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Col)).BeginInit();
            this.SuspendLayout();
            // 
            // square
            // 
            this.square.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.square.AutoScroll = true;
            this.square.BackColor = System.Drawing.SystemColors.Control;
            this.square.Location = new System.Drawing.Point(12, 103);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(400, 350);
            this.square.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Change_button2);
            this.groupBox1.Controls.Add(this.Change_button1);
            this.groupBox1.Controls.Add(this.Numeric_Row);
            this.groupBox1.Controls.Add(this.Numeric_Col);
            this.groupBox1.Controls.Add(this.ResetButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 68);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Change_button2
            // 
            this.Change_button2.Enabled = false;
            this.Change_button2.Location = new System.Drawing.Point(365, 39);
            this.Change_button2.Name = "Change_button2";
            this.Change_button2.Size = new System.Drawing.Size(25, 25);
            this.Change_button2.TabIndex = 19;
            this.Change_button2.Text = "b";
            this.Change_button2.UseVisualStyleBackColor = true;
            this.Change_button2.Click += new System.EventHandler(this.Change_button2_Click);
            // 
            // Change_button1
            // 
            this.Change_button1.Location = new System.Drawing.Point(334, 39);
            this.Change_button1.Name = "Change_button1";
            this.Change_button1.Size = new System.Drawing.Size(25, 25);
            this.Change_button1.TabIndex = 18;
            this.Change_button1.Text = "f";
            this.Change_button1.UseVisualStyleBackColor = true;
            this.Change_button1.Click += new System.EventHandler(this.Change_button1_Click);
            // 
            // Numeric_Row
            // 
            this.Numeric_Row.Location = new System.Drawing.Point(6, 19);
            this.Numeric_Row.Name = "Numeric_Row";
            this.Numeric_Row.Size = new System.Drawing.Size(75, 20);
            this.Numeric_Row.TabIndex = 17;
            this.Numeric_Row.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Numeric_Col
            // 
            this.Numeric_Col.Location = new System.Drawing.Point(87, 19);
            this.Numeric_Col.Name = "Numeric_Col";
            this.Numeric_Col.Size = new System.Drawing.Size(75, 20);
            this.Numeric_Col.TabIndex = 16;
            this.Numeric_Col.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(168, 19);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 20);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.Reset);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.square);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Col)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel square;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown Numeric_Row;
        private System.Windows.Forms.NumericUpDown Numeric_Col;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button Change_button2;
        private System.Windows.Forms.Button Change_button1;
    }
}

