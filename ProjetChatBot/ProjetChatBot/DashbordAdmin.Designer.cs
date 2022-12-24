
namespace ProjetChatBot
{
    partial class DashbordAdmin
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
            this.button_add_user = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_add_user
            // 
            this.button_add_user.Location = new System.Drawing.Point(265, 35);
            this.button_add_user.Name = "button_add_user";
            this.button_add_user.Size = new System.Drawing.Size(246, 74);
            this.button_add_user.TabIndex = 0;
            this.button_add_user.Text = "ADD_User";
            this.button_add_user.UseVisualStyleBackColor = true;
            this.button_add_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 74);
            this.button2.TabIndex = 1;
            this.button2.Text = "ADD Question";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(265, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 74);
            this.button3.TabIndex = 2;
            this.button3.Text = "ADD Answer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DashbordAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_add_user);
            this.Name = "DashbordAdmin";
            this.Text = "DashbordAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add_user;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}