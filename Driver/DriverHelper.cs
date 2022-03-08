using System;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace Driver
{
    public class DriverHelper
    {
        public static void RunDLL(string dll, string nameSpace)
        {
            try
            {
                Assembly assembly = System.Reflection.Assembly.LoadFile(Path.GetFullPath(dll));

                if (assembly != null)
                {
                    var type = assembly.GetType($"{nameSpace}.Program");
                    object obj = Activator.CreateInstance(type);

                    if (obj != null)
                    {
                        System.Reflection.MethodInfo method = type.GetMethod("Main");
                        method.Invoke(obj, new object[] { new String[0] });
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.Write($"FileNotFound:\n{ex.Message}\n");
            }
            catch (Exception ex)
            {
                Console.Write($"Exception:\n{ex.Message}\n");
            }
        }

        public static void ExitToDriver()
        {
            var driverPath = Constants.Projects.Driver.path;
            var driverNameSpace = Constants.Projects.Driver.nameSpace;
            Driver.DriverHelper.RunDLL(driverPath, driverNameSpace);
        }
    }

}