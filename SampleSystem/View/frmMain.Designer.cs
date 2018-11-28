namespace SampleSystem
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDentist = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.agendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgDentists = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgAttendances = new System.Windows.Forms.ToolStripMenuItem();
            this.MAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuporte = new System.Windows.Forms.ToolStripMenuItem();
            this.MSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.agendasToolStripMenuItem,
            this.MAjuda,
            this.MSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDentist,
            this.menuPatient,
            this.menuAttendance});
            this.cadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.Image")));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.cadastrosToolStripMenuItem.Text = "Records";
            // 
            // menuDentist
            // 
            this.menuDentist.Name = "menuDentist";
            this.menuDentist.Size = new System.Drawing.Size(135, 22);
            this.menuDentist.Text = "Dentist";
            this.menuDentist.Click += new System.EventHandler(this.menuDentist_Click);
            // 
            // menuPatient
            // 
            this.menuPatient.Name = "menuPatient";
            this.menuPatient.Size = new System.Drawing.Size(135, 22);
            this.menuPatient.Text = "Patient";
            // 
            // menuAttendance
            // 
            this.menuAttendance.Name = "menuAttendance";
            this.menuAttendance.Size = new System.Drawing.Size(135, 22);
            this.menuAttendance.Text = "Attendance";
            // 
            // agendasToolStripMenuItem
            // 
            this.agendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgDentists,
            this.menuAgPatients,
            this.menuAgAttendances});
            this.agendasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agendasToolStripMenuItem.Image")));
            this.agendasToolStripMenuItem.Name = "agendasToolStripMenuItem";
            this.agendasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.agendasToolStripMenuItem.Text = "Schedule";
            // 
            // menuAgDentists
            // 
            this.menuAgDentists.Name = "menuAgDentists";
            this.menuAgDentists.Size = new System.Drawing.Size(140, 22);
            this.menuAgDentists.Text = "Dentists";
            this.menuAgDentists.Click += new System.EventHandler(this.menuAgDentists_Click);
            // 
            // menuAgPatients
            // 
            this.menuAgPatients.Name = "menuAgPatients";
            this.menuAgPatients.Size = new System.Drawing.Size(140, 22);
            this.menuAgPatients.Text = "Patients";
            // 
            // menuAgAttendances
            // 
            this.menuAgAttendances.Name = "menuAgAttendances";
            this.menuAgAttendances.Size = new System.Drawing.Size(140, 22);
            this.menuAgAttendances.Text = "Attendances";
            // 
            // MAjuda
            // 
            this.MAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSuporte});
            this.MAjuda.Image = ((System.Drawing.Image)(resources.GetObject("MAjuda.Image")));
            this.MAjuda.Name = "MAjuda";
            this.MAjuda.Size = new System.Drawing.Size(60, 20);
            this.MAjuda.Text = "Help";
            // 
            // menuSuporte
            // 
            this.menuSuporte.Name = "menuSuporte";
            this.menuSuporte.Size = new System.Drawing.Size(116, 22);
            this.menuSuporte.Text = "Support";
            // 
            // MSair
            // 
            this.MSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSair});
            this.MSair.Image = ((System.Drawing.Image)(resources.GetObject("MSair.Image")));
            this.MSair.Name = "MSair";
            this.MSair.Size = new System.Drawing.Size(53, 20);
            this.MSair.Text = "Exit";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(180, 22);
            this.menuSair.Text = "Quit";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Sample System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MAjuda;
        private System.Windows.Forms.ToolStripMenuItem MSair;
        private System.Windows.Forms.ToolStripMenuItem menuDentist;
        private System.Windows.Forms.ToolStripMenuItem menuPatient;
        private System.Windows.Forms.ToolStripMenuItem menuAttendance;
        private System.Windows.Forms.ToolStripMenuItem menuAgDentists;
        private System.Windows.Forms.ToolStripMenuItem menuAgPatients;
        private System.Windows.Forms.ToolStripMenuItem menuAgAttendances;
        private System.Windows.Forms.ToolStripMenuItem menuSuporte;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
    }
}

