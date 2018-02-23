namespace Practica_bits_y_bytes
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
            this.btnprocess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLlenado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVieto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnProcessData = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnprocess
            // 
            this.btnprocess.Location = new System.Drawing.Point(12, 15);
            this.btnprocess.Name = "btnprocess";
            this.btnprocess.Size = new System.Drawing.Size(75, 23);
            this.btnprocess.TabIndex = 1;
            this.btnprocess.Text = "Procesar";
            this.btnprocess.UseVisualStyleBackColor = true;
            this.btnprocess.Click += new System.EventHandler(this.btnprocess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sensor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sensor 2";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(107, 15);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(46, 20);
            this.txtnumero.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Proceso de Llenado";
            // 
            // lblLlenado
            // 
            this.lblLlenado.AutoSize = true;
            this.lblLlenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlenado.Location = new System.Drawing.Point(194, 58);
            this.lblLlenado.Name = "lblLlenado";
            this.lblLlenado.Size = new System.Drawing.Size(122, 16);
            this.lblLlenado.TabIndex = 6;
            this.lblLlenado.Text = "Estado de Llendao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Movimiento del Viento";
            // 
            // lblVieto
            // 
            this.lblVieto.AutoSize = true;
            this.lblVieto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVieto.Location = new System.Drawing.Point(380, 54);
            this.lblVieto.Name = "lblVieto";
            this.lblVieto.Size = new System.Drawing.Size(24, 25);
            this.lblVieto.TabIndex = 8;
            this.lblVieto.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Lectura";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(183, 118);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(111, 20);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "YYYY/MM/DD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(424, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "_____________________________________________________________________-";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // btnProcessData
            // 
            this.btnProcessData.Location = new System.Drawing.Point(173, 234);
            this.btnProcessData.Name = "btnProcessData";
            this.btnProcessData.Size = new System.Drawing.Size(75, 23);
            this.btnProcessData.TabIndex = 13;
            this.btnProcessData.Text = "Procesar";
            this.btnProcessData.UseVisualStyleBackColor = true;
            this.btnProcessData.Click += new System.EventHandler(this.btnProcessData_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(163, 263);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 317);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnProcessData);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblVieto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLlenado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnprocess);
            this.Name = "Form1";
            this.Text = "Practica Bits y Bytes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnprocess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLlenado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVieto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnProcessData;
        private System.Windows.Forms.TextBox txtNum;
    }
}

