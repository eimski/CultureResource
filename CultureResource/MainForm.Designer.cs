namespace CultureResource
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.button_save = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.japaneseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new CultureResource.AppData();
            this.label_test = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(622, 440);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(85, 40);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "&Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.englishDataGridViewTextBoxColumn,
            this.japaneseDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.languagesBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(39, 34);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(668, 370);
            this.dataGridView.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // englishDataGridViewTextBoxColumn
            // 
            this.englishDataGridViewTextBoxColumn.DataPropertyName = "English";
            this.englishDataGridViewTextBoxColumn.HeaderText = "English";
            this.englishDataGridViewTextBoxColumn.Name = "englishDataGridViewTextBoxColumn";
            // 
            // japaneseDataGridViewTextBoxColumn
            // 
            this.japaneseDataGridViewTextBoxColumn.DataPropertyName = "Japanese";
            this.japaneseDataGridViewTextBoxColumn.HeaderText = "Japanese";
            this.japaneseDataGridViewTextBoxColumn.Name = "japaneseDataGridViewTextBoxColumn";
            // 
            // languagesBindingSource
            // 
            this.languagesBindingSource.DataMember = "Languages";
            this.languagesBindingSource.DataSource = this.appDataBindingSource;
            // 
            // appDataBindingSource
            // 
            this.appDataBindingSource.DataSource = this.appData;
            this.appDataBindingSource.Position = 0;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_test
            // 
            this.label_test.AutoSize = true;
            this.label_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_test.Location = new System.Drawing.Point(35, 449);
            this.label_test.Name = "label_test";
            this.label_test.Size = new System.Drawing.Size(36, 20);
            this.label_test.TabIndex = 2;
            this.label_test.Text = "test";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 492);
            this.Controls.Add(this.label_test);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button_save);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Culture";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn japaneseDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource languagesBindingSource;
        private System.Windows.Forms.BindingSource appDataBindingSource;
        private AppData appData;
        private System.Windows.Forms.Label label_test;
    }
}

