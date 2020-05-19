using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
namespace XuLyTextFile
{
  public  class FileFactory
    {
        public static bool LuuFile(List<SinhVien> dssv, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dssv);

                fs.Close();
                return true;
            }
            catch (Exception er)
            {
                throw er;
            }
        }


        public static List<SinhVien> DocFile(string path)
        {
            List<SinhVien> dssv = new List<SinhVien>();
            try
            {
                FileStream fs = new FileStream(path,FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data = bf.Deserialize(fs);
                dssv = data as List<SinhVien>;

                fs.Close();
                return dssv;
                
            }
            catch (Exception er)
            {
                throw er;
            }
        }

            /*  public static bool LuuFile(List<SinhVien> dssv, string path)
              {
                  try
                  {
                      StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                      foreach(SinhVien sv in dssv)
                      {
                          string line = sv.Ma+";"+ sv.Ten+";" + sv.namsinh.ToString("dd/MM/yyyy");
                           sw.WriteLine(line);
                      }
                      sw.Close();
                      return true;
                  }
                  catch (Exception er)
                  {
                      throw er;
                  }
              }

              public static List<SinhVien> DocFile(string path)
              {
                  List<SinhVien> dssv = new List<SinhVien>();
                  try
                  {

                      StreamReader sr = new StreamReader(path, Encoding.UTF8);


                      string line = sr.ReadLine();
                      while ( line !=null)

                      {

                          string[] arr = line.Split(';'); 
                          if(arr.Length ==3)
                          {
                              SinhVien sv = new SinhVien();
                              sv.Ma = int.Parse(arr[0]);
                              sv.Ten = arr[1];
                              sv.namsinh = DateTime.ParseExact(arr[2],"dd/MM/yyyy",null);
                              dssv.Add(sv);
                          }                

                          line = sr.ReadLine();
                      }
                      sr.Close();

                  }
                  catch(Exception ex)
                  {

                      throw ex;
                  }
                  return dssv;
              }*/
        }
}
