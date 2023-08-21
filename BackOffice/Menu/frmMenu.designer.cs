namespace BackOffice.Menu
{
    partial class frmMenu
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnPanelPrincipal = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Gray;
            this.panelButtons.Controls.Add(this.btnSalir);
            this.panelButtons.Controls.Add(this.btnUsuarios);
            this.panelButtons.Controls.Add(this.btnPersona);
            this.panelButtons.Controls.Add(this.btnPanelPrincipal);
            this.panelButtons.Controls.Add(this.btnEmpresa);
            this.panelButtons.Location = new System.Drawing.Point(1, 0);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(199, 633);
            this.panelButtons.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(15, 590);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(153, 28);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Cerrar Sesión";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(15, 241);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(153, 28);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Empleados";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(15, 187);
            this.btnPersona.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(153, 28);
            this.btnPersona.TabIndex = 4;
            this.btnPersona.Text = "Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnPanelPrincipal
            // 
            this.btnPanelPrincipal.Location = new System.Drawing.Point(15, 127);
            this.btnPanelPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.btnPanelPrincipal.Name = "btnPanelPrincipal";
            this.btnPanelPrincipal.Size = new System.Drawing.Size(153, 28);
            this.btnPanelPrincipal.TabIndex = 3;
            this.btnPanelPrincipal.Text = "Panel Principal";
            this.btnPanelPrincipal.UseVisualStyleBackColor = true;
            this.btnPanelPrincipal.Click += new System.EventHandler(this.btnPanelPrincipal_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Location = new System.Drawing.Point(15, 71);
            this.btnEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(153, 28);
            this.btnEmpresa.TabIndex = 2;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Location = new System.Drawing.Point(197, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1003, 633);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(337, 154);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 240);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(317, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sistema de cuenta por cobrar";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 633);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelButtons);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load_1);
            this.panelButtons.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnPanelPrincipal;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}