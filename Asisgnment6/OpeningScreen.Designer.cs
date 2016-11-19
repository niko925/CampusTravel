namespace Asisgnment6
{
    partial class OpeningScreen
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
            this.AddAgentBut = new System.Windows.Forms.Button();
            this.AddSaleBut = new System.Windows.Forms.Button();
            this.SearchSaleBut = new System.Windows.Forms.Button();
            this.bookingBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseTable = new System.Windows.Forms.Button();
            this.pathPageBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAgentBut
            // 
            this.AddAgentBut.Location = new System.Drawing.Point(497, 230);
            this.AddAgentBut.Name = "AddAgentBut";
            this.AddAgentBut.Size = new System.Drawing.Size(120, 42);
            this.AddAgentBut.TabIndex = 0;
            this.AddAgentBut.Text = "Add Agent";
            this.AddAgentBut.UseVisualStyleBackColor = true;
            this.AddAgentBut.Click += new System.EventHandler(this.AddAgentBut_Click);
            // 
            // AddSaleBut
            // 
            this.AddSaleBut.Location = new System.Drawing.Point(497, 295);
            this.AddSaleBut.Name = "AddSaleBut";
            this.AddSaleBut.Size = new System.Drawing.Size(120, 42);
            this.AddSaleBut.TabIndex = 1;
            this.AddSaleBut.Text = "Add Sale";
            this.AddSaleBut.UseVisualStyleBackColor = true;
            this.AddSaleBut.Click += new System.EventHandler(this.AddSaleBut_Click);
            // 
            // SearchSaleBut
            // 
            this.SearchSaleBut.Location = new System.Drawing.Point(143, 230);
            this.SearchSaleBut.Name = "SearchSaleBut";
            this.SearchSaleBut.Size = new System.Drawing.Size(120, 42);
            this.SearchSaleBut.TabIndex = 2;
            this.SearchSaleBut.Text = "Search Sale";
            this.SearchSaleBut.UseVisualStyleBackColor = true;
            this.SearchSaleBut.Click += new System.EventHandler(this.SearchSaleBut_Click);
            // 
            // bookingBut
            // 
            this.bookingBut.Location = new System.Drawing.Point(143, 295);
            this.bookingBut.Name = "bookingBut";
            this.bookingBut.Size = new System.Drawing.Size(120, 42);
            this.bookingBut.TabIndex = 3;
            this.bookingBut.Text = "Agent Booking";
            this.bookingBut.UseVisualStyleBackColor = true;
            this.bookingBut.Click += new System.EventHandler(this.bookingBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(111, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome To The Campus Travel Control Panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // databaseTable
            // 
            this.databaseTable.Location = new System.Drawing.Point(316, 168);
            this.databaseTable.Name = "databaseTable";
            this.databaseTable.Size = new System.Drawing.Size(137, 55);
            this.databaseTable.TabIndex = 5;
            this.databaseTable.Text = "Database Table";
            this.databaseTable.UseVisualStyleBackColor = true;
            this.databaseTable.Click += new System.EventHandler(this.databaseTable_Click);
            // 
            // pathPageBut
            // 
            this.pathPageBut.BackColor = System.Drawing.Color.Red;
            this.pathPageBut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pathPageBut.Location = new System.Drawing.Point(316, 262);
            this.pathPageBut.Name = "pathPageBut";
            this.pathPageBut.Size = new System.Drawing.Size(137, 42);
            this.pathPageBut.TabIndex = 8;
            this.pathPageBut.Text = "Database Path Setting";
            this.pathPageBut.UseVisualStyleBackColor = false;
            this.pathPageBut.Click += new System.EventHandler(this.pathPageBut_Click);
            this.pathPageBut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pathPageBut_KeyDown);
            this.pathPageBut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pathPageBut_MouseDown);
            this.pathPageBut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pathPageBut_Mouseup);
            // 
            // OpeningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 406);
            this.Controls.Add(this.pathPageBut);
            this.Controls.Add(this.databaseTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookingBut);
            this.Controls.Add(this.SearchSaleBut);
            this.Controls.Add(this.AddSaleBut);
            this.Controls.Add(this.AddAgentBut);
            this.Name = "OpeningScreen";
            this.Text = "Opening Screen";
            this.Load += new System.EventHandler(this.OpeningScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAgentBut;
        private System.Windows.Forms.Button AddSaleBut;
        private System.Windows.Forms.Button SearchSaleBut;
        private System.Windows.Forms.Button bookingBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button databaseTable;
        private System.Windows.Forms.Button pathPageBut;
    }
}