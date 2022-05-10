namespace WinFormsApp1.New
{
    partial class NewJourney
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtID = new System.Windows.Forms.Label();
            this.dFecha = new System.Windows.Forms.DateTimePicker();
            this.cBoxChofer = new System.Windows.Forms.ComboBox();
            this.cBoxCamion = new System.Windows.Forms.ComboBox();
            this.cBoxAcoplado = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDOLAR = new System.Windows.Forms.NumericUpDown();
            this.txtARG = new System.Windows.Forms.NumericUpDown();
            this.txtURU = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOLAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtARG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtURU)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "#ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Camion";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Acoplado";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chofer";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pesos Argentinos";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pesos Uruguayos";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dolares";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 199);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5443F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.4557F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dFecha, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cBoxChofer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cBoxCamion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cBoxAcoplado, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 173);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(95, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(297, 21);
            this.txtID.TabIndex = 5;
            this.txtID.Text = "ID";
            this.txtID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dFecha
            // 
            this.dFecha.Location = new System.Drawing.Point(95, 37);
            this.dFecha.Name = "dFecha";
            this.dFecha.Size = new System.Drawing.Size(296, 29);
            this.dFecha.TabIndex = 6;
            // 
            // cBoxChofer
            // 
            this.cBoxChofer.FormattingEnabled = true;
            this.cBoxChofer.Location = new System.Drawing.Point(95, 71);
            this.cBoxChofer.Name = "cBoxChofer";
            this.cBoxChofer.Size = new System.Drawing.Size(296, 29);
            this.cBoxChofer.TabIndex = 7;
            // 
            // cBoxCamion
            // 
            this.cBoxCamion.FormattingEnabled = true;
            this.cBoxCamion.Location = new System.Drawing.Point(95, 105);
            this.cBoxCamion.Name = "cBoxCamion";
            this.cBoxCamion.Size = new System.Drawing.Size(296, 29);
            this.cBoxCamion.TabIndex = 8;
            this.cBoxCamion.SelectedIndexChanged += new System.EventHandler(this.cBoxCamion_SelectedIndexChanged);
            // 
            // cBoxAcoplado
            // 
            this.cBoxAcoplado.FormattingEnabled = true;
            this.cBoxAcoplado.Location = new System.Drawing.Point(95, 139);
            this.cBoxAcoplado.Name = "cBoxAcoplado";
            this.cBoxAcoplado.Size = new System.Drawing.Size(296, 29);
            this.cBoxAcoplado.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 153);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Caja";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.96202F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.03798F));
            this.tableLayoutPanel2.Controls.Add(this.txtDOLAR, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtARG, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtURU, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(395, 119);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtDOLAR
            // 
            this.txtDOLAR.Location = new System.Drawing.Point(148, 81);
            this.txtDOLAR.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtDOLAR.Name = "txtDOLAR";
            this.txtDOLAR.Size = new System.Drawing.Size(243, 29);
            this.txtDOLAR.TabIndex = 10;
            this.txtDOLAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtARG
            // 
            this.txtARG.Location = new System.Drawing.Point(148, 3);
            this.txtARG.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtARG.Name = "txtARG";
            this.txtARG.Size = new System.Drawing.Size(243, 29);
            this.txtARG.TabIndex = 8;
            this.txtARG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtURU
            // 
            this.txtURU.Location = new System.Drawing.Point(148, 42);
            this.txtURU.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtURU.Name = "txtURU";
            this.txtURU.Size = new System.Drawing.Size(243, 29);
            this.txtURU.TabIndex = 9;
            this.txtURU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(217, 380);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 33);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(318, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 33);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // NewJourney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 428);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewJourney";
            this.Text = "NewJourney";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDOLAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtARG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtURU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label txtID;
        private DateTimePicker dFecha;
        private ComboBox cBoxChofer;
        private ComboBox cBoxCamion;
        private ComboBox cBoxAcoplado;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private NumericUpDown txtDOLAR;
        private NumericUpDown txtARG;
        private NumericUpDown txtURU;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}