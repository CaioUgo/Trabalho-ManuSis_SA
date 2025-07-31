namespace Trabalho_ManuSis_SA
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelTopo = new Guna.UI2.WinForms.Guna2Panel();
            panelLateral = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            SuspendLayout();
            // 
            // panelTopo
            // 
            panelTopo.BackColor = Color.DarkSlateGray;
            panelTopo.CustomizableEdges = customizableEdges1;
            panelTopo.Dock = DockStyle.Top;
            panelTopo.Location = new Point(0, 0);
            panelTopo.Name = "panelTopo";
            panelTopo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            panelTopo.Size = new Size(992, 29);
            panelTopo.TabIndex = 0;
            // 
            // panelLateral
            // 
            panelLateral.BackColor = SystemColors.InactiveCaption;
            panelLateral.CustomizableEdges = customizableEdges3;
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 29);
            panelLateral.Name = "panelLateral";
            panelLateral.ShadowDecoration.CustomizableEdges = customizableEdges4;
            panelLateral.Size = new Size(115, 550);
            panelLateral.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = SystemColors.AppWorkspace;
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(115, 29);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(877, 550);
            guna2Panel1.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 579);
            Controls.Add(guna2Panel1);
            Controls.Add(panelLateral);
            Controls.Add(panelTopo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelTopo;
        private Guna.UI2.WinForms.Guna2Panel panelLateral;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
