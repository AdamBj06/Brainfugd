namespace Brainfugd
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcb_Start = new System.Windows.Forms.PictureBox();
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.lbl_OutputLetters = new System.Windows.Forms.Label();
            this.lbl_OutputNumber = new System.Windows.Forms.Label();
            this.lbl_Mem1 = new System.Windows.Forms.Label();
            this.lbl_Mem2 = new System.Windows.Forms.Label();
            this.lbl_Mem3 = new System.Windows.Forms.Label();
            this.lbl_Mem4 = new System.Windows.Forms.Label();
            this.lbl_Mem5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_Start
            // 
            this.pcb_Start.BackColor = System.Drawing.Color.Silver;
            this.pcb_Start.Location = new System.Drawing.Point(130, 320);
            this.pcb_Start.Name = "pcb_Start";
            this.pcb_Start.Size = new System.Drawing.Size(50, 50);
            this.pcb_Start.TabIndex = 0;
            this.pcb_Start.TabStop = false;
            // 
            // pcb1
            // 
            this.pcb1.BackColor = System.Drawing.Color.White;
            this.pcb1.Location = new System.Drawing.Point(185, 330);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(50, 50);
            this.pcb1.TabIndex = 1;
            this.pcb1.TabStop = false;
            // 
            // lbl_OutputLetters
            // 
            this.lbl_OutputLetters.AutoSize = true;
            this.lbl_OutputLetters.Location = new System.Drawing.Point(144, 81);
            this.lbl_OutputLetters.Name = "lbl_OutputLetters";
            this.lbl_OutputLetters.Size = new System.Drawing.Size(35, 13);
            this.lbl_OutputLetters.TabIndex = 2;
            this.lbl_OutputLetters.Text = "label1";
            // 
            // lbl_OutputNumber
            // 
            this.lbl_OutputNumber.AutoSize = true;
            this.lbl_OutputNumber.Location = new System.Drawing.Point(347, 81);
            this.lbl_OutputNumber.Name = "lbl_OutputNumber";
            this.lbl_OutputNumber.Size = new System.Drawing.Size(35, 13);
            this.lbl_OutputNumber.TabIndex = 3;
            this.lbl_OutputNumber.Text = "label2";
            // 
            // lbl_Mem1
            // 
            this.lbl_Mem1.AutoSize = true;
            this.lbl_Mem1.Location = new System.Drawing.Point(144, 186);
            this.lbl_Mem1.Name = "lbl_Mem1";
            this.lbl_Mem1.Size = new System.Drawing.Size(35, 13);
            this.lbl_Mem1.TabIndex = 4;
            this.lbl_Mem1.Text = "label3";
            // 
            // lbl_Mem2
            // 
            this.lbl_Mem2.AutoSize = true;
            this.lbl_Mem2.Location = new System.Drawing.Point(200, 186);
            this.lbl_Mem2.Name = "lbl_Mem2";
            this.lbl_Mem2.Size = new System.Drawing.Size(35, 13);
            this.lbl_Mem2.TabIndex = 5;
            this.lbl_Mem2.Text = "label4";
            // 
            // lbl_Mem3
            // 
            this.lbl_Mem3.AutoSize = true;
            this.lbl_Mem3.Location = new System.Drawing.Point(266, 186);
            this.lbl_Mem3.Name = "lbl_Mem3";
            this.lbl_Mem3.Size = new System.Drawing.Size(35, 13);
            this.lbl_Mem3.TabIndex = 6;
            this.lbl_Mem3.Text = "label5";
            // 
            // lbl_Mem4
            // 
            this.lbl_Mem4.AutoSize = true;
            this.lbl_Mem4.Location = new System.Drawing.Point(333, 186);
            this.lbl_Mem4.Name = "lbl_Mem4";
            this.lbl_Mem4.Size = new System.Drawing.Size(35, 13);
            this.lbl_Mem4.TabIndex = 7;
            this.lbl_Mem4.Text = "label6";
            // 
            // lbl_Mem5
            // 
            this.lbl_Mem5.AutoSize = true;
            this.lbl_Mem5.Location = new System.Drawing.Point(407, 186);
            this.lbl_Mem5.Name = "lbl_Mem5";
            this.lbl_Mem5.Size = new System.Drawing.Size(35, 13);
            this.lbl_Mem5.TabIndex = 8;
            this.lbl_Mem5.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lbl_Mem5);
            this.Controls.Add(this.lbl_Mem4);
            this.Controls.Add(this.lbl_Mem3);
            this.Controls.Add(this.lbl_Mem2);
            this.Controls.Add(this.lbl_Mem1);
            this.Controls.Add(this.lbl_OutputNumber);
            this.Controls.Add(this.lbl_OutputLetters);
            this.Controls.Add(this.pcb1);
            this.Controls.Add(this.pcb_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_Start;
        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.Label lbl_OutputLetters;
        private System.Windows.Forms.Label lbl_OutputNumber;
        private System.Windows.Forms.Label lbl_Mem1;
        private System.Windows.Forms.Label lbl_Mem2;
        private System.Windows.Forms.Label lbl_Mem3;
        private System.Windows.Forms.Label lbl_Mem4;
        private System.Windows.Forms.Label lbl_Mem5;
    }
}

