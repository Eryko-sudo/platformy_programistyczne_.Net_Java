namespace WeatherProject
{
    partial class WeatherApiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherApiForm));
            listBox1 = new ListBox();
            SendCoordinatesButton = new Button();
            textBox1 = new TextBox();
            lonTextBox = new TextBox();
            RefreshListButton = new Button();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(690, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(330, 544);
            listBox1.TabIndex = 1;
            // 
            // SendCoordinatesButton
            // 
            SendCoordinatesButton.Location = new Point(12, 156);
            SendCoordinatesButton.Name = "SendCoordinatesButton";
            SendCoordinatesButton.Size = new Size(157, 42);
            SendCoordinatesButton.TabIndex = 2;
            SendCoordinatesButton.Text = "Send coordinates";
            SendCoordinatesButton.UseVisualStyleBackColor = true;
            SendCoordinatesButton.Click += SendCoordinatesButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lonTextBox
            // 
            lonTextBox.Location = new Point(12, 114);
            lonTextBox.Name = "lonTextBox";
            lonTextBox.Size = new Size(157, 27);
            lonTextBox.TabIndex = 4;
            lonTextBox.TextChanged += lonTextBox_TextChanged;
            // 
            // RefreshListButton
            // 
            RefreshListButton.Location = new Point(779, 575);
            RefreshListButton.Name = "RefreshListButton";
            RefreshListButton.Size = new Size(157, 39);
            RefreshListButton.TabIndex = 5;
            RefreshListButton.Text = "Refresh list";
            RefreshListButton.UseVisualStyleBackColor = true;
            RefreshListButton.Click += RefreshListButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 7;
            label2.Text = "Latitude";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 85);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 8;
            label3.Text = "Longitude";
            // 
            // button3
            // 
            button3.Location = new Point(556, 15);
            button3.Name = "button3";
            button3.Size = new Size(116, 52);
            button3.TabIndex = 10;
            button3.Text = "Sort by temperature";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button4.Location = new Point(12, 578);
            button4.Name = "button4";
            button4.Size = new Size(113, 38);
            button4.TabIndex = 14;
            button4.Text = "Delete data";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1048, 658);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Paris", "London", "Berlin", "Rome", "Warsaw", "Wroclaw" });
            comboBox1.Location = new Point(12, 289);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 266);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 23;
            label1.Text = "City selector";
            // 
            // button1
            // 
            button1.Location = new Point(556, 73);
            button1.Name = "button1";
            button1.Size = new Size(116, 52);
            button1.TabIndex = 24;
            button1.Text = "Sort by wind";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(556, 131);
            button2.Name = "button2";
            button2.Size = new Size(116, 52);
            button2.TabIndex = 25;
            button2.Text = "Sort by humidity";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Location = new Point(556, 189);
            button5.Name = "button5";
            button5.Size = new Size(116, 52);
            button5.TabIndex = 26;
            button5.Text = "Sort by pressure";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(556, 247);
            button6.Name = "button6";
            button6.Size = new Size(116, 52);
            button6.TabIndex = 27;
            button6.Text = "Sort by feel temperature";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 323);
            button7.Name = "button7";
            button7.Size = new Size(157, 42);
            button7.TabIndex = 28;
            button7.Text = "Select city";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // WeatherApiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1032, 626);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RefreshListButton);
            Controls.Add(lonTextBox);
            Controls.Add(textBox1);
            Controls.Add(SendCoordinatesButton);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Name = "WeatherApiForm";
            Text = "Eryk's Weather APP";
            Load += WeatherApiForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private Button SendCoordinatesButton;
        private TextBox textBox1;
        private TextBox lonTextBox;
        private Button RefreshListButton;
        private Label label2;
        private Label label3;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}
