using System.Drawing;
using System.Windows.Forms;

namespace malaria
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            toolTip1 = new ToolTip(components);
            label20 = new Label();
            City = new ComboBox();
            button1 = new Button();
            Fever = new ComboBox();
            Fatigue = new ComboBox();
            Headache = new ComboBox();
            Diarrhea = new ComboBox();
            MusclePain = new ComboBox();
            Nausea_vomit = new ComboBox();
            label8 = new Label();
            Seizures = new ComboBox();
            label9 = new Label();
            labResult = new ComboBox();
            addData = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ara Hamah 1982", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(445, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(370, 32);
            label1.TabIndex = 0;
            label1.Text = "رجاءٍ قم بتقييم الأعراض التالية من 1 الى 10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ara Hamah 1982", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(751, 106);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 29);
            label2.TabIndex = 1;
            label2.Text = "الحمى";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ara Hamah 1982", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(751, 176);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 29);
            label3.TabIndex = 1;
            label3.Text = "الارهاق";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ara Hamah 1982", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(751, 242);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 29);
            label4.TabIndex = 1;
            label4.Text = "الصداع";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ara Hamah 1982", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(296, 59);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 29);
            label5.TabIndex = 1;
            label5.Text = "الإسهال";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Ara Hamah 1982", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(296, 123);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 29);
            label6.TabIndex = 1;
            label6.Text = "الم العضلات";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Ara Hamah 1982", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(292, 196);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(117, 29);
            label7.TabIndex = 1;
            label7.Text = "الغثيان أو القيء";
            // 
            // toolTip1
            // 
            toolTip1.ShowAlways = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Ara Hamah 1982", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(256, 353);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(377, 32);
            label20.TabIndex = 0;
            label20.Text = "المنطقة المتواجد فيها عند حدوث الأعراض";
            // 
            // City
            // 
            City.DropDownStyle = ComboBoxStyle.DropDownList;
            City.Font = new Font("Ara Hamah 1982", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            City.FormattingEnabled = true;
            City.Items.AddRange(new object[] { "Amran", "Aden", "Hodeidah", "Taiz", "Al-Mukalla", "Zabid", "Dhamar", "Sana'a", "Ibb", "Sayyan" });
            City.Location = new Point(296, 407);
            City.Margin = new Padding(4);
            City.Name = "City";
            City.Size = new Size(278, 33);
            City.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(359, 472);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(160, 51);
            button1.TabIndex = 9;
            button1.Text = "قدّر";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Fever
            // 
            Fever.DropDownStyle = ComboBoxStyle.DropDownList;
            Fever.Font = new Font("Tajawal Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Fever.FormattingEnabled = true;
            Fever.Items.AddRange(new object[] { "mild", "medium", "severe" });
            Fever.Location = new Point(553, 105);
            Fever.Margin = new Padding(4);
            Fever.Name = "Fever";
            Fever.Size = new Size(176, 34);
            Fever.TabIndex = 10;
            Fever.SelectedValueChanged += seizures_SelectedValueChanged;
            // 
            // Fatigue
            // 
            Fatigue.DropDownStyle = ComboBoxStyle.DropDownList;
            Fatigue.Font = new Font("Tajawal Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Fatigue.FormattingEnabled = true;
            Fatigue.Items.AddRange(new object[] { "mild", "medium", "severe" });
            Fatigue.Location = new Point(553, 169);
            Fatigue.Margin = new Padding(4);
            Fatigue.Name = "Fatigue";
            Fatigue.Size = new Size(176, 34);
            Fatigue.TabIndex = 10;
            Fatigue.SelectedValueChanged += seizures_SelectedValueChanged;
            // 
            // Headache
            // 
            Headache.DropDownStyle = ComboBoxStyle.DropDownList;
            Headache.Font = new Font("Tajawal Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Headache.FormattingEnabled = true;
            Headache.Items.AddRange(new object[] { "mild", "medium", "severe" });
            Headache.Location = new Point(553, 242);
            Headache.Margin = new Padding(4);
            Headache.Name = "Headache";
            Headache.Size = new Size(176, 34);
            Headache.TabIndex = 10;
            Headache.SelectedValueChanged += seizures_SelectedValueChanged;
            // 
            // Diarrhea
            // 
            Diarrhea.DropDownStyle = ComboBoxStyle.DropDownList;
            Diarrhea.Font = new Font("Tajawal Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Diarrhea.FormattingEnabled = true;
            Diarrhea.Items.AddRange(new object[] { "mild", "medium", "severe" });
            Diarrhea.Location = new Point(104, 59);
            Diarrhea.Margin = new Padding(4);
            Diarrhea.Name = "Diarrhea";
            Diarrhea.Size = new Size(176, 34);
            Diarrhea.TabIndex = 10;
            Diarrhea.SelectedValueChanged += seizures_SelectedValueChanged;
            // 
            // MusclePain
            // 
            MusclePain.DropDownStyle = ComboBoxStyle.DropDownList;
            MusclePain.Font = new Font("Tajawal Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MusclePain.FormattingEnabled = true;
            MusclePain.Items.AddRange(new object[] { "mild", "medium", "severe" });
            MusclePain.Location = new Point(104, 123);
            MusclePain.Margin = new Padding(4);
            MusclePain.Name = "MusclePain";
            MusclePain.Size = new Size(176, 34);
            MusclePain.TabIndex = 10;
            MusclePain.SelectedValueChanged += seizures_SelectedValueChanged;
            // 
            // Nausea_vomit
            // 
            Nausea_vomit.DropDownStyle = ComboBoxStyle.DropDownList;
            Nausea_vomit.Font = new Font("Tajawal Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Nausea_vomit.FormattingEnabled = true;
            Nausea_vomit.Items.AddRange(new object[] { "mild", "medium", "severe" });
            Nausea_vomit.Location = new Point(104, 190);
            Nausea_vomit.Margin = new Padding(4);
            Nausea_vomit.Name = "Nausea_vomit";
            Nausea_vomit.Size = new Size(176, 34);
            Nausea_vomit.TabIndex = 10;
            Nausea_vomit.SelectedIndexChanged += comboBox8_SelectedIndexChanged;
            Nausea_vomit.SelectedValueChanged += seizures_SelectedValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Ara Hamah 1982", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(302, 262);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(63, 29);
            label8.TabIndex = 1;
            label8.Text = "التشنج";
            // 
            // Seizures
            // 
            Seizures.DropDownStyle = ComboBoxStyle.DropDownList;
            Seizures.Font = new Font("Tajawal Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Seizures.FormattingEnabled = true;
            Seizures.Items.AddRange(new object[] { "mild", "medium", "severe" });
            Seizures.Location = new Point(104, 262);
            Seizures.Margin = new Padding(4);
            Seizures.Name = "Seizures";
            Seizures.Size = new Size(176, 34);
            Seizures.TabIndex = 10;
            Seizures.SelectedIndexChanged += comboBox8_SelectedIndexChanged;
            Seizures.SelectedValueChanged += seizures_SelectedValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Ara Hamah 1982", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(176, 682);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(377, 32);
            label9.TabIndex = 11;
            label9.Text = "المنطقة المتواجد فيها عند حدوث الأعراض";
            // 
            // labResult
            // 
            labResult.DropDownStyle = ComboBoxStyle.DropDownList;
            labResult.Font = new Font("Ara Hamah 1982", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labResult.FormattingEnabled = true;
            labResult.Items.AddRange(new object[] { "مصاب", "غير مصاب" });
            labResult.Location = new Point(271, 304);
            labResult.Margin = new Padding(4);
            labResult.Name = "labResult";
            labResult.Size = new Size(278, 33);
            labResult.TabIndex = 12;
            labResult.Visible = false;
            // 
            // addData
            // 
            addData.Location = new Point(334, 355);
            addData.Margin = new Padding(4);
            addData.Name = "addData";
            addData.Size = new Size(160, 30);
            addData.TabIndex = 13;
            addData.Text = "ادخال نتيجة الفحص";
            addData.UseVisualStyleBackColor = true;
            addData.Visible = false;
            addData.Click += button2_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(840, 592);
            Controls.Add(addData);
            Controls.Add(labResult);
            Controls.Add(label9);
            Controls.Add(Seizures);
            Controls.Add(Nausea_vomit);
            Controls.Add(MusclePain);
            Controls.Add(Diarrhea);
            Controls.Add(Headache);
            Controls.Add(Fatigue);
            Controls.Add(Fever);
            Controls.Add(button1);
            Controls.Add(City);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label20);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Symptoms";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ToolTip toolTip1;
        private Label label20;
        private Button button1;
        private Label label8;
        public ComboBox Fever;
        public ComboBox Fatigue;
        public ComboBox Headache;
        public ComboBox Diarrhea;
        public ComboBox MusclePain;
        public ComboBox Nausea_vomit;
        public ComboBox Seizures;
        public ComboBox City;
        private Label label9;
        public ComboBox labResult;
        private Button addData;
    }
}