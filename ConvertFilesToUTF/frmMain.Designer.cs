namespace ConvertFilesToUTF
{
    partial class frmMain
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasta = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnPasta = new System.Windows.Forms.Button();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.lblpgb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchPatern = new System.Windows.Forms.TextBox();
            this.btnCopiarNomeArquivos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasta:";
            // 
            // txtPasta
            // 
            this.txtPasta.Location = new System.Drawing.Point(53, 13);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(697, 20);
            this.txtPasta.TabIndex = 1;
            this.txtPasta.Text = "K:\\DORIATI_GIT\\JooMob3Git\\administrator\\components\\com_joomob";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(714, 79);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnPasta
            // 
            this.btnPasta.Location = new System.Drawing.Point(756, 11);
            this.btnPasta.Name = "btnPasta";
            this.btnPasta.Size = new System.Drawing.Size(33, 23);
            this.btnPasta.TabIndex = 3;
            this.btnPasta.Text = "...";
            this.btnPasta.UseVisualStyleBackColor = true;
            this.btnPasta.Click += new System.EventHandler(this.btnPasta_Click);
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(15, 52);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(774, 21);
            this.pgb.TabIndex = 4;
            // 
            // lblpgb
            // 
            this.lblpgb.AutoSize = true;
            this.lblpgb.Location = new System.Drawing.Point(12, 36);
            this.lblpgb.Name = "lblpgb";
            this.lblpgb.Size = new System.Drawing.Size(37, 13);
            this.lblpgb.TabIndex = 5;
            this.lblpgb.Text = "0 de 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de arquivos:";
            // 
            // txtSearchPatern
            // 
            this.txtSearchPatern.Location = new System.Drawing.Point(107, 84);
            this.txtSearchPatern.Name = "txtSearchPatern";
            this.txtSearchPatern.Size = new System.Drawing.Size(263, 20);
            this.txtSearchPatern.TabIndex = 7;
            this.txtSearchPatern.Text = "*.php";
            // 
            // btnCopiarNomeArquivos
            // 
            this.btnCopiarNomeArquivos.Location = new System.Drawing.Point(567, 80);
            this.btnCopiarNomeArquivos.Name = "btnCopiarNomeArquivos";
            this.btnCopiarNomeArquivos.Size = new System.Drawing.Size(141, 23);
            this.btnCopiarNomeArquivos.TabIndex = 8;
            this.btnCopiarNomeArquivos.Text = "Copiar Nome Arquivos";
            this.btnCopiarNomeArquivos.UseVisualStyleBackColor = true;
            this.btnCopiarNomeArquivos.Click += new System.EventHandler(this.btnCopiarNomeArquivos_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 115);
            this.Controls.Add(this.btnCopiarNomeArquivos);
            this.Controls.Add(this.txtSearchPatern);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpgb);
            this.Controls.Add(this.pgb);
            this.Controls.Add(this.btnPasta);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.txtPasta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Convert File To UTF8 WithBOM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasta;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnPasta;
        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.Label lblpgb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchPatern;
        private System.Windows.Forms.Button btnCopiarNomeArquivos;
    }
}

