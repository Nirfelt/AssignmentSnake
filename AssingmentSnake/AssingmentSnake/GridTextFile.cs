using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentSnake
{
    public partial class Grid
    {
        public bool ReadFromTextFile(string fileName, out string errorMsg)
        {
            bool ok = false;
            StreamReader reader = null;
            errorMsg = string.Empty;
            bool lineOne = true;
            int c = 0;

            try
            {
                //1. File must exit - otherwise exception is thrown
                reader = new StreamReader(fileName, Encoding.UTF8);

                while (!reader.EndOfStream) //read to end of file
                {
                    if (lineOne)
                    {
                        string lineOneData = reader.ReadLine();
                        string[] lineOneValues = lineOneData.Split(',');
                        X = Convert.ToInt32(lineOneValues[0].Trim());
                        Y = Convert.ToInt32(lineOneValues[1].Trim());
                        NumberOfObstacles = Convert.ToInt32(lineOneValues[2].Trim());
                        obstacles = new int[NumberOfObstacles, 2];
                        lineOne = false;
                    }

                    string rowData = reader.ReadLine();
                    string[] obstacleValues = rowData.Split(',');

                    //2. get the values from a row in the file in the same ordning there were written
                    string strRowData = reader.ReadLine(); //read the whole row
                    string[] strValues = strRowData.Split('\n');
                    prod.Name = strValues[0].Trim();  //delete spaces

                    prod.Price = Convert.ToDouble(strValues[1].Trim());
                    prod.Count = Convert.ToInt32(strValues[2].Trim());

                    m_productRegistry.Add(prod);

                }
                ok = true;

            }
            catch (Exception e)
            {
                errorMsg = e.Message;
            }
			finally   //always performed even when no exception is thrown
            {
                //3.  Close the file
                reader.Close();
            }
            return ok;
        }//ReadFrom..
    }
}
