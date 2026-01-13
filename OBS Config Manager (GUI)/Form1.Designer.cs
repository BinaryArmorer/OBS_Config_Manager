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
			this.checkBoxAutoRunObs = new System.Windows.Forms.CheckBox();
			this.checkBoxCloseManager = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// listBoxConfigsList
			// 
			this.listBoxConfigsList.FormattingEnabled = true;
			this.listBoxConfigsList.Location = new System.Drawing.Point(12, 12);
			this.listBoxConfigsList.Name = "listBoxConfigsList";
			this.listBoxConfigsList.Size = new System.Drawing.Size(421, 329);
			this.listBoxConfigsList.TabIndex = 1;
			// 
			// btApplyConfig
			// 
			this.btApplyConfig.Location = new System.Drawing.Point(439, 306);
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
			this.btDelConfig.Location = new System.Drawing.Point(439, 42);
			this.btDelConfig.Name = "btDelConfig";
			this.btDelConfig.Size = new System.Drawing.Size(127, 24);
			this.btDelConfig.TabIndex = 4;
			this.btDelConfig.Text = "Удалить";
			this.btDelConfig.UseVisualStyleBackColor = true;
			this.btDelConfig.Click += new System.EventHandler(this.btDelConfig_Click);
			// 
			// btDublicateConfig
			// 
			this.btDublicateConfig.Location = new System.Drawing.Point(439, 246);
			this.btDublicateConfig.Name = "btDublicateConfig";
			this.btDublicateConfig.Size = new System.Drawing.Size(127, 24);
			this.btDublicateConfig.TabIndex = 5;
			this.btDublicateConfig.Text = "Клонировать";
			this.btDublicateConfig.UseVisualStyleBackColor = true;
			this.btDublicateConfig.Click += new System.EventHandler(this.btDublicateConfig_Click);
			// 
			// btCreateConfig
			// 
			this.btCreateConfig.Location = new System.Drawing.Point(439, 276);
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
			this.btSaveDefault.Location = new System.Drawing.Point(439, 12);
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
			this.checkBoxUnlock1.Location = new System.Drawing.Point(439, 102);
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
			this.checkBoxUnlock2.Location = new System.Drawing.Point(439, 125);
			this.checkBoxUnlock2.Name = "checkBoxUnlock2";
			this.checkBoxUnlock2.Size = new System.Drawing.Size(118, 17);
			this.checkBoxUnlock2.TabIndex = 9;
			this.checkBoxUnlock2.Text = "Включить удалить";
			this.checkBoxUnlock2.UseVisualStyleBackColor = true;
			this.checkBoxUnlock2.CheckedChanged += new System.EventHandler(this.checkBoxUnlock2_CheckedChanged);
			// 
			// textBoxConfigName
			// 
			this.textBoxConfigName.Location = new System.Drawing.Point(439, 220);
			this.textBoxConfigName.Name = "textBoxConfigName";
			this.textBoxConfigName.Size = new System.Drawing.Size(127, 20);
			this.textBoxConfigName.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(439, 204);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Название";
			// 
			// btUpdateList
			// 
			this.btUpdateList.Location = new System.Drawing.Point(439, 72);
			this.btUpdateList.Name = "btUpdateList";
			this.btUpdateList.Size = new System.Drawing.Size(127, 24);
			this.btUpdateList.TabIndex = 12;
			this.btUpdateList.Text = "Обновить";
			this.btUpdateList.UseVisualStyleBackColor = true;
			this.btUpdateList.Click += new System.EventHandler(this.btUpdateList_Click);
			// 
			// checkBoxAutoRunObs
			// 
			this.checkBoxAutoRunObs.AutoSize = true;
			this.checkBoxAutoRunObs.Checked = true;
			this.checkBoxAutoRunObs.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxAutoRunObs.Location = new System.Drawing.Point(439, 148);
			this.checkBoxAutoRunObs.Name = "checkBoxAutoRunObs";
			this.checkBoxAutoRunObs.Size = new System.Drawing.Size(110, 17);
			this.checkBoxAutoRunObs.TabIndex = 13;
			this.checkBoxAutoRunObs.Text = "Автозапуск OBS";
			this.checkBoxAutoRunObs.UseVisualStyleBackColor = true;
			this.checkBoxAutoRunObs.CheckedChanged += new System.EventHandler(this.checkBoxAutoRunObs_CheckedChanged);
			// 
			// checkBoxCloseManager
			// 
			this.checkBoxCloseManager.AutoSize = true;
			this.checkBoxCloseManager.Checked = true;
			this.checkBoxCloseManager.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxCloseManager.Location = new System.Drawing.Point(439, 171);
			this.checkBoxCloseManager.Name = "checkBoxCloseManager";
			this.checkBoxCloseManager.Size = new System.Drawing.Size(137, 17);
			this.checkBoxCloseManager.TabIndex = 14;
			this.checkBoxCloseManager.Text = "Закрывать менеджер";
			this.checkBoxCloseManager.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(578, 355);
			this.Controls.Add(this.checkBoxCloseManager);
			this.Controls.Add(this.checkBoxAutoRunObs);
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
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OBS CONFIG MANAGER";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.CheckBox checkBoxAutoRunObs;
        private System.Windows.Forms.CheckBox checkBoxCloseManager;
    }
}

