namespace OBS_Config_Manager__GUI_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLogo = new System.Windows.Forms.Label();
            this.listBoxConfigsList = new System.Windows.Forms.ListBox();
            this.btApplyConfig = new System.Windows.Forms.Button();
            this.btDelConfig = new System.Windows.Forms.Button();
            this.btDublicateConfig = new System.Windows.Forms.Button();
            this.btCreateConfig = new System.Windows.Forms.Button();
            this.btSaveDefault = new System.Windows.Forms.Button();
            this.checkBoxUnlock1 = new System.Windows.Forms.CheckBox();
            this.checkBoxUnlock2 = new System.Windows.Forms.CheckBox();
            this.textBoxConfigName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btUpdateList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Location = new System.Drawing.Point(126, 9);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(129, 13);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "OBS CONFIG MANAGER";
            // 
            // listBoxConfigsList
            // 
            this.listBoxConfigsList.FormattingEnabled = true;
            this.listBoxConfigsList.Location = new System.Drawing.Point(15, 38);
            this.listBoxConfigsList.Name = "listBoxConfigsList";
            this.listBoxConfigsList.Size = new System.Drawing.Size(218, 277);
            this.listBoxConfigsList.TabIndex = 1;
            // 
            // btApplyConfig
            // 
            this.btApplyConfig.Location = new System.Drawing.Point(239, 280);
            this.btApplyConfig.Name = "btApplyConfig";
            this.btApplyConfig.Size = new System.Drawing.Size(127, 35);
            this.btApplyConfig.TabIndex = 2;
            this.btApplyConfig.Text = "Запустить";
            this.btApplyConfig.UseVisualStyleBackColor = true;
            this.btApplyConfig.Click += new System.EventHandler(this.btApplyConfig_Click);
            // 
            // btDelConfig
            // 
            this.btDelConfig.Enabled = false;
            this.btDelConfig.Location = new System.Drawing.Point(239, 68);
            this.btDelConfig.Name = "btDelConfig";
            this.btDelConfig.Size = new System.Drawing.Size(127, 24);
            this.btDelConfig.TabIndex = 4;
            this.btDelConfig.Text = "Удалить";
            this.btDelConfig.UseVisualStyleBackColor = true;
            this.btDelConfig.Click += new System.EventHandler(this.btDelConfig_Click);
            // 
            // btDublicateConfig
            // 
            this.btDublicateConfig.Location = new System.Drawing.Point(239, 220);
            this.btDublicateConfig.Name = "btDublicateConfig";
            this.btDublicateConfig.Size = new System.Drawing.Size(127, 24);
            this.btDublicateConfig.TabIndex = 5;
            this.btDublicateConfig.Text = "Клонировать";
            this.btDublicateConfig.UseVisualStyleBackColor = true;
            this.btDublicateConfig.Click += new System.EventHandler(this.btDublicateConfig_Click);
            // 
            // btCreateConfig
            // 
            this.btCreateConfig.Location = new System.Drawing.Point(239, 250);
            this.btCreateConfig.Name = "btCreateConfig";
            this.btCreateConfig.Size = new System.Drawing.Size(127, 24);
            this.btCreateConfig.TabIndex = 6;
            this.btCreateConfig.Text = "Создать";
            this.btCreateConfig.UseVisualStyleBackColor = true;
            this.btCreateConfig.Click += new System.EventHandler(this.btCreateConfig_Click);
            // 
            // btSaveDefault
            // 
            this.btSaveDefault.Enabled = false;
            this.btSaveDefault.Location = new System.Drawing.Point(239, 38);
            this.btSaveDefault.Name = "btSaveDefault";
            this.btSaveDefault.Size = new System.Drawing.Size(127, 24);
            this.btSaveDefault.TabIndex = 7;
            this.btSaveDefault.Text = "Сделать копию";
            this.btSaveDefault.UseVisualStyleBackColor = true;
            this.btSaveDefault.Click += new System.EventHandler(this.btSaveDefault_Click);
            // 
            // checkBoxUnlock1
            // 
            this.checkBoxUnlock1.AutoSize = true;
            this.checkBoxUnlock1.Location = new System.Drawing.Point(239, 128);
            this.checkBoxUnlock1.Name = "checkBoxUnlock1";
            this.checkBoxUnlock1.Size = new System.Drawing.Size(108, 17);
            this.checkBoxUnlock1.TabIndex = 8;
            this.checkBoxUnlock1.Text = "Включить бэкап";
            this.checkBoxUnlock1.UseVisualStyleBackColor = true;
            this.checkBoxUnlock1.CheckedChanged += new System.EventHandler(this.checkBoxUnlock1_CheckedChanged);
            // 
            // checkBoxUnlock2
            // 
            this.checkBoxUnlock2.AutoSize = true;
            this.checkBoxUnlock2.Location = new System.Drawing.Point(239, 148);
            this.checkBoxUnlock2.Name = "checkBoxUnlock2";
            this.checkBoxUnlock2.Size = new System.Drawing.Size(118, 17);
            this.checkBoxUnlock2.TabIndex = 9;
            this.checkBoxUnlock2.Text = "Включить удалить";
            this.checkBoxUnlock2.UseVisualStyleBackColor = true;
            this.checkBoxUnlock2.CheckedChanged += new System.EventHandler(this.checkBoxUnlock2_CheckedChanged);
            // 
            // textBoxConfigName
            // 
            this.textBoxConfigName.Location = new System.Drawing.Point(239, 194);
            this.textBoxConfigName.Name = "textBoxConfigName";
            this.textBoxConfigName.Size = new System.Drawing.Size(127, 20);
            this.textBoxConfigName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название";
            // 
            // btUpdateList
            // 
            this.btUpdateList.Location = new System.Drawing.Point(239, 98);
            this.btUpdateList.Name = "btUpdateList";
            this.btUpdateList.Size = new System.Drawing.Size(127, 24);
            this.btUpdateList.TabIndex = 12;
            this.btUpdateList.Text = "Обновить";
            this.btUpdateList.UseVisualStyleBackColor = true;
            this.btUpdateList.Click += new System.EventHandler(this.btUpdateList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 328);
            this.Controls.Add(this.btUpdateList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConfigName);
            this.Controls.Add(this.checkBoxUnlock2);
            this.Controls.Add(this.checkBoxUnlock1);
            this.Controls.Add(this.btSaveDefault);
            this.Controls.Add(this.btCreateConfig);
            this.Controls.Add(this.btDublicateConfig);
            this.Controls.Add(this.btDelConfig);
            this.Controls.Add(this.btApplyConfig);
            this.Controls.Add(this.listBoxConfigsList);
            this.Controls.Add(this.labelLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.ListBox listBoxConfigsList;
        private System.Windows.Forms.Button btApplyConfig;
        private System.Windows.Forms.Button btDelConfig;
        private System.Windows.Forms.Button btDublicateConfig;
        private System.Windows.Forms.Button btCreateConfig;
        private System.Windows.Forms.Button btSaveDefault;
        private System.Windows.Forms.CheckBox checkBoxUnlock1;
        private System.Windows.Forms.CheckBox checkBoxUnlock2;
        private System.Windows.Forms.TextBox textBoxConfigName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btUpdateList;
    }
}

