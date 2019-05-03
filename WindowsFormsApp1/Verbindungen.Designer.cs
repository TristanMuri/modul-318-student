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
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonsuchen = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.labelvon = new System.Windows.Forms.Label();
            this.labelnach = new System.Windows.Forms.Label();
            this.buttonclear = new System.Windows.Forms.Button();
            this.lvConnections = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonabfahrtstafel = new System.Windows.Forms.Button();
            this.listvonStation = new System.Windows.Forms.ListBox();
            this.textBoxvon = new System.Windows.Forms.TextBox();
            this.listnachstation = new System.Windows.Forms.ListBox();
            this.textBoxnach = new System.Windows.Forms.TextBox();
            this.buttonlocation = new System.Windows.Forms.Button();
            this.buttonmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonswitch
            // 
            this.buttonswitch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonswitch.BackgroundImage")));
            this.buttonswitch.Location = new System.Drawing.Point(188, 34);
            this.buttonswitch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonswitch.Name = "buttonswitch";
            this.buttonswitch.Size = new System.Drawing.Size(40, 43);
            this.buttonswitch.TabIndex = 0;
            this.buttonswitch.UseVisualStyleBackColor = true;
            this.buttonswitch.Click += new System.EventHandler(this.buttonswitch_Click);
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(30, 143);
            this.TimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(84, 20);
            this.TimePicker.TabIndex = 4;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(137, 143);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(73, 20);
            this.datePicker.TabIndex = 5;
            // 
            // buttonsuchen
            // 
            this.buttonsuchen.Location = new System.Drawing.Point(406, 46);
            this.buttonsuchen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.buttonclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.labelnach.Location = new System.Drawing.Point(262, 29);
            this.labelnach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnach.Name = "labelnach";
            this.labelnach.Size = new System.Drawing.Size(31, 13);
            this.labelnach.TabIndex = 9;
            this.labelnach.Text = "nach";
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(406, 98);
            this.buttonclear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(56, 19);
            this.buttonclear.TabIndex = 10;
            this.buttonclear.Text = "clear";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // lvConnections
            // 
            this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.lvConnections.Location = new System.Drawing.Point(10, 180);
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
            // buttonabfahrtstafel
            // 
            this.buttonabfahrtstafel.Location = new System.Drawing.Point(264, 143);
            this.buttonabfahrtstafel.Name = "buttonabfahrtstafel";
            this.buttonabfahrtstafel.Size = new System.Drawing.Size(83, 23);
            this.buttonabfahrtstafel.TabIndex = 34;
            this.buttonabfahrtstafel.Text = "Abfahrtstafel";
            this.buttonabfahrtstafel.UseVisualStyleBackColor = true;
            this.buttonabfahrtstafel.Click += new System.EventHandler(this.buttonabfahrtstafel_Click);
            // 
            // listvonStation
            // 
            this.listvonStation.FormattingEnabled = true;
            this.listvonStation.Location = new System.Drawing.Point(30, 72);
            this.listvonStation.Name = "listvonStation";
            this.listvonStation.Size = new System.Drawing.Size(122, 56);
            this.listvonStation.TabIndex = 38;
            this.listvonStation.Click += new System.EventHandler(this.listclickautocompletevon);
            // 
            // textBoxvon
            // 
            this.textBoxvon.Location = new System.Drawing.Point(30, 46);
            this.textBoxvon.Name = "textBoxvon";
            this.textBoxvon.Size = new System.Drawing.Size(122, 20);
            this.textBoxvon.TabIndex = 37;
            this.textBoxvon.TextChanged += new System.EventHandler(this.txtchangevonstation);
            // 
            // listnachstation
            // 
            this.listnachstation.FormattingEnabled = true;
            this.listnachstation.Location = new System.Drawing.Point(264, 72);
            this.listnachstation.Name = "listnachstation";
            this.listnachstation.Size = new System.Drawing.Size(122, 56);
            this.listnachstation.TabIndex = 40;
            this.listnachstation.Click += new System.EventHandler(this.listclickautocompletenach);
            // 
            // textBoxnach
            // 
            this.textBoxnach.Location = new System.Drawing.Point(264, 46);
            this.textBoxnach.Name = "textBoxnach";
            this.textBoxnach.Size = new System.Drawing.Size(122, 20);
            this.textBoxnach.TabIndex = 39;
            this.textBoxnach.TextChanged += new System.EventHandler(this.txtchangenachstation);
            // 
            // buttonlocation
            // 
            this.buttonlocation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonlocation.BackgroundImage")));
            this.buttonlocation.Location = new System.Drawing.Point(495, 27);
            this.buttonlocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonlocation.Name = "buttonlocation";
            this.buttonlocation.Size = new System.Drawing.Size(60, 56);
            this.buttonlocation.TabIndex = 41;
            this.buttonlocation.UseVisualStyleBackColor = true;
            this.buttonlocation.Click += new System.EventHandler(this.buttonlocation_Click);
            // 
            // buttonmail
            // 
            this.buttonmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonmail.BackgroundImage")));
            this.buttonmail.Location = new System.Drawing.Point(495, 98);
            this.buttonmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonmail.Name = "buttonmail";
            this.buttonmail.Size = new System.Drawing.Size(69, 63);
            this.buttonmail.TabIndex = 42;
            this.buttonmail.UseVisualStyleBackColor = true;
            this.buttonmail.Click += new System.EventHandler(this.buttonmail_Click);
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 366);
            this.Controls.Add(this.buttonmail);
            this.Controls.Add(this.buttonlocation);
            this.Controls.Add(this.listnachstation);
            this.Controls.Add(this.textBoxnach);
            this.Controls.Add(this.listvonStation);
            this.Controls.Add(this.textBoxvon);
            this.Controls.Add(this.buttonabfahrtstafel);
            this.Controls.Add(this.lvConnections);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.labelnach);
            this.Controls.Add(this.labelvon);
            this.Controls.Add(this.buttonclose);
            this.Controls.Add(this.buttonsuchen);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.buttonswitch);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Verbindungen";
            this.Text = "Verbindungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonswitch;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button buttonsuchen;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Label labelvon;
        private System.Windows.Forms.Label labelnach;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.ListView lvConnections;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonabfahrtstafel;
        private System.Windows.Forms.ListBox listvonStation;
        private System.Windows.Forms.TextBox textBoxvon;
        private System.Windows.Forms.ListBox listnachstation;
        private System.Windows.Forms.TextBox textBoxnach;
        private System.Windows.Forms.Button buttonlocation;
        private System.Windows.Forms.Button buttonmail;
    }
}

