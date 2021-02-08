
namespace Project_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.loadData = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.codeDpmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeMun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDpmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox1.Location = new System.Drawing.Point(37, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escoja una letra";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar información según la letra escogida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Mostrar gráfico pastel de la cantidad de municipios de cada departamento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(37, 48);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(118, 35);
            this.loadData.TabIndex = 4;
            this.loadData.Text = "Cargar archivo...";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(226, 59);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(169, 13);
            this.path.TabIndex = 5;
            this.path.Text = "-- Ruta del archivo seleccionado --";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDpmt,
            this.codeMun,
            this.nameDpmt,
            this.nameMun,
            this.type});
            this.dgv.Location = new System.Drawing.Point(37, 212);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(587, 251);
            this.dgv.TabIndex = 6;
            // 
            // codeDpmt
            // 
            this.codeDpmt.HeaderText = "Código Departamento";
            this.codeDpmt.Name = "codeDpmt";
            // 
            // codeMun
            // 
            this.codeMun.HeaderText = "Código Municipio";
            this.codeMun.Name = "codeMun";
            // 
            // nameDpmt
            // 
            this.nameDpmt.HeaderText = "Nombre Departamento";
            this.nameDpmt.Name = "nameDpmt";
            // 
            // nameMun
            // 
            this.nameMun.HeaderText = "Nombre Municipio";
            this.nameMun.Name = "nameMun";
            // 
            // type
            // 
            this.type.HeaderText = "Tipo";
            this.type.Name = "type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 540);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.path);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Tarea #7 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDpmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeMun;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDpmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMun;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}

