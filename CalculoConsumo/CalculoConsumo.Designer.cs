
namespace CalculoConsumo
{
    partial class CalculoConsumo
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelKM = new System.Windows.Forms.Label();
            this.labelLitros = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBoxLitros = new System.Windows.Forms.TextBox();
            this.textBoxKM = new System.Windows.Forms.TextBox();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.labelConsuResul = new System.Windows.Forms.Label();
            this.labelRendResul = new System.Windows.Forms.Label();
            this.labelRendimentos = new System.Windows.Forms.Label();
            this.labelConsumo = new System.Windows.Forms.Label();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(185, 37);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(430, 29);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Cálculo de Consumo de Veículos";
            // 
            // labelKM
            // 
            this.labelKM.AutoSize = true;
            this.labelKM.BackColor = System.Drawing.Color.DarkOrange;
            this.labelKM.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKM.ForeColor = System.Drawing.Color.Black;
            this.labelKM.Location = new System.Drawing.Point(44, 29);
            this.labelKM.Name = "labelKM";
            this.labelKM.Size = new System.Drawing.Size(39, 21);
            this.labelKM.TabIndex = 1;
            this.labelKM.Text = "KM:";
            // 
            // labelLitros
            // 
            this.labelLitros.AutoSize = true;
            this.labelLitros.BackColor = System.Drawing.Color.DarkOrange;
            this.labelLitros.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLitros.Location = new System.Drawing.Point(27, 79);
            this.labelLitros.Name = "labelLitros";
            this.labelLitros.Size = new System.Drawing.Size(56, 21);
            this.labelLitros.TabIndex = 2;
            this.labelLitros.Text = "Litros:";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBoxInfo.Controls.Add(this.buttonCalcular);
            this.groupBoxInfo.Controls.Add(this.textBoxLitros);
            this.groupBoxInfo.Controls.Add(this.textBoxKM);
            this.groupBoxInfo.Controls.Add(this.labelKM);
            this.groupBoxInfo.Controls.Add(this.labelLitros);
            this.groupBoxInfo.ForeColor = System.Drawing.Color.Black;
            this.groupBoxInfo.Location = new System.Drawing.Point(119, 134);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(255, 174);
            this.groupBoxInfo.TabIndex = 7;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Insira as Informações";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.LightGreen;
            this.buttonCalcular.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCalcular.Location = new System.Drawing.Point(89, 127);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(88, 28);
            this.buttonCalcular.TabIndex = 3;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textBoxLitros
            // 
            this.textBoxLitros.Location = new System.Drawing.Point(89, 81);
            this.textBoxLitros.Name = "textBoxLitros";
            this.textBoxLitros.Size = new System.Drawing.Size(123, 23);
            this.textBoxLitros.TabIndex = 2;
            this.textBoxLitros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxKM
            // 
            this.textBoxKM.Location = new System.Drawing.Point(89, 31);
            this.textBoxKM.Name = "textBoxKM";
            this.textBoxKM.Size = new System.Drawing.Size(123, 23);
            this.textBoxKM.TabIndex = 1;
            this.textBoxKM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBoxResultados.Controls.Add(this.labelConsuResul);
            this.groupBoxResultados.Controls.Add(this.labelRendResul);
            this.groupBoxResultados.Controls.Add(this.labelRendimentos);
            this.groupBoxResultados.Controls.Add(this.labelConsumo);
            this.groupBoxResultados.ForeColor = System.Drawing.Color.Black;
            this.groupBoxResultados.Location = new System.Drawing.Point(425, 134);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Size = new System.Drawing.Size(255, 174);
            this.groupBoxResultados.TabIndex = 8;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Resultados";
            // 
            // labelConsuResul
            // 
            this.labelConsuResul.BackColor = System.Drawing.Color.SeaShell;
            this.labelConsuResul.Location = new System.Drawing.Point(30, 127);
            this.labelConsuResul.Name = "labelConsuResul";
            this.labelConsuResul.Size = new System.Drawing.Size(189, 23);
            this.labelConsuResul.TabIndex = 4;
            this.labelConsuResul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRendResul
            // 
            this.labelRendResul.BackColor = System.Drawing.Color.SeaShell;
            this.labelRendResul.Location = new System.Drawing.Point(30, 60);
            this.labelRendResul.Name = "labelRendResul";
            this.labelRendResul.Size = new System.Drawing.Size(189, 23);
            this.labelRendResul.TabIndex = 3;
            this.labelRendResul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRendimentos
            // 
            this.labelRendimentos.AutoSize = true;
            this.labelRendimentos.BackColor = System.Drawing.Color.DarkOrange;
            this.labelRendimentos.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRendimentos.ForeColor = System.Drawing.Color.Black;
            this.labelRendimentos.Location = new System.Drawing.Point(30, 29);
            this.labelRendimentos.Name = "labelRendimentos";
            this.labelRendimentos.Size = new System.Drawing.Size(189, 21);
            this.labelRendimentos.TabIndex = 1;
            this.labelRendimentos.Text = "Rendimentos KM/Litros";
            this.labelRendimentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelConsumo
            // 
            this.labelConsumo.BackColor = System.Drawing.Color.DarkOrange;
            this.labelConsumo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConsumo.Location = new System.Drawing.Point(30, 94);
            this.labelConsumo.Name = "labelConsumo";
            this.labelConsumo.Size = new System.Drawing.Size(189, 21);
            this.labelConsumo.TabIndex = 2;
            this.labelConsumo.Text = "Consumo - KM/Litros";
            this.labelConsumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculoConsumo
            // 
            this.AcceptButton = this.buttonCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxResultados);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.groupBoxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "CalculoConsumo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Consumo";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalculoConsumo_KeyPress);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxResultados.ResumeLayout(false);
            this.groupBoxResultados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelKM;
        private System.Windows.Forms.Label labelLitros;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox textBoxLitros;
        private System.Windows.Forms.TextBox textBoxKM;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.Label labelRendimentos;
        private System.Windows.Forms.Label labelConsumo;
        private System.Windows.Forms.Label labelConsuResul;
        private System.Windows.Forms.Label labelRendResul;
    }
}

