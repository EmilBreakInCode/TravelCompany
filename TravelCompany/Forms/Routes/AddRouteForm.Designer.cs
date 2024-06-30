namespace TravelCompany.Forms.Routes
{
    partial class AddRouteForm
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
            RoutesCountryAddTextBox = new TextBox();
            RoutesClimateAddTextBox = new TextBox();
            RoutesHotelAddTextBox = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            RoutesDurationAddTextBox = new TextBox();
            RoutesCoastAddTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            RoutesSaveAddButton = new Button();
            RouteIdAddTextBox = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(211, 30);
            label1.TabIndex = 0;
            label1.Text = "Добавить маршрут";
            // 
            // RoutesCountryAddTextBox
            // 
            RoutesCountryAddTextBox.Location = new Point(86, 92);
            RoutesCountryAddTextBox.Name = "RoutesCountryAddTextBox";
            RoutesCountryAddTextBox.Size = new Size(206, 23);
            RoutesCountryAddTextBox.TabIndex = 1;
            // 
            // RoutesClimateAddTextBox
            // 
            RoutesClimateAddTextBox.Location = new Point(86, 138);
            RoutesClimateAddTextBox.Name = "RoutesClimateAddTextBox";
            RoutesClimateAddTextBox.Size = new Size(206, 23);
            RoutesClimateAddTextBox.TabIndex = 2;
            // 
            // RoutesHotelAddTextBox
            // 
            RoutesHotelAddTextBox.Location = new Point(456, 94);
            RoutesHotelAddTextBox.Name = "RoutesHotelAddTextBox";
            RoutesHotelAddTextBox.Size = new Size(251, 23);
            RoutesHotelAddTextBox.TabIndex = 3;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // RoutesDurationAddTextBox
            // 
            RoutesDurationAddTextBox.Location = new Point(456, 142);
            RoutesDurationAddTextBox.Name = "RoutesDurationAddTextBox";
            RoutesDurationAddTextBox.Size = new Size(102, 23);
            RoutesDurationAddTextBox.TabIndex = 4;
            // 
            // RoutesCoastAddTextBox
            // 
            RoutesCoastAddTextBox.Location = new Point(456, 197);
            RoutesCoastAddTextBox.Name = "RoutesCoastAddTextBox";
            RoutesCoastAddTextBox.Size = new Size(102, 23);
            RoutesCoastAddTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 6;
            label2.Text = "Страна";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(15, 140);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 7;
            label3.Text = "Климат";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(321, 96);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 8;
            label4.Text = "Отель";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(321, 144);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 9;
            label5.Text = "Длительность";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(321, 199);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 10;
            label6.Text = "Цена";
            // 
            // RoutesSaveAddButton
            // 
            RoutesSaveAddButton.Location = new Point(86, 200);
            RoutesSaveAddButton.Name = "RoutesSaveAddButton";
            RoutesSaveAddButton.Size = new Size(206, 23);
            RoutesSaveAddButton.TabIndex = 11;
            RoutesSaveAddButton.Text = "Сохранить";
            RoutesSaveAddButton.UseVisualStyleBackColor = true;
            RoutesSaveAddButton.Click += RouteSaveRoutesSaveAddButton_Click;
            // 
            // RouteIdAddTextBox
            // 
            RouteIdAddTextBox.Location = new Point(456, 30);
            RouteIdAddTextBox.Name = "RouteIdAddTextBox";
            RouteIdAddTextBox.Size = new Size(102, 23);
            RouteIdAddTextBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(321, 32);
            label7.Name = "label7";
            label7.Size = new Size(63, 21);
            label7.TabIndex = 13;
            label7.Text = "Номер";
            // 
            // AddRouteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(731, 291);
            Controls.Add(label7);
            Controls.Add(RouteIdAddTextBox);
            Controls.Add(RoutesSaveAddButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RoutesCoastAddTextBox);
            Controls.Add(RoutesDurationAddTextBox);
            Controls.Add(RoutesHotelAddTextBox);
            Controls.Add(RoutesClimateAddTextBox);
            Controls.Add(RoutesCountryAddTextBox);
            Controls.Add(label1);
            Name = "AddRouteForm";
            Text = "AddRoute";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox RoutesCountryAddTextBox;
        private TextBox RoutesClimateAddTextBox;
        private TextBox RoutesHotelAddTextBox;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox RoutesDurationAddTextBox;
        private TextBox RoutesCoastAddTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button RoutesSaveAddButton;
        private TextBox RouteIdAddTextBox;
        private Label label7;
    }
}