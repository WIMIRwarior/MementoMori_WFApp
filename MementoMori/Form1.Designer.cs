namespace MementoMori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dtp_DayOfBirth = new DateTimePicker();
            dtp_CurrentDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            comboBox_Country = new ComboBox();
            SuspendLayout();
            // 
            // dtp_DayOfBirth
            // 
            dtp_DayOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtp_DayOfBirth.CustomFormat = "dd-MMM-yyyy";
            dtp_DayOfBirth.Format = DateTimePickerFormat.Custom;
            dtp_DayOfBirth.ImeMode = ImeMode.NoControl;
            dtp_DayOfBirth.Location = new Point(50, 400);
            dtp_DayOfBirth.MaximumSize = new Size(120, 23);
            dtp_DayOfBirth.MinimumSize = new Size(120, 23);
            dtp_DayOfBirth.Name = "dtp_DayOfBirth";
            dtp_DayOfBirth.Size = new Size(120, 23);
            dtp_DayOfBirth.TabIndex = 0;
            // 
            // dtp_CurrentDate
            // 
            dtp_CurrentDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtp_CurrentDate.CustomFormat = "dd-MMM-yyyy";
            dtp_CurrentDate.Format = DateTimePickerFormat.Custom;
            dtp_CurrentDate.ImeMode = ImeMode.NoControl;
            dtp_CurrentDate.Location = new Point(621, 400);
            dtp_CurrentDate.MaximumSize = new Size(120, 23);
            dtp_CurrentDate.MinimumSize = new Size(120, 23);
            dtp_CurrentDate.Name = "dtp_CurrentDate";
            dtp_CurrentDate.Size = new Size(120, 23);
            dtp_CurrentDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(50, 382);
            label1.MaximumSize = new Size(69, 15);
            label1.MinimumSize = new Size(69, 15);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Day of birth";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(621, 382);
            label2.MaximumSize = new Size(73, 15);
            label2.MinimumSize = new Size(73, 15);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 4;
            label2.Text = "Current date";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(361, 400);
            button1.MaximumSize = new Size(75, 23);
            button1.MinimumSize = new Size(75, 23);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox_Country
            // 
            comboBox_Country.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Country.FormattingEnabled = true;
            comboBox_Country.Items.AddRange(new object[] { "Albania", "Austria", "Belarus", "Belgium", "Bosnia and Herzegovina", "Bulgaria", "Croatia", "Cyprus", "Czechia", "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary", "Iceland", "Ireland", "Italy", "Kosovo", "Latvia", "Liechtenstein", "Lithuania", "Luxembourg", "Malta", "Moldova", "Montenegro", "Netherlands", "North Macedonia", "Norway", "Poland", "Portugal", "Romania", "Russia", "Serbia", "Slovakia", "Slovenia", "Spain", "Sweden", "Switzerland", "Ukraine", "United Kingdom" });
            comboBox_Country.Location = new Point(50, 35);
            comboBox_Country.MaximumSize = new Size(121, 0);
            comboBox_Country.MinimumSize = new Size(121, 0);
            comboBox_Country.Name = "comboBox_Country";
            comboBox_Country.Size = new Size(121, 23);
            comboBox_Country.TabIndex = 6;
            comboBox_Country.Text = "Country";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(757, 445);
            Controls.Add(comboBox_Country);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtp_CurrentDate);
            Controls.Add(dtp_DayOfBirth);
            MaximumSize = new Size(773, 484);
            MinimumSize = new Size(773, 484);
            Name = "Form1";
            Text = "Memento mori v0.1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_DayOfBirth;
        private DateTimePicker dtp_CurrentDate;
        private Label label1;
        private Label label2;
        private Button button1;
        private ComboBox comboBox_Country;
    }
}
