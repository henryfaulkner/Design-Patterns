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
                Console.WriteLine(Path.GetFullPath(dll));
                Console.WriteLine(assembly.FullName);
                if (assembly != null)
                {
                    var type = assembly.GetType($"{nameSpace}.Program");

                    if (type == null) Console.WriteLine(assembly);
                    else
                    {
                        object obj = Activator.CreateInstance(type);

                        if (obj != null)
                        {
                            System.Reflection.MethodInfo method = type.GetMethod("Main");
                            method.Invoke(obj, new object[0]);
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"FileNotFound:\n{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception:\n{ex.Message}");
            }
        }
    }

}