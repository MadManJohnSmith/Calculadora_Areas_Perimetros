namespace Calculadora_Areas_Perimetros.UserControls
{
    partial class Heptagon
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
            this.tbCirIns = new System.Windows.Forms.TextBox();
            this.tbCirCir = new System.Windows.Forms.TextBox();
            this.tbLado = new System.Windows.Forms.TextBox();
            this.tbLados = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCirIns = new System.Windows.Forms.Label();
            this.lblCirCir = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblLados = new System.Windows.Forms.Label();
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
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(179, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(377, 26);
            this.label13.TabIndex = 49;
            this.label13.Text = "Introduzca el número de lados y un valor";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("ROG Fonts", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(114, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(485, 44);
            this.label12.TabIndex = 48;
            this.label12.Text = "POLIGONO Regular";
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
            // tbCirIns
            // 
            this.tbCirIns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbCirIns.Location = new System.Drawing.Point(342, 206);
            this.tbCirIns.Name = "tbCirIns";
            this.tbCirIns.Size = new System.Drawing.Size(113, 20);
            this.tbCirIns.TabIndex = 40;
            // 
            // tbCirCir
            // 
            this.tbCirCir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbCirCir.Location = new System.Drawing.Point(342, 142);
            this.tbCirCir.Name = "tbCirCir";
            this.tbCirCir.Size = new System.Drawing.Size(113, 20);
            this.tbCirCir.TabIndex = 39;
            // 
            // tbLado
            // 
            this.tbLado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbLado.Location = new System.Drawing.Point(143, 209);
            this.tbLado.Name = "tbLado";
            this.tbLado.Size = new System.Drawing.Size(113, 20);
            this.tbLado.TabIndex = 38;
            // 
            // tbLados
            // 
            this.tbLados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbLados.Location = new System.Drawing.Point(143, 142);
            this.tbLados.Name = "tbLados";
            this.tbLados.Size = new System.Drawing.Size(113, 20);
            this.tbLados.TabIndex = 37;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblArea.Location = new System.Drawing.Point(234, 335);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(52, 24);
            this.lblArea.TabIndex = 35;
            this.lblArea.Text = "Área";
            // 
            // lblCirIns
            // 
            this.lblCirIns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCirIns.AutoSize = true;
            this.lblCirIns.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCirIns.Location = new System.Drawing.Point(342, 180);
            this.lblCirIns.Name = "lblCirIns";
            this.lblCirIns.Size = new System.Drawing.Size(250, 24);
            this.lblCirIns.TabIndex = 29;
            this.lblCirIns.Text = "circunferencia inscrita (radio)";
            // 
            // lblCirCir
            // 
            this.lblCirCir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCirCir.AutoSize = true;
            this.lblCirCir.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCirCir.Location = new System.Drawing.Point(337, 113);
            this.lblCirCir.Name = "lblCirCir";
            this.lblCirCir.Size = new System.Drawing.Size(286, 24);
            this.lblCirCir.TabIndex = 28;
            this.lblCirCir.Text = "circunferencia circunscrita (radio)";
            // 
            // lblLado
            // 
            this.lblLado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLado.AutoSize = true;
            this.lblLado.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.Location = new System.Drawing.Point(144, 180);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(51, 24);
            this.lblLado.TabIndex = 27;
            this.lblLado.Text = "Lado";
            // 
            // lblLados
            // 
            this.lblLados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLados.AutoSize = true;
            this.lblLados.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLados.Location = new System.Drawing.Point(139, 113);
            this.lblLados.Name = "lblLados";
            this.lblLados.Size = new System.Drawing.Size(60, 24);
            this.lblLados.TabIndex = 26;
            this.lblLados.Text = "Lados";
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
            // Heptagon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbPerimetro);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.tbCirIns);
            this.Controls.Add(this.tbCirCir);
            this.Controls.Add(this.tbLado);
            this.Controls.Add(this.tbLados);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblCirIns);
            this.Controls.Add(this.lblCirCir);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblLados);
            this.Name = "Heptagon";
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
        private System.Windows.Forms.TextBox tbCirIns;
        private System.Windows.Forms.TextBox tbCirCir;
        private System.Windows.Forms.TextBox tbLado;
        private System.Windows.Forms.TextBox tbLados;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCirIns;
        private System.Windows.Forms.Label lblCirCir;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblLados;
        private System.Windows.Forms.Button btnHome;
    }
}
