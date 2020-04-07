namespace SC_WorkingWithStrings
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
            this.lstDisplayMethods = new System.Windows.Forms.ListBox();
            this.btnProcessWord = new System.Windows.Forms.Button();
            this.txtEnterWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDisplayMethods
            // 
            this.lstDisplayMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDisplayMethods.FormattingEnabled = true;
            this.lstDisplayMethods.ItemHeight = 16;
            this.lstDisplayMethods.Location = new System.Drawing.Point(12, 122);
            this.lstDisplayMethods.Name = "lstDisplayMethods";
            this.lstDisplayMethods.Size = new System.Drawing.Size(668, 180);
            this.lstDisplayMethods.TabIndex = 7;
            this.lstDisplayMethods.SelectedIndexChanged += new System.EventHandler(this.lstDisplayMethods_SelectedIndexChanged);
            // 
            // btnProcessWord
            // 
            this.btnProcessWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessWord.Location = new System.Drawing.Point(12, 61);
            this.btnProcessWord.Name = "btnProcessWord";
            this.btnProcessWord.Size = new System.Drawing.Size(143, 35);
            this.btnProcessWord.TabIndex = 6;
            this.btnProcessWord.Text = "Process Word";
            this.btnProcessWord.UseVisualStyleBackColor = true;
            this.btnProcessWord.Click += new System.EventHandler(this.btnProcessWord_Click);
            // 
            // txtEnterWord
            // 
            this.txtEnterWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterWord.Location = new System.Drawing.Point(195, 65);
            this.txtEnterWord.Name = "txtEnterWord";
            this.txtEnterWord.Size = new System.Drawing.Size(299, 26);
            this.txtEnterWord.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Working with Strings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 335);
            this.Controls.Add(this.lstDisplayMethods);
            this.Controls.Add(this.btnProcessWord);
            this.Controls.Add(this.txtEnterWord);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplayMethods;
        private System.Windows.Forms.Button btnProcessWord;
        private System.Windows.Forms.TextBox txtEnterWord;
        private System.Windows.Forms.Label label1;
    }
}

