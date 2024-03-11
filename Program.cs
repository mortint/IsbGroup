using ISBGroup.Forms;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

[assembly: Obfuscation(Exclude = false, Feature = "namespace('ISBGroup.Enums'):-rename")]
[assembly: Obfuscation(Exclude = false, Feature = "namespace('ISBGroup.Targets'):-rename")]
[assembly: Obfuscation(Exclude = false, Feature = "namespace('ISBGroup.Engine.API'):-rename")]
[assembly: Obfuscation(Exclude = false, Feature = "namespace('ISBGroup.Tasks'):-Mutation")]
[assembly: Obfuscation(Exclude = false, Feature = "namespace('ISBGroup.Engine'):-Mutation")]
[assembly: Obfuscation(Exclude = false, Feature = "namespace('ISBGroup.Tasks.Settings'):-rename")]
[assembly: Obfuscation(Exclude = false, Feature = "namespace('ISBGroup.Forms'):-rename")]
[assembly: Obfuscation(Exclude = false, Feature = "namespace('ISBGroup.Configs'):-rename")]

namespace ISBGroup
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += AbsenceOfDLL;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var instance = Assembly.GetExecutingAssembly().CreateInstance(
                "ISBGroup.Forms.MainForm") as MainForm;
            
            Application.Run(instance);
        }
        /// <summary>
        /// Метод для обработки события отсутствия сборки (DLL).
        /// </summary>
        /// <param name="sender">Объект, инициировавший событие.</param>
        /// <param name="args">Аргументы события с запросом на разрешение сборки.</param>
        /// <returns>Загруженная сборка или null, если сборка отсутствует.</returns>
        private static Assembly AbsenceOfDLL(object sender, ResolveEventArgs args)
        {
            var folderPath = @"Library";
            var assemblyPath = Path.Combine(folderPath, new AssemblyName(args.Name).Name + ".dll");

            if (File.Exists(assemblyPath))
            {
                return Assembly.LoadFrom(assemblyPath);
            }

            return null;
        }
    }
}
