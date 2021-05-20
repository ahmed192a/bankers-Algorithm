
namespace Bankers_Algorithm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_nprocess = new System.Windows.Forms.TextBox();
            this.text_nresource = new System.Windows.Forms.TextBox();
            this.button_check = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.text_allocation = new System.Windows.Forms.TextBox();
            this.rich_allocation = new System.Windows.Forms.RichTextBox();
            this.button_allocation = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.text_max = new System.Windows.Forms.TextBox();
            this.rich_max = new System.Windows.Forms.RichTextBox();
            this.button_max = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.text_available = new System.Windows.Forms.TextBox();
            this.rich_output = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_safe = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.rich_need = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.text_Prequest = new System.Windows.Forms.TextBox();
            this.text_Rrequest = new System.Windows.Forms.TextBox();
            this.radioButton_safe = new System.Windows.Forms.RadioButton();
            this.radioButton_request = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bankers Algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "num processes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "num resources";
            // 
            // text_nprocess
            // 
            this.text_nprocess.Location = new System.Drawing.Point(180, 49);
            this.text_nprocess.Name = "text_nprocess";
            this.text_nprocess.Size = new System.Drawing.Size(87, 22);
            this.text_nprocess.TabIndex = 3;
            // 
            // text_nresource
            // 
            this.text_nresource.Location = new System.Drawing.Point(180, 82);
            this.text_nresource.Name = "text_nresource";
            this.text_nresource.Size = new System.Drawing.Size(87, 22);
            this.text_nresource.TabIndex = 4;
            // 
            // button_check
            // 
            this.button_check.Location = new System.Drawing.Point(316, 49);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(115, 26);
            this.button_check.TabIndex = 5;
            this.button_check.Text = "Enter";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Allocation matrix";
            // 
            // text_allocation
            // 
            this.text_allocation.Enabled = false;
            this.text_allocation.Location = new System.Drawing.Point(52, 181);
            this.text_allocation.Name = "text_allocation";
            this.text_allocation.Size = new System.Drawing.Size(100, 22);
            this.text_allocation.TabIndex = 7;
            // 
            // rich_allocation
            // 
            this.rich_allocation.Location = new System.Drawing.Point(180, 146);
            this.rich_allocation.Name = "rich_allocation";
            this.rich_allocation.ReadOnly = true;
            this.rich_allocation.Size = new System.Drawing.Size(200, 129);
            this.rich_allocation.TabIndex = 8;
            this.rich_allocation.Text = "";
            // 
            // button_allocation
            // 
            this.button_allocation.Enabled = false;
            this.button_allocation.Location = new System.Drawing.Point(53, 224);
            this.button_allocation.Name = "button_allocation";
            this.button_allocation.Size = new System.Drawing.Size(101, 23);
            this.button_allocation.TabIndex = 9;
            this.button_allocation.Text = "Add row";
            this.button_allocation.UseVisualStyleBackColor = true;
            this.button_allocation.Click += new System.EventHandler(this.button_allocation_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max matrix";
            // 
            // text_max
            // 
            this.text_max.Enabled = false;
            this.text_max.Location = new System.Drawing.Point(428, 183);
            this.text_max.Name = "text_max";
            this.text_max.Size = new System.Drawing.Size(91, 22);
            this.text_max.TabIndex = 11;
            // 
            // rich_max
            // 
            this.rich_max.Location = new System.Drawing.Point(555, 146);
            this.rich_max.Name = "rich_max";
            this.rich_max.ReadOnly = true;
            this.rich_max.Size = new System.Drawing.Size(209, 129);
            this.rich_max.TabIndex = 12;
            this.rich_max.Text = "";
            // 
            // button_max
            // 
            this.button_max.Enabled = false;
            this.button_max.Location = new System.Drawing.Point(428, 222);
            this.button_max.Name = "button_max";
            this.button_max.Size = new System.Drawing.Size(91, 25);
            this.button_max.TabIndex = 13;
            this.button_max.Text = "Add row";
            this.button_max.UseVisualStyleBackColor = true;
            this.button_max.Click += new System.EventHandler(this.button_max_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(828, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Available matrix";
            // 
            // text_available
            // 
            this.text_available.Enabled = false;
            this.text_available.Location = new System.Drawing.Point(831, 181);
            this.text_available.Name = "text_available";
            this.text_available.Size = new System.Drawing.Size(136, 22);
            this.text_available.TabIndex = 15;
            // 
            // rich_output
            // 
            this.rich_output.Location = new System.Drawing.Point(461, 330);
            this.rich_output.Name = "rich_output";
            this.rich_output.ReadOnly = true;
            this.rich_output.Size = new System.Drawing.Size(223, 141);
            this.rich_output.TabIndex = 16;
            this.rich_output.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Output";
            // 
            // button_safe
            // 
            this.button_safe.Location = new System.Drawing.Point(772, 481);
            this.button_safe.Name = "button_safe";
            this.button_safe.Size = new System.Drawing.Size(123, 31);
            this.button_safe.TabIndex = 18;
            this.button_safe.Text = "check ";
            this.button_safe.UseVisualStyleBackColor = true;
            this.button_safe.Click += new System.EventHandler(this.button_safe_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(933, 481);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(124, 32);
            this.button_clear.TabIndex = 19;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Need Matrix";
            // 
            // rich_need
            // 
            this.rich_need.Location = new System.Drawing.Point(52, 331);
            this.rich_need.Name = "rich_need";
            this.rich_need.ReadOnly = true;
            this.rich_need.Size = new System.Drawing.Size(328, 140);
            this.rich_need.TabIndex = 28;
            this.rich_need.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(762, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Request process";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(762, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Request resources";
            this.label9.Visible = false;
            // 
            // text_Prequest
            // 
            this.text_Prequest.Location = new System.Drawing.Point(904, 353);
            this.text_Prequest.Name = "text_Prequest";
            this.text_Prequest.Size = new System.Drawing.Size(104, 22);
            this.text_Prequest.TabIndex = 23;
            this.text_Prequest.Visible = false;
            // 
            // text_Rrequest
            // 
            this.text_Rrequest.Location = new System.Drawing.Point(905, 402);
            this.text_Rrequest.Name = "text_Rrequest";
            this.text_Rrequest.Size = new System.Drawing.Size(139, 22);
            this.text_Rrequest.TabIndex = 24;
            this.text_Rrequest.Visible = false;
            // 
            // radioButton_safe
            // 
            this.radioButton_safe.AutoSize = true;
            this.radioButton_safe.Checked = true;
            this.radioButton_safe.Enabled = false;
            this.radioButton_safe.Location = new System.Drawing.Point(765, 307);
            this.radioButton_safe.Name = "radioButton_safe";
            this.radioButton_safe.Size = new System.Drawing.Size(122, 21);
            this.radioButton_safe.TabIndex = 25;
            this.radioButton_safe.TabStop = true;
            this.radioButton_safe.Text = "safe sequence";
            this.radioButton_safe.UseVisualStyleBackColor = true;
            this.radioButton_safe.CheckedChanged += new System.EventHandler(this.radioButton_safe_CheckedChanged);
            // 
            // radioButton_request
            // 
            this.radioButton_request.AutoSize = true;
            this.radioButton_request.Enabled = false;
            this.radioButton_request.Location = new System.Drawing.Point(904, 307);
            this.radioButton_request.Name = "radioButton_request";
            this.radioButton_request.Size = new System.Drawing.Size(82, 21);
            this.radioButton_request.TabIndex = 26;
            this.radioButton_request.Text = "Request";
            this.radioButton_request.UseVisualStyleBackColor = true;
            this.radioButton_request.CheckedChanged += new System.EventHandler(this.radioButton_request_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1074, 573);
            this.Controls.Add(this.rich_need);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radioButton_request);
            this.Controls.Add(this.radioButton_safe);
            this.Controls.Add(this.text_Rrequest);
            this.Controls.Add(this.text_Prequest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_safe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rich_output);
            this.Controls.Add(this.text_available);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_max);
            this.Controls.Add(this.rich_max);
            this.Controls.Add(this.text_max);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_allocation);
            this.Controls.Add(this.rich_allocation);
            this.Controls.Add(this.text_allocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_check);
            this.Controls.Add(this.text_nresource);
            this.Controls.Add(this.text_nprocess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bnakers Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_nprocess;
        private System.Windows.Forms.TextBox text_nresource;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_allocation;
        private System.Windows.Forms.RichTextBox rich_allocation;
        private System.Windows.Forms.Button button_allocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_max;
        private System.Windows.Forms.RichTextBox rich_max;
        private System.Windows.Forms.Button button_max;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_available;
        private System.Windows.Forms.RichTextBox rich_output;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_safe;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rich_need;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox text_Prequest;
        private System.Windows.Forms.TextBox text_Rrequest;
        private System.Windows.Forms.RadioButton radioButton_safe;
        private System.Windows.Forms.RadioButton radioButton_request;
    }
}

