namespace prjct_winforms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cálculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.msiAbrirCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.calculo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opc2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opc3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cálculadoraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(900, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cálculadoraToolStripMenuItem
            // 
            this.cálculadoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiCalculadora,
            this.opc2ToolStripMenuItem,
            this.opc3ToolStripMenuItem});
            this.cálculadoraToolStripMenuItem.Name = "cálculadoraToolStripMenuItem";
            this.cálculadoraToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.cálculadoraToolStripMenuItem.Text = "Cálculadora";
            this.cálculadoraToolStripMenuItem.ToolTipText = "Abrir a cálculadora";
            // 
            // tsiCalculadora
            // 
            this.tsiCalculadora.CheckOnClick = true;
            this.tsiCalculadora.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAbrirCalculadora,
            this.calculo2ToolStripMenuItem});
            this.tsiCalculadora.Name = "tsiCalculadora";
            this.tsiCalculadora.Size = new System.Drawing.Size(206, 34);
            this.tsiCalculadora.Text = "Cálculadora";
            this.tsiCalculadora.Click += new System.EventHandler(this.tsiCalculadora_Click);
            // 
            // msiAbrirCalculadora
            // 
            this.msiAbrirCalculadora.AutoToolTip = true;
            this.msiAbrirCalculadora.Name = "msiAbrirCalculadora";
            this.msiAbrirCalculadora.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.msiAbrirCalculadora.Size = new System.Drawing.Size(312, 34);
            this.msiAbrirCalculadora.Text = "Abrir Cálculadora";
            this.msiAbrirCalculadora.ToolTipText = "Abre a cálculadora para diversos cálculos matemáticos";
            this.msiAbrirCalculadora.Click += new System.EventHandler(this.msiAbrirCalculadora_Click);
            // 
            // calculo2ToolStripMenuItem
            // 
            this.calculo2ToolStripMenuItem.Name = "calculo2ToolStripMenuItem";
            this.calculo2ToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.calculo2ToolStripMenuItem.Text = "calculo 2";
            // 
            // opc2ToolStripMenuItem
            // 
            this.opc2ToolStripMenuItem.Name = "opc2ToolStripMenuItem";
            this.opc2ToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.opc2ToolStripMenuItem.Text = "opc 2";
            // 
            // opc3ToolStripMenuItem
            // 
            this.opc3ToolStripMenuItem.Name = "opc3ToolStripMenuItem";
            this.opc3ToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.opc3ToolStripMenuItem.Text = "opc 3";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsiCalculadora;
        private System.Windows.Forms.ToolStripMenuItem msiAbrirCalculadora;
        private System.Windows.Forms.ToolStripMenuItem calculo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opc2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opc3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cálculadoraToolStripMenuItem;
    }
}