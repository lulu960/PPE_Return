using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace Variation
{

    class Program
    {

        static void Main(string[] args)
        {
            MySqlCommand sqlCommand;
            string[] cripty(int[] pawd, int[] id)
            {
                string str = "Sed condimentum dictum ex a vestibulum.Duis ullamcorper ante mollis ipsum aliquam, in elementum lectus fringilla.Sed" +
                    "blandit elementum magna, id ornare elit. Suspendisse viverra pretium scelerisque. Phasellus ultricies consequat gravida. In Convallis" +
                    "vestibulum malesuada. Praesent molestie dolor eros, ac volutpat ante aliquaM in. Etiam ac est facilisis erat viverra interdum.Suspendisse" +
                    "a tortor eleifend, dictum urna eu, tempor ex.Donec pellentesque felis sed turpis fringilla, in rutrum est fringilla.Vestibulum ornare " +
                    "risus sed leo ornare, non pulvinar odio fermentum.Phasellus pellentesque imperdiet " +
                    "tellus, ut molestie diam ultrices sit amet.Nunc augue leo, volutpat nec suscipit et, maximus in lectus.Nam mollis vehicula interdum." +
                    "Quisque in ante lacus. Nullam eget porta augue. Phasellus et tincidunt nisi." +
                    "Sed cursus magna id nisi fringil5la, et dapibus turpis consectet7ur.Curabitur porttitor elit vitae velit malesuada" +
                    "porttitor.Proin efficitur lect6us a venenat4is laor31eet. Vestibu6lum nec magna tell5us. Nunc maximus sapien et ante pulvinar," +
                    "ut tincidunt sapien tincid7unt.Fusce vitae8 orci sed q9uam iacu2lis volutp01at quis 4vitae enim.";

                char[] listknow = new char[pawd.Length];
                char[] listword = new char[id.Length];

                int i = 0;

                foreach (int x in pawd)
                {
                    listknow[i] = str[x];
                    i++;
                }

                int j = 0;

                foreach (int y in id)
                {
                    listword[j] = str[y];
                    j++;
                }

                string[] result = new string[2];
                result[0] = string.Join("", listknow);
                result[1] = string.Join("", listword);

                return result;


            }
            Random randy = new Random();
            int nbr = 0;
            int[] know = { 233, 48, 186 };
            int[] word = { 469, 69, 694, 869, 969, 1114, 1125, 1114, 1114 };
            string[] list = cripty(know, word);
            string user = list[0];
            string pwd = list[1];

            string connetionString = "server=78.123.60.28;uid=" + user + ";password=" + pwd + ";database=ppe;";
            try
            {
                MySqlConnection cnn = new MySqlConnection(connetionString);
                cnn.Open();
                sqlCommand = cnn.CreateCommand();
                while(true)
                {
                    Thread.Sleep(10000);
                        Console.WriteLine("cours a jour");
                    sqlCommand.CommandText = "UPDATE libelles SET Cours = Cours + RAND() * (-0.05 - 0.05) + 0.05 ORDER BY RAND() LIMIT 40";
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.CommandText = "UPDATE libelles SET Cours = 0.001 WHERE Cours< 0 ORDER BY RAND() LIMIT 40 ";
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message, "Erreur de connexion");
            }
           

        }
    
    }

}
