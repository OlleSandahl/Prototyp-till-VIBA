namespace VIBA
{
    partial class Lagerhantering
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Artikelnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artikelnamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hylla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Siffra2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Siffra1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artikelnummer,
            this.Artikelnamn,
            this.Hylla,
            this.Antal});
            this.dataGridView1.Location = new System.Drawing.Point(16, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 126);
            this.dataGridView1.TabIndex = 0;
            // 
            // Artikelnummer
            // 
            this.Artikelnummer.HeaderText = "Artikelnummer";
            this.Artikelnummer.Name = "Artikelnummer";
            // 
            // Artikelnamn
            // 
            this.Artikelnamn.HeaderText = "Artikelnamn";
            this.Artikelnamn.Name = "Artikelnamn";
            // 
            // Hylla
            // 
            this.Hylla.HeaderText = "Hylla";
            this.Hylla.Name = "Hylla";
            // 
            // Antal
            // 
            this.Antal.HeaderText = "Antal";
            this.Antal.Name = "Antal";
            // 
            // Siffra2
            // 
            this.Siffra2.FormattingEnabled = true;
            this.Siffra2.Location = new System.Drawing.Point(239, 42);
            this.Siffra2.Name = "Siffra2";
            this.Siffra2.Size = new System.Drawing.Size(91, 30);
            this.Siffra2.TabIndex = 33;
            this.Siffra2.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ordrar i kö";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Aktuell plocklista";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 36;
            this.button1.Text = "Vara plockad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "PlockID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Siffra1
            // 
            this.Siffra1.FormattingEnabled = true;
            this.Siffra1.Location = new System.Drawing.Point(20, 42);
            this.Siffra1.Name = "Siffra1";
            this.Siffra1.Size = new System.Drawing.Size(91, 30);
            this.Siffra1.TabIndex = 37;
            this.Siffra1.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // Lagerhantering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 288);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Siffra1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Siffra2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lagerhantering";
            this.Text = "Lagerhantering";
            this.Load += new System.EventHandler(this.Lagerhantering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox Siffra2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hylla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Siffra1;
    }
}