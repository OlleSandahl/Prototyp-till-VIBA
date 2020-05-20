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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Ordernummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organisationsnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 126);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Plocklista";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 36;
            this.button1.Text = "Vara plockad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 22);
            this.button4.TabIndex = 42;
            this.button4.Text = "Sök";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Sök order";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(274, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(152, 20);
            this.textBox7.TabIndex = 40;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ordernummer,
            this.Organisationsnummer,
            this.Namn,
            this.Pris});
            this.dataGridView2.Location = new System.Drawing.Point(20, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(476, 124);
            this.dataGridView2.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ordrar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 32);
            this.button2.TabIndex = 44;
            this.button2.Text = "Skapa plocklista";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Ordernummer
            // 
            this.Ordernummer.HeaderText = "Ordernummer";
            this.Ordernummer.Name = "Ordernummer";
            // 
            // Organisationsnummer
            // 
            this.Organisationsnummer.HeaderText = "Organisationsnummer";
            this.Organisationsnummer.Name = "Organisationsnummer";
            this.Organisationsnummer.Width = 130;
            // 
            // Namn
            // 
            this.Namn.HeaderText = "Namn";
            this.Namn.Name = "Namn";
            // 
            // Pris
            // 
            this.Pris.HeaderText = "Pris";
            this.Pris.Name = "Pris";
            // 
            // Lagerhantering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 472);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lagerhantering";
            this.Text = "Lagerhantering";
            this.Load += new System.EventHandler(this.Lagerhantering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikelnamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hylla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Antal;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordernummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organisationsnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}