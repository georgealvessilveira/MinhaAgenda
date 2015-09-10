namespace MinhaAgenda
{
    partial class PegarId
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
            this.adicionarContatoBtn = new System.Windows.Forms.Button();
            this.mostrarTodosBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adicionarContatoBtn
            // 
            this.adicionarContatoBtn.Location = new System.Drawing.Point(12, 43);
            this.adicionarContatoBtn.Name = "adicionarContatoBtn";
            this.adicionarContatoBtn.Size = new System.Drawing.Size(120, 57);
            this.adicionarContatoBtn.TabIndex = 0;
            this.adicionarContatoBtn.Text = "&Adicionar contato";
            this.adicionarContatoBtn.UseVisualStyleBackColor = true;
            this.adicionarContatoBtn.Click += new System.EventHandler(this.adicionarContatoBtn_Click);
            // 
            // mostrarTodosBtn
            // 
            this.mostrarTodosBtn.Location = new System.Drawing.Point(12, 106);
            this.mostrarTodosBtn.Name = "mostrarTodosBtn";
            this.mostrarTodosBtn.Size = new System.Drawing.Size(120, 54);
            this.mostrarTodosBtn.TabIndex = 1;
            this.mostrarTodosBtn.Text = "&Mostrar Todos";
            this.mostrarTodosBtn.UseVisualStyleBackColor = true;
            this.mostrarTodosBtn.Click += new System.EventHandler(this.mostrarTodosBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pegar Por Id";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PegarId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mostrarTodosBtn);
            this.Controls.Add(this.adicionarContatoBtn);
            this.Name = "PegarId";
            this.Text = "Agenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adicionarContatoBtn;
        private System.Windows.Forms.Button mostrarTodosBtn;
        private System.Windows.Forms.Button button1;
    }
}

