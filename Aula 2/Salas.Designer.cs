
namespace Aula_2
{
    partial class Salas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNumPC = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNumCadeiras = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPredio = new System.Windows.Forms.Label();
            this.txtAndar = new System.Windows.Forms.TextBox();
            this.lblPredio = new System.Windows.Forms.Label();
            this.chkLab = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Salas";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(12, 87);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblNumPC
            // 
            this.lblNumPC.AutoSize = true;
            this.lblNumPC.BackColor = System.Drawing.Color.Transparent;
            this.lblNumPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPC.ForeColor = System.Drawing.Color.White;
            this.lblNumPC.Location = new System.Drawing.Point(12, 145);
            this.lblNumPC.Name = "lblNumPC";
            this.lblNumPC.Size = new System.Drawing.Size(81, 24);
            this.lblNumPC.TabIndex = 4;
            this.lblNumPC.Text = "Num PC";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 20);
            this.txtNome.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 225);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 20);
            this.textBox2.TabIndex = 8;
            // 
            // lblNumCadeiras
            // 
            this.lblNumCadeiras.AutoSize = true;
            this.lblNumCadeiras.BackColor = System.Drawing.Color.Transparent;
            this.lblNumCadeiras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCadeiras.ForeColor = System.Drawing.Color.White;
            this.lblNumCadeiras.Location = new System.Drawing.Point(12, 198);
            this.lblNumCadeiras.Name = "lblNumCadeiras";
            this.lblNumCadeiras.Size = new System.Drawing.Size(130, 24);
            this.lblNumCadeiras.TabIndex = 7;
            this.lblNumCadeiras.Text = "Num Cadeiras";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 278);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 20);
            this.textBox3.TabIndex = 10;
            // 
            // txtPredio
            // 
            this.txtPredio.AutoSize = true;
            this.txtPredio.BackColor = System.Drawing.Color.Transparent;
            this.txtPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPredio.ForeColor = System.Drawing.Color.White;
            this.txtPredio.Location = new System.Drawing.Point(16, 251);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.Size = new System.Drawing.Size(65, 24);
            this.txtPredio.TabIndex = 9;
            this.txtPredio.Text = "Prédio";
            // 
            // txtAndar
            // 
            this.txtAndar.Location = new System.Drawing.Point(16, 384);
            this.txtAndar.Name = "txtAndar";
            this.txtAndar.Size = new System.Drawing.Size(265, 20);
            this.txtAndar.TabIndex = 12;
            // 
            // lblPredio
            // 
            this.lblPredio.AutoSize = true;
            this.lblPredio.BackColor = System.Drawing.Color.Transparent;
            this.lblPredio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredio.ForeColor = System.Drawing.Color.White;
            this.lblPredio.Location = new System.Drawing.Point(16, 357);
            this.lblPredio.Name = "lblPredio";
            this.lblPredio.Size = new System.Drawing.Size(61, 24);
            this.lblPredio.TabIndex = 11;
            this.lblPredio.Text = "Andar";
            // 
            // chkLab
            // 
            this.chkLab.AutoSize = true;
            this.chkLab.BackColor = System.Drawing.Color.Transparent;
            this.chkLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLab.ForeColor = System.Drawing.Color.White;
            this.chkLab.Location = new System.Drawing.Point(16, 315);
            this.chkLab.Name = "chkLab";
            this.chkLab.Size = new System.Drawing.Size(123, 28);
            this.chkLab.TabIndex = 13;
            this.chkLab.Text = "Laboratório";
            this.chkLab.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(644, 368);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(144, 50);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(451, 368);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(144, 50);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aula_2.Properties.Resources.undertale;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.chkLab);
            this.Controls.Add(this.txtAndar);
            this.Controls.Add(this.lblPredio);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtPredio);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNumCadeiras);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNumPC);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Salas";
            this.Text = "labek";
            this.Load += new System.EventHandler(this.Salas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNumPC;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNumCadeiras;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtPredio;
        private System.Windows.Forms.TextBox txtAndar;
        private System.Windows.Forms.Label lblPredio;
        private System.Windows.Forms.CheckBox chkLab;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
    }
}