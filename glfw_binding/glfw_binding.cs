using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace glfw_binding
{
    
   public class glfw_binding: ILibrary
    {

        /// Setup the driver options here.
        public void Setup(Driver driver)
        {
            var options = driver.Options;
            options.GeneratorKind = GeneratorKind.CSharp;
            var module = options.AddModule("glfw3");
            module.IncludeDirs.Add("D:\\Projects\\glfw\\include\\GLFW");
            module.Headers.Add("glfw3.h");
            module.LibraryDirs.Add("C:\\Users\\mihan\\source\\repos\\hello_window_cppsharp\\_build_glfw\\src\\Release");
            module.Libraries.Add("glfw3dll.lib");
        }

        /// Setup your passes here.
        public void SetupPasses(Driver driver)
        {

        }

        /// Do transformations that should happen before passes are processed.
        public void Preprocess(Driver driver, ASTContext ctx)
        {

        }

        /// Do transformations that should happen after passes are processed.
        public void Postprocess(Driver driver, ASTContext ctx)
        {

        }

        public static void run()
        {
            ConsoleDriver.Run(new glfw_binding());
        }
    }
}
