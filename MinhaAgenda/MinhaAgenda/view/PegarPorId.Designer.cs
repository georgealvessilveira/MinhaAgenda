namespace MinhaAgenda.view
{
    partial class PegarPorId
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idTbx = new System.Windows.Forms.TextBox();
            this.nomeTbx = new System.Windows.Forms.TextBox();
            this.emailTbx = new System.Windows.Forms.TextBox();
            this.telefoneTbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.removerBtn = new System.Windows.Forms.Button();
            this.atualizarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // idTbx
            // 
            this.idTbx.Location = new System.Drawing.Point(136, 45);
            this.idTbx.Name = "idTbx";
            this.idTbx.Size = new System.Drawing.Size(210, 20);
            this.idTbx.TabIndex = 4;
            // 
            // nomeTbx
            // 
            this.nomeTbx.Enabled = false;
            this.nomeTbx.Location = new System.Drawing.Point(136, 90);
            this.nomeTbx.Name = "nomeTbx";
            this.nomeTbx.Size = new System.Drawing.Size(210, 20);
            this.nomeTbx.TabIndex = 5;
            // 
            // emailTbx
            // 
            this.emailTbx.Enabled = false;
            this.emailTbx.Location = new System.Drawing.Point(136, 132);
            this.emailTbx.Name = "emailTbx";
            this.emailTbx.Size = new System.Drawing.Size(210, 20);
            this.emailTbx.TabIndex = 6;
            // 
            // telefoneTbx
            // 
            this.telefoneTbx.Enabled = false;
            this.telefoneTbx.Location = new System.Drawing.Point(136, 174);
            this.telefoneTbx.Name = "telefoneTbx";
            this.telefoneTbx.Size = new System.Drawing.Size(210, 20);
            this.telefoneTbx.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Buscar!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // removerBtn
            // 
            this.removerBtn.Enabled = false;
            this.removerBtn.Location = new System.Drawing.Point(111, 266);
            this.removerBtn.Name = "removerBtn";
            this.removerBtn.Size = new System.Drawing.Size(98, 40);
            this.removerBtn.TabIndex = 9;
            this.removerBtn.Text = "&Remover!";
            this.removerBtn.UseVisualStyleBackColor = true;
            this.removerBtn.Click += new System.EventHandler(this.removerBtn_Click);
            // 
            // atualizarBtn
            // 
            this.atualizarBtn.Enabled = false;
            this.atualizarBtn.Location = new System.Drawing.Point(215, 266);
            this.atualizarBtn.Name = "atualizarBtn";
            this.atualizarBtn.Size = new System.Drawing.Size(98, 40);
            this.atualizarBtn.TabIndex = 10;
            this.atualizarBtn.Text = "&Atualizar!";
            this.atualizarBtn.UseVisualStyleBackColor = true;
            this.atualizarBtn.Click += new System.EventHandler(this.atualizarBtn_Click);
            // 
            // PegarPorId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 327);
            this.Controls.Add(this.atualizarBtn);
            this.Controls.Add(this.removerBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telefoneTbx);
            this.Controls.Add(this.emailTbx);
            this.Controls.Add(this.nomeTbx);
            this.Controls.Add(this.idTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PegarPorId";
            this.Text = "PegarPorId";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idTbx;
        private System.Windows.Forms.TextBox nomeTbx;
        private System.Windows.Forms.TextBox emailTbx;
        private System.Windows.Forms.TextBox telefoneTbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button removerBtn;
        private System.Windows.Forms.Button atualizarBtn;
    }
}