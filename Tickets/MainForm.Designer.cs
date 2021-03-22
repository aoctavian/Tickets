
namespace Tickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLogIn = new System.Windows.Forms.Button();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelTickets = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.btnShowAll = new System.Windows.Forms.ToolStripButton();
            this.btnShowOpened = new System.Windows.Forms.ToolStripButton();
            this.btnShowClosed = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.btnCreateTicket = new System.Windows.Forms.ToolStripButton();
            this.panelTickets.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(391, 262);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(99, 33);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // layoutPanel
            // 
            this.layoutPanel.AutoSize = true;
            this.layoutPanel.BackColor = System.Drawing.SystemColors.Window;
            this.layoutPanel.ColumnCount = 1;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutPanel.Location = new System.Drawing.Point(0, 10);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 1;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel.Size = new System.Drawing.Size(882, 0);
            this.layoutPanel.TabIndex = 3;
            // 
            // panelTickets
            // 
            this.panelTickets.AutoScroll = true;
            this.panelTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTickets.Controls.Add(this.layoutPanel);
            this.panelTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTickets.Location = new System.Drawing.Point(0, 0);
            this.panelTickets.Name = "panelTickets";
            this.panelTickets.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelTickets.Size = new System.Drawing.Size(884, 561);
            this.panelTickets.TabIndex = 4;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.btnShowAll,
            this.btnShowOpened,
            this.btnShowClosed,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.btnCreateTicket});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStrip.Size = new System.Drawing.Size(82, 561);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.Visible = false;
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton7.Enabled = false;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(75, 19);
            this.toolStripButton7.Text = "View";
            // 
            // btnShowAll
            // 
            this.btnShowAll.CheckOnClick = true;
            this.btnShowAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowAll.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAll.Image")));
            this.btnShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 19);
            this.btnShowAll.Text = "All";
            this.btnShowAll.ToolTipText = "All Tickets";
            this.btnShowAll.Click += new System.EventHandler(this.ViewTickets_Click);
            // 
            // btnShowOpened
            // 
            this.btnShowOpened.Checked = true;
            this.btnShowOpened.CheckOnClick = true;
            this.btnShowOpened.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnShowOpened.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowOpened.Image = ((System.Drawing.Image)(resources.GetObject("btnShowOpened.Image")));
            this.btnShowOpened.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowOpened.Name = "btnShowOpened";
            this.btnShowOpened.Size = new System.Drawing.Size(75, 19);
            this.btnShowOpened.Text = "Opened";
            this.btnShowOpened.ToolTipText = "Opened Tickets";
            this.btnShowOpened.Click += new System.EventHandler(this.ViewTickets_Click);
            // 
            // btnShowClosed
            // 
            this.btnShowClosed.CheckOnClick = true;
            this.btnShowClosed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowClosed.Image = ((System.Drawing.Image)(resources.GetObject("btnShowClosed.Image")));
            this.btnShowClosed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowClosed.Name = "btnShowClosed";
            this.btnShowClosed.Size = new System.Drawing.Size(75, 19);
            this.btnShowClosed.Text = "Closed";
            this.btnShowClosed.ToolTipText = "Closed Tickets";
            this.btnShowClosed.Click += new System.EventHandler(this.ViewTickets_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(75, 6);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Enabled = false;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(75, 19);
            this.toolStripButton5.Text = "Options";
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.BackColor = System.Drawing.SystemColors.Window;
            this.btnCreateTicket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCreateTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateTicket.Image")));
            this.btnCreateTicket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(75, 19);
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.Click += new System.EventHandler(this.BtnCreateTicket_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelTickets);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnLogIn);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTickets.ResumeLayout(false);
            this.panelTickets.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.Panel panelTickets;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnShowClosed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnShowAll;
        private System.Windows.Forms.ToolStripButton btnShowOpened;
        private System.Windows.Forms.ToolStripButton btnCreateTicket;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}

