namespace TravelCompany.Forms
{
    partial class EditClientForm
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
            ClientSaveEditButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ClientTelephoneEditTextBox = new TextBox();
            ClientAddressEditTextBox = new TextBox();
            ClientPatronymicEditTextBox = new TextBox();
            ClientFirstnameEditTextBox = new TextBox();
            ClientSurnameEditTextBox = new TextBox();
            label1 = new Label();
            ClientIdEditTextBox = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // ClientSaveEditButton
            // 
            ClientSaveEditButton.Location = new Point(361, 199);
            ClientSaveEditButton.Name = "ClientSaveEditButton";
            ClientSaveEditButton.Size = new Size(189, 23);
            ClientSaveEditButton.TabIndex = 23;
            ClientSaveEditButton.Text = "Сохранить";
            ClientSaveEditButton.UseVisualStyleBackColor = true;
            ClientSaveEditButton.Click += ClientSaveAddButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(361, 152);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 22;
            label6.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(361, 103);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 21;
            label5.Text = "Адрес";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(25, 198);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 20;
            label4.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(25, 148);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 19;
            label3.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(25, 101);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 18;
            label2.Text = "Фамилия";
            // 
            // ClientTelephoneEditTextBox
            // 
            ClientTelephoneEditTextBox.Location = new Point(450, 150);
            ClientTelephoneEditTextBox.Name = "ClientTelephoneEditTextBox";
            ClientTelephoneEditTextBox.Size = new Size(100, 23);
            ClientTelephoneEditTextBox.TabIndex = 17;
            // 
            // ClientAddressEditTextBox
            // 
            ClientAddressEditTextBox.Location = new Point(450, 101);
            ClientAddressEditTextBox.Name = "ClientAddressEditTextBox";
            ClientAddressEditTextBox.Size = new Size(100, 23);
            ClientAddressEditTextBox.TabIndex = 16;
            // 
            // ClientPatronymicEditTextBox
            // 
            ClientPatronymicEditTextBox.Location = new Point(114, 196);
            ClientPatronymicEditTextBox.Name = "ClientPatronymicEditTextBox";
            ClientPatronymicEditTextBox.Size = new Size(172, 23);
            ClientPatronymicEditTextBox.TabIndex = 15;
            // 
            // ClientFirstnameEditTextBox
            // 
            ClientFirstnameEditTextBox.Location = new Point(114, 146);
            ClientFirstnameEditTextBox.Name = "ClientFirstnameEditTextBox";
            ClientFirstnameEditTextBox.Size = new Size(172, 23);
            ClientFirstnameEditTextBox.TabIndex = 14;
            // 
            // ClientSurnameEditTextBox
            // 
            ClientSurnameEditTextBox.Location = new Point(114, 95);
            ClientSurnameEditTextBox.Name = "ClientSurnameEditTextBox";
            ClientSurnameEditTextBox.Size = new Size(172, 23);
            ClientSurnameEditTextBox.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(290, 32);
            label1.TabIndex = 12;
            label1.Text = "Редактировать клиента";
            // 
            // ClientIdEditTextBox
            // 
            ClientIdEditTextBox.Location = new Point(450, 36);
            ClientIdEditTextBox.Name = "ClientIdEditTextBox";
            ClientIdEditTextBox.Size = new Size(100, 23);
            ClientIdEditTextBox.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(361, 38);
            label7.Name = "label7";
            label7.Size = new Size(63, 21);
            label7.TabIndex = 25;
            label7.Text = "Номер";
            // 
            // EditClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(606, 286);
            Controls.Add(label7);
            Controls.Add(ClientIdEditTextBox);
            Controls.Add(ClientSaveEditButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ClientTelephoneEditTextBox);
            Controls.Add(ClientAddressEditTextBox);
            Controls.Add(ClientPatronymicEditTextBox);
            Controls.Add(ClientFirstnameEditTextBox);
            Controls.Add(ClientSurnameEditTextBox);
            Controls.Add(label1);
            Name = "EditClientForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClientSaveEditButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox ClientTelephoneEditTextBox;
        private TextBox ClientAddressEditTextBox;
        private TextBox ClientPatronymicEditTextBox;
        private TextBox ClientFirstnameEditTextBox;
        private TextBox ClientSurnameEditTextBox;
        private Label label1;
        private TextBox ClientIdEditTextBox;
        private Label label7;
    }
}