namespace WinFormsApp1.Edit
{
    partial class EditTrailer
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
            this.label11 = new System.Windows.Forms.Label();
            this.cBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dPoliza = new System.Windows.Forms.DateTimePicker();
            this.dSenasa = new System.Windows.Forms.DateTimePicker();
            this.dRutas = new System.Windows.Forms.DateTimePicker();
            this.dVTV = new System.Windows.Forms.DateTimePicker();
            this.dEngrasado = new System.Windows.Forms.DateTimePicker();
            this.dService = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cBoxID = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(229, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 21);
            this.label11.TabIndex = 16;
            this.label11.Text = "Estado";
            // 
            // cBoxStatus
            // 
            this.cBoxStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxStatus.FormattingEnabled = true;
            this.cBoxStatus.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.cBoxStatus.Location = new System.Drawing.Point(291, 414);
            this.cBoxStatus.Name = "cBoxStatus";
            this.cBoxStatus.Size = new System.Drawing.Size(91, 29);
            this.cBoxStatus.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(268, 463);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 33);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(148, 463);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 33);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 236);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vencimientos";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.66752F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.33248F));
            this.tableLayoutPanel1.Controls.Add(this.dPoliza, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dSenasa, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dRutas, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dVTV, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dEngrasado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dService, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 211);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // dPoliza
            // 
            this.dPoliza.Location = new System.Drawing.Point(119, 178);
            this.dPoliza.Name = "dPoliza";
            this.dPoliza.Size = new System.Drawing.Size(269, 29);
            this.dPoliza.TabIndex = 17;
            // 
            // dSenasa
            // 
            this.dSenasa.Location = new System.Drawing.Point(119, 143);
            this.dSenasa.Name = "dSenasa";
            this.dSenasa.Size = new System.Drawing.Size(269, 29);
            this.dSenasa.TabIndex = 16;
            // 
            // dRutas
            // 
            this.dRutas.Location = new System.Drawing.Point(119, 108);
            this.dRutas.Name = "dRutas";
            this.dRutas.Size = new System.Drawing.Size(269, 29);
            this.dRutas.TabIndex = 15;
            // 
            // dVTV
            // 
            this.dVTV.Location = new System.Drawing.Point(119, 73);
            this.dVTV.Name = "dVTV";
            this.dVTV.Size = new System.Drawing.Size(269, 29);
            this.dVTV.TabIndex = 14;
            // 
            // dEngrasado
            // 
            this.dEngrasado.Location = new System.Drawing.Point(119, 3);
            this.dEngrasado.Name = "dEngrasado";
            this.dEngrasado.Size = new System.Drawing.Size(269, 29);
            this.dEngrasado.TabIndex = 8;
            // 
            // dService
            // 
            this.dService.Location = new System.Drawing.Point(119, 38);
            this.dService.Name = "dService";
            this.dService.Size = new System.Drawing.Size(269, 29);
            this.dService.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Engrasado";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Poliza seguro";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Senasa";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Service";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "VTV";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rutas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 153);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.14286F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.85714F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtPatente, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtModelo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cBoxID, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(391, 120);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "ID#";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patente";
            // 
            // txtPatente
            // 
            this.txtPatente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPatente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPatente.Location = new System.Drawing.Point(128, 85);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(260, 29);
            this.txtPatente.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModelo.Location = new System.Drawing.Point(128, 45);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(260, 29);
            this.txtModelo.TabIndex = 2;
            // 
            // cBoxID
            // 
            this.cBoxID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxID.FormattingEnabled = true;
            this.cBoxID.Location = new System.Drawing.Point(128, 3);
            this.cBoxID.Name = "cBoxID";
            this.cBoxID.Size = new System.Drawing.Size(260, 29);
            this.cBoxID.TabIndex = 7;
            this.cBoxID.SelectedIndexChanged += new System.EventHandler(this.cBoxID_SelectedIndexChanged);
            // 
            // EditTrailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 507);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cBoxStatus);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditTrailer";
            this.Text = "EditTrailer";
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label11;
        private ComboBox cBoxStatus;
        private Button btnCancelar;
        private Button btnGuardar;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dPoliza;
        private DateTimePicker dSenasa;
        private DateTimePicker dRutas;
        private DateTimePicker dVTV;
        private DateTimePicker dEngrasado;
        private DateTimePicker dService;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label9;
        private Label label1;
        private Label label2;
        private TextBox txtPatente;
        private TextBox txtModelo;
        private ComboBox cBoxID;
    }
}