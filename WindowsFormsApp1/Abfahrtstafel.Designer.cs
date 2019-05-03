namespace WindowsFormsApp1
{
    partial class Abfahrtstafel
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
            this.textBoxAbfahrtstabelle = new System.Windows.Forms.TextBox();
            this.listStation = new System.Windows.Forms.ListBox();
            this.buttonabfahrtsuchen = new System.Windows.Forms.Button();
            this.lvAbfahrt = new System.Windows.Forms.ListView();
            this.Kategorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Numemer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBoxAbfahrtstabelle
            // 
            this.textBoxAbfahrtstabelle.Location = new System.Drawing.Point(16, 41);
            this.textBoxAbfahrtstabelle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAbfahrtstabelle.Name = "textBoxAbfahrtstabelle";
            this.textBoxAbfahrtstabelle.Size = new System.Drawing.Size(161, 22);
            this.textBoxAbfahrtstabelle.TabIndex = 35;
            this.textBoxAbfahrtstabelle.TextChanged += new System.EventHandler(this.textchanged);
            // 
            // listStation
            // 
            this.listStation.FormattingEnabled = true;
            this.listStation.ItemHeight = 16;
            this.listStation.Location = new System.Drawing.Point(16, 73);
            this.listStation.Margin = new System.Windows.Forms.Padding(4);
            this.listStation.Name = "listStation";
            this.listStation.Size = new System.Drawing.Size(161, 20);
            this.listStation.TabIndex = 36;
            this.listStation.Click += new System.EventHandler(this.liststationclick);
            // 
            // buttonabfahrtsuchen
            // 
            this.buttonabfahrtsuchen.Location = new System.Drawing.Point(193, 39);
            this.buttonabfahrtsuchen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonabfahrtsuchen.Name = "buttonabfahrtsuchen";
            this.buttonabfahrtsuchen.Size = new System.Drawing.Size(75, 23);
            this.buttonabfahrtsuchen.TabIndex = 39;
            this.buttonabfahrtsuchen.Text = "Suchen";
            this.buttonabfahrtsuchen.UseVisualStyleBackColor = true;
            this.buttonabfahrtsuchen.Click += new System.EventHandler(this.buttonabfahrtsuchen_Click_1);
            // 
            // lvAbfahrt
            // 
            this.lvAbfahrt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Kategorie,
            this.Numemer,
            this.Nach});
            this.lvAbfahrt.Location = new System.Drawing.Point(16, 114);
            this.lvAbfahrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAbfahrt.Name = "lvAbfahrt";
            this.lvAbfahrt.Size = new System.Drawing.Size(447, 152);
            this.lvAbfahrt.TabIndex = 40;
            this.lvAbfahrt.UseCompatibleStateImageBehavior = false;
            this.lvAbfahrt.View = System.Windows.Forms.View.Details;
            // 
            // Kategorie
            // 
            this.Kategorie.Text = "Kategorie";
            this.Kategorie.Width = 100;
            // 
            // Numemer
            // 
            this.Numemer.Text = "Nummer";
            this.Numemer.Width = 100;
            // 
            // Nach
            // 
            this.Nach.Text = "Nach";
            this.Nach.Width = 130;
            // 
            // Abfahrtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 318);
            this.Controls.Add(this.lvAbfahrt);
            this.Controls.Add(this.buttonabfahrtsuchen);
            this.Controls.Add(this.listStation);
            this.Controls.Add(this.textBoxAbfahrtstabelle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Abfahrtstafel";
            this.Text = "Abfahrts Tafel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAbfahrtstabelle;
        private System.Windows.Forms.ListBox listStation;
        private System.Windows.Forms.Button buttonabfahrtsuchen;
        private System.Windows.Forms.ListView lvAbfahrt;
        private System.Windows.Forms.ColumnHeader Kategorie;
        private System.Windows.Forms.ColumnHeader Numemer;
        private System.Windows.Forms.ColumnHeader Nach;
    }
}