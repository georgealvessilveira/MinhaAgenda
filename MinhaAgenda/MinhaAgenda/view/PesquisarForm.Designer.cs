namespace MinhaAgenda
{
    partial class PesquisarForm
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
            this.pesquisaNomeRdb = new System.Windows.Forms.RadioButton();
            this.pesquisasGbx = new System.Windows.Forms.GroupBox();
            this.pesquisaIdRdb = new System.Windows.Forms.RadioButton();
            this.pesquisarNomeGbx = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pesquisaNomeTbx = new System.Windows.Forms.TextBox();
            this.pesquisarIdGbx = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pesquisaIdTbx = new System.Windows.Forms.ComboBox();
            this.pesquisarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.pesquisasGbx.SuspendLayout();
            this.pesquisarNomeGbx.SuspendLayout();
            this.pesquisarIdGbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // pesquisaNomeRdb
            // 
            this.pesquisaNomeRdb.AutoSize = true;
            this.pesquisaNomeRdb.Location = new System.Drawing.Point(35, 37);
            this.pesquisaNomeRdb.Name = "pesquisaNomeRdb";
            this.pesquisaNomeRdb.Size = new System.Drawing.Size(113, 17);
            this.pesquisaNomeRdb.TabIndex = 0;
            this.pesquisaNomeRdb.TabStop = true;
            this.pesquisaNomeRdb.Text = "Pequisar por nome";
            this.pesquisaNomeRdb.UseVisualStyleBackColor = true;
            this.pesquisaNomeRdb.CheckedChanged += new System.EventHandler(this.pesquisaNomeRdb_CheckedChanged);
            // 
            // pesquisasGbx
            // 
            this.pesquisasGbx.Controls.Add(this.pesquisaIdRdb);
            this.pesquisasGbx.Controls.Add(this.pesquisaNomeRdb);
            this.pesquisasGbx.Location = new System.Drawing.Point(12, 12);
            this.pesquisasGbx.Name = "pesquisasGbx";
            this.pesquisasGbx.Size = new System.Drawing.Size(423, 92);
            this.pesquisasGbx.TabIndex = 1;
            this.pesquisasGbx.TabStop = false;
            this.pesquisasGbx.Text = "Modo de pesquisa";
            // 
            // pesquisaIdRdb
            // 
            this.pesquisaIdRdb.AutoSize = true;
            this.pesquisaIdRdb.Location = new System.Drawing.Point(193, 37);
            this.pesquisaIdRdb.Name = "pesquisaIdRdb";
            this.pesquisaIdRdb.Size = new System.Drawing.Size(101, 17);
            this.pesquisaIdRdb.TabIndex = 1;
            this.pesquisaIdRdb.TabStop = true;
            this.pesquisaIdRdb.Text = "Pesquisar por Id";
            this.pesquisaIdRdb.UseVisualStyleBackColor = true;
            this.pesquisaIdRdb.CheckedChanged += new System.EventHandler(this.pesquisaIdRdb_CheckedChanged);
            // 
            // pesquisarNomeGbx
            // 
            this.pesquisarNomeGbx.Controls.Add(this.label1);
            this.pesquisarNomeGbx.Controls.Add(this.pesquisaNomeTbx);
            this.pesquisarNomeGbx.Location = new System.Drawing.Point(12, 110);
            this.pesquisarNomeGbx.Name = "pesquisarNomeGbx";
            this.pesquisarNomeGbx.Size = new System.Drawing.Size(423, 82);
            this.pesquisarNomeGbx.TabIndex = 2;
            this.pesquisarNomeGbx.TabStop = false;
            this.pesquisarNomeGbx.Text = "Pesquisa por nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // pesquisaNomeTbx
            // 
            this.pesquisaNomeTbx.Location = new System.Drawing.Point(111, 36);
            this.pesquisaNomeTbx.Name = "pesquisaNomeTbx";
            this.pesquisaNomeTbx.Size = new System.Drawing.Size(225, 20);
            this.pesquisaNomeTbx.TabIndex = 0;
            // 
            // pesquisarIdGbx
            // 
            this.pesquisarIdGbx.Controls.Add(this.label2);
            this.pesquisarIdGbx.Controls.Add(this.pesquisaIdTbx);
            this.pesquisarIdGbx.Location = new System.Drawing.Point(12, 110);
            this.pesquisarIdGbx.Name = "pesquisarIdGbx";
            this.pesquisarIdGbx.Size = new System.Drawing.Size(423, 82);
            this.pesquisarIdGbx.TabIndex = 3;
            this.pesquisarIdGbx.TabStop = false;
            this.pesquisarIdGbx.Text = "Pesquisa por Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escolha o id:";
            // 
            // pesquisaIdTbx
            // 
            this.pesquisaIdTbx.FormattingEnabled = true;
            this.pesquisaIdTbx.Location = new System.Drawing.Point(111, 40);
            this.pesquisaIdTbx.Name = "pesquisaIdTbx";
            this.pesquisaIdTbx.Size = new System.Drawing.Size(70, 21);
            this.pesquisaIdTbx.TabIndex = 0;
            // 
            // pesquisarBtn
            // 
            this.pesquisarBtn.Location = new System.Drawing.Point(282, 313);
            this.pesquisarBtn.Name = "pesquisarBtn";
            this.pesquisarBtn.Size = new System.Drawing.Size(142, 35);
            this.pesquisarBtn.TabIndex = 4;
            this.pesquisarBtn.Text = "Pesquisar";
            this.pesquisarBtn.UseVisualStyleBackColor = true;
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(123, 313);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(142, 35);
            this.cancelarBtn.TabIndex = 5;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // PesquisarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 360);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.pesquisarBtn);
            this.Controls.Add(this.pesquisarIdGbx);
            this.Controls.Add(this.pesquisarNomeGbx);
            this.Controls.Add(this.pesquisasGbx);
            this.Name = "PesquisarForm";
            this.Text = "PesquisarForm";
            this.pesquisasGbx.ResumeLayout(false);
            this.pesquisasGbx.PerformLayout();
            this.pesquisarNomeGbx.ResumeLayout(false);
            this.pesquisarNomeGbx.PerformLayout();
            this.pesquisarIdGbx.ResumeLayout(false);
            this.pesquisarIdGbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton pesquisaNomeRdb;
        private System.Windows.Forms.GroupBox pesquisasGbx;
        private System.Windows.Forms.RadioButton pesquisaIdRdb;
        private System.Windows.Forms.GroupBox pesquisarNomeGbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pesquisaNomeTbx;
        private System.Windows.Forms.GroupBox pesquisarIdGbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pesquisaIdTbx;
        private System.Windows.Forms.Button pesquisarBtn;
        private System.Windows.Forms.Button cancelarBtn;
    }
}