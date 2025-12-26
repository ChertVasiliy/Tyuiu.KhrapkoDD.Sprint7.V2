using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.KhrapkoDD.Sprint7.Desktop;

ApplicationConfiguration.Initialize();

// создаём папку Data, если нет
var dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
Directory.CreateDirectory(dataFolder);

Application.Run(new MainForm_KhrapkoDD(dataFolder));