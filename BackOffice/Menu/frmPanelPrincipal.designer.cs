namespace BackOffice.Menu
{
    partial class frmPanelPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListaCuenta = new System.Windows.Forms.Button();
            this.btnNuevaCuenta = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnListaCuenta);
            this.panel1.Controls.Add(this.btnNuevaCuenta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 634);
            this.panel1.TabIndex = 2;
            // 
            // btnListaCuenta
            // 
            this.btnListaCuenta.Location = new System.Drawing.Point(12, 169);
            this.btnListaCuenta.Name = "btnListaCuenta";
            this.btnListaCuenta.Size = new System.Drawing.Size(100, 70);
            this.btnListaCuenta.TabIndex = 3;
            this.btnListaCuenta.Text = "Lista de Cuentas";
            this.btnListaCuenta.UseVisualStyleBackColor = true;
            this.btnListaCuenta.Click += new System.EventHandler(this.btnListaCuenta_Click);
            // 
            // btnNuevaCuenta
            // 
            this.btnNuevaCuenta.Location = new System.Drawing.Point(12, 82);
            this.btnNuevaCuenta.Name = "btnNuevaCuenta";
            this.btnNuevaCuenta.Size = new System.Drawing.Size(100, 69);
            this.btnNuevaCuenta.TabIndex = 2;
            this.btnNuevaCuenta.Text = "Nueva Cuenta";
            this.btnNuevaCuenta.UseVisualStyleBackColor = true;
            this.btnNuevaCuenta.Click += new System.EventHandler(this.btnNuevaCuenta_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMain.Location = new System.Drawing.Point(150, 15);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1026, 603);
            this.panelMain.TabIndex = 3;
            // 
            // frmPanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1199, 633);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPanelPrincipal";
            this.Text = "frmPanelPrincipal";
            this.Load += new System.EventHandler(this.frmPanelPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnNuevaCuenta;
        private System.Windows.Forms.Button btnListaCuenta;
    }
}