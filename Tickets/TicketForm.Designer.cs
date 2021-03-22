
namespace Tickets
{
    partial class TicketForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbSubject = new System.Windows.Forms.RichTextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbServiceType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPriority = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbCreatedAtText = new System.Windows.Forms.Label();
            this.lbCreatedAt = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCloseTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // rtbSubject
            // 
            this.rtbSubject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtbSubject.Location = new System.Drawing.Point(16, 40);
            this.rtbSubject.Name = "rtbSubject";
            this.rtbSubject.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbSubject.Size = new System.Drawing.Size(875, 62);
            this.rtbSubject.TabIndex = 2;
            this.rtbSubject.Text = "";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtbDescription.Location = new System.Drawing.Point(16, 135);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDescription.Size = new System.Drawing.Size(875, 203);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbStatus.Location = new System.Drawing.Point(69, 365);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(202, 24);
            this.lbStatus.TabIndex = 5;
            // 
            // lbType
            // 
            this.lbType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbType.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbType.Location = new System.Drawing.Point(64, 397);
            this.lbType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(202, 24);
            this.lbType.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 400);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Type:";
            // 
            // lbServiceType
            // 
            this.lbServiceType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbServiceType.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbServiceType.Location = new System.Drawing.Point(113, 429);
            this.lbServiceType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbServiceType.Name = "lbServiceType";
            this.lbServiceType.Size = new System.Drawing.Size(202, 24);
            this.lbServiceType.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 432);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Service Type:";
            // 
            // lbPriority
            // 
            this.lbPriority.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPriority.ForeColor = System.Drawing.Color.Firebrick;
            this.lbPriority.Location = new System.Drawing.Point(73, 461);
            this.lbPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(202, 24);
            this.lbPriority.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 464);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Priority:";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCustomerName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbCustomerName.Location = new System.Drawing.Point(89, 493);
            this.lbCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(202, 22);
            this.lbCustomerName.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 496);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Customer:";
            // 
            // lbCreatedAtText
            // 
            this.lbCreatedAtText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCreatedAtText.AutoSize = true;
            this.lbCreatedAtText.Location = new System.Drawing.Point(13, 533);
            this.lbCreatedAtText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCreatedAtText.Name = "lbCreatedAtText";
            this.lbCreatedAtText.Size = new System.Drawing.Size(111, 16);
            this.lbCreatedAtText.TabIndex = 14;
            this.lbCreatedAtText.Text = "Ticket created at:";
            this.lbCreatedAtText.Visible = false;
            // 
            // lbCreatedAt
            // 
            this.lbCreatedAt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCreatedAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCreatedAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedAt.Location = new System.Drawing.Point(127, 530);
            this.lbCreatedAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCreatedAt.Name = "lbCreatedAt";
            this.lbCreatedAt.Size = new System.Drawing.Size(144, 22);
            this.lbCreatedAt.TabIndex = 15;
            this.lbCreatedAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCreatedAt.Visible = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(659, 568);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(123, 30);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Create ticket";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(801, 568);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTicket.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnCloseTicket.Location = new System.Drawing.Point(528, 568);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(113, 30);
            this.btnCloseTicket.TabIndex = 18;
            this.btnCloseTicket.Text = "Close Ticket";
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            this.btnCloseTicket.Visible = false;
            this.btnCloseTicket.Click += new System.EventHandler(this.BtnCloseTicket_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(903, 619);
            this.Controls.Add(this.btnCloseTicket);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbCreatedAt);
            this.Controls.Add(this.lbCreatedAtText);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbPriority);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbServiceType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.rtbSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbSubject;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lbStatus;
        private System.Windows.Forms.ComboBox lbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox lbServiceType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox lbPriority;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lbCustomerName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbCreatedAtText;
        private System.Windows.Forms.Label lbCreatedAt;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCloseTicket;
    }
}