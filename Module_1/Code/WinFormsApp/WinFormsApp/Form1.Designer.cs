
namespace WinFormsApp
{
    partial class btn_hello
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_hello_message = new System.Windows.Forms.Label();
            this.btn_change_color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hello Click Me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_hello_message
            // 
            this.lbl_hello_message.AutoSize = true;
            this.lbl_hello_message.Location = new System.Drawing.Point(156, 148);
            this.lbl_hello_message.Name = "lbl_hello_message";
            this.lbl_hello_message.Size = new System.Drawing.Size(16, 15);
            this.lbl_hello_message.TabIndex = 1;
            this.lbl_hello_message.Text = "...";
            // 
            // btn_change_color
            // 
            this.btn_change_color.Location = new System.Drawing.Point(298, 87);
            this.btn_change_color.Name = "btn_change_color";
            this.btn_change_color.Size = new System.Drawing.Size(119, 37);
            this.btn_change_color.TabIndex = 2;
            this.btn_change_color.Text = "Change Color";
            this.btn_change_color.UseVisualStyleBackColor = true;
            this.btn_change_color.Click += new System.EventHandler(this.btn_change_color_Click);
            // 
            // btn_hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 233);
            this.Controls.Add(this.btn_change_color);
            this.Controls.Add(this.lbl_hello_message);
            this.Controls.Add(this.button1);
            this.Name = "btn_hello";
            this.Text = "Hello Click Me";
            this.Load += new System.EventHandler(this.btn_hello_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_hello_message;
        private System.Windows.Forms.Button btn_change_color;
    }
}

