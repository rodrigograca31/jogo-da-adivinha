namespace JogoDaAdivinha
{
    partial class Form1
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
            this.inputInferior = new System.Windows.Forms.TextBox();
            this.inputSuperior = new System.Windows.Forms.TextBox();
            this.inputTentativas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btTentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Superior?";
            // 
            // inputInferior
            // 
            this.inputInferior.Location = new System.Drawing.Point(109, 30);
            this.inputInferior.Name = "inputInferior";
            this.inputInferior.Size = new System.Drawing.Size(100, 20);
            this.inputInferior.TabIndex = 1;
            // 
            // inputSuperior
            // 
            this.inputSuperior.Location = new System.Drawing.Point(109, 6);
            this.inputSuperior.Name = "inputSuperior";
            this.inputSuperior.Size = new System.Drawing.Size(100, 20);
            this.inputSuperior.TabIndex = 2;
            // 
            // inputTentativas
            // 
            this.inputTentativas.Location = new System.Drawing.Point(109, 56);
            this.inputTentativas.Name = "inputTentativas";
            this.inputTentativas.Size = new System.Drawing.Size(100, 20);
            this.inputTentativas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inferior?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tentativas?";
            // 
            // btTentar
            // 
            this.btTentar.Location = new System.Drawing.Point(119, 131);
            this.btTentar.Name = "btTentar";
            this.btTentar.Size = new System.Drawing.Size(75, 23);
            this.btTentar.TabIndex = 6;
            this.btTentar.Text = "Tentar";
            this.btTentar.UseVisualStyleBackColor = true;
            this.btTentar.Click += new System.EventHandler(this.btTentar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 239);
            this.Controls.Add(this.btTentar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputTentativas);
            this.Controls.Add(this.inputSuperior);
            this.Controls.Add(this.inputInferior);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputInferior;
        private System.Windows.Forms.TextBox inputSuperior;
        private System.Windows.Forms.TextBox inputTentativas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btTentar;
    }
}

