namespace TravelCompany.Forms.ExportForms
{
    partial class HtmlExportForm
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
            TravelPackagesButtton = new Button();
            RoutesButton = new Button();
            ClientsButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // TravelPackagesButtton
            // 
            TravelPackagesButtton.Location = new Point(96, 309);
            TravelPackagesButtton.Name = "TravelPackagesButtton";
            TravelPackagesButtton.Size = new Size(136, 55);
            TravelPackagesButtton.TabIndex = 11;
            TravelPackagesButtton.Text = "Путевки";
            TravelPackagesButtton.UseVisualStyleBackColor = true;
            TravelPackagesButtton.Click += TravelPackagesButtton_Click;
            // 
            // RoutesButton
            // 
            RoutesButton.Location = new Point(96, 222);
            RoutesButton.Name = "RoutesButton";
            RoutesButton.Size = new Size(136, 55);
            RoutesButton.TabIndex = 10;
            RoutesButton.Text = "Маршруты";
            RoutesButton.UseVisualStyleBackColor = true;
            RoutesButton.Click += RoutesButton_Click;
            // 
            // ClientsButton
            // 
            ClientsButton.Location = new Point(96, 135);
            ClientsButton.Name = "ClientsButton";
            ClientsButton.Size = new Size(136, 55);
            ClientsButton.TabIndex = 9;
            ClientsButton.Text = "Клиенты";
            ClientsButton.UseVisualStyleBackColor = true;
            ClientsButton.Click += ClientsButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(69, 64);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 8;
            label1.Text = "Выберите таблицу";
            // 
            // HtmlExportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(343, 450);
            Controls.Add(TravelPackagesButtton);
            Controls.Add(RoutesButton);
            Controls.Add(ClientsButton);
            Controls.Add(label1);
            Name = "HtmlExportForm";
            Text = "HtmlExportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button TravelPackagesButtton;
        private Button RoutesButton;
        private Button ClientsButton;
        private Label label1;
    }
}