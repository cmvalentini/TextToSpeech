
namespace TextToVoice
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textrtb = new System.Windows.Forms.RichTextBox();
            this.btn_talk = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textrtb
            // 
            this.textrtb.Location = new System.Drawing.Point(38, 21);
            this.textrtb.Name = "textrtb";
            this.textrtb.Size = new System.Drawing.Size(732, 394);
            this.textrtb.TabIndex = 0;
            this.textrtb.Text = "";
            // 
            // btn_talk
            // 
            this.btn_talk.Location = new System.Drawing.Point(38, 423);
            this.btn_talk.Name = "btn_talk";
            this.btn_talk.Size = new System.Drawing.Size(132, 58);
            this.btn_talk.TabIndex = 1;
            this.btn_talk.Text = "Play";
            this.btn_talk.UseVisualStyleBackColor = true;
            this.btn_talk.Click += new System.EventHandler(this.btn_talk_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(186, 423);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(132, 58);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_resume
            // 
            this.btn_resume.Location = new System.Drawing.Point(335, 427);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(132, 55);
            this.btn_resume.TabIndex = 3;
            this.btn_resume.Text = "Resume";
            this.btn_resume.UseVisualStyleBackColor = true;
            this.btn_resume.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(638, 428);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(132, 54);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Exit";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_resume);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_talk);
            this.Controls.Add(this.textrtb);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Text to Voice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textrtb;
        private System.Windows.Forms.Button btn_talk;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button button1;
    }
}

