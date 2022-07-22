
namespace BusDepot
{
    partial class FormDrivers
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
            this.buttonChangeData = new System.Windows.Forms.Button();
            this.labelDrivers = new System.Windows.Forms.Label();
            this.buttonAddDriver = new System.Windows.Forms.Button();
            this.listBoxDrivers = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxChangeName = new System.Windows.Forms.TextBox();
            this.textBoxChangeSurname = new System.Windows.Forms.TextBox();
            this.textBoxChangeExperience = new System.Windows.Forms.TextBox();
            this.textBoxChangeRoute = new System.Windows.Forms.TextBox();
            this.watermarkTextBoxAddRoute = new BusDepot.WatermarkTextBox();
            this.watermarkTextBoxAddExperience = new BusDepot.WatermarkTextBox();
            this.watermarkTextBoxAddSurname = new BusDepot.WatermarkTextBox();
            this.watermarkTextBoxAddName = new BusDepot.WatermarkTextBox();
            this.SuspendLayout();
            // 
            // buttonChangeData
            // 
            this.buttonChangeData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeData.Location = new System.Drawing.Point(338, 258);
            this.buttonChangeData.Name = "buttonChangeData";
            this.buttonChangeData.Size = new System.Drawing.Size(150, 77);
            this.buttonChangeData.TabIndex = 16;
            this.buttonChangeData.Text = "Изменить данные";
            this.buttonChangeData.UseVisualStyleBackColor = true;
            this.buttonChangeData.Click += new System.EventHandler(this.buttonChangeData_Click);
            // 
            // labelDrivers
            // 
            this.labelDrivers.AutoSize = true;
            this.labelDrivers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrivers.Location = new System.Drawing.Point(214, 22);
            this.labelDrivers.Name = "labelDrivers";
            this.labelDrivers.Size = new System.Drawing.Size(75, 19);
            this.labelDrivers.TabIndex = 12;
            this.labelDrivers.Text = "Водители";
            // 
            // buttonAddDriver
            // 
            this.buttonAddDriver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddDriver.Location = new System.Drawing.Point(338, 47);
            this.buttonAddDriver.Name = "buttonAddDriver";
            this.buttonAddDriver.Size = new System.Drawing.Size(150, 77);
            this.buttonAddDriver.TabIndex = 11;
            this.buttonAddDriver.Text = "Добавить водителя";
            this.buttonAddDriver.UseVisualStyleBackColor = true;
            this.buttonAddDriver.Click += new System.EventHandler(this.buttonAddDriver_Click);
            // 
            // listBoxDrivers
            // 
            this.listBoxDrivers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxDrivers.FormattingEnabled = true;
            this.listBoxDrivers.HorizontalScrollbar = true;
            this.listBoxDrivers.ItemHeight = 19;
            this.listBoxDrivers.Items.AddRange(new object[] {
            "ID | Имя | Фамилия | Опыт работы | Маршрут"});
            this.listBoxDrivers.Location = new System.Drawing.Point(12, 47);
            this.listBoxDrivers.Name = "listBoxDrivers";
            this.listBoxDrivers.Size = new System.Drawing.Size(320, 498);
            this.listBoxDrivers.TabIndex = 10;
            this.listBoxDrivers.SelectedIndexChanged += new System.EventHandler(this.listBoxDrivers_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(338, 469);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 76);
            this.buttonDelete.TabIndex = 20;
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
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Главное меню";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxChangeName
            // 
            this.textBoxChangeName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChangeName.Location = new System.Drawing.Point(338, 341);
            this.textBoxChangeName.Name = "textBoxChangeName";
            this.textBoxChangeName.Size = new System.Drawing.Size(150, 26);
            this.textBoxChangeName.TabIndex = 27;
            this.textBoxChangeName.Visible = false;
            // 
            // textBoxChangeSurname
            // 
            this.textBoxChangeSurname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChangeSurname.Location = new System.Drawing.Point(338, 373);
            this.textBoxChangeSurname.Name = "textBoxChangeSurname";
            this.textBoxChangeSurname.Size = new System.Drawing.Size(150, 26);
            this.textBoxChangeSurname.TabIndex = 28;
            this.textBoxChangeSurname.Visible = false;
            // 
            // textBoxChangeExperience
            // 
            this.textBoxChangeExperience.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChangeExperience.Location = new System.Drawing.Point(338, 405);
            this.textBoxChangeExperience.Name = "textBoxChangeExperience";
            this.textBoxChangeExperience.Size = new System.Drawing.Size(150, 26);
            this.textBoxChangeExperience.TabIndex = 29;
            this.textBoxChangeExperience.Visible = false;
            // 
            // textBoxChangeRoute
            // 
            this.textBoxChangeRoute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChangeRoute.Location = new System.Drawing.Point(338, 437);
            this.textBoxChangeRoute.Name = "textBoxChangeRoute";
            this.textBoxChangeRoute.Size = new System.Drawing.Size(150, 26);
            this.textBoxChangeRoute.TabIndex = 31;
            this.textBoxChangeRoute.Visible = false;
            // 
            // watermarkTextBoxAddRoute
            // 
            this.watermarkTextBoxAddRoute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watermarkTextBoxAddRoute.Location = new System.Drawing.Point(338, 226);
            this.watermarkTextBoxAddRoute.Name = "watermarkTextBoxAddRoute";
            this.watermarkTextBoxAddRoute.Size = new System.Drawing.Size(150, 26);
            this.watermarkTextBoxAddRoute.TabIndex = 30;
            this.watermarkTextBoxAddRoute.Visible = false;
            this.watermarkTextBoxAddRoute.Watermark = "Маршрут";
            // 
            // watermarkTextBoxAddExperience
            // 
            this.watermarkTextBoxAddExperience.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watermarkTextBoxAddExperience.Location = new System.Drawing.Point(338, 194);
            this.watermarkTextBoxAddExperience.Name = "watermarkTextBoxAddExperience";
            this.watermarkTextBoxAddExperience.Size = new System.Drawing.Size(150, 26);
            this.watermarkTextBoxAddExperience.TabIndex = 26;
            this.watermarkTextBoxAddExperience.Visible = false;
            this.watermarkTextBoxAddExperience.Watermark = "Опыт работы";
            // 
            // watermarkTextBoxAddSurname
            // 
            this.watermarkTextBoxAddSurname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watermarkTextBoxAddSurname.Location = new System.Drawing.Point(338, 162);
            this.watermarkTextBoxAddSurname.Name = "watermarkTextBoxAddSurname";
            this.watermarkTextBoxAddSurname.Size = new System.Drawing.Size(150, 26);
            this.watermarkTextBoxAddSurname.TabIndex = 25;
            this.watermarkTextBoxAddSurname.Visible = false;
            this.watermarkTextBoxAddSurname.Watermark = "Фамилия";
            // 
            // watermarkTextBoxAddName
            // 
            this.watermarkTextBoxAddName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watermarkTextBoxAddName.Location = new System.Drawing.Point(338, 130);
            this.watermarkTextBoxAddName.Name = "watermarkTextBoxAddName";
            this.watermarkTextBoxAddName.Size = new System.Drawing.Size(150, 26);
            this.watermarkTextBoxAddName.TabIndex = 24;
            this.watermarkTextBoxAddName.Visible = false;
            this.watermarkTextBoxAddName.Watermark = "Имя";
            // 
            // FormDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 553);
            this.Controls.Add(this.textBoxChangeRoute);
            this.Controls.Add(this.watermarkTextBoxAddRoute);
            this.Controls.Add(this.textBoxChangeExperience);
            this.Controls.Add(this.textBoxChangeSurname);
            this.Controls.Add(this.textBoxChangeName);
            this.Controls.Add(this.watermarkTextBoxAddExperience);
            this.Controls.Add(this.watermarkTextBoxAddSurname);
            this.Controls.Add(this.watermarkTextBoxAddName);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChangeData);
            this.Controls.Add(this.labelDrivers);
            this.Controls.Add(this.buttonAddDriver);
            this.Controls.Add(this.listBoxDrivers);
            this.Name = "FormDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus depot drivers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDrivers_FormClosing);
            this.Shown += new System.EventHandler(this.FormDrivers_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChangeData;
        private System.Windows.Forms.Label labelDrivers;
        private System.Windows.Forms.Button buttonAddDriver;
        private System.Windows.Forms.ListBox listBoxDrivers;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBack;
        private WatermarkTextBox watermarkTextBoxAddName;
        private WatermarkTextBox watermarkTextBoxAddSurname;
        private WatermarkTextBox watermarkTextBoxAddExperience;
        private System.Windows.Forms.TextBox textBoxChangeName;
        private System.Windows.Forms.TextBox textBoxChangeSurname;
        private System.Windows.Forms.TextBox textBoxChangeExperience;
        private WatermarkTextBox watermarkTextBoxAddRoute;
        private System.Windows.Forms.TextBox textBoxChangeRoute;
    }
}