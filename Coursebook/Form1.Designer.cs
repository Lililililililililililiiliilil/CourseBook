namespace Coursebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Themes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Colloc = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.Colloc2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Colloc3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Test3 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Test2 = new System.Windows.Forms.DataGridView();
            this.Test = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.exam3 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.exam2 = new System.Windows.Forms.DataGridView();
            this.exam1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Themes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colloc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colloc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colloc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Test3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Test2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1)).BeginInit();
            this.SuspendLayout();
            // 
            // Themes
            // 
            this.Themes.BackgroundColor = System.Drawing.Color.OldLace;
            this.Themes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Themes.Location = new System.Drawing.Point(38, 12);
            this.Themes.Name = "Themes";
            this.Themes.ReadOnly = true;
            this.Themes.Size = new System.Drawing.Size(345, 407);
            this.Themes.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Location = new System.Drawing.Point(389, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Коллоквиум";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Colloc
            // 
            this.Colloc.BackgroundColor = System.Drawing.Color.OldLace;
            this.Colloc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Colloc.Location = new System.Drawing.Point(389, 77);
            this.Colloc.Name = "Colloc";
            this.Colloc.ReadOnly = true;
            this.Colloc.RowHeadersVisible = false;
            this.Colloc.Size = new System.Drawing.Size(107, 138);
            this.Colloc.TabIndex = 2;
            this.Colloc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Colloc_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.Location = new System.Drawing.Point(752, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Контрольная работа";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Colloc2
            // 
            this.Colloc2.BackgroundColor = System.Drawing.Color.OldLace;
            this.Colloc2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Colloc2.Location = new System.Drawing.Point(502, 77);
            this.Colloc2.Name = "Colloc2";
            this.Colloc2.ReadOnly = true;
            this.Colloc2.RowHeadersVisible = false;
            this.Colloc2.Size = new System.Drawing.Size(107, 138);
            this.Colloc2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(415, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вариант 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(525, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вариант 2";
            // 
            // Colloc3
            // 
            this.Colloc3.BackgroundColor = System.Drawing.Color.OldLace;
            this.Colloc3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Colloc3.Location = new System.Drawing.Point(615, 77);
            this.Colloc3.Name = "Colloc3";
            this.Colloc3.ReadOnly = true;
            this.Colloc3.RowHeadersVisible = false;
            this.Colloc3.Size = new System.Drawing.Size(107, 138);
            this.Colloc3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(640, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вариант 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(1003, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Вариант 3";
            // 
            // Test3
            // 
            this.Test3.BackgroundColor = System.Drawing.Color.OldLace;
            this.Test3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Test3.Location = new System.Drawing.Point(978, 77);
            this.Test3.Name = "Test3";
            this.Test3.ReadOnly = true;
            this.Test3.RowHeadersVisible = false;
            this.Test3.Size = new System.Drawing.Size(107, 138);
            this.Test3.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(888, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Вариант 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(778, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Вариант 1";
            // 
            // Test2
            // 
            this.Test2.BackgroundColor = System.Drawing.Color.OldLace;
            this.Test2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Test2.Location = new System.Drawing.Point(865, 77);
            this.Test2.Name = "Test2";
            this.Test2.ReadOnly = true;
            this.Test2.RowHeadersVisible = false;
            this.Test2.Size = new System.Drawing.Size(107, 138);
            this.Test2.TabIndex = 11;
            // 
            // Test
            // 
            this.Test.BackgroundColor = System.Drawing.Color.OldLace;
            this.Test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Test.Location = new System.Drawing.Point(752, 77);
            this.Test.Name = "Test";
            this.Test.ReadOnly = true;
            this.Test.RowHeadersVisible = false;
            this.Test.Size = new System.Drawing.Size(107, 138);
            this.Test.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Bisque;
            this.button3.Location = new System.Drawing.Point(389, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 37);
            this.button3.TabIndex = 16;
            this.button3.Text = "Экзамен";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(851, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Вариант 3";
            // 
            // exam3
            // 
            this.exam3.BackgroundColor = System.Drawing.Color.OldLace;
            this.exam3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exam3.Location = new System.Drawing.Point(791, 281);
            this.exam3.Name = "exam3";
            this.exam3.ReadOnly = true;
            this.exam3.RowHeadersVisible = false;
            this.exam3.Size = new System.Drawing.Size(178, 138);
            this.exam3.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(650, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Вариант 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(449, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Вариант 1";
            // 
            // exam2
            // 
            this.exam2.BackgroundColor = System.Drawing.Color.OldLace;
            this.exam2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exam2.Location = new System.Drawing.Point(590, 281);
            this.exam2.Name = "exam2";
            this.exam2.ReadOnly = true;
            this.exam2.RowHeadersVisible = false;
            this.exam2.Size = new System.Drawing.Size(178, 138);
            this.exam2.TabIndex = 18;
            // 
            // exam1
            // 
            this.exam1.BackgroundColor = System.Drawing.Color.OldLace;
            this.exam1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exam1.Location = new System.Drawing.Point(389, 281);
            this.exam1.Name = "exam1";
            this.exam1.ReadOnly = true;
            this.exam1.RowHeadersVisible = false;
            this.exam1.Size = new System.Drawing.Size(178, 138);
            this.exam1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(195)))), ((int)(((byte)(215)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1111, 443);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exam3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.exam2);
            this.Controls.Add(this.exam1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Test3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Test2);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Colloc3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Colloc2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Colloc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Themes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Themes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colloc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colloc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Colloc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Test3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Test2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exam1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Themes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Colloc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Colloc2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Colloc3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Test3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Test2;
        private System.Windows.Forms.DataGridView Test;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView exam3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView exam2;
        private System.Windows.Forms.DataGridView exam1;
    }
}

