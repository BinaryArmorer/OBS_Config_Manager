using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using static System.IO.Directory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS_Config_Manager__GUI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfigList(); // Загрузка списка конфигов
        }

        private void ChangeConfig()
        {
            if (listBoxConfigsList.SelectedItems.Count != 0)
            {
                string ChangeConfig = listBoxConfigsList.SelectedItem.ToString();

                if (Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/obs-studio"))
                {
                    Directory.Delete($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/obs-studio", true);
                }

                CopyDir($"configs/{ChangeConfig}", $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/obs-studio");
            }
            else
            {
                MessageBox.Show("Выберите нужный профиль!");
                return;
            }
            
        }

        private void LoadConfigList() // Загрузка списка конфигов
        {
            listBoxConfigsList.Items.Clear();

            string[] configs = new string[Directory.GetDirectories("configs").Count()];

            for (int i = 0; i < configs.Length; i++)
            {
                configs[i] = Directory.GetDirectories("configs")[i];
            }

            for (int i = 0; i < configs.Length; i++)
            {
                configs[i] = configs[i].Remove(0,8);
            }

            listBoxConfigsList.Items.AddRange(configs);
        }

        private void CopyDefaultConfig() // Сохранение default-config
        {
            DialogResult result = MessageBox.Show("Вы уверенны, что хотите удалить ваш начальный конфиг, заменив его на текущий?", "", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                if (Directory.Exists("configs/default-config") == true)
                {
                    Directory.Delete("configs/default-config", true);
                }

                CopyDir($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/obs-studio", "configs/default-config");
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void CopyDir(string fromDir, string toDir) // Копирование директории с файлами
        {
            if (Directory.Exists(fromDir) == true)
            {
                Directory.CreateDirectory(toDir);

                foreach (string s1 in Directory.GetFiles(fromDir))
                {
                    string s2 = toDir + "\\" + Path.GetFileName(s1);
                    File.Copy(s1, s2);
                }

                foreach (string s in Directory.GetDirectories(fromDir))
                {
                    CopyDir(s, toDir + "\\" + Path.GetFileName(s));
                }
            }
            else if (Directory.Exists(fromDir) == false) 
            {
                MessageBox.Show("Отстуствует файл для копирования!");
            }
        }

        private void checkBoxUnlock1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUnlock1.Checked)
            {
                btSaveDefault.Enabled = true;
            }
            else
            {
                btSaveDefault.Enabled = false;
            }
        }

        private void checkBoxUnlock2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUnlock2.Checked)
            {
                btDelConfig.Enabled = true;
            }
            else
            {
                btDelConfig.Enabled = false;
            }
        }

        private void CreateConfig(string configName)
        {
            CopyDir("configs/default-config", $"configs/{configName}");
        }

        private void btApplyConfig_Click(object sender, EventArgs e)
        {
            ChangeConfig();
            LoadConfigList();
        }

        private void btCreateConfig_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxConfigName.Text) == false && textBoxConfigName.Text != "default-config")
            {
                CreateConfig(textBoxConfigName.Text);
            }
            else if (textBoxConfigName.Text == "default-config")
            {
                MessageBox.Show("Нельзя назвать конфиг также как и базовый!");
            }
            else if (string.IsNullOrEmpty(textBoxConfigName.Text) == true)
            {
                MessageBox.Show("Дайте название конфигу!");
            }

            LoadConfigList();
        }

        private void btSaveDefault_Click(object sender, EventArgs e)
        {
            CopyDefaultConfig(); // Копирование директории с файлами
            LoadConfigList();
        }

        private void btUpdateList_Click(object sender, EventArgs e)
        {
            LoadConfigList();
        }

        private void btDelConfig_Click(object sender, EventArgs e)
        {
            if (listBoxConfigsList.SelectedItems.Count != 0 && listBoxConfigsList.SelectedItem.ToString() != "default-config")
            {
                string SelectedItem = listBoxConfigsList.SelectedItem.ToString();

                if (Exists($"configs/{SelectedItem}"))
                {
                    Directory.Delete($"configs/{SelectedItem}", true);
                    MessageBox.Show("Успешно!");
                }

                LoadConfigList();
            }
            else if (listBoxConfigsList.SelectedItems.Count != 0 && listBoxConfigsList.SelectedItem.ToString() == "default-config")
            {
                MessageBox.Show("Базовый профиль можно только заменить!");
                return;
            }
            else
            {
                MessageBox.Show("Выберите нужный профиль!");
                return;
            }
        }

        private void btDublicateConfig_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxConfigName.Text) == false && textBoxConfigName.Text != "default-config")
            {
                if (listBoxConfigsList.SelectedItems.Count != 0)
                {
                    CopyDir($"configs/{listBoxConfigsList.SelectedItem.ToString()}", $"configs/{textBoxConfigName.Text}");
                }
                else
                {
                    MessageBox.Show("Выберите нужный профиль!");
                }
            }
            else if (textBoxConfigName.Text == "default-config")
            {
                MessageBox.Show("Нельзя назвать конфиг также как и базовый!");
            }
            else if (string.IsNullOrEmpty(textBoxConfigName.Text) == true)
            {
                MessageBox.Show("Дайте название конфигу!");
            }

            LoadConfigList();
        }
    }
}
