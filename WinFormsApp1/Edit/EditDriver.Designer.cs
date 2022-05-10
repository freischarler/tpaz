namespace WinFormsApp1.Edit
{
    partial class EditDriver
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.dNac = new System.Windows.Forms.DateTimePicker();
            this.txtDNI = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNI)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(393, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(292, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 157);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.00862F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.99138F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dNac, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDNI, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cBoxID, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 125);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID#";
            // 
            // dNac
            // 
            this.dNac.Location = new System.Drawing.Point(184, 96);
            this.dNac.Name = "dNac";
            this.dNac.Size = new System.Drawing.Size(277, 29);
            this.dNac.TabIndex = 5;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(184, 65);
            this.txtDNI.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(277, 29);
            this.txtDNI.TabIndex = 4;
            this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(184, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 29);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // cBoxID
            // 
            this.cBoxID.FormattingEnabled = true;
            this.cBoxID.Location = new System.Drawing.Point(184, 3);
            this.cBoxID.Name = "cBoxID";
            this.cBoxID.Size = new System.Drawing.Size(277, 29);
            this.cBoxID.TabIndex = 7;
            this.cBoxID.SelectedIndexChanged += new System.EventHandler(this.cBoxID_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(325, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Estado";
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.cBoxStatus.Location = new System.Drawing.Point(387, 175);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(91, 29);
            this.cBoxStatus.TabIndex = 17;
            // 
            // EditDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 274);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cBoxStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditDriver";
            this.Text = "EditDriver";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDNI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private DateTimePicker dNac;
        private NumericUpDown txtDNI;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private ComboBox cBoxID;
        private Label label11;
        private ComboBox cBoxStatus;
    }
}