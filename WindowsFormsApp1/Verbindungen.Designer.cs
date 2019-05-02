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
            this.buttonswitch = new System.Windows.Forms.Button();
            this.comboBoxnach = new System.Windows.Forms.ComboBox();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonsuchen = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.labelvon = new System.Windows.Forms.Label();
            this.labelnach = new System.Windows.Forms.Label();
            this.buttonclear = new System.Windows.Forms.Button();
            this.comboBoxvon = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonAnkunft = new System.Windows.Forms.RadioButton();
            this.radioButtonabfahrt = new System.Windows.Forms.RadioButton();
            this.lvConnections = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonswitch
            // 
            this.buttonswitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonswitch.BackgroundImage")));
            this.buttonswitch.Location = new System.Drawing.Point(188, 34);
            this.buttonswitch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonswitch.Name = "buttonswitch";
            this.buttonswitch.Size = new System.Drawing.Size(40, 43);
            this.buttonswitch.TabIndex = 0;
            this.buttonswitch.UseVisualStyleBackColor = true;
            this.buttonswitch.Click += new System.EventHandler(this.buttonswitch_Click);
            // 
            // comboBoxnach
            // 
            this.comboBoxnach.FormattingEnabled = true;
            this.comboBoxnach.Location = new System.Drawing.Point(282, 56);
            this.comboBoxnach.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxnach.Name = "comboBoxnach";
            this.comboBoxnach.Size = new System.Drawing.Size(92, 21);
            this.comboBoxnach.TabIndex = 2;
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(31, 96);
            this.TimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(56, 20);
            this.TimePicker.TabIndex = 4;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(301, 96);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(73, 20);
            this.datePicker.TabIndex = 5;
            // 
            // buttonsuchen
            // 
            this.buttonsuchen.Location = new System.Drawing.Point(318, 143);
            this.buttonsuchen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsuchen.Name = "buttonsuchen";
            this.buttonsuchen.Size = new System.Drawing.Size(56, 19);
            this.buttonsuchen.TabIndex = 6;
            this.buttonsuchen.Text = "Suchen";
            this.buttonsuchen.UseVisualStyleBackColor = true;
            this.buttonsuchen.Click += new System.EventHandler(this.buttonsuchen_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.Location = new System.Drawing.Point(495, 317);
            this.buttonclose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(56, 19);
            this.buttonclose.TabIndex = 7;
            this.buttonclose.Text = "Close";
            this.buttonclose.UseVisualStyleBackColor = true;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // labelvon
            // 
            this.labelvon.AutoSize = true;
            this.labelvon.Location = new System.Drawing.Point(28, 30);
            this.labelvon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelvon.Name = "labelvon";
            this.labelvon.Size = new System.Drawing.Size(25, 13);
            this.labelvon.TabIndex = 8;
            this.labelvon.Text = "von";
            // 
            // labelnach
            // 
            this.labelnach.AutoSize = true;
            this.labelnach.Location = new System.Drawing.Point(279, 23);
            this.labelnach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnach.Name = "labelnach";
            this.labelnach.Size = new System.Drawing.Size(31, 13);
            this.labelnach.TabIndex = 9;
            this.labelnach.Text = "nach";
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(318, 120);
            this.buttonclear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(56, 19);
            this.buttonclear.TabIndex = 10;
            this.buttonclear.Text = "clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // comboBoxvon
            // 
            this.comboBoxvon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxvon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxvon.FormattingEnabled = true;
            this.comboBoxvon.Location = new System.Drawing.Point(30, 46);
            this.comboBoxvon.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxvon.Name = "comboBoxvon";
            this.comboBoxvon.Size = new System.Drawing.Size(92, 21);
            this.comboBoxvon.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonAnkunft);
            this.panel1.Controls.Add(this.radioButtonabfahrt);
            this.panel1.Location = new System.Drawing.Point(31, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 27);
            this.panel1.TabIndex = 14;
            // 
            // radioButtonAnkunft
            // 
            this.radioButtonAnkunft.AutoSize = true;
            this.radioButtonAnkunft.Location = new System.Drawing.Point(74, 2);
            this.radioButtonAnkunft.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonAnkunft.Name = "radioButtonAnkunft";
            this.radioButtonAnkunft.Size = new System.Drawing.Size(62, 17);
            this.radioButtonAnkunft.TabIndex = 1;
            this.radioButtonAnkunft.TabStop = true;
            this.radioButtonAnkunft.Text = "Ankunft";
            this.radioButtonAnkunft.UseVisualStyleBackColor = true;
            // 
            // radioButtonabfahrt
            // 
            this.radioButtonabfahrt.AutoSize = true;
            this.radioButtonabfahrt.Location = new System.Drawing.Point(2, 2);
            this.radioButtonabfahrt.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonabfahrt.Name = "radioButtonabfahrt";
            this.radioButtonabfahrt.Size = new System.Drawing.Size(59, 17);
            this.radioButtonabfahrt.TabIndex = 0;
            this.radioButtonabfahrt.TabStop = true;
            this.radioButtonabfahrt.Text = "Abfahrt";
            this.radioButtonabfahrt.UseVisualStyleBackColor = true;
            // 
            // lvConnections
            // 
            this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.lvConnections.Location = new System.Drawing.Point(12, 179);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(555, 123);
            this.lvConnections.TabIndex = 33;
            this.lvConnections.TileSize = new System.Drawing.Size(168, 30);
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Von";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nach";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Abfahrt";
            this.columnHeader2.Width = 46;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ankunft";
            this.columnHeader4.Width = 49;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dauer";
            this.columnHeader5.Width = 55;
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 366);
            this.Controls.Add(this.lvConnections);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxvon);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.labelnach);
            this.Controls.Add(this.labelvon);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.buttonsuchen);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.comboBoxnach);
            this.Controls.Add(this.buttonswitch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Verbindungen";
            this.Text = "Verbindungen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonswitch;
        private System.Windows.Forms.ComboBox comboBoxnach;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button buttonsuchen;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Label labelvon;
        private System.Windows.Forms.Label labelnach;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.ComboBox comboBoxvon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonAnkunft;
        private System.Windows.Forms.RadioButton radioButtonabfahrt;
        private System.Windows.Forms.ListView lvConnections;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

