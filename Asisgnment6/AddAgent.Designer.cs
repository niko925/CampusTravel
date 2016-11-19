namespace Asisgnment6
{
    partial class AddAgent
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.bSubmit = new System.Windows.Forms.Button();
            this.cbOfficeLocation = new System.Windows.Forms.ComboBox();
            this.oFFICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAMPUSDataSet = new Asisgnment6.CAMPUSDataSet();
            this.oFFICETableAdapter = new Asisgnment6.CAMPUSDataSetTableAdapters.OFFICETableAdapter();
            this.CloseWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.oFFICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(430, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(494, 322);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Agent Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Office Location";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "# Sales";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Sales";
            this.columnHeader4.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agent Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Office Location";
            // 
            // txtAgentName
            // 
            this.txtAgentName.Location = new System.Drawing.Point(165, 59);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(115, 20);
            this.txtAgentName.TabIndex = 3;
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(60, 190);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(121, 50);
            this.bSubmit.TabIndex = 5;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // cbOfficeLocation
            // 
            this.cbOfficeLocation.DataSource = this.oFFICEBindingSource;
            this.cbOfficeLocation.DisplayMember = "OfficeLocation";
            this.cbOfficeLocation.FormattingEnabled = true;
            this.cbOfficeLocation.Location = new System.Drawing.Point(165, 103);
            this.cbOfficeLocation.Name = "cbOfficeLocation";
            this.cbOfficeLocation.Size = new System.Drawing.Size(115, 21);
            this.cbOfficeLocation.TabIndex = 6;
            this.cbOfficeLocation.ValueMember = "OfficeId";
            // 
            // oFFICEBindingSource
            // 
            this.oFFICEBindingSource.DataMember = "OFFICE";
            this.oFFICEBindingSource.DataSource = this.cAMPUSDataSet;
            // 
            // cAMPUSDataSet
            // 
            this.cAMPUSDataSet.DataSetName = "CAMPUSDataSet";
            this.cAMPUSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oFFICETableAdapter
            // 
            this.oFFICETableAdapter.ClearBeforeFill = true;
            // 
            // CloseWindow
            // 
            this.CloseWindow.Location = new System.Drawing.Point(180, 335);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(183, 46);
            this.CloseWindow.TabIndex = 7;
            this.CloseWindow.Text = "Close Window";
            this.CloseWindow.UseVisualStyleBackColor = true;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // AddAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 480);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.cbOfficeLocation);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.txtAgentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Name = "AddAgent";
            this.Text = "Add Agent";
            this.Load += new System.EventHandler(this.AddAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oFFICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgentName;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.ComboBox cbOfficeLocation;
        private CAMPUSDataSet cAMPUSDataSet;
        private System.Windows.Forms.BindingSource oFFICEBindingSource;
        private CAMPUSDataSetTableAdapters.OFFICETableAdapter oFFICETableAdapter;
        private System.Windows.Forms.Button CloseWindow;
    }
}

