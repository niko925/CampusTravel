namespace Asisgnment6
{
    partial class AddSale
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
            this.CloseBut = new System.Windows.Forms.Button();
            this.bSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAgent = new System.Windows.Forms.ComboBox();
            this.aGENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAMPUSDataSet1 = new Asisgnment6.CAMPUSDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDestinaiton = new System.Windows.Forms.ComboBox();
            this.dESTINATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cAMPUSDataSet2 = new Asisgnment6.CAMPUSDataSet2();
            this.aGENTTableAdapter = new Asisgnment6.CAMPUSDataSet1TableAdapters.AGENTTableAdapter();
            this.dESTINATIONTableAdapter = new Asisgnment6.CAMPUSDataSet2TableAdapters.DESTINATIONTableAdapter();
            this.labDate = new System.Windows.Forms.Label();
            this.cAMPUSDataSet3 = new Asisgnment6.CAMPUSDataSet3();
            this.aGENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aGENTTableAdapter1 = new Asisgnment6.CAMPUSDataSet3TableAdapters.AGENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aGENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESTINATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBut
            // 
            this.CloseBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CloseBut.Location = new System.Drawing.Point(472, 313);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(99, 47);
            this.CloseBut.TabIndex = 1;
            this.CloseBut.Text = "Close";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // bSubmit
            // 
            this.bSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bSubmit.Location = new System.Drawing.Point(338, 313);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(99, 47);
            this.bSubmit.TabIndex = 6;
            this.bSubmit.Text = "Add Sale";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Sale";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(75, 125);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(350, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Agent:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbAgent
            // 
            this.cbAgent.DataSource = this.aGENTBindingSource1;
            this.cbAgent.DisplayMember = "AgentName";
            this.cbAgent.DropDownWidth = 150;
            this.cbAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbAgent.FormattingEnabled = true;
            this.cbAgent.Location = new System.Drawing.Point(463, 89);
            this.cbAgent.Name = "cbAgent";
            this.cbAgent.Size = new System.Drawing.Size(150, 32);
            this.cbAgent.TabIndex = 11;
            this.cbAgent.ValueMember = "AgentId";
            this.cbAgent.SelectedIndexChanged += new System.EventHandler(this.cbAgent_SelectedIndexChanged);
            // 
            // aGENTBindingSource
            // 
            this.aGENTBindingSource.DataMember = "AGENT";
            this.aGENTBindingSource.DataSource = this.cAMPUSDataSet1;
            // 
            // cAMPUSDataSet1
            // 
            this.cAMPUSDataSet1.DataSetName = "CAMPUSDataSet1";
            this.cAMPUSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(350, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAmount.Location = new System.Drawing.Point(463, 144);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 29);
            this.txtAmount.TabIndex = 13;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(350, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Destination:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbDestinaiton
            // 
            this.cbDestinaiton.DataSource = this.dESTINATIONBindingSource;
            this.cbDestinaiton.DisplayMember = "DestinationName";
            this.cbDestinaiton.DropDownWidth = 150;
            this.cbDestinaiton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbDestinaiton.FormattingEnabled = true;
            this.cbDestinaiton.Location = new System.Drawing.Point(463, 191);
            this.cbDestinaiton.Name = "cbDestinaiton";
            this.cbDestinaiton.Size = new System.Drawing.Size(150, 32);
            this.cbDestinaiton.TabIndex = 15;
            this.cbDestinaiton.ValueMember = "DestinationId";
            this.cbDestinaiton.SelectedIndexChanged += new System.EventHandler(this.cbDestinaiton_SelectedIndexChanged);
            // 
            // dESTINATIONBindingSource
            // 
            this.dESTINATIONBindingSource.DataMember = "DESTINATION";
            this.dESTINATIONBindingSource.DataSource = this.cAMPUSDataSet2;
            // 
            // cAMPUSDataSet2
            // 
            this.cAMPUSDataSet2.DataSetName = "CAMPUSDataSet2";
            this.cAMPUSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aGENTTableAdapter
            // 
            this.aGENTTableAdapter.ClearBeforeFill = true;
            // 
            // dESTINATIONTableAdapter
            // 
            this.dESTINATIONTableAdapter.ClearBeforeFill = true;
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDate.Location = new System.Drawing.Point(71, 92);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(45, 24);
            this.labDate.TabIndex = 16;
            this.labDate.Text = "data";
            this.labDate.Click += new System.EventHandler(this.label6_Click);
            // 
            // cAMPUSDataSet3
            // 
            this.cAMPUSDataSet3.DataSetName = "CAMPUSDataSet3";
            this.cAMPUSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aGENTBindingSource1
            // 
            this.aGENTBindingSource1.DataMember = "AGENT";
            this.aGENTBindingSource1.DataSource = this.cAMPUSDataSet3;
            // 
            // aGENTTableAdapter1
            // 
            this.aGENTTableAdapter1.ClearBeforeFill = true;
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 422);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.cbDestinaiton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbAgent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.CloseBut);
            this.Name = "AddSale";
            this.Text = "Add Sales";
            this.Load += new System.EventHandler(this.AddSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aGENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESTINATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAMPUSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGENTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAgent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDestinaiton;
        private CAMPUSDataSet1 cAMPUSDataSet1;
        private System.Windows.Forms.BindingSource aGENTBindingSource;
        private CAMPUSDataSet1TableAdapters.AGENTTableAdapter aGENTTableAdapter;
        private CAMPUSDataSet2 cAMPUSDataSet2;
        private System.Windows.Forms.BindingSource dESTINATIONBindingSource;
        private CAMPUSDataSet2TableAdapters.DESTINATIONTableAdapter dESTINATIONTableAdapter;
        private System.Windows.Forms.Label labDate;
        private CAMPUSDataSet3 cAMPUSDataSet3;
        private System.Windows.Forms.BindingSource aGENTBindingSource1;
        private CAMPUSDataSet3TableAdapters.AGENTTableAdapter aGENTTableAdapter1;
    }
}