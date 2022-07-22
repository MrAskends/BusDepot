
namespace BusDepot
{
    partial class FormFleet
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
            this.listBoxFleet = new System.Windows.Forms.ListBox();
            this.buttonAddBus = new System.Windows.Forms.Button();
            this.labelFleet = new System.Windows.Forms.Label();
            this.buttonChangeData = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.watermarkTextBoxAddBrand = new BusDepot.WatermarkTextBox();
            this.watermarkTextBoxAddNumber = new BusDepot.WatermarkTextBox();
            this.watermarkTextBoxAddRoute = new BusDepot.WatermarkTextBox();
            this.textBoxChangeNumber = new System.Windows.Forms.TextBox();
            this.textBoxChangeBrand = new System.Windows.Forms.TextBox();
            this.textBoxChangeRoute = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxFleet
            // 
            this.listBoxFleet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFleet.FormattingEnabled = true;
            this.listBoxFleet.HorizontalScrollbar = true;
            this.listBoxFleet.ItemHeight = 19;
            this.listBoxFleet.Items.AddRange(new object[] {
            "ID | Марка | Гос.Номер | Маршрут"});
            this.listBoxFleet.Location = new System.Drawing.Point(12, 47);
            this.listBoxFleet.Name = "listBoxFleet";
            this.listBoxFleet.Size = new System.Drawing.Size(251, 441);
            this.listBoxFleet.TabIndex = 0;
            this.listBoxFleet.SelectedIndexChanged += new System.EventHandler(this.listBoxFleet_SelectedIndexChanged);
            // 
            // buttonAddBus
            // 
            this.buttonAddBus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddBus.Location = new System.Drawing.Point(269, 47);
            this.buttonAddBus.Name = "buttonAddBus";
            this.buttonAddBus.Size = new System.Drawing.Size(150, 77);
            this.buttonAddBus.TabIndex = 1;
            this.buttonAddBus.Text = "Добавить автобус";
            this.buttonAddBus.UseVisualStyleBackColor = true;
            this.buttonAddBus.Click += new System.EventHandler(this.buttonAddBus_Click);
            // 
            // labelFleet
            // 
            this.labelFleet.AutoSize = true;
            this.labelFleet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFleet.Location = new System.Drawing.Point(189, 18);
            this.labelFleet.Name = "labelFleet";
            this.labelFleet.Size = new System.Drawing.Size(74, 19);
            this.labelFleet.TabIndex = 2;
            this.labelFleet.Text = "Автопарк";
            // 
            // buttonChangeData
            // 
            this.buttonChangeData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeData.Location = new System.Drawing.Point(269, 226);
            this.buttonChangeData.Name = "buttonChangeData";
            this.buttonChangeData.Size = new System.Drawing.Size(150, 77);
            this.buttonChangeData.TabIndex = 6;
            this.buttonChangeData.Text = "Изменить данные";
            this.buttonChangeData.UseVisualStyleBackColor = true;
            this.buttonChangeData.Click += new System.EventHandler(this.buttonChangeData_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(269, 405);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 83);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(119, 29);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Text = "Главное меню";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // watermarkTextBoxAddBrand
            // 
            this.watermarkTextBoxAddBrand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watermarkTextBoxAddBrand.Location = new System.Drawing.Point(269, 130);
            this.watermarkTextBoxAddBrand.Name = "watermarkTextBoxAddBrand";
            this.watermarkTextBoxAddBrand.Size = new System.Drawing.Size(150, 26);
            this.watermarkTextBoxAddBrand.TabIndex = 23;
            this.watermarkTextBoxAddBrand.Visible = false;
            this.watermarkTextBoxAddBrand.Watermark = "Марка";
            // 
            // watermarkTextBoxAddNumber
            // 
            this.watermarkTextBoxAddNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watermarkTextBoxAddNumber.Location = new System.Drawing.Point(269, 162);
            this.watermarkTextBoxAddNumber.Name = "watermarkTextBoxAddNumber";
            this.watermarkTextBoxAddNumber.Size = new System.Drawing.Size(150, 26);
            this.watermarkTextBoxAddNumber.TabIndex = 24;
            this.watermarkTextBoxAddNumber.Visible = false;
            this.watermarkTextBoxAddNumber.Watermark = "Гос.Номер";
            // 
            // watermarkTextBoxAddRoute
            // 
            this.watermarkTextBoxAddRoute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watermarkTextBoxAddRoute.Location = new System.Drawing.Point(269, 194);
            this.watermarkTextBoxAddRoute.Name = "watermarkTextBoxAddRoute";
            this.watermarkTextBoxAddRoute.Size = new System.Drawing.Size(150, 26);
            this.watermarkTextBoxAddRoute.TabIndex = 25;
            this.watermarkTextBoxAddRoute.Visible = false;
            this.watermarkTextBoxAddRoute.Watermark = "Маршрут";
            // 
            // textBoxChangeNumber
            // 
            this.textBoxChangeNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChangeNumber.Location = new System.Drawing.Point(269, 341);
            this.textBoxChangeNumber.Name = "textBoxChangeNumber";
            this.textBoxChangeNumber.Size = new System.Drawing.Size(150, 26);
            this.textBoxChangeNumber.TabIndex = 26;
            this.textBoxChangeNumber.Visible = false;
            // 
            // textBoxChangeBrand
            // 
            this.textBoxChangeBrand.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChangeBrand.Location = new System.Drawing.Point(269, 309);
            this.textBoxChangeBrand.Name = "textBoxChangeBrand";
            this.textBoxChangeBrand.Size = new System.Drawing.Size(150, 26);
            this.textBoxChangeBrand.TabIndex = 27;
            this.textBoxChangeBrand.Visible = false;
            // 
            // textBoxChangeRoute
            // 
            this.textBoxChangeRoute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChangeRoute.Location = new System.Drawing.Point(269, 373);
            this.textBoxChangeRoute.Name = "textBoxChangeRoute";
            this.textBoxChangeRoute.Size = new System.Drawing.Size(150, 26);
            this.textBoxChangeRoute.TabIndex = 28;
            this.textBoxChangeRoute.Visible = false;
            // 
            // FormFleet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 496);
            this.Controls.Add(this.textBoxChangeRoute);
            this.Controls.Add(this.textBoxChangeBrand);
            this.Controls.Add(this.textBoxChangeNumber);
            this.Controls.Add(this.watermarkTextBoxAddRoute);
            this.Controls.Add(this.watermarkTextBoxAddNumber);
            this.Controls.Add(this.watermarkTextBoxAddBrand);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChangeData);
            this.Controls.Add(this.labelFleet);
            this.Controls.Add(this.buttonAddBus);
            this.Controls.Add(this.listBoxFleet);
            this.Name = "FormFleet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus depot fleet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFleet_FormClosing);
            this.Shown += new System.EventHandler(this.FormFleet_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFleet;
        private System.Windows.Forms.Button buttonAddBus;
        private System.Windows.Forms.Label labelFleet;
        private System.Windows.Forms.Button buttonChangeData;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
        private WatermarkTextBox watermarkTextBoxAddBrand;
        private WatermarkTextBox watermarkTextBoxAddNumber;
        private WatermarkTextBox watermarkTextBoxAddRoute;
        private System.Windows.Forms.TextBox textBoxChangeNumber;
        private System.Windows.Forms.TextBox textBoxChangeBrand;
        private System.Windows.Forms.TextBox textBoxChangeRoute;
    }
}