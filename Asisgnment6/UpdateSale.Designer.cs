namespace Asisgnment6
{
    partial class UpdateSale
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
            this.butUpdate = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labDate = new System.Windows.Forms.Label();
            this.cbDestinaiton = new System.Windows.Forms.ComboBox();
            this.dESTINATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAMPUSDataSet6 = new Asisgnment6.CAMPUSDataSet6();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAgent = new System.Windows.Forms.ComboBox();
            this.aGENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAMPUSDataSet7 = new Asisgnment6.CAMPUSDataSet7();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cAMPUSDataSet = new Asisgnment6.CAMPUSDataSet();
            this.cAMPUSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAMPUSDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cAMPUSDataSet3 = new Asisgnment6.CAMPUSDataSet3();
            this.cAMPUSDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dESTINATIONTableAdapter = new Asisgnment6.CAMPUSDataSet6TableAdapters.DESTINATIONTableAdapter();
            this.aGENTTableAdapter = new Asisgnment6.CAMPUSDataSet7TableAdapters.AGENTTableAdapter();
            this.cAMPUSDataSet8 = new Asisgnment6.CAMPUSDataSet8();
            this.aGENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aGENTTableAdapter1 = new Asisgnment6.CAMPUSDataSet8TableAdapters.AGENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dESTINATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // butUpdate
            // 
            this.butUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butUpdate.Location = new System.Drawing.Point(309, 272);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(133, 47);
            this.butUpdate.TabIndex = 0;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butDelete
            // 
            this.butDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butDelete.Location = new System.Drawing.Point(499, 272);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(133, 47);
            this.butDelete.TabIndex = 1;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butClose
            // 
            this.butClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butClose.Location = new System.Drawing.Point(401, 346);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(142, 62);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "Close";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(48, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(584, 79);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Destination";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Agent";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Office";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sale Id";
            this.columnHeader6.Width = 0;
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDate.Location = new System.Drawing.Point(112, 114);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(45, 24);
            this.labDate.TabIndex = 25;
            this.labDate.Text = "data";
            // 
            // cbDestinaiton
            // 
            this.cbDestinaiton.DataSource = this.dESTINATIONBindingSource;
            this.cbDestinaiton.DisplayMember = "DestinationName";
            this.cbDestinaiton.DropDownWidth = 150;
            this.cbDestinaiton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbDestinaiton.FormattingEnabled = true;
            this.cbDestinaiton.Location = new System.Drawing.Point(418, 212);
            this.cbDestinaiton.Name = "cbDestinaiton";
            this.cbDestinaiton.Size = new System.Drawing.Size(150, 32);
            this.cbDestinaiton.TabIndex = 24;
            this.cbDestinaiton.ValueMember = "DestinationId";
            // 
            // dESTINATIONBindingSource
            // 
            this.dESTINATIONBindingSource.DataMember = "DESTINATION";
            this.dESTINATIONBindingSource.DataSource = this.cAMPUSDataSet6;
            // 
            // cAMPUSDataSet6
            // 
            this.cAMPUSDataSet6.DataSetName = "CAMPUSDataSet6";
            this.cAMPUSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(305, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Destination:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(418, 177);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 29);
            this.txtAmount.TabIndex = 22;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(305, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Amount:";
            // 
            // cbAgent
            // 
            this.cbAgent.DataSource = this.aGENTBindingSource1;
            this.cbAgent.DisplayMember = "AgentName";
            this.cbAgent.DropDownWidth = 150;
            this.cbAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbAgent.FormattingEnabled = true;
            this.cbAgent.Location = new System.Drawing.Point(418, 139);
            this.cbAgent.Name = "cbAgent";
            this.cbAgent.Size = new System.Drawing.Size(150, 32);
            this.cbAgent.TabIndex = 20;
            this.cbAgent.ValueMember = "AgentId";
            this.cbAgent.SelectedIndexChanged += new System.EventHandler(this.cbAgent_SelectedIndexChanged);
            // 
            // aGENTBindingSource
            // 
            this.aGENTBindingSource.DataMember = "AGENT";
            this.aGENTBindingSource.DataSource = this.cAMPUSDataSet7;
            // 
            // cAMPUSDataSet7
            // 
            this.cAMPUSDataSet7.DataSetName = "CAMPUSDataSet7";
            this.cAMPUSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(305, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Agent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(53, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Date:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(57, 147);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // cAMPUSDataSet
            // 
            this.cAMPUSDataSet.DataSetName = "CAMPUSDataSet";
            this.cAMPUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAMPUSDataSetBindingSource
            // 
            this.cAMPUSDataSetBindingSource.DataSource = this.cAMPUSDataSet;
            this.cAMPUSDataSetBindingSource.Position = 0;
            // 
            // cAMPUSDataSetBindingSource1
            // 
            this.cAMPUSDataSetBindingSource1.DataSource = this.cAMPUSDataSet;
            this.cAMPUSDataSetBindingSource1.Position = 0;
            // 
            // cAMPUSDataSet3
            // 
            this.cAMPUSDataSet3.DataSetName = "CAMPUSDataSet3";
            this.cAMPUSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cAMPUSDataSet3BindingSource
            // 
            this.cAMPUSDataSet3BindingSource.DataSource = this.cAMPUSDataSet3;
            this.cAMPUSDataSet3BindingSource.Position = 0;
            // 
            // dESTINATIONTableAdapter
            // 
            this.dESTINATIONTableAdapter.ClearBeforeFill = true;
            // 
            // aGENTTableAdapter
            // 
            this.aGENTTableAdapter.ClearBeforeFill = true;
            // 
            // cAMPUSDataSet8
            // 
            this.cAMPUSDataSet8.DataSetName = "CAMPUSDataSet8";
            this.cAMPUSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aGENTBindingSource1
            // 
            this.aGENTBindingSource1.DataMember = "AGENT";
            this.aGENTBindingSource1.DataSource = this.cAMPUSDataSet8;
            // 
            // aGENTTableAdapter1
            // 
            this.aGENTTableAdapter1.ClearBeforeFill = true;
            // 
            // UpdateSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 420);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.cbDestinaiton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAgent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butUpdate);
            this.Name = "UpdateSale";
            this.Text = "UpdateSale";
            this.Load += new System.EventHandler(this.UpdateSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dESTINATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.ComboBox cbDestinaiton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAgent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private CAMPUSDataSet cAMPUSDataSet;
        private System.Windows.Forms.BindingSource cAMPUSDataSetBindingSource;
        private System.Windows.Forms.BindingSource cAMPUSDataSetBindingSource1;
        private CAMPUSDataSet3 cAMPUSDataSet3;
        private System.Windows.Forms.BindingSource cAMPUSDataSet3BindingSource;
        private CAMPUSDataSet6 cAMPUSDataSet6;
        private System.Windows.Forms.BindingSource dESTINATIONBindingSource;
        private CAMPUSDataSet6TableAdapters.DESTINATIONTableAdapter dESTINATIONTableAdapter;
        private CAMPUSDataSet7 cAMPUSDataSet7;
        private System.Windows.Forms.BindingSource aGENTBindingSource;
        private CAMPUSDataSet7TableAdapters.AGENTTableAdapter aGENTTableAdapter;
        private CAMPUSDataSet8 cAMPUSDataSet8;
        private System.Windows.Forms.BindingSource aGENTBindingSource1;
        private CAMPUSDataSet8TableAdapters.AGENTTableAdapter aGENTTableAdapter1;
    }
}