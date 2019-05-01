namespace WindowsFormsApp1
{
    partial class Verbindungen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verbindungen));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxvon = new System.Windows.Forms.ComboBox();
            this.comboBoxnach = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonsuchen = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.labelvon = new System.Windows.Forms.Label();
            this.labelnach = new System.Windows.Forms.Label();
            this.buttonclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(187, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 53);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxvon
            // 
            this.comboBoxvon.FormattingEnabled = true;
            this.comboBoxvon.Location = new System.Drawing.Point(40, 57);
            this.comboBoxvon.Name = "comboBoxvon";
            this.comboBoxvon.Size = new System.Drawing.Size(121, 24);
            this.comboBoxvon.TabIndex = 1;
            this.comboBoxvon.TextChanged += new System.EventHandler(this.comborefresh);
            // 
            // comboBoxnach
            // 
            this.comboBoxnach.FormattingEnabled = true;
            this.comboBoxnach.Location = new System.Drawing.Point(264, 57);
            this.comboBoxnach.Name = "comboBoxnach";
            this.comboBoxnach.Size = new System.Drawing.Size(121, 24);
            this.comboBoxnach.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(41, 223);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 132);
            this.listBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(41, 115);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // buttonsuchen
            // 
            this.buttonsuchen.Location = new System.Drawing.Point(285, 117);
            this.buttonsuchen.Name = "buttonsuchen";
            this.buttonsuchen.Size = new System.Drawing.Size(75, 23);
            this.buttonsuchen.TabIndex = 6;
            this.buttonsuchen.Text = "Suchen";
            this.buttonsuchen.UseVisualStyleBackColor = true;
            this.buttonsuchen.Click += new System.EventHandler(this.buttonsuchen_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(336, 398);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(75, 23);
            this.buttonclose.TabIndex = 7;
            this.buttonclose.Text = "Close";
            this.buttonclose.UseVisualStyleBackColor = true;
            // 
            // labelvon
            // 
            this.labelvon.AutoSize = true;
            this.labelvon.Location = new System.Drawing.Point(38, 37);
            this.labelvon.Name = "labelvon";
            this.labelvon.Size = new System.Drawing.Size(31, 17);
            this.labelvon.TabIndex = 8;
            this.labelvon.Text = "von";
            // 
            // labelnach
            // 
            this.labelnach.AutoSize = true;
            this.labelnach.Location = new System.Drawing.Point(261, 37);
            this.labelnach.Name = "labelnach";
            this.labelnach.Size = new System.Drawing.Size(39, 17);
            this.labelnach.TabIndex = 9;
            this.labelnach.Text = "nach";
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(285, 88);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(75, 23);
            this.buttonclear.TabIndex = 10;
            this.buttonclear.Text = "clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.labelnach);
            this.Controls.Add(this.labelvon);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.buttonsuchen);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxnach);
            this.Controls.Add(this.comboBoxvon);
            this.Controls.Add(this.button1);
            this.Name = "Verbindungen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxvon;
        private System.Windows.Forms.ComboBox comboBoxnach;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonsuchen;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Label labelvon;
        private System.Windows.Forms.Label labelnach;
        private System.Windows.Forms.Button buttonclear;
    }
}

