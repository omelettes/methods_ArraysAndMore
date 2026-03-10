namespace nigganigga
{
    partial class Form2
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
            this.btn_nextpage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_avg = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_allscore = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_nextpage
            // 
            this.btn_nextpage.BackColor = System.Drawing.Color.LightCoral;
            this.btn_nextpage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nextpage.Location = new System.Drawing.Point(177, 282);
            this.btn_nextpage.Margin = new System.Windows.Forms.Padding(6);
            this.btn_nextpage.Name = "btn_nextpage";
            this.btn_nextpage.Size = new System.Drawing.Size(130, 35);
            this.btn_nextpage.TabIndex = 8;
            this.btn_nextpage.Text = "Back";
            this.btn_nextpage.UseVisualStyleBackColor = false;
            this.btn_nextpage.Click += new System.EventHandler(this.btn_nextpage_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(319, 282);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.lbl_avg);
            this.groupBox1.Controls.Add(this.lbl_total);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_allscore);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(459, 234);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Score";
            // 
            // lbl_avg
            // 
            this.lbl_avg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_avg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_avg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_avg.Location = new System.Drawing.Point(224, 176);
            this.lbl_avg.Name = "lbl_avg";
            this.lbl_avg.Size = new System.Drawing.Size(204, 28);
            this.lbl_avg.TabIndex = 3;
            // 
            // lbl_total
            // 
            this.lbl_total.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_total.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_total.Location = new System.Drawing.Point(14, 176);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(204, 28);
            this.lbl_total.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total and Average";
            // 
            // lbl_allscore
            // 
            this.lbl_allscore.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_allscore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_allscore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_allscore.Location = new System.Drawing.Point(9, 32);
            this.lbl_allscore.Name = "lbl_allscore";
            this.lbl_allscore.Size = new System.Drawing.Size(414, 90);
            this.lbl_allscore.TabIndex = 0;
            this.lbl_allscore.Click += new System.EventHandler(this.lbl_allscore_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.LightCoral;
            this.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_calculate.Location = new System.Drawing.Point(35, 282);
            this.btn_calculate.Margin = new System.Windows.Forms.Padding(6);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(130, 35);
            this.btn_calculate.TabIndex = 5;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 332);
            this.Controls.Add(this.btn_nextpage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_calculate);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nextpage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_avg;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_allscore;
        private System.Windows.Forms.Button btn_calculate;
    }
}