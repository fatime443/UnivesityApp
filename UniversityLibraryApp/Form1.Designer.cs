namespace UniversityLibraryApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFacultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pcImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Firebrick;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.readersToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(649, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.addAuthorsToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(74, 27);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.aToolStripMenuItem.Text = "Add Books";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // addAuthorsToolStripMenuItem
            // 
            this.addAuthorsToolStripMenuItem.Name = "addAuthorsToolStripMenuItem";
            this.addAuthorsToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.addAuthorsToolStripMenuItem.Text = "Add Authors";
            // 
            // readersToolStripMenuItem
            // 
            this.readersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReadersToolStripMenuItem,
            this.addFacultyToolStripMenuItem});
            this.readersToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.readersToolStripMenuItem.Name = "readersToolStripMenuItem";
            this.readersToolStripMenuItem.Size = new System.Drawing.Size(90, 27);
            this.readersToolStripMenuItem.Text = "Readers";
            // 
            // addReadersToolStripMenuItem
            // 
            this.addReadersToolStripMenuItem.Name = "addReadersToolStripMenuItem";
            this.addReadersToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.addReadersToolStripMenuItem.Text = "Add Readers";
            // 
            // addFacultyToolStripMenuItem
            // 
            this.addFacultyToolStripMenuItem.Name = "addFacultyToolStripMenuItem";
            this.addFacultyToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.addFacultyToolStripMenuItem.Text = "Add Faculty";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(71, 27);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pcImage
            // 
            this.pcImage.Image = ((System.Drawing.Image)(resources.GetObject("pcImage.Image")));
            this.pcImage.Location = new System.Drawing.Point(49, 79);
            this.pcImage.Name = "pcImage";
            this.pcImage.Size = new System.Drawing.Size(539, 315);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcImage.TabIndex = 2;
            this.pcImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 425);
            this.Controls.Add(this.pcImage);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFacultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pcImage;
    }
}

