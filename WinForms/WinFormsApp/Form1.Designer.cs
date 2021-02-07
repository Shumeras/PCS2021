
namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Convert_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Output_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Input_TextBox
            // 
            this.Input_TextBox.Location = new System.Drawing.Point(12, 33);
            this.Input_TextBox.Name = "Input_TextBox";
            this.Input_TextBox.Size = new System.Drawing.Size(296, 23);
            this.Input_TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input file";
            // 
            // Clear_Button
            // 
            this.Clear_Button.Location = new System.Drawing.Point(12, 124);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(142, 23);
            this.Clear_Button.TabIndex = 2;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = true;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Convert_Button
            // 
            this.Convert_Button.Location = new System.Drawing.Point(169, 124);
            this.Convert_Button.Name = "Convert_Button";
            this.Convert_Button.Size = new System.Drawing.Size(139, 23);
            this.Convert_Button.TabIndex = 3;
            this.Convert_Button.Text = "Convert";
            this.Convert_Button.UseVisualStyleBackColor = true;
            this.Convert_Button.Click += new System.EventHandler(this.Convert_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output File";
            // 
            // Output_TextBox
            // 
            this.Output_TextBox.Location = new System.Drawing.Point(12, 95);
            this.Output_TextBox.Name = "Output_TextBox";
            this.Output_TextBox.Size = new System.Drawing.Size(296, 23);
            this.Output_TextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 170);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Output_TextBox);
            this.Controls.Add(this.Convert_Button);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Button Convert_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Output_TextBox;
    }
}

