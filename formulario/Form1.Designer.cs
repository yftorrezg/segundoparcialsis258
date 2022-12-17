
namespace formulario
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
            this.IDAmbiente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nit = new System.Windows.Forms.Label();
            this.cufd = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.modalidad = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btncotizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDAmbiente
            // 
            this.IDAmbiente.AutoSize = true;
            this.IDAmbiente.Location = new System.Drawing.Point(44, 76);
            this.IDAmbiente.Name = "IDAmbiente";
            this.IDAmbiente.Size = new System.Drawing.Size(140, 32);
            this.IDAmbiente.TabIndex = 0;
            this.IDAmbiente.Text = "IDAmbiente";
            this.IDAmbiente.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 39);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 39);
            this.textBox2.TabIndex = 2;
            // 
            // nit
            // 
            this.nit.AutoSize = true;
            this.nit.Location = new System.Drawing.Point(56, 151);
            this.nit.Name = "nit";
            this.nit.Size = new System.Drawing.Size(42, 32);
            this.nit.TabIndex = 3;
            this.nit.Text = "nit";
            // 
            // cufd
            // 
            this.cufd.AutoSize = true;
            this.cufd.Location = new System.Drawing.Point(56, 237);
            this.cufd.Name = "cufd";
            this.cufd.Size = new System.Drawing.Size(65, 32);
            this.cufd.TabIndex = 4;
            this.cufd.Text = "Cufd";
            this.cufd.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(205, 237);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 39);
            this.textBox3.TabIndex = 5;
            // 
            // modalidad
            // 
            this.modalidad.AutoSize = true;
            this.modalidad.Location = new System.Drawing.Point(44, 329);
            this.modalidad.Name = "modalidad";
            this.modalidad.Size = new System.Drawing.Size(128, 32);
            this.modalidad.TabIndex = 6;
            this.modalidad.Text = "Modalidad";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(205, 329);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 39);
            this.textBox4.TabIndex = 7;
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Location = new System.Drawing.Point(439, 76);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(105, 32);
            this.cantidad.TabIndex = 8;
            this.cantidad.Text = "cantidad";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(550, 76);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(192, 39);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(550, 151);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 39);
            this.textBox6.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(889, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "cotizar";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(463, 513);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 40);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btncotizar
            // 
            this.btncotizar.Location = new System.Drawing.Point(889, 222);
            this.btncotizar.Name = "btncotizar";
            this.btncotizar.Size = new System.Drawing.Size(150, 46);
            this.btncotizar.TabIndex = 13;
            this.btncotizar.Text = "cotizar";
            this.btncotizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 656);
            this.Controls.Add(this.btncotizar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.modalidad);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cufd);
            this.Controls.Add(this.nit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IDAmbiente);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDAmbiente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nit;
        private System.Windows.Forms.Label cufd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label modalidad;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btncotizar;
    }
}

