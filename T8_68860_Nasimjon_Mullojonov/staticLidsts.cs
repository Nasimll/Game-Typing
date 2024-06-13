using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_68860_Nasimjon_Mullojonov
{

    enum Mode
    {
        Words,
        Sentances,
        Both,
    }
    static class staticLidsts
    {
        public static List<string> words = new List<string>();
        public static List<string> sentances = new List<string>();
        public static List<string> both = new List<string>();

        public static string wordsrd;


        public static void ReadProductFromFile()
        {
            string line = "";
            FileStream fileStream = new FileStream("textMine.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            while (!streamReader.EndOfStream)
            {
                line = streamReader.ReadLine();
                both.Add(line);


                if (line.Trim().Contains(" "))
                {
                    sentances.Add(line);

                }
                else if (!line.Trim().Contains(" "))
                {
                    words.Add(line);

                }



            }


            streamReader.Close();
            fileStream.Close();
        }

    }

}