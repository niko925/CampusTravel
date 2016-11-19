namespace Asisgnment6
{
    partial class SearchSales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAgent = new System.Windows.Forms.ComboBox();
            this.aGENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAMPUSDataSet3 = new Asisgnment6.CAMPUSDataSet3();
            this.dESTINATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAMPUSDataSet4 = new Asisgnment6.CAMPUSDataSet4();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.aGENTTableAdapter = new Asisgnment6.CAMPUSDataSet3TableAdapters.AGENTTableAdapter();
            this.dESTINATIONTableAdapter = new Asisgnment6.CAMPUSDataSet4TableAdapters.DESTINATIONTableAdapter();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.aGENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESTINATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(35, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amounts Above";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(35, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amounts Below";
            // 
            // cbAgent
            // 
            this.cbAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbAgent.FormattingEnabled = true;
            this.cbAgent.Location = new System.Drawing.Point(183, 47);
            this.cbAgent.Name = "cbAgent";
            this.cbAgent.Size = new System.Drawing.Size(161, 32);
            this.cbAgent.TabIndex = 4;
            // 
            // aGENTBindingSource
            // 
            this.aGENTBindingSource.DataMember = "AGENT";
            this.aGENTBindingSource.DataSource = this.cAMPUSDataSet3;
            // 
            // cAMPUSDataSet3
            // 
            this.cAMPUSDataSet3.DataSetName = "CAMPUSDataSet3";
            this.cAMPUSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dESTINATIONBindingSource
            // 
            this.dESTINATIONBindingSource.DataMember = "DESTINATION";
            this.dESTINATIONBindingSource.DataSource = this.cAMPUSDataSet4;
            // 
            // cAMPUSDataSet4
            // 
            this.cAMPUSDataSet4.DataSetName = "CAMPUSDataSet4";
            this.cAMPUSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(183, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 29);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(183, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 29);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(39, 262);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(112, 47);
            this.butSearch.TabIndex = 8;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // butClose
            // 
            this.butClose.Location = new System.Drawing.Point(183, 262);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(112, 47);
            this.butClose.TabIndex = 9;
            this.butClose.Text = "Close";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // aGENTTableAdapter
            // 
            this.aGENTTableAdapter.ClearBeforeFill = true;
            // 
            // dESTINATIONTableAdapter
            // 
            this.dESTINATIONTableAdapter.ClearBeforeFill = true;
            // 
            // cbDestination
            // 
            this.cbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(183, 87);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(161, 32);
            this.cbDestination.TabIndex = 10;
            // 
            // SearchSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 381);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbAgent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchSales";
            this.Text = "Search Sales";
            this.Load += new System.EventHandler(this.SearchSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aGENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESTINATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAgent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butClose;
        private CAMPUSDataSet3 cAMPUSDataSet3;
        private System.Windows.Forms.BindingSource aGENTBindingSource;
        private CAMPUSDataSet3TableAdapters.AGENTTableAdapter aGENTTableAdapter;
        private CAMPUSDataSet4 cAMPUSDataSet4;
        private System.Windows.Forms.BindingSource dESTINATIONBindingSource;
        private CAMPUSDataSet4TableAdapters.DESTINATIONTableAdapter dESTINATIONTableAdapter;
        private System.Windows.Forms.ComboBox cbDestination;
    }
}