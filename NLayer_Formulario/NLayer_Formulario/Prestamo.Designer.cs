
namespace NLayer_Formulario
{
    partial class Prestamo
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
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst_Cliente = new System.Windows.Forms.ListBox();
            this.txtCuotaTotal = new System.Windows.Forms.TextBox();
            this.lblCUOTA_total = new System.Windows.Forms.Label();
            this.txtCuotaInteres = new System.Windows.Forms.TextBox();
            this.lblCUOTA_interes = new System.Windows.Forms.Label();
            this.txtCuotaCapital = new System.Windows.Forms.TextBox();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lblTNA = new System.Windows.Forms.Label();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.txtTNA = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.lblCUOTA_capital = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_Prestamo = new System.Windows.Forms.ListBox();
            this.txtComisionTotal = new System.Windows.Forms.TextBox();
            this.lblComisionTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SIMULAR = new System.Windows.Forms.Button();
            this.ALTA = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamo.Location = new System.Drawing.Point(23, 9);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(148, 29);
            this.lblPrestamo.TabIndex = 5;
            this.lblPrestamo.Text = "PRESTAMO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ALTA);
            this.groupBox1.Controls.Add(this.SIMULAR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lst_Cliente);
            this.groupBox1.Controls.Add(this.txtCuotaTotal);
            this.groupBox1.Controls.Add(this.lblCUOTA_total);
            this.groupBox1.Controls.Add(this.txtCuotaInteres);
            this.groupBox1.Controls.Add(this.lblCUOTA_interes);
            this.groupBox1.Controls.Add(this.txtCuotaCapital);
            this.groupBox1.Controls.Add(this.lblLinea);
            this.groupBox1.Controls.Add(this.lblTNA);
            this.groupBox1.Controls.Add(this.txtPlazo);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.lblPlazo);
            this.groupBox1.Controls.Add(this.txtTNA);
            this.groupBox1.Controls.Add(this.lblMonto);
            this.groupBox1.Controls.Add(this.txtLinea);
            this.groupBox1.Controls.Add(this.lblCUOTA_capital);
            this.groupBox1.Location = new System.Drawing.Point(28, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 376);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lst_Cliente
            // 
            this.lst_Cliente.FormattingEnabled = true;
            this.lst_Cliente.Location = new System.Drawing.Point(11, 65);
            this.lst_Cliente.Name = "lst_Cliente";
            this.lst_Cliente.Size = new System.Drawing.Size(216, 303);
            this.lst_Cliente.TabIndex = 36;
            // 
            // txtCuotaTotal
            // 
            this.txtCuotaTotal.Location = new System.Drawing.Point(351, 316);
            this.txtCuotaTotal.Name = "txtCuotaTotal";
            this.txtCuotaTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaTotal.TabIndex = 35;
            // 
            // lblCUOTA_total
            // 
            this.lblCUOTA_total.AutoSize = true;
            this.lblCUOTA_total.Location = new System.Drawing.Point(246, 316);
            this.lblCUOTA_total.Name = "lblCUOTA_total";
            this.lblCUOTA_total.Size = new System.Drawing.Size(82, 13);
            this.lblCUOTA_total.TabIndex = 34;
            this.lblCUOTA_total.Text = "CUOTA TOTAL";
            // 
            // txtCuotaInteres
            // 
            this.txtCuotaInteres.Location = new System.Drawing.Point(351, 281);
            this.txtCuotaInteres.Name = "txtCuotaInteres";
            this.txtCuotaInteres.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaInteres.TabIndex = 31;
            // 
            // lblCUOTA_interes
            // 
            this.lblCUOTA_interes.AutoSize = true;
            this.lblCUOTA_interes.Location = new System.Drawing.Point(246, 281);
            this.lblCUOTA_interes.Name = "lblCUOTA_interes";
            this.lblCUOTA_interes.Size = new System.Drawing.Size(81, 13);
            this.lblCUOTA_interes.TabIndex = 30;
            this.lblCUOTA_interes.Text = "CUOTA(interes)";
            // 
            // txtCuotaCapital
            // 
            this.txtCuotaCapital.Location = new System.Drawing.Point(351, 245);
            this.txtCuotaCapital.Name = "txtCuotaCapital";
            this.txtCuotaCapital.Size = new System.Drawing.Size(100, 20);
            this.txtCuotaCapital.TabIndex = 29;
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Location = new System.Drawing.Point(246, 72);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(33, 13);
            this.lblLinea.TabIndex = 17;
            this.lblLinea.Text = "Linea";
            // 
            // lblTNA
            // 
            this.lblTNA.AutoSize = true;
            this.lblTNA.Location = new System.Drawing.Point(246, 110);
            this.lblTNA.Name = "lblTNA";
            this.lblTNA.Size = new System.Drawing.Size(29, 13);
            this.lblTNA.TabIndex = 18;
            this.lblTNA.Text = "TNA";
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(351, 175);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(100, 20);
            this.txtPlazo.TabIndex = 27;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(351, 140);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 26;
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Location = new System.Drawing.Point(246, 180);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(33, 13);
            this.lblPlazo.TabIndex = 20;
            this.lblPlazo.Text = "Plazo";
            // 
            // txtTNA
            // 
            this.txtTNA.Location = new System.Drawing.Point(351, 103);
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.Size = new System.Drawing.Size(100, 20);
            this.txtTNA.TabIndex = 25;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(246, 146);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 21;
            this.lblMonto.Text = "Monto";
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(351, 69);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(100, 20);
            this.txtLinea.TabIndex = 24;
            // 
            // lblCUOTA_capital
            // 
            this.lblCUOTA_capital.AutoSize = true;
            this.lblCUOTA_capital.Location = new System.Drawing.Point(246, 245);
            this.lblCUOTA_capital.Name = "lblCUOTA_capital";
            this.lblCUOTA_capital.Size = new System.Drawing.Size(81, 13);
            this.lblCUOTA_capital.TabIndex = 22;
            this.lblCUOTA_capital.Text = "CUOTA(capital)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lst_Prestamo);
            this.groupBox2.Controls.Add(this.txtComisionTotal);
            this.groupBox2.Controls.Add(this.lblComisionTotal);
            this.groupBox2.Location = new System.Drawing.Point(506, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 376);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "PRESTAMOS DADOS DE ALTA";
            // 
            // lst_Prestamo
            // 
            this.lst_Prestamo.FormattingEnabled = true;
            this.lst_Prestamo.Location = new System.Drawing.Point(10, 63);
            this.lst_Prestamo.Name = "lst_Prestamo";
            this.lst_Prestamo.Size = new System.Drawing.Size(222, 264);
            this.lst_Prestamo.TabIndex = 36;
            // 
            // txtComisionTotal
            // 
            this.txtComisionTotal.Location = new System.Drawing.Point(121, 340);
            this.txtComisionTotal.Name = "txtComisionTotal";
            this.txtComisionTotal.Size = new System.Drawing.Size(100, 20);
            this.txtComisionTotal.TabIndex = 35;
            // 
            // lblComisionTotal
            // 
            this.lblComisionTotal.AutoSize = true;
            this.lblComisionTotal.Location = new System.Drawing.Point(7, 347);
            this.lblComisionTotal.Name = "lblComisionTotal";
            this.lblComisionTotal.Size = new System.Drawing.Size(98, 13);
            this.lblComisionTotal.TabIndex = 34;
            this.lblComisionTotal.Text = "COMISION TOTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "TIPOS PRESTAMO";
            // 
            // SIMULAR
            // 
            this.SIMULAR.Location = new System.Drawing.Point(249, 207);
            this.SIMULAR.Name = "SIMULAR";
            this.SIMULAR.Size = new System.Drawing.Size(202, 23);
            this.SIMULAR.TabIndex = 38;
            this.SIMULAR.Text = "button1";
            this.SIMULAR.UseVisualStyleBackColor = true;
            // 
            // ALTA
            // 
            this.ALTA.Location = new System.Drawing.Point(251, 342);
            this.ALTA.Name = "ALTA";
            this.ALTA.Size = new System.Drawing.Size(202, 23);
            this.ALTA.TabIndex = 39;
            this.ALTA.Text = "button2";
            this.ALTA.UseVisualStyleBackColor = true;
            // 
            // Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPrestamo);
            this.Name = "Prestamo";
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.Prestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_Cliente;
        private System.Windows.Forms.TextBox txtCuotaTotal;
        private System.Windows.Forms.Label lblCUOTA_total;
        private System.Windows.Forms.TextBox txtCuotaInteres;
        private System.Windows.Forms.Label lblCUOTA_interes;
        private System.Windows.Forms.TextBox txtCuotaCapital;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblTNA;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.TextBox txtTNA;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.Label lblCUOTA_capital;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_Prestamo;
        private System.Windows.Forms.TextBox txtComisionTotal;
        private System.Windows.Forms.Label lblComisionTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ALTA;
        private System.Windows.Forms.Button SIMULAR;
    }
}