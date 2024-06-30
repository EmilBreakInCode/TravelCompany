namespace TravelCompany.Forms.TravelPackages
{
    partial class AddTravelPackageForm
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
            label1 = new Label();
            TravelPackagesRouteAddComboBox = new ComboBox();
            TravelPackagesClientAddComboBox = new ComboBox();
            TravelPackagesDateOfAddDateTimePicker = new DateTimePicker();
            TravelPackagesCountAddTextBox = new TextBox();
            TravelPackagesDiscountAddTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TravelPackagesAddSaveButton = new Button();
            TravelIdAddTextBox = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(138, 26);
            label1.Name = "label1";
            label1.Size = new Size(207, 32);
            label1.TabIndex = 0;
            label1.Text = "Создать путевку";
            // 
            // TravelPackagesRouteAddComboBox
            // 
            TravelPackagesRouteAddComboBox.FormattingEnabled = true;
            TravelPackagesRouteAddComboBox.Location = new Point(138, 92);
            TravelPackagesRouteAddComboBox.Name = "TravelPackagesRouteAddComboBox";
            TravelPackagesRouteAddComboBox.Size = new Size(437, 23);
            TravelPackagesRouteAddComboBox.TabIndex = 1;
            // 
            // TravelPackagesClientAddComboBox
            // 
            TravelPackagesClientAddComboBox.FormattingEnabled = true;
            TravelPackagesClientAddComboBox.Location = new Point(138, 141);
            TravelPackagesClientAddComboBox.Name = "TravelPackagesClientAddComboBox";
            TravelPackagesClientAddComboBox.Size = new Size(437, 23);
            TravelPackagesClientAddComboBox.TabIndex = 2;
            // 
            // TravelPackagesDateOfAddDateTimePicker
            // 
            TravelPackagesDateOfAddDateTimePicker.Location = new Point(326, 199);
            TravelPackagesDateOfAddDateTimePicker.Name = "TravelPackagesDateOfAddDateTimePicker";
            TravelPackagesDateOfAddDateTimePicker.Size = new Size(249, 23);
            TravelPackagesDateOfAddDateTimePicker.TabIndex = 3;
            // 
            // TravelPackagesCountAddTextBox
            // 
            TravelPackagesCountAddTextBox.Location = new Point(475, 247);
            TravelPackagesCountAddTextBox.Name = "TravelPackagesCountAddTextBox";
            TravelPackagesCountAddTextBox.Size = new Size(100, 23);
            TravelPackagesCountAddTextBox.TabIndex = 4;
            // 
            // TravelPackagesDiscountAddTextBox
            // 
            TravelPackagesDiscountAddTextBox.Location = new Point(475, 295);
            TravelPackagesDiscountAddTextBox.Name = "TravelPackagesDiscountAddTextBox";
            TravelPackagesDiscountAddTextBox.Size = new Size(100, 23);
            TravelPackagesDiscountAddTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(48, 94);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 6;
            label2.Text = "Маршрут";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(65, 143);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 7;
            label3.Text = "Клиент";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(166, 201);
            label4.Name = "label4";
            label4.Size = new Size(154, 21);
            label4.TabIndex = 8;
            label4.Text = "Дата отправления";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(366, 249);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 9;
            label5.Text = "Количество";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(366, 297);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 10;
            label6.Text = "Скидка";
            // 
            // TravelPackagesAddSaveButton
            // 
            TravelPackagesAddSaveButton.Location = new Point(366, 356);
            TravelPackagesAddSaveButton.Name = "TravelPackagesAddSaveButton";
            TravelPackagesAddSaveButton.Size = new Size(209, 23);
            TravelPackagesAddSaveButton.TabIndex = 11;
            TravelPackagesAddSaveButton.Text = "Сохранить";
            TravelPackagesAddSaveButton.UseVisualStyleBackColor = true;
            TravelPackagesAddSaveButton.Click += TravelPackagesAddSaveButton_Click;
            // 
            // TravelIdAddTextBox
            // 
            TravelIdAddTextBox.Location = new Point(475, 37);
            TravelIdAddTextBox.Name = "TravelIdAddTextBox";
            TravelIdAddTextBox.Size = new Size(100, 23);
            TravelIdAddTextBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(366, 39);
            label7.Name = "label7";
            label7.Size = new Size(63, 21);
            label7.TabIndex = 13;
            label7.Text = "Номер";
            // 
            // AddTravelPackageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(610, 450);
            Controls.Add(label7);
            Controls.Add(TravelIdAddTextBox);
            Controls.Add(TravelPackagesAddSaveButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TravelPackagesDiscountAddTextBox);
            Controls.Add(TravelPackagesCountAddTextBox);
            Controls.Add(TravelPackagesDateOfAddDateTimePicker);
            Controls.Add(TravelPackagesClientAddComboBox);
            Controls.Add(TravelPackagesRouteAddComboBox);
            Controls.Add(label1);
            Name = "AddTravelPackageForm";
            Text = "AddTravelPackage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox TravelPackagesRouteAddComboBox;
        private ComboBox TravelPackagesClientAddComboBox;
        private DateTimePicker TravelPackagesDateOfAddDateTimePicker;
        private TextBox TravelPackagesCountAddTextBox;
        private TextBox TravelPackagesDiscountAddTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button TravelPackagesAddSaveButton;
        private TextBox TravelIdAddTextBox;
        private Label label7;
    }
}