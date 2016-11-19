namespace Asisgnment6
{
    partial class DatabaseTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAMPUSDataSet5 = new Asisgnment6.CAMPUSDataSet5();
            this.sALESTableAdapter = new Asisgnment6.CAMPUSDataSet5TableAdapters.SALESTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIdDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.agentKeyDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.destinationKeyDataGridViewTextBoxColumn,
            this.agentIdDataGridViewTextBoxColumn,
            this.agentNameDataGridViewTextBoxColumn,
            this.officeKeyDataGridViewTextBoxColumn,
            this.officeIdDataGridViewTextBoxColumn,
            this.officeLocationDataGridViewTextBoxColumn,
            this.destinationIdDataGridViewTextBoxColumn,
            this.destinationNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sALESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // saleIdDataGridViewTextBoxColumn
            // 
            this.saleIdDataGridViewTextBoxColumn.DataPropertyName = "SaleId";
            this.saleIdDataGridViewTextBoxColumn.HeaderText = "SaleId";
            this.saleIdDataGridViewTextBoxColumn.Name = "saleIdDataGridViewTextBoxColumn";
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            // 
            // agentKeyDataGridViewTextBoxColumn
            // 
            this.agentKeyDataGridViewTextBoxColumn.DataPropertyName = "AgentKey";
            this.agentKeyDataGridViewTextBoxColumn.HeaderText = "AgentKey";
            this.agentKeyDataGridViewTextBoxColumn.Name = "agentKeyDataGridViewTextBoxColumn";
            this.agentKeyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.agentKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // destinationKeyDataGridViewTextBoxColumn
            // 
            this.destinationKeyDataGridViewTextBoxColumn.DataPropertyName = "DestinationKey";
            this.destinationKeyDataGridViewTextBoxColumn.HeaderText = "DestinationKey";
            this.destinationKeyDataGridViewTextBoxColumn.Name = "destinationKeyDataGridViewTextBoxColumn";
            this.destinationKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // agentIdDataGridViewTextBoxColumn
            // 
            this.agentIdDataGridViewTextBoxColumn.DataPropertyName = "AgentId";
            this.agentIdDataGridViewTextBoxColumn.HeaderText = "AgentId";
            this.agentIdDataGridViewTextBoxColumn.Name = "agentIdDataGridViewTextBoxColumn";
            this.agentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // agentNameDataGridViewTextBoxColumn
            // 
            this.agentNameDataGridViewTextBoxColumn.DataPropertyName = "AgentName";
            this.agentNameDataGridViewTextBoxColumn.HeaderText = "AgentName";
            this.agentNameDataGridViewTextBoxColumn.Name = "agentNameDataGridViewTextBoxColumn";
            // 
            // officeKeyDataGridViewTextBoxColumn
            // 
            this.officeKeyDataGridViewTextBoxColumn.DataPropertyName = "OfficeKey";
            this.officeKeyDataGridViewTextBoxColumn.HeaderText = "OfficeKey";
            this.officeKeyDataGridViewTextBoxColumn.Name = "officeKeyDataGridViewTextBoxColumn";
            this.officeKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // officeIdDataGridViewTextBoxColumn
            // 
            this.officeIdDataGridViewTextBoxColumn.DataPropertyName = "OfficeId";
            this.officeIdDataGridViewTextBoxColumn.HeaderText = "OfficeId";
            this.officeIdDataGridViewTextBoxColumn.Name = "officeIdDataGridViewTextBoxColumn";
            this.officeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // officeLocationDataGridViewTextBoxColumn
            // 
            this.officeLocationDataGridViewTextBoxColumn.DataPropertyName = "OfficeLocation";
            this.officeLocationDataGridViewTextBoxColumn.HeaderText = "OfficeLocation";
            this.officeLocationDataGridViewTextBoxColumn.Name = "officeLocationDataGridViewTextBoxColumn";
            // 
            // destinationIdDataGridViewTextBoxColumn
            // 
            this.destinationIdDataGridViewTextBoxColumn.DataPropertyName = "DestinationId";
            this.destinationIdDataGridViewTextBoxColumn.HeaderText = "DestinationId";
            this.destinationIdDataGridViewTextBoxColumn.Name = "destinationIdDataGridViewTextBoxColumn";
            this.destinationIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // destinationNameDataGridViewTextBoxColumn
            // 
            this.destinationNameDataGridViewTextBoxColumn.DataPropertyName = "DestinationName";
            this.destinationNameDataGridViewTextBoxColumn.HeaderText = "DestinationName";
            this.destinationNameDataGridViewTextBoxColumn.Name = "destinationNameDataGridViewTextBoxColumn";
            // 
            // sALESBindingSource
            // 
            this.sALESBindingSource.DataMember = "SALES";
            this.sALESBindingSource.DataSource = this.cAMPUSDataSet5;
            // 
            // cAMPUSDataSet5
            // 
            this.cAMPUSDataSet5.DataSetName = "CAMPUSDataSet5";
            this.cAMPUSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sALESTableAdapter
            // 
            this.sALESTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(724, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database Table";
            // 
            // DatabaseTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DatabaseTable";
            this.Text = "DatabaseTable";
            this.Load += new System.EventHandler(this.DatabaseTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CAMPUSDataSet5 cAMPUSDataSet5;
        private System.Windows.Forms.BindingSource sALESBindingSource;
        private CAMPUSDataSet5TableAdapters.SALESTableAdapter sALESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}