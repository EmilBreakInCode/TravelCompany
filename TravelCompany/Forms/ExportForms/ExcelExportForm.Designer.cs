namespace TravelCompany.Forms.ExportForms
{
    partial class ExcelExportForm
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
            ClientsButton = new Button();
            RoutesButton = new Button();
            TravelPackagesButtton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(63, 42);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "Выберите таблицу";
            // 
            // ClientsButton
            // 
            ClientsButton.Location = new Point(90, 113);
            ClientsButton.Name = "ClientsButton";
            ClientsButton.Size = new Size(136, 55);
            ClientsButton.TabIndex = 1;
            ClientsButton.Text = "Клиенты";
            ClientsButton.UseVisualStyleBackColor = true;
            ClientsButton.Click += ClientsButton_Click;
            // 
            // RoutesButton
            // 
            RoutesButton.Location = new Point(90, 200);
            RoutesButton.Name = "RoutesButton";
            RoutesButton.Size = new Size(136, 55);
            RoutesButton.TabIndex = 2;
            RoutesButton.Text = "Маршруты";
            RoutesButton.UseVisualStyleBackColor = true;
            RoutesButton.Click += RoutesButton_Click;
            // 
            // TravelPackagesButtton
            // 
            TravelPackagesButtton.Location = new Point(90, 287);
            TravelPackagesButtton.Name = "TravelPackagesButtton";
            TravelPackagesButtton.Size = new Size(136, 55);
            TravelPackagesButtton.TabIndex = 3;
            TravelPackagesButtton.Text = "Путевки";
            TravelPackagesButtton.UseVisualStyleBackColor = true;
            TravelPackagesButtton.Click += TravelPackagesButtton_Click;
            // 
            // ExcelExportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(326, 450);
            Controls.Add(TravelPackagesButtton);
            Controls.Add(RoutesButton);
            Controls.Add(ClientsButton);
            Controls.Add(label1);
            Name = "ExcelExportForm";
            Text = "ExcelExportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ClientsButton;
        private Button RoutesButton;
        private Button TravelPackagesButtton;
    }
}