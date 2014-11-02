﻿using System;
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
                reader = new StreamReader(fileName, Encoding.UTF8);

                while (!reader.EndOfStream)
                {
                    if (lineOne)
                    {
                        string lineOneData = reader.ReadLine();
                        string[] lineOneValues = lineOneData.Split(',');
                        X = Convert.ToInt32(lineOneValues[0].Trim());
                        Y = Convert.ToInt32(lineOneValues[1].Trim());
                        NumberOfObstacles = Convert.ToInt32(lineOneValues[2].Trim());
                        lineOne = false;
                    }
                    else
                    {
                        string rowData = reader.ReadLine();
                        string[] obstacleValues = rowData.Split(',');
                        xValueObst.Add(Convert.ToInt32(obstacleValues[0].Trim()));
                        yValueObst.Add(Convert.ToInt32(obstacleValues[1].Trim()));
                    }
                }
                ok = true;

            }
            catch (Exception e)
            {
                errorMsg = e.Message;
            }
			finally
            {
                reader.Close();
            }
            return ok;
        }
    }
}
