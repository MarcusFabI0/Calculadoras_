namespace ExercícioTPAula02
{
    partial class frmIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIMC));
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSistemaIMC = new System.Windows.Forms.Label();
            this.ptIMC = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCm = new System.Windows.Forms.Label();
            this.lblKg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptIMC)).BeginInit();
            this.SuspendLayout();
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(74, 178);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(368, 23);
            this.txbPeso.TabIndex = 1;
            this.txbPeso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(33, 181);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 15);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso:";
            this.lblPeso.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(74, 232);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(368, 23);
            this.txbAltura.TabIndex = 2;
            this.txbAltura.TextChanged += new System.EventHandler(this.label1_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(30, 235);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(42, 15);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAltura.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Image = global::Calcs.Properties.Resources.botaoverde;
            this.btnCalcular.Location = new System.Drawing.Point(74, 281);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(117, 30);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Image = global::Calcs.Properties.Resources.botaoverde;
            this.btnLimpar.Location = new System.Drawing.Point(325, 281);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 30);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSistemaIMC
            // 
            this.lblSistemaIMC.AutoSize = true;
            this.lblSistemaIMC.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSistemaIMC.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSistemaIMC.Location = new System.Drawing.Point(137, 146);
            this.lblSistemaIMC.Name = "lblSistemaIMC";
            this.lblSistemaIMC.Size = new System.Drawing.Size(232, 29);
            this.lblSistemaIMC.TabIndex = 0;
            this.lblSistemaIMC.Text = "Sistema de Cálculo IMC";
            // 
            // ptIMC
            // 
            this.ptIMC.Image = ((System.Drawing.Image)(resources.GetObject("ptIMC.Image")));
            this.ptIMC.Location = new System.Drawing.Point(148, 9);
            this.ptIMC.Name = "ptIMC";
            this.ptIMC.Size = new System.Drawing.Size(205, 122);
            this.ptIMC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptIMC.TabIndex = 6;
            this.ptIMC.TabStop = false;
            this.ptIMC.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResult.Location = new System.Drawing.Point(30, 407);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 29);
            this.lblResult.TabIndex = 9;
            // 
            // lblCm
            // 
            this.lblCm.AutoSize = true;
            this.lblCm.Location = new System.Drawing.Point(445, 235);
            this.lblCm.Name = "lblCm";
            this.lblCm.Size = new System.Drawing.Size(24, 15);
            this.lblCm.TabIndex = 7;
            this.lblCm.Text = "cm";
            this.lblCm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(448, 181);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(21, 15);
            this.lblKg.TabIndex = 8;
            this.lblKg.Text = "Kg";
            // 
            // frmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(495, 508);
            this.Controls.Add(this.lblCm);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.ptIMC);
            this.Controls.Add(this.lblSistemaIMC);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbPeso);
            this.Name = "frmIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora IMC";
            this.Load += new System.EventHandler(this.frmIMC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptIMC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbPeso;
        private Label lblPeso;
        private TextBox txbAltura;
        private Label lblAltura;
        private Button btnCalcular;
        private Button btnLimpar;
        private Label lblSistemaIMC;
        private PictureBox ptIMC;
        private Label lblResult;
        private Label lblCm;
        private Label lblKg;
    }
}