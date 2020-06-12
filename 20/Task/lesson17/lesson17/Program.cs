using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream f = new FileStream(@"D:\files\data.txt",
                FileMode.Create);
                byte[] ba = { (byte)'1', (byte)'2', (byte)'3', (byte)'4',
                    (byte)'5',(byte)'6'};
                f.Write(ba, 0, ba.Length);

                string str = "\nSome string";
                var bytes_from_str = Encoding.ASCII.GetBytes(str);
                f.Write(bytes_from_str, 0, bytes_from_str.Length);
                f.Close();

                FileStream f2 = new FileStream(@"D:\files\data.txt",
                FileMode.Append);
                f2.Write(bytes_from_str, 0, bytes_from_str.Length);
                f2.Close();

                FileStream f3 = new FileStream(@"D:\files\data.txt",
                FileMode.OpenOrCreate);
                string str2 = "\nModified string";
                var bytes_from_mstr = Encoding.ASCII.GetBytes(str2);
                f3.Write(bytes_from_mstr, 3, bytes_from_mstr.Length-3);
                f3.Close();

                //FileStream f4 = new FileStream(@"D:\files\data.txt",
                //FileMode.Truncate);
                //f4.Write(bytes_from_mstr, 0, bytes_from_mstr.Length);
                //f4.Close();
                FileStream f5 = new FileStream(@"D:\files\data.txt",
                FileMode.Open);
                byte[] frm_file = new byte[f5.Length];
                f5.Read(frm_file, 0, frm_file.Length);
                f5.Close();
                Console.WriteLine(Encoding.ASCII.GetString(frm_file));

                FileStream f6 = File.OpenWrite(@"D:\files\data_f.txt");
                f6.Write(bytes_from_mstr, 0, bytes_from_mstr.Length);
                f6.Close();

                string c_dir = Environment.CurrentDirectory;
                Console.WriteLine(c_dir);

                string app_dir = AppDomain.CurrentDomain.BaseDirectory;
                Console.WriteLine(app_dir);

                string m_file = Path.Combine(app_dir, "my_dir_file.txt");
                Console.WriteLine(m_file);
                FileStream f7 = File.OpenWrite(m_file);
                f7.Write(bytes_from_mstr, 0, bytes_from_mstr.Length);
                f7.Close();

                string f_path = Environment.GetFolderPath(
                    Environment.SpecialFolder.Desktop);
                Console.WriteLine(f_path);

                string f_path2 = Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments);
                Console.WriteLine(f_path2);

                string my_doc_file = Path.Combine(f_path2, "doc_file.txt");
                FileStream f8 = File.OpenWrite(my_doc_file);
                f8.Write(bytes_from_mstr, 0, bytes_from_mstr.Length);
                f8.Close();

                FileInfo fi = new FileInfo(my_doc_file);
                //fi.Encrypt();
                //fi.Decrypt();
                Console.WriteLine(fi.Name);
                Console.WriteLine(fi.LastWriteTime);
                Console.WriteLine(fi.Extension);
                Console.WriteLine(fi.CreationTime);
                string my_doc_file_c = Path.Combine(f_path2, "doc_file_copy.txt");
                //fi.CopyTo(my_doc_file_c);
                //DirectoryInfo di = new DirectoryInfo(f_path2);
                DirectoryInfo di = fi.Directory;
                Console.WriteLine(di.ToString());
                Console.WriteLine(di.Name);
                Console.WriteLine(di.Parent);
                Console.WriteLine(di.Root);
                DirectoryInfo[] dirs = di.GetDirectories();
                foreach (var d_item in dirs)
                {
                    Console.WriteLine(d_item.ToString());
                }
                FileInfo[] files = di.GetFiles();
                foreach (var f_item in files)
                {
                    Console.WriteLine(f_item.ToString());
                }

                DriveInfo[] dr = DriveInfo.GetDrives();
                foreach (var dr_item in dr)
                {
                    Console.WriteLine(dr_item.ToString());
                    Console.WriteLine($"size:{dr_item.TotalSize}");
                    Console.WriteLine($"free:{dr_item.TotalFreeSpace}");
                    Console.WriteLine($"root:{dr_item.RootDirectory}");
                }

                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
