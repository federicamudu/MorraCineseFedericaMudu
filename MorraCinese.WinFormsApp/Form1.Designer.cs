namespace MorraCinese.WinFormsApp
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
            this.btnSasso = new System.Windows.Forms.Button();
            this.btnCarta = new System.Windows.Forms.Button();
            this.btnForbici = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVS = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textEsito = new System.Windows.Forms.TextBox();
            this.labelGiocata = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSasso
            // 
            this.btnSasso.Location = new System.Drawing.Point(30, 164);
            this.btnSasso.Name = "btnSasso";
            this.btnSasso.Size = new System.Drawing.Size(212, 56);
            this.btnSasso.TabIndex = 0;
            this.btnSasso.Text = "Sasso";
            this.btnSasso.UseVisualStyleBackColor = true;
            this.btnSasso.Click += new System.EventHandler(this.btnSasso_Click);
            // 
            // btnCarta
            // 
            this.btnCarta.Location = new System.Drawing.Point(30, 237);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(212, 50);
            this.btnCarta.TabIndex = 1;
            this.btnCarta.Text = "Carta";
            this.btnCarta.UseVisualStyleBackColor = true;
            // 
            // btnForbici
            // 
            this.btnForbici.Location = new System.Drawing.Point(30, 301);
            this.btnForbici.Name = "btnForbici";
            this.btnForbici.Size = new System.Drawing.Size(214, 47);
            this.btnForbici.TabIndex = 2;
            this.btnForbici.Text = "Forbici";
            this.btnForbici.UseVisualStyleBackColor = true;
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(30, 418);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(214, 47);
            this.btnConferma.TabIndex = 3;
            this.btnConferma.Text = "Conferma!";
            this.btnConferma.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MorraCinese.WinFormsApp.Properties.Resources.sconosciuto;
            this.pictureBox1.Location = new System.Drawing.Point(286, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 184);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelVS
            // 
            this.labelVS.AutoSize = true;
            this.labelVS.Location = new System.Drawing.Point(489, 250);
            this.labelVS.Name = "labelVS";
            this.labelVS.Size = new System.Drawing.Size(33, 25);
            this.labelVS.TabIndex = 5;
            this.labelVS.Text = "VS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MorraCinese.WinFormsApp.Properties.Resources.sconosciuto;
            this.pictureBox2.Location = new System.Drawing.Point(528, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 184);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // textEsito
            // 
            this.textEsito.Location = new System.Drawing.Point(286, 434);
            this.textEsito.Name = "textEsito";
            this.textEsito.ReadOnly = true;
            this.textEsito.Size = new System.Drawing.Size(445, 31);
            this.textEsito.TabIndex = 7;
            // 
            // labelGiocata
            // 
            this.labelGiocata.AutoSize = true;
            this.labelGiocata.Location = new System.Drawing.Point(286, 389);
            this.labelGiocata.Name = "labelGiocata";
            this.labelGiocata.Size = new System.Drawing.Size(114, 25);
            this.labelGiocata.TabIndex = 8;
            this.labelGiocata.Text = "Esito Giocata";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Computer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGiocata);
            this.Controls.Add(this.textEsito);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelVS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.btnForbici);
            this.Controls.Add(this.btnCarta);
            this.Controls.Add(this.btnSasso);
            this.Name = "Form1";
            this.Text = "Morra Cinese";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSasso;
        private Button btnCarta;
        private Button btnForbici;
        private Button btnConferma;
        private PictureBox pictureBox1;
        private Label labelVS;
        private PictureBox pictureBox2;
        private TextBox textEsito;
        private Label labelGiocata;
        private Label label1;
        private Label label2;
    }
}