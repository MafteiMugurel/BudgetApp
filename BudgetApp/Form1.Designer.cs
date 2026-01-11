namespace BudgetApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSuma = new TextBox();
            txtCategorie = new TextBox();
            rbVenit = new RadioButton();
            rbCheltuiala = new RadioButton();
            btnAdauga = new Button();
            btnRaport = new Button();
            lstAfisare = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnSterge = new Button();
            lblBalanta = new Label();
            dtpData = new DateTimePicker();
            SuspendLayout();
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(54, 96);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(145, 23);
            txtSuma.TabIndex = 0;
            txtSuma.KeyPress += txtSuma_KeyPress;
            // 
            // txtCategorie
            // 
            txtCategorie.Location = new Point(373, 96);
            txtCategorie.Name = "txtCategorie";
            txtCategorie.Size = new Size(149, 23);
            txtCategorie.TabIndex = 1;
            // 
            // rbVenit
            // 
            rbVenit.AutoSize = true;
            rbVenit.Location = new Point(373, 142);
            rbVenit.Name = "rbVenit";
            rbVenit.Size = new Size(51, 19);
            rbVenit.TabIndex = 2;
            rbVenit.Text = "Venit";
            rbVenit.UseVisualStyleBackColor = true;
            // 
            // rbCheltuiala
            // 
            rbCheltuiala.AutoSize = true;
            rbCheltuiala.Checked = true;
            rbCheltuiala.Location = new Point(373, 167);
            rbCheltuiala.Name = "rbCheltuiala";
            rbCheltuiala.Size = new Size(78, 19);
            rbCheltuiala.TabIndex = 3;
            rbCheltuiala.TabStop = true;
            rbCheltuiala.Text = "Cheltuiala";
            rbCheltuiala.UseVisualStyleBackColor = true;
            // 
            // btnAdauga
            // 
            btnAdauga.Location = new Point(373, 218);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(149, 23);
            btnAdauga.TabIndex = 4;
            btnAdauga.Text = "Adauga Tranzactie";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // btnRaport
            // 
            btnRaport.Location = new Point(373, 276);
            btnRaport.Name = "btnRaport";
            btnRaport.Size = new Size(149, 26);
            btnRaport.TabIndex = 5;
            btnRaport.Text = "Genereaza Raport";
            btnRaport.UseVisualStyleBackColor = true;
            btnRaport.Click += btnRaport_Click;
            // 
            // lstAfisare
            // 
            lstAfisare.FormattingEnabled = true;
            lstAfisare.ItemHeight = 15;
            lstAfisare.Location = new Point(552, 78);
            lstAfisare.Name = "lstAfisare";
            lstAfisare.Size = new Size(328, 379);
            lstAfisare.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 78);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 7;
            label1.Text = "Suma (RON)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 78);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 8;
            label2.Text = "Categorie";
            // 
            // btnSterge
            // 
            btnSterge.Location = new Point(373, 247);
            btnSterge.Name = "btnSterge";
            btnSterge.Size = new Size(149, 23);
            btnSterge.TabIndex = 9;
            btnSterge.Text = "Sterge Tranzactie";
            btnSterge.UseVisualStyleBackColor = true;
            btnSterge.Click += btnSterge_Click;
            // 
            // lblBalanta
            // 
            lblBalanta.AutoSize = true;
            lblBalanta.Font = new Font("Segoe UI", 14F);
            lblBalanta.Location = new Point(886, 78);
            lblBalanta.Name = "lblBalanta";
            lblBalanta.Size = new Size(138, 25);
            lblBalanta.TabIndex = 10;
            lblBalanta.Text = "Balanta: 0 RON";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(54, 138);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 686);
            Controls.Add(dtpData);
            Controls.Add(lblBalanta);
            Controls.Add(btnSterge);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstAfisare);
            Controls.Add(btnRaport);
            Controls.Add(btnAdauga);
            Controls.Add(rbCheltuiala);
            Controls.Add(rbVenit);
            Controls.Add(txtCategorie);
            Controls.Add(txtSuma);
            Font = new Font("Segoe UI", 9F);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSuma;
        private TextBox txtCategorie;
        private RadioButton rbVenit;
        private RadioButton rbCheltuiala;
        private Button btnAdauga;
        private Button btnRaport;
        private ListBox lstAfisare;
        private Label label1;
        private Label label2;
        private Button btnSterge;
        private Label lblBalanta;
        private DateTimePicker dtpData;
    }
}
