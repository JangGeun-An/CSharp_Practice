using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_IO
{
    internal class Direc
    {
        public void Run()
        {
            TestDirectory();
        }

        private void TestDirectory()
        {
            //Console.WriteLine("Directory 입력: ");
            //string root = Console.ReadLine();

            //CreateDirectory(root);
            //ReadDirectory(root);
            //DeleteDirectory(root);
            //RenameDirectory(root);

            string fileSystem = "c:";
            string directory1 = "Windows";
            string root = Path.Combine(fileSystem, directory1);
            ReadDirectory(root);
        }

        private void CreateDirectory(string root)
        {
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
                return;
            }
        }

        private void ReadDirectory(string root)
        {
            if (Directory.Exists(root))
            {
                Console.WriteLine($"{root} 디렉터리가 존재합니다.");
                DirectoryInfo di = new DirectoryInfo(root);
                FileInfo[] files = di.GetFiles();
                foreach (FileInfo file in files)
                    Console.WriteLine($"{file.FullName} {file.Extension}을 찾았습니다.");
                string[] subdirs = Directory.GetDirectories(root);
                foreach (string dir in subdirs)
                    Console.WriteLine($"디렉토리 {dir}을 찾았습니다.");
            }

            else
            {
                Console.WriteLine($"{root} 디렉터리가 없습니다.");
            }
        }

        private void DeleteDirectory(string root)
        {
            try
            {
                if (Directory.Exists(root)) Directory.Delete(root);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"오류발생:{ex.Message}");
            }
        }

        private void RenameDirectory(string? root)
        {
            try
            {
                Directory.Move(root, "d:\\zeek2");
                Console.WriteLine("이름 변경 완료");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
