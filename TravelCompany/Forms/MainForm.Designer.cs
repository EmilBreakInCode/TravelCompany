namespace TravelCompany
{
    partial class MainForm
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
            clientsDataGridView = new DataGridView();
            routesDataGridView = new DataGridView();
            travelPackagesDataGridView = new DataGridView();
            buttonAddClient = new Button();
            buttonEditClient = new Button();
            buttonDelClient = new Button();
            buttonDelRoute = new Button();
            buttonEditRoute = new Button();
            buttonAddRoute = new Button();
            buttonDelTravelPackage = new Button();
            buttonEditTravelPackage = new Button();
            buttonAddTravelPackage = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            buttonHTML = new Button();
            buttonExcel = new Button();
            buttonWord = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)routesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)travelPackagesDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.GridColor = Color.FromArgb(255, 128, 128);
            clientsDataGridView.Location = new Point(12, 121);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.Size = new Size(648, 150);
            clientsDataGridView.TabIndex = 0;
            // 
            // routesDataGridView
            // 
            routesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            routesDataGridView.GridColor = Color.FromArgb(255, 128, 128);
            routesDataGridView.Location = new Point(12, 313);
            routesDataGridView.Name = "routesDataGridView";
            routesDataGridView.Size = new Size(648, 150);
            routesDataGridView.TabIndex = 1;
            // 
            // travelPackagesDataGridView
            // 
            travelPackagesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            travelPackagesDataGridView.GridColor = Color.FromArgb(255, 128, 128);
            travelPackagesDataGridView.Location = new Point(12, 507);
            travelPackagesDataGridView.Name = "travelPackagesDataGridView";
            travelPackagesDataGridView.Size = new Size(648, 150);
            travelPackagesDataGridView.TabIndex = 2;
            // 
            // buttonAddClient
            // 
            buttonAddClient.Location = new Point(666, 190);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(75, 23);
            buttonAddClient.TabIndex = 3;
            buttonAddClient.Text = "Добавить";
            buttonAddClient.UseVisualStyleBackColor = true;
            buttonAddClient.Click += buttonAddClient_Click;
            // 
            // buttonEditClient
            // 
            buttonEditClient.Location = new Point(666, 219);
            buttonEditClient.Name = "buttonEditClient";
            buttonEditClient.Size = new Size(75, 23);
            buttonEditClient.TabIndex = 4;
            buttonEditClient.Text = "Изменить";
            buttonEditClient.UseVisualStyleBackColor = true;
            buttonEditClient.Click += buttonEditClient_Click;
            // 
            // buttonDelClient
            // 
            buttonDelClient.Location = new Point(666, 248);
            buttonDelClient.Name = "buttonDelClient";
            buttonDelClient.Size = new Size(75, 23);
            buttonDelClient.TabIndex = 5;
            buttonDelClient.Text = "Удалить";
            buttonDelClient.UseVisualStyleBackColor = true;
            buttonDelClient.Click += buttonDelClient_Click;
            // 
            // buttonDelRoute
            // 
            buttonDelRoute.Location = new Point(666, 440);
            buttonDelRoute.Name = "buttonDelRoute";
            buttonDelRoute.Size = new Size(75, 23);
            buttonDelRoute.TabIndex = 8;
            buttonDelRoute.Text = "Удалить";
            buttonDelRoute.UseVisualStyleBackColor = true;
            buttonDelRoute.Click += buttonDelRoute_Click;
            // 
            // buttonEditRoute
            // 
            buttonEditRoute.Location = new Point(666, 411);
            buttonEditRoute.Name = "buttonEditRoute";
            buttonEditRoute.Size = new Size(75, 23);
            buttonEditRoute.TabIndex = 7;
            buttonEditRoute.Text = "Изменить";
            buttonEditRoute.UseVisualStyleBackColor = true;
            buttonEditRoute.Click += buttonEditRoute_Click;
            // 
            // buttonAddRoute
            // 
            buttonAddRoute.Location = new Point(666, 382);
            buttonAddRoute.Name = "buttonAddRoute";
            buttonAddRoute.Size = new Size(75, 23);
            buttonAddRoute.TabIndex = 6;
            buttonAddRoute.Text = "Добавить";
            buttonAddRoute.UseVisualStyleBackColor = true;
            buttonAddRoute.Click += buttonAddRoute_Click;
            // 
            // buttonDelTravelPackage
            // 
            buttonDelTravelPackage.Location = new Point(666, 634);
            buttonDelTravelPackage.Name = "buttonDelTravelPackage";
            buttonDelTravelPackage.Size = new Size(75, 23);
            buttonDelTravelPackage.TabIndex = 11;
            buttonDelTravelPackage.Text = "Удалить";
            buttonDelTravelPackage.UseVisualStyleBackColor = true;
            buttonDelTravelPackage.Click += buttonDelTravelPackage_Click;
            // 
            // buttonEditTravelPackage
            // 
            buttonEditTravelPackage.Location = new Point(666, 605);
            buttonEditTravelPackage.Name = "buttonEditTravelPackage";
            buttonEditTravelPackage.Size = new Size(75, 23);
            buttonEditTravelPackage.TabIndex = 10;
            buttonEditTravelPackage.Text = "Изменить";
            buttonEditTravelPackage.UseVisualStyleBackColor = true;
            buttonEditTravelPackage.Click += buttonEditTravelPackage_Click;
            // 
            // buttonAddTravelPackage
            // 
            buttonAddTravelPackage.Location = new Point(666, 576);
            buttonAddTravelPackage.Name = "buttonAddTravelPackage";
            buttonAddTravelPackage.Size = new Size(75, 23);
            buttonAddTravelPackage.TabIndex = 9;
            buttonAddTravelPackage.Text = "Добавить";
            buttonAddTravelPackage.UseVisualStyleBackColor = true;
            buttonAddTravelPackage.Click += buttonAddTravelPackage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(365, 45);
            label1.TabIndex = 12;
            label1.Text = "Туристическая фирма";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(128, 255, 128);
            groupBox1.Controls.Add(buttonHTML);
            groupBox1.Controls.Add(buttonExcel);
            groupBox1.Controls.Add(buttonWord);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 698);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(729, 77);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Отчеты";
            // 
            // buttonHTML
            // 
            buttonHTML.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHTML.Location = new Point(524, 12);
            buttonHTML.Name = "buttonHTML";
            buttonHTML.Size = new Size(124, 52);
            buttonHTML.TabIndex = 16;
            buttonHTML.Text = "HTML";
            buttonHTML.UseVisualStyleBackColor = true;
            buttonHTML.Click += buttonHTML_Click;
            // 
            // buttonExcel
            // 
            buttonExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonExcel.Location = new Point(321, 12);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(124, 52);
            buttonExcel.TabIndex = 15;
            buttonExcel.Text = "Excel";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += buttonExcel_Click;
            // 
            // buttonWord
            // 
            buttonWord.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonWord.Location = new Point(126, 12);
            buttonWord.Name = "buttonWord";
            buttonWord.Size = new Size(124, 52);
            buttonWord.TabIndex = 14;
            buttonWord.Text = "Word";
            buttonWord.UseVisualStyleBackColor = true;
            buttonWord.Click += buttonWord_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 14;
            label2.Text = "Клиенты";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 289);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 15;
            label3.Text = "Маршруты";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 483);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 16;
            label4.Text = "Путёвки";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(753, 787);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(buttonDelTravelPackage);
            Controls.Add(buttonEditTravelPackage);
            Controls.Add(buttonAddTravelPackage);
            Controls.Add(buttonDelRoute);
            Controls.Add(buttonEditRoute);
            Controls.Add(buttonAddRoute);
            Controls.Add(buttonDelClient);
            Controls.Add(buttonEditClient);
            Controls.Add(buttonAddClient);
            Controls.Add(travelPackagesDataGridView);
            Controls.Add(routesDataGridView);
            Controls.Add(clientsDataGridView);
            Name = "MainForm";
            Text = "Travel Company";
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)routesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)travelPackagesDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView clientsDataGridView;
        private DataGridView routesDataGridView;
        private DataGridView travelPackagesDataGridView;
        private Button buttonAddClient;
        private Button buttonEditClient;
        private Button buttonDelClient;
        private Button buttonDelRoute;
        private Button buttonEditRoute;
        private Button buttonAddRoute;
        private Button buttonDelTravelPackage;
        private Button buttonEditTravelPackage;
        private Button buttonAddTravelPackage;
        private Label label1;
        private GroupBox groupBox1;
        private Button buttonHTML;
        private Button buttonExcel;
        private Button buttonWord;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
