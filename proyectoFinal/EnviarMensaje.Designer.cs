namespace proyectoFinal
{
    partial class EnviarMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarMensaje));
            this.label1 = new System.Windows.Forms.Label();
            this.Para = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtRedactar = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enviar mensaje";
            // 
            // Para
            // 
            this.Para.AutoSize = true;
            this.Para.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Para.Location = new System.Drawing.Point(12, 111);
            this.Para.Name = "Para";
            this.Para.Size = new System.Drawing.Size(41, 21);
            this.Para.TabIndex = 1;
            this.Para.Text = "Para";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(16, 135);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(209, 20);
            this.txtPara.TabIndex = 2;
            this.txtPara.TextChanged += new System.EventHandler(this.TxtPara_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Asunto";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(16, 200);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(772, 20);
            this.txtAsunto.TabIndex = 4;
            // 
            // txtRedactar
            // 
            this.txtRedactar.Location = new System.Drawing.Point(16, 243);
            this.txtRedactar.Multiline = true;
            this.txtRedactar.Name = "txtRedactar";
            this.txtRedactar.Size = new System.Drawing.Size(772, 195);
            this.txtRedactar.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnviar.Location = new System.Drawing.Point(642, 59);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(146, 124);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EnviarMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtRedactar);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.Para);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnviarMensaje";
            this.Text = "Send Messague";
            this.Load += new System.EventHandler(this.EnviarMensaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Para;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtRedactar;
        private System.Windows.Forms.Button btnEnviar;
    }
}