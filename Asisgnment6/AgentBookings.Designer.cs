namespace Asisgnment6
{
    partial class AgentBookings
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
            this.CloseBut = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.agentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.officeLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numSales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseBut
            // 
            this.CloseBut.Location = new System.Drawing.Point(95, 120);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(129, 65);
            this.CloseBut.TabIndex = 0;
            this.CloseBut.Text = "Close";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.agentName,
            this.officeLocation,
            this.numSales,
            this.total});
            this.listView1.Location = new System.Drawing.Point(277, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(433, 332);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // agentName
            // 
            this.agentName.Text = "Agent Name";
            this.agentName.Width = 150;
            // 
            // officeLocation
            // 
            this.officeLocation.Text = "Office Location";
            this.officeLocation.Width = 150;
            // 
            // numSales
            // 
            this.numSales.Text = "# Sales";
            // 
            // total
            // 
            this.total.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(54, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agent Bookings";
            // 
            // AgentBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.CloseBut);
            this.Name = "AgentBookings";
            this.Text = "Agent Bookings";
            this.Load += new System.EventHandler(this.AgentBookings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader agentName;
        private System.Windows.Forms.ColumnHeader officeLocation;
        private System.Windows.Forms.ColumnHeader numSales;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.Label label1;
    }
}