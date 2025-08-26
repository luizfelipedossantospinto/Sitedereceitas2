namespace Sitedereceitas2
{
    partial class FrmTelaInicial
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
            this.TXBNAME = new System.Windows.Forms.TextBox();
            this.TXBCPF = new System.Windows.Forms.TextBox();
            this.TXBRG = new System.Windows.Forms.TextBox();
            this.TXBADDRESS = new System.Windows.Forms.TextBox();
            this.TXBN = new System.Windows.Forms.TextBox();
            this.TXBBAIRO = new System.Windows.Forms.TextBox();
            this.TXBCITY = new System.Windows.Forms.TextBox();
            this.TXBCEP = new System.Windows.Forms.TextBox();
            this.TXBTEL = new System.Windows.Forms.TextBox();
            this.TXBCELL = new System.Windows.Forms.TextBox();
            this.TXBEMAIL = new System.Windows.Forms.TextBox();
            this.BTNREGISTER = new System.Windows.Forms.Button();
            this.BTNSAIR2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXBNAME
            // 
            this.TXBNAME.Location = new System.Drawing.Point(62, 241);
            this.TXBNAME.Name = "TXBNAME";
            this.TXBNAME.Size = new System.Drawing.Size(747, 20);
            this.TXBNAME.TabIndex = 0;
            // 
            // TXBCPF
            // 
            this.TXBCPF.Location = new System.Drawing.Point(99, 280);
            this.TXBCPF.Name = "TXBCPF";
            this.TXBCPF.Size = new System.Drawing.Size(310, 20);
            this.TXBCPF.TabIndex = 1;
            this.TXBCPF.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TXBRG
            // 
            this.TXBRG.Location = new System.Drawing.Point(450, 280);
            this.TXBRG.MaxLength = 12;
            this.TXBRG.Name = "TXBRG";
            this.TXBRG.Size = new System.Drawing.Size(359, 20);
            this.TXBRG.TabIndex = 2;
            this.TXBRG.TextChanged += new System.EventHandler(this.TXBRG_TextChanged);
            // 
            // TXBADDRESS
            // 
            this.TXBADDRESS.Location = new System.Drawing.Point(90, 319);
            this.TXBADDRESS.Name = "TXBADDRESS";
            this.TXBADDRESS.Size = new System.Drawing.Size(319, 20);
            this.TXBADDRESS.TabIndex = 3;
            // 
            // TXBN
            // 
            this.TXBN.Location = new System.Drawing.Point(440, 319);
            this.TXBN.Name = "TXBN";
            this.TXBN.Size = new System.Drawing.Size(369, 20);
            this.TXBN.TabIndex = 4;
            // 
            // TXBBAIRO
            // 
            this.TXBBAIRO.Location = new System.Drawing.Point(62, 358);
            this.TXBBAIRO.Name = "TXBBAIRO";
            this.TXBBAIRO.Size = new System.Drawing.Size(265, 20);
            this.TXBBAIRO.TabIndex = 5;
            // 
            // TXBCITY
            // 
            this.TXBCITY.Location = new System.Drawing.Point(390, 358);
            this.TXBCITY.Name = "TXBCITY";
            this.TXBCITY.Size = new System.Drawing.Size(222, 20);
            this.TXBCITY.TabIndex = 6;
            // 
            // TXBCEP
            // 
            this.TXBCEP.Location = new System.Drawing.Point(654, 358);
            this.TXBCEP.MaxLength = 9;
            this.TXBCEP.Name = "TXBCEP";
            this.TXBCEP.Size = new System.Drawing.Size(155, 20);
            this.TXBCEP.TabIndex = 7;
            // 
            // TXBTEL
            // 
            this.TXBTEL.Location = new System.Drawing.Point(81, 399);
            this.TXBTEL.Name = "TXBTEL";
            this.TXBTEL.Size = new System.Drawing.Size(219, 20);
            this.TXBTEL.TabIndex = 8;
            this.TXBTEL.TextChanged += new System.EventHandler(this.TXBTEL_TextChanged);
            // 
            // TXBCELL
            // 
            this.TXBCELL.Location = new System.Drawing.Point(369, 399);
            this.TXBCELL.Name = "TXBCELL";
            this.TXBCELL.Size = new System.Drawing.Size(440, 20);
            this.TXBCELL.TabIndex = 9;
            // 
            // TXBEMAIL
            // 
            this.TXBEMAIL.Location = new System.Drawing.Point(62, 437);
            this.TXBEMAIL.Name = "TXBEMAIL";
            this.TXBEMAIL.Size = new System.Drawing.Size(747, 20);
            this.TXBEMAIL.TabIndex = 10;
            // 
            // BTNREGISTER
            // 
            this.BTNREGISTER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTNREGISTER.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNREGISTER.Location = new System.Drawing.Point(654, 473);
            this.BTNREGISTER.Name = "BTNREGISTER";
            this.BTNREGISTER.Size = new System.Drawing.Size(155, 49);
            this.BTNREGISTER.TabIndex = 11;
            this.BTNREGISTER.Text = "CADASTRAR";
            this.BTNREGISTER.UseVisualStyleBackColor = false;
            this.BTNREGISTER.Click += new System.EventHandler(this.BTNREGISTER_Click);
            // 
            // BTNSAIR2
            // 
            this.BTNSAIR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTNSAIR2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSAIR2.Location = new System.Drawing.Point(496, 473);
            this.BTNSAIR2.Name = "BTNSAIR2";
            this.BTNSAIR2.Size = new System.Drawing.Size(152, 49);
            this.BTNSAIR2.TabIndex = 12;
            this.BTNSAIR2.Text = "SAIR";
            this.BTNSAIR2.UseVisualStyleBackColor = false;
            this.BTNSAIR2.Click += new System.EventHandler(this.BTNSAIR2_Click);
            // 
            // FrmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 534);
            this.Controls.Add(this.BTNSAIR2);
            this.Controls.Add(this.BTNREGISTER);
            this.Controls.Add(this.TXBEMAIL);
            this.Controls.Add(this.TXBCELL);
            this.Controls.Add(this.TXBTEL);
            this.Controls.Add(this.TXBCEP);
            this.Controls.Add(this.TXBCITY);
            this.Controls.Add(this.TXBBAIRO);
            this.Controls.Add(this.TXBN);
            this.Controls.Add(this.TXBADDRESS);
            this.Controls.Add(this.TXBRG);
            this.Controls.Add(this.TXBCPF);
            this.Controls.Add(this.TXBNAME);
            this.Name = "FrmTelaInicial";
            this.Text = "FrmTelaInicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXBNAME;
        private System.Windows.Forms.TextBox TXBCPF;
        private System.Windows.Forms.TextBox TXBRG;
        private System.Windows.Forms.TextBox TXBADDRESS;
        private System.Windows.Forms.TextBox TXBN;
        private System.Windows.Forms.TextBox TXBBAIRO;
        private System.Windows.Forms.TextBox TXBCITY;
        private System.Windows.Forms.TextBox TXBCEP;
        private System.Windows.Forms.TextBox TXBTEL;
        private System.Windows.Forms.TextBox TXBCELL;
        private System.Windows.Forms.TextBox TXBEMAIL;
        private System.Windows.Forms.Button BTNREGISTER;
        private System.Windows.Forms.Button BTNSAIR2;
    }
}