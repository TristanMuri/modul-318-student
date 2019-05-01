namespace SwissTransport
{
    partial class FormsVerbindungen
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
            this.listBoxverbindungen = new System.Windows.Forms.ListBox();
            this.textBoxvon = new System.Windows.Forms.TextBox();
            this.textBoxnach = new System.Windows.Forms.TextBox();
            this.labelvon = new System.Windows.Forms.Label();
            this.labelnach = new System.Windows.Forms.Label();
            this.textBoxasugangszeit = new System.Windows.Forms.TextBox();
            this.labelausgangszeit = new System.Windows.Forms.Label();
            this.buttonsuchen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxverbindungen
            // 
            this.listBoxverbindungen.FormattingEnabled = true;
            this.listBoxverbindungen.ItemHeight = 16;
            this.listBoxverbindungen.Location = new System.Drawing.Point(-1, 188);
            this.listBoxverbindungen.Name = "listBoxverbindungen";
            this.listBoxverbindungen.Size = new System.Drawing.Size(621, 260);
            this.listBoxverbindungen.TabIndex = 0;
            // 
            // textBoxvon
            // 
            this.textBoxvon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxvon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBoxvon.Location = new System.Drawing.Point(64, 75);
            this.textBoxvon.Name = "textBoxvon";
            this.textBoxvon.Size = new System.Drawing.Size(132, 22);
            this.textBoxvon.TabIndex = 1;
            // 
            // textBoxnach
            // 
            this.textBoxnach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxnach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBoxnach.Location = new System.Drawing.Point(319, 75);
            this.textBoxnach.Name = "textBoxnach";
            this.textBoxnach.Size = new System.Drawing.Size(140, 22);
            this.textBoxnach.TabIndex = 2;
            // 
            // labelvon
            // 
            this.labelvon.AutoSize = true;
            this.labelvon.Location = new System.Drawing.Point(61, 55);
            this.labelvon.Name = "labelvon";
            this.labelvon.Size = new System.Drawing.Size(33, 17);
            this.labelvon.TabIndex = 3;
            this.labelvon.Text = "Von";
            // 
            // labelnach
            // 
            this.labelnach.AutoSize = true;
            this.labelnach.Location = new System.Drawing.Point(316, 55);
            this.labelnach.Name = "labelnach";
            this.labelnach.Size = new System.Drawing.Size(41, 17);
            this.labelnach.TabIndex = 4;
            this.labelnach.Text = "Nach";
            // 
            // textBoxasugangszeit
            // 
            this.textBoxasugangszeit.Location = new System.Drawing.Point(64, 131);
            this.textBoxasugangszeit.Name = "textBoxasugangszeit";
            this.textBoxasugangszeit.Size = new System.Drawing.Size(100, 22);
            this.textBoxasugangszeit.TabIndex = 5;
            // 
            // labelausgangszeit
            // 
            this.labelausgangszeit.AutoSize = true;
            this.labelausgangszeit.Location = new System.Drawing.Point(61, 111);
            this.labelausgangszeit.Name = "labelausgangszeit";
            this.labelausgangszeit.Size = new System.Drawing.Size(93, 17);
            this.labelausgangszeit.TabIndex = 6;
            this.labelausgangszeit.Text = "Ausgangszeit";
            // 
            // buttonsuchen
            // 
            this.buttonsuchen.Location = new System.Drawing.Point(216, 130);
            this.buttonsuchen.Name = "buttonsuchen";
            this.buttonsuchen.Size = new System.Drawing.Size(75, 23);
            this.buttonsuchen.TabIndex = 7;
            this.buttonsuchen.Text = "Suchen";
            this.buttonsuchen.UseVisualStyleBackColor = true;
            this.buttonsuchen.Click += new System.EventHandler(this.buttonsuchen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "wechseln";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormsVerbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(620, 434);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonsuchen);
            this.Controls.Add(this.labelausgangszeit);
            this.Controls.Add(this.textBoxasugangszeit);
            this.Controls.Add(this.labelnach);
            this.Controls.Add(this.labelvon);
            this.Controls.Add(this.textBoxnach);
            this.Controls.Add(this.textBoxvon);
            this.Controls.Add(this.listBoxverbindungen);
            this.Name = "FormsVerbindungen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxverbindungen;
        private System.Windows.Forms.TextBox textBoxvon;
        private System.Windows.Forms.TextBox textBoxnach;
        private System.Windows.Forms.Label labelvon;
        private System.Windows.Forms.Label labelnach;
        private System.Windows.Forms.TextBox textBoxasugangszeit;
        private System.Windows.Forms.Label labelausgangszeit;
        private System.Windows.Forms.Button buttonsuchen;
        private System.Windows.Forms.Button button1;
    }
}