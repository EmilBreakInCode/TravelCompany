namespace TravelCompany.Forms.Clients
{
    partial class AddClientForm
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
            ClientSurnameAddTextBox = new TextBox();
            ClientFirstnameAddTextBox = new TextBox();
            ClientPatronymcAddTextBox = new TextBox();
            ClientAddressAddTextBox = new TextBox();
            ClientTelephoneAddTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ClientSaveAddButton = new Button();
            ClientIdAddTextBox = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(106, 30);
            label1.Name = "label1";
            label1.Size = new Size(230, 32);
            label1.TabIndex = 0;
            label1.Text = "Добавить клиента";
            // 
            // ClientSurnameAddTextBox
            // 
            ClientSurnameAddTextBox.Location = new Point(106, 99);
            ClientSurnameAddTextBox.Name = "ClientSurnameAddTextBox";
            ClientSurnameAddTextBox.Size = new Size(172, 23);
            ClientSurnameAddTextBox.TabIndex = 1;
            // 
            // ClientFirstnameAddTextBox
            // 
            ClientFirstnameAddTextBox.Location = new Point(106, 150);
            ClientFirstnameAddTextBox.Name = "ClientFirstnameAddTextBox";
            ClientFirstnameAddTextBox.Size = new Size(172, 23);
            ClientFirstnameAddTextBox.TabIndex = 2;
            // 
            // ClientPatronymcAddTextBox
            // 
            ClientPatronymcAddTextBox.Location = new Point(106, 200);
            ClientPatronymcAddTextBox.Name = "ClientPatronymcAddTextBox";
            ClientPatronymcAddTextBox.Size = new Size(172, 23);
            ClientPatronymcAddTextBox.TabIndex = 3;
            // 
            // ClientAddressAddTextBox
            // 
            ClientAddressAddTextBox.Location = new Point(442, 105);
            ClientAddressAddTextBox.Name = "ClientAddressAddTextBox";
            ClientAddressAddTextBox.Size = new Size(100, 23);
            ClientAddressAddTextBox.TabIndex = 4;
            // 
            // ClientTelephoneAddTextBox
            // 
            ClientTelephoneAddTextBox.Location = new Point(442, 154);
            ClientTelephoneAddTextBox.Name = "ClientTelephoneAddTextBox";
            ClientTelephoneAddTextBox.Size = new Size(100, 23);
            ClientTelephoneAddTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(17, 105);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 6;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(17, 152);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 7;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(17, 202);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 8;
            label4.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(353, 107);
            label5.Name = "label5";
            label5.Size = new Size(59, 21);
            label5.TabIndex = 9;
            label5.Text = "Адрес";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(353, 156);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 10;
            label6.Text = "Телефон";
            // 
            // ClientSaveAddButton
            // 
            ClientSaveAddButton.Location = new Point(353, 203);
            ClientSaveAddButton.Name = "ClientSaveAddButton";
            ClientSaveAddButton.Size = new Size(189, 23);
            ClientSaveAddButton.TabIndex = 11;
            ClientSaveAddButton.Text = "Сохранить";
            ClientSaveAddButton.UseVisualStyleBackColor = true;
            ClientSaveAddButton.Click += ClientSaveAddButton_Click;
            // 
            // ClientIdAddTextBox
            // 
            ClientIdAddTextBox.Location = new Point(442, 39);
            ClientIdAddTextBox.Name = "ClientIdAddTextBox";
            ClientIdAddTextBox.Size = new Size(100, 23);
            ClientIdAddTextBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(353, 41);
            label7.Name = "label7";
            label7.Size = new Size(63, 21);
            label7.TabIndex = 13;
            label7.Text = "Номер";
            // 
            // AddClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(591, 262);
            Controls.Add(label7);
            Controls.Add(ClientIdAddTextBox);
            Controls.Add(ClientSaveAddButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ClientTelephoneAddTextBox);
            Controls.Add(ClientAddressAddTextBox);
            Controls.Add(ClientPatronymcAddTextBox);
            Controls.Add(ClientFirstnameAddTextBox);
            Controls.Add(ClientSurnameAddTextBox);
            Controls.Add(label1);
            Name = "AddClientForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ClientSurnameAddTextBox;
        private TextBox ClientFirstnameAddTextBox;
        private TextBox ClientPatronymcAddTextBox;
        private TextBox ClientAddressAddTextBox;
        private TextBox ClientTelephoneAddTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button ClientSaveAddButton;
        private TextBox ClientIdAddTextBox;
        private Label label7;
    }
}