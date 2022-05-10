namespace WinFormsApp1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnVerCamion = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acopladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acopladoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.choferToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSync = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listPriority = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataActiveJourney = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acoplado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataActiveJourney)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerCamion
            // 
            this.btnVerCamion.Location = new System.Drawing.Point(349, 22);
            this.btnVerCamion.Name = "btnVerCamion";
            this.btnVerCamion.Size = new System.Drawing.Size(69, 31);
            this.btnVerCamion.TabIndex = 25;
            this.btnVerCamion.Text = "VER";
            this.btnVerCamion.UseVisualStyleBackColor = true;
            this.btnVerCamion.Click += new System.EventHandler(this.btnVerCamion_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viajeToolStripMenuItem,
            this.camionToolStripMenuItem,
            this.acopladoToolStripMenuItem,
            this.choferToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // viajeToolStripMenuItem
            // 
            this.viajeToolStripMenuItem.Name = "viajeToolStripMenuItem";
            this.viajeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.viajeToolStripMenuItem.Text = "Viaje";
            this.viajeToolStripMenuItem.Click += new System.EventHandler(this.viajeToolStripMenuItem_Click);
            // 
            // camionToolStripMenuItem
            // 
            this.camionToolStripMenuItem.Name = "camionToolStripMenuItem";
            this.camionToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.camionToolStripMenuItem.Text = "Camion";
            this.camionToolStripMenuItem.Click += new System.EventHandler(this.camionToolStripMenuItem_Click);
            // 
            // acopladoToolStripMenuItem
            // 
            this.acopladoToolStripMenuItem.Name = "acopladoToolStripMenuItem";
            this.acopladoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.acopladoToolStripMenuItem.Text = "Acoplado";
            this.acopladoToolStripMenuItem.Click += new System.EventHandler(this.acopladoToolStripMenuItem_Click);
            // 
            // choferToolStripMenuItem
            // 
            this.choferToolStripMenuItem.Name = "choferToolStripMenuItem";
            this.choferToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.choferToolStripMenuItem.Text = "Chofer";
            this.choferToolStripMenuItem.Click += new System.EventHandler(this.choferToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camionToolStripMenuItem1,
            this.acopladoToolStripMenuItem1,
            this.choferToolStripMenuItem1});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // camionToolStripMenuItem1
            // 
            this.camionToolStripMenuItem1.Name = "camionToolStripMenuItem1";
            this.camionToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.camionToolStripMenuItem1.Text = "Camion";
            this.camionToolStripMenuItem1.Click += new System.EventHandler(this.camionToolStripMenuItem1_Click);
            // 
            // acopladoToolStripMenuItem1
            // 
            this.acopladoToolStripMenuItem1.Name = "acopladoToolStripMenuItem1";
            this.acopladoToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.acopladoToolStripMenuItem1.Text = "Acoplado";
            this.acopladoToolStripMenuItem1.Click += new System.EventHandler(this.acopladoToolStripMenuItem1_Click);
            // 
            // choferToolStripMenuItem1
            // 
            this.choferToolStripMenuItem1.Name = "choferToolStripMenuItem1";
            this.choferToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.choferToolStripMenuItem1.Text = "Chofer";
            this.choferToolStripMenuItem1.Click += new System.EventHandler(this.choferToolStripMenuItem1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 900000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(638, 80);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(75, 23);
            this.btnSync.TabIndex = 27;
            this.btnSync.Text = "SYNC";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status,
            this.StatusDate});
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 28;
            this.statusBar.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.AutoSize = false;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(650, 17);
            this.Status.Text = "Status";
            // 
            // StatusDate
            // 
            this.StatusDate.Name = "StatusDate";
            this.StatusDate.Size = new System.Drawing.Size(63, 17);
            this.StatusDate.Text = "StatusDate";
            this.StatusDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listPriority);
            this.groupBox1.Location = new System.Drawing.Point(12, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 217);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista prioridades";
            // 
            // listPriority
            // 
            this.listPriority.FormattingEnabled = true;
            this.listPriority.ItemHeight = 15;
            this.listPriority.Location = new System.Drawing.Point(6, 22);
            this.listPriority.Name = "listPriority";
            this.listPriority.Size = new System.Drawing.Size(331, 184);
            this.listPriority.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataActiveJourney);
            this.groupBox2.Controls.Add(this.btnVerCamion);
            this.groupBox2.Location = new System.Drawing.Point(12, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 147);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Viajes activos";
            // 
            // dataActiveJourney
            // 
            this.dataActiveJourney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataActiveJourney.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fecha,
            this.Camion,
            this.Acoplado,
            this.Chofer});
            this.dataActiveJourney.Location = new System.Drawing.Point(6, 22);
            this.dataActiveJourney.Name = "dataActiveJourney";
            this.dataActiveJourney.RowHeadersVisible = false;
            this.dataActiveJourney.RowTemplate.Height = 25;
            this.dataActiveJourney.Size = new System.Drawing.Size(337, 119);
            this.dataActiveJourney.TabIndex = 32;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 35;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 80;
            // 
            // Camion
            // 
            this.Camion.HeaderText = "Camion";
            this.Camion.Name = "Camion";
            this.Camion.ReadOnly = true;
            this.Camion.Width = 60;
            // 
            // Acoplado
            // 
            this.Acoplado.HeaderText = "Acoplado";
            this.Acoplado.Name = "Acoplado";
            this.Acoplado.ReadOnly = true;
            this.Acoplado.Width = 60;
            // 
            // Chofer
            // 
            this.Chofer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Chofer.HeaderText = "Chofer";
            this.Chofer.Name = "Chofer";
            this.Chofer.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataActiveJourney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVerCamion;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem viajeToolStripMenuItem;
        private ToolStripMenuItem camionToolStripMenuItem;
        private ToolStripMenuItem acopladoToolStripMenuItem;
        private ToolStripMenuItem choferToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem camionToolStripMenuItem1;
        private ToolStripMenuItem acopladoToolStripMenuItem1;
        private ToolStripMenuItem choferToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private Button btnSync;
        private StatusStrip statusBar;
        private ToolStripStatusLabel Status;
        private ToolStripStatusLabel StatusDate;
        private GroupBox groupBox1;
        private ListBox listPriority;
        private GroupBox groupBox2;
        private DataGridView dataActiveJourney;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Camion;
        private DataGridViewTextBoxColumn Acoplado;
        private DataGridViewTextBoxColumn Chofer;
    }
}