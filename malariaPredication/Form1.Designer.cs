using System.Drawing;
using System.Windows.Forms;

namespace malaria
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
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ara Hamah 1982", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(106, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(362, 32);
            label1.TabIndex = 0;
            label1.Text = "مرحباً بك في نظام تشخيص مرض الملاريا";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.FlatAppearance.BorderColor = Color.SeaShell;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.SandyBrown;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Ara Hamah 1982", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(210, 399);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(217, 61);
            button1.TabIndex = 1;
            button1.Text = "التالي";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Location = new Point(-1, 192);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 88);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 488);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "malaria predication system";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel1;
    }
}

