namespace Sotfware_PolleriaPioChicken
{
    partial class MantenedorCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxEstadoCL = new System.Windows.Forms.CheckBox();
            this.txtIdCL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLeerCL = new System.Windows.Forms.Button();
            this.btnEliminarCL = new System.Windows.Forms.Button();
            this.btnModificarCL = new System.Windows.Forms.Button();
            this.btnCrearCL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCliente.Location = new System.Drawing.Point(12, 12);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(520, 182);
            this.dgvCliente.TabIndex = 5;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.cbxEstadoCL);
            this.groupBox1.Controls.Add(this.txtIdCL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreCL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 198);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // cbxEstadoCL
            // 
            this.cbxEstadoCL.AutoSize = true;
            this.cbxEstadoCL.Location = new System.Drawing.Point(20, 142);
            this.cbxEstadoCL.Name = "cbxEstadoCL";
            this.cbxEstadoCL.Size = new System.Drawing.Size(145, 18);
            this.cbxEstadoCL.TabIndex = 13;
            this.cbxEstadoCL.Text = "ESTADO DEL CLIENTE";
            this.cbxEstadoCL.UseVisualStyleBackColor = true;
            // 
            // txtIdCL
            // 
            this.txtIdCL.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCL.Location = new System.Drawing.Point(87, 34);
            this.txtIdCL.Name = "txtIdCL";
            this.txtIdCL.Size = new System.Drawing.Size(327, 20);
            this.txtIdCL.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txtNombreCL
            // 
            this.txtNombreCL.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCL.Location = new System.Drawing.Point(87, 79);
            this.txtNombreCL.Name = "txtNombreCL";
            this.txtNombreCL.Size = new System.Drawing.Size(327, 20);
            this.txtNombreCL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnLeerCL);
            this.groupBox2.Controls.Add(this.btnEliminarCL);
            this.groupBox2.Controls.Add(this.btnModificarCL);
            this.groupBox2.Controls.Add(this.btnCrearCL);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 75);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPERACIONES";
            // 
            // btnLeerCL
            // 
            this.btnLeerCL.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerCL.Location = new System.Drawing.Point(386, 19);
            this.btnLeerCL.Name = "btnLeerCL";
            this.btnLeerCL.Size = new System.Drawing.Size(116, 42);
            this.btnLeerCL.TabIndex = 8;
            this.btnLeerCL.Text = "Consultar";
            this.btnLeerCL.UseVisualStyleBackColor = true;
            this.btnLeerCL.Click += new System.EventHandler(this.btnLeerCL_Click);
            // 
            // btnEliminarCL
            // 
            this.btnEliminarCL.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCL.Location = new System.Drawing.Point(142, 19);
            this.btnEliminarCL.Name = "btnEliminarCL";
            this.btnEliminarCL.Size = new System.Drawing.Size(116, 42);
            this.btnEliminarCL.TabIndex = 7;
            this.btnEliminarCL.Text = "Eliminar";
            this.btnEliminarCL.UseVisualStyleBackColor = true;
            this.btnEliminarCL.Click += new System.EventHandler(this.btnEliminarCL_Click);
            // 
            // btnModificarCL
            // 
            this.btnModificarCL.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCL.Location = new System.Drawing.Point(264, 19);
            this.btnModificarCL.Name = "btnModificarCL";
            this.btnModificarCL.Size = new System.Drawing.Size(116, 42);
            this.btnModificarCL.TabIndex = 6;
            this.btnModificarCL.Text = "Modificar";
            this.btnModificarCL.UseVisualStyleBackColor = true;
            this.btnModificarCL.Click += new System.EventHandler(this.btnModificarCL_Click);
            // 
            // btnCrearCL
            // 
            this.btnCrearCL.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCL.Location = new System.Drawing.Point(20, 19);
            this.btnCrearCL.Name = "btnCrearCL";
            this.btnCrearCL.Size = new System.Drawing.Size(116, 42);
            this.btnCrearCL.TabIndex = 3;
            this.btnCrearCL.Text = "Crear";
            this.btnCrearCL.UseVisualStyleBackColor = true;
            this.btnCrearCL.Click += new System.EventHandler(this.btnCrearCL_Click);
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 491);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCliente);
            this.Name = "MantenedorCliente";
            this.Text = "MantenedorCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreCL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLeerCL;
        private System.Windows.Forms.Button btnEliminarCL;
        private System.Windows.Forms.Button btnModificarCL;
        private System.Windows.Forms.Button btnCrearCL;
        private System.Windows.Forms.TextBox txtIdCL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxEstadoCL;
    }
}