
namespace Algoritmos_DekkerPeterson
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSetData = new System.Windows.Forms.TextBox();
            this.txtTimeoutP1 = new System.Windows.Forms.TextBox();
            this.txtTimeoutP2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdP2 = new System.Windows.Forms.TextBox();
            this.txtIdP1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tooltipDescription = new System.Windows.Forms.ToolTip(this.components);
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algoritmos Dekker y Peterson";
            // 
            // cmbOption
            // 
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Items.AddRange(new object[] {
            "Algoritmos de Dekker Versión 1",
            "Algoritmos de Dekker Versión 2",
            "Algoritmos de Dekker Versión 3",
            "Algoritmos de Dekker Versión 4",
            "Algoritmos de Dekker Versión 5",
            "Algoritmo Peterson"});
            this.cmbOption.Location = new System.Drawing.Point(219, 248);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(281, 21);
            this.cmbOption.TabIndex = 1;
            this.tooltipDescription.SetToolTip(this.cmbOption, "Selecciona una opcion de algoritmo");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Algoritmos Dekker y Peterson";
            // 
            // txtSetData
            // 
            this.txtSetData.Location = new System.Drawing.Point(114, 353);
            this.txtSetData.Multiline = true;
            this.txtSetData.Name = "txtSetData";
            this.txtSetData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSetData.Size = new System.Drawing.Size(510, 294);
            this.txtSetData.TabIndex = 3;
            // 
            // txtTimeoutP1
            // 
            this.txtTimeoutP1.Location = new System.Drawing.Point(232, 190);
            this.txtTimeoutP1.Name = "txtTimeoutP1";
            this.txtTimeoutP1.Size = new System.Drawing.Size(100, 21);
            this.txtTimeoutP1.TabIndex = 4;
            this.tooltipDescription.SetToolTip(this.txtTimeoutP1, "Ingresa cantidad en milisegundos");
            // 
            // txtTimeoutP2
            // 
            this.txtTimeoutP2.Location = new System.Drawing.Point(385, 190);
            this.txtTimeoutP2.Name = "txtTimeoutP2";
            this.txtTimeoutP2.Size = new System.Drawing.Size(100, 21);
            this.txtTimeoutP2.TabIndex = 5;
            this.tooltipDescription.SetToolTip(this.txtTimeoutP2, "Ingresa cantidad en milisegundos");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Definicion de tiempo milisegundos para cada proceso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Proceso 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proceso 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Proceso 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Proceso 1";
            // 
            // txtIdP2
            // 
            this.txtIdP2.Location = new System.Drawing.Point(385, 117);
            this.txtIdP2.Name = "txtIdP2";
            this.txtIdP2.Size = new System.Drawing.Size(100, 21);
            this.txtIdP2.TabIndex = 10;
            this.tooltipDescription.SetToolTip(this.txtIdP2, "Establece un ID unico para el proceso.");
            // 
            // txtIdP1
            // 
            this.txtIdP1.Location = new System.Drawing.Point(232, 117);
            this.txtIdP1.Name = "txtIdP1";
            this.txtIdP1.Size = new System.Drawing.Size(100, 21);
            this.txtIdP1.TabIndex = 9;
            this.tooltipDescription.SetToolTip(this.txtIdP1, "Establece un ID unico para el proceso.");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(272, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Definir ID para cada proceso";
            // 
            // tooltipDescription
            // 
            this.tooltipDescription.IsBalloon = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(257, 304);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 14;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(388, 304);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reiniciar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(135)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(757, 669);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdP2);
            this.Controls.Add(this.txtIdP1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTimeoutP2);
            this.Controls.Add(this.txtTimeoutP1);
            this.Controls.Add(this.txtSetData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOption);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSetData;
        private System.Windows.Forms.TextBox txtTimeoutP1;
        private System.Windows.Forms.TextBox txtTimeoutP2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdP2;
        private System.Windows.Forms.TextBox txtIdP1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip tooltipDescription;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnReset;
    }
}

