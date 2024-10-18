namespace Calculadora_Areas_Perimetros.UserControls
{
    partial class Trapezoid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPerimetro = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbAngDelta = new System.Windows.Forms.TextBox();
            this.tbAngGamma = new System.Windows.Forms.TextBox();
            this.tbAngBeta = new System.Windows.Forms.TextBox();
            this.tbAngAlfa = new System.Windows.Forms.TextBox();
            this.tbAlt = new System.Windows.Forms.TextBox();
            this.tbLadoD = new System.Windows.Forms.TextBox();
            this.tbLadoC = new System.Windows.Forms.TextBox();
            this.tbLadoB = new System.Windows.Forms.TextBox();
            this.tbLadoA = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAngDelta = new System.Windows.Forms.Label();
            this.lblAngGamma = new System.Windows.Forms.Label();
            this.lblAngBeta = new System.Windows.Forms.Label();
            this.lblAngAlfa = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblLadoD = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(515, 335);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 42);
            this.btnReset.TabIndex = 51;
            this.btnReset.Text = "Borrar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalcular.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(86, 335);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 42);
            this.btnCalcular.TabIndex = 50;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(237, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(242, 26);
            this.label13.TabIndex = 49;
            this.label13.Text = "Introduzca cuatro valores";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("ROG Fonts", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(201, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(322, 44);
            this.label12.TabIndex = 48;
            this.label12.Text = "TRAPEZOIDE";
            // 
            // tbPerimetro
            // 
            this.tbPerimetro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbPerimetro.Location = new System.Drawing.Point(383, 358);
            this.tbPerimetro.Name = "tbPerimetro";
            this.tbPerimetro.Size = new System.Drawing.Size(113, 20);
            this.tbPerimetro.TabIndex = 47;
            // 
            // tbArea
            // 
            this.tbArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbArea.Location = new System.Drawing.Point(234, 358);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(113, 20);
            this.tbArea.TabIndex = 46;
            // 
            // tbAngDelta
            // 
            this.tbAngDelta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngDelta.Location = new System.Drawing.Point(514, 275);
            this.tbAngDelta.Name = "tbAngDelta";
            this.tbAngDelta.Size = new System.Drawing.Size(113, 20);
            this.tbAngDelta.TabIndex = 45;
            // 
            // tbAngGamma
            // 
            this.tbAngGamma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngGamma.Location = new System.Drawing.Point(514, 208);
            this.tbAngGamma.Name = "tbAngGamma";
            this.tbAngGamma.Size = new System.Drawing.Size(113, 20);
            this.tbAngGamma.TabIndex = 44;
            // 
            // tbAngBeta
            // 
            this.tbAngBeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAngBeta.Location = new System.Drawing.Point(514, 142);
            this.tbAngBeta.Name = "tbAngBeta";
            this.tbAngBeta.Size = new System.Drawing.Size(113, 20);
            this.tbAngBeta.TabIndex = 43;
            // 
            // tbAngAlfa
            // 
            this.tbAngAlfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbAngAlfa.Location = new System.Drawing.Point(288, 275);
            this.tbAngAlfa.Name = "tbAngAlfa";
            this.tbAngAlfa.Size = new System.Drawing.Size(113, 20);
            this.tbAngAlfa.TabIndex = 42;
            // 
            // tbAlt
            // 
            this.tbAlt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbAlt.Location = new System.Drawing.Point(288, 208);
            this.tbAlt.Name = "tbAlt";
            this.tbAlt.Size = new System.Drawing.Size(113, 20);
            this.tbAlt.TabIndex = 41;
            // 
            // tbLadoD
            // 
            this.tbLadoD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbLadoD.Location = new System.Drawing.Point(288, 142);
            this.tbLadoD.Name = "tbLadoD";
            this.tbLadoD.Size = new System.Drawing.Size(113, 20);
            this.tbLadoD.TabIndex = 40;
            // 
            // tbLadoC
            // 
            this.tbLadoC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLadoC.Location = new System.Drawing.Point(87, 275);
            this.tbLadoC.Name = "tbLadoC";
            this.tbLadoC.Size = new System.Drawing.Size(113, 20);
            this.tbLadoC.TabIndex = 39;
            // 
            // tbLadoB
            // 
            this.tbLadoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLadoB.Location = new System.Drawing.Point(87, 209);
            this.tbLadoB.Name = "tbLadoB";
            this.tbLadoB.Size = new System.Drawing.Size(113, 20);
            this.tbLadoB.TabIndex = 38;
            // 
            // tbLadoA
            // 
            this.tbLadoA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbLadoA.Location = new System.Drawing.Point(87, 142);
            this.tbLadoA.Name = "tbLadoA";
            this.tbLadoA.Size = new System.Drawing.Size(113, 20);
            this.tbLadoA.TabIndex = 37;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPerimetro.Location = new System.Drawing.Point(383, 335);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(98, 24);
            this.lblPerimetro.TabIndex = 36;
            this.lblPerimetro.Text = "Perimetro";
            // 
            // lblArea
            // 
            this.lblArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblArea.Location = new System.Drawing.Point(234, 335);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(52, 24);
            this.lblArea.TabIndex = 35;
            this.lblArea.Text = "Área";
            // 
            // lblAngDelta
            // 
            this.lblAngDelta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAngDelta.AutoSize = true;
            this.lblAngDelta.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngDelta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAngDelta.Location = new System.Drawing.Point(511, 247);
            this.lblAngDelta.Name = "lblAngDelta";
            this.lblAngDelta.Size = new System.Drawing.Size(84, 24);
            this.lblAngDelta.TabIndex = 34;
            this.lblAngDelta.Text = "Ángulo δ";
            // 
            // lblAngGamma
            // 
            this.lblAngGamma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAngGamma.AutoSize = true;
            this.lblAngGamma.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngGamma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAngGamma.Location = new System.Drawing.Point(511, 180);
            this.lblAngGamma.Name = "lblAngGamma";
            this.lblAngGamma.Size = new System.Drawing.Size(82, 24);
            this.lblAngGamma.TabIndex = 33;
            this.lblAngGamma.Text = "Ángulo γ";
            // 
            // lblAngBeta
            // 
            this.lblAngBeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAngBeta.AutoSize = true;
            this.lblAngBeta.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngBeta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAngBeta.Location = new System.Drawing.Point(511, 114);
            this.lblAngBeta.Name = "lblAngBeta";
            this.lblAngBeta.Size = new System.Drawing.Size(84, 24);
            this.lblAngBeta.TabIndex = 32;
            this.lblAngBeta.Text = "Ángulo β";
            // 
            // lblAngAlfa
            // 
            this.lblAngAlfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAngAlfa.AutoSize = true;
            this.lblAngAlfa.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngAlfa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAngAlfa.Location = new System.Drawing.Point(288, 248);
            this.lblAngAlfa.Name = "lblAngAlfa";
            this.lblAngAlfa.Size = new System.Drawing.Size(84, 24);
            this.lblAngAlfa.TabIndex = 31;
            this.lblAngAlfa.Text = "Ángulo α";
            // 
            // lblAltura
            // 
            this.lblAltura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAltura.Location = new System.Drawing.Point(288, 180);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(61, 24);
            this.lblAltura.TabIndex = 30;
            this.lblAltura.Text = "Altura";
            // 
            // lblLadoD
            // 
            this.lblLadoD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLadoD.AutoSize = true;
            this.lblLadoD.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLadoD.Location = new System.Drawing.Point(288, 116);
            this.lblLadoD.Name = "lblLadoD";
            this.lblLadoD.Size = new System.Drawing.Size(66, 24);
            this.lblLadoD.TabIndex = 29;
            this.lblLadoD.Text = "Lado d";
            // 
            // lblLadoC
            // 
            this.lblLadoC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLadoC.Location = new System.Drawing.Point(82, 246);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(65, 24);
            this.lblLadoC.TabIndex = 28;
            this.lblLadoC.Text = "Lado c";
            // 
            // lblLadoB
            // 
            this.lblLadoB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLadoB.Location = new System.Drawing.Point(88, 180);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(66, 24);
            this.lblLadoB.TabIndex = 27;
            this.lblLadoB.Text = "Lado b";
            // 
            // lblLadoA
            // 
            this.lblLadoA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLadoA.Location = new System.Drawing.Point(83, 113);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(65, 24);
            this.lblLadoA.TabIndex = 26;
            this.lblLadoA.Text = "Lado a";
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHome.Image = global::Calculadora_Areas_Perimetros.Properties.Resources._3574480_200;
            this.btnHome.Location = new System.Drawing.Point(20, 520);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(120, 120);
            this.btnHome.TabIndex = 52;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Trapezoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbPerimetro);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.tbAngDelta);
            this.Controls.Add(this.tbAngGamma);
            this.Controls.Add(this.tbAngBeta);
            this.Controls.Add(this.tbAngAlfa);
            this.Controls.Add(this.tbAlt);
            this.Controls.Add(this.tbLadoD);
            this.Controls.Add(this.tbLadoC);
            this.Controls.Add(this.tbLadoB);
            this.Controls.Add(this.tbLadoA);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAngDelta);
            this.Controls.Add(this.lblAngGamma);
            this.Controls.Add(this.lblAngBeta);
            this.Controls.Add(this.lblAngAlfa);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblLadoD);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Name = "Trapezoid";
            this.Size = new System.Drawing.Size(689, 661);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPerimetro;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbAngDelta;
        private System.Windows.Forms.TextBox tbAngGamma;
        private System.Windows.Forms.TextBox tbAngBeta;
        private System.Windows.Forms.TextBox tbAngAlfa;
        private System.Windows.Forms.TextBox tbAlt;
        private System.Windows.Forms.TextBox tbLadoD;
        private System.Windows.Forms.TextBox tbLadoC;
        private System.Windows.Forms.TextBox tbLadoB;
        private System.Windows.Forms.TextBox tbLadoA;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAngDelta;
        private System.Windows.Forms.Label lblAngGamma;
        private System.Windows.Forms.Label lblAngBeta;
        private System.Windows.Forms.Label lblAngAlfa;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblLadoD;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Button btnHome;
    }
}
