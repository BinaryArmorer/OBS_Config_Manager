using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.IO.Directory;

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

        private int maxLengthName = 200;
        private string pathOBSFolderConfigs = "obs-studio";
		private string pathOBS = @"C:\Program Files\obs-studio\bin\64bit";
		private string pathOBSexe = @"C:\Program Files\obs-studio\bin\64bit\obs64.exe";

		private void CloseOBS()
		{
			// Находим все процессы OBS
			Process[] obsProcesses = Process.GetProcessesByName("obs64");

			foreach (Process process in obsProcesses)
			{
				try
				{
					// Пытаемся закрыть через главное окно
					if (!process.HasExited && process.MainWindowHandle != IntPtr.Zero)
					{
						process.CloseMainWindow();

						// Ждем, пока закроется корректно
						while (!process.HasExited)
						{
							System.Threading.Thread.Sleep(100);
						}

						Console.WriteLine("OBS корректно закрыт");
					}
				}
				catch
				{
					// Игнорируем ошибки, если процесс уже закрыт
				}
				finally
				{
					process.Dispose();
				}
			}
		}

        private void OpenOBS()
        {
            if (checkBoxAutoRunObs.Checked)
            {
				var startInfo = new ProcessStartInfo
				{
					FileName = pathOBSexe,
					WorkingDirectory = pathOBS,
					UseShellExecute = true
				};

				Process.Start(startInfo);
			}
		}

		private void ChangeConfig()
        {
            if (listBoxConfigsList.SelectedItems.Count != 0)
            {
                CloseOBS();

				string ChangeConfig = listBoxConfigsList.SelectedItem.ToString();

				if (Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/{pathOBSFolderConfigs}"))
				{
					Directory.Delete($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/{pathOBSFolderConfigs}", true);
				}

				CopyDir($"configs/{ChangeConfig}", $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/{pathOBSFolderConfigs}");

                if (checkBoxCloseManager.Checked == false)
                {
					MessageBox.Show($"Конфиг {ChangeConfig} успешно применён!");
				}
                else if (checkBoxCloseManager.Checked == true)
                {
					this.Close();
				}

                OpenOBS();
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

			if (Directory.Exists("configs") == false)
			{
                Directory.CreateDirectory("configs");
                CopyDir($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/{pathOBSFolderConfigs}", "configs/default-config");
                MessageBox.Show("Ваш установленный в obs конфиг, скопирован и назван default-config");
			}

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
            DialogResult result = MessageBox.Show("Вы уверенны, что хотите удалить ваш \"default-config\", заменив его на текущий установленный в obs?", "", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
				CloseOBS();

				if (Directory.Exists("configs/default-config") == true)
                {
                    Directory.Delete("configs/default-config", true);
                }

                CopyDir($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/{pathOBSFolderConfigs}", "configs/default-config");

				MessageBox.Show("Успешно!");
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

		private void checkBoxAutoRunObs_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void CreateConfig(string configName)
        {
            CloseOBS();

            CopyDir("configs/default-config", $"configs/{configName}");

			MessageBox.Show("Успешно!");
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
