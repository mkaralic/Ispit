namespace Zadatak2
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            ljubimciBindingSource = new BindingSource(components);
            saveButton = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vrstaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cenaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nivoSreceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nivoHraneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ljubimciBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ljubimciBindingSource
            // 
            ljubimciBindingSource.DataSource = typeof(Models.Ljubimac);
            // 
            // saveButton
            // 
            saveButton.Location = new Point(747, 517);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 0;
            saveButton.Text = "Snimi";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, imeDataGridViewTextBoxColumn, vrstaDataGridViewTextBoxColumn, cenaDataGridViewTextBoxColumn, nivoSreceDataGridViewTextBoxColumn, nivoHraneDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ljubimciBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(829, 488);
            dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            imeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vrstaDataGridViewTextBoxColumn
            // 
            vrstaDataGridViewTextBoxColumn.DataPropertyName = "Vrsta";
            vrstaDataGridViewTextBoxColumn.HeaderText = "Vrsta";
            vrstaDataGridViewTextBoxColumn.MinimumWidth = 6;
            vrstaDataGridViewTextBoxColumn.Name = "vrstaDataGridViewTextBoxColumn";
            vrstaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            cenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            cenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nivoSreceDataGridViewTextBoxColumn
            // 
            nivoSreceDataGridViewTextBoxColumn.DataPropertyName = "NivoSrece";
            nivoSreceDataGridViewTextBoxColumn.HeaderText = "NivoSrece";
            nivoSreceDataGridViewTextBoxColumn.MinimumWidth = 6;
            nivoSreceDataGridViewTextBoxColumn.Name = "nivoSreceDataGridViewTextBoxColumn";
            nivoSreceDataGridViewTextBoxColumn.Width = 125;
            // 
            // nivoHraneDataGridViewTextBoxColumn
            // 
            nivoHraneDataGridViewTextBoxColumn.DataPropertyName = "NivoHrane";
            nivoHraneDataGridViewTextBoxColumn.HeaderText = "NivoHrane";
            nivoHraneDataGridViewTextBoxColumn.MinimumWidth = 6;
            nivoHraneDataGridViewTextBoxColumn.Name = "nivoHraneDataGridViewTextBoxColumn";
            nivoHraneDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 559);
            Controls.Add(dataGridView1);
            Controls.Add(saveButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ljubimciBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource ljubimciBindingSource;
        private Button saveButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vrstaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nivoSreceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nivoHraneDataGridViewTextBoxColumn;
    }
}
