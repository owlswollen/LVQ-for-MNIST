using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace LVQforMNIST
{
    class Data
    {
        // read training and test data
        public static void ReadData(List<float[]>[] trainData, List<float[]>[] testData, int mnistSize)
        {
            float[] temp;
            string[] testDataFiles;
            string[] trainDataFiles;
            int count = 0;
            Bitmap img;
            for (int k = 0; k < 10; k++)
            {
                trainData[k] = new List<float[]>();
                testData[k] = new List<float[]>();
                trainDataFiles = Directory.GetFiles(@"mnist-train\" + k, "*.png");
                foreach (string filePath in trainDataFiles)
                {
                    temp = new float[mnistSize];
                    img = new Bitmap(filePath);
                    for (int i = 0; i < 28; i++)
                    {
                        for (int j = 0; j < 28; j++)
                        {
                            temp[j + i * 28] = img.GetPixel(j, i).R / 255.0f;
                        }
                    }
                    trainData[k].Add(temp);
                }
                count += trainData[k].Count;
                testDataFiles = Directory.GetFiles(@"mnist-test\" + k, "*.png");
                foreach (string filePath in testDataFiles)
                {
                    temp = new float[mnistSize];
                    img = new Bitmap(filePath);
                    for (int i = 0; i < 28; i++)
                    {
                        for (int j = 0; j < 28; j++)
                        {
                            temp[j + i * 28] = img.GetPixel(j, i).R / 255.0f;
                        }
                    }
                    testData[k].Add(temp);
                }
            }
            Form1.trainDataCount = count;
        }
        // write results to csv file
        public static void WriteResults(float[] accuracy, string fileName, int classCount)
        {
            string results = "Rakam sinifi,0,1,2,3,4,5,6,7,8,9,Ortalama\n";
            results += "Accuracy degeri,";
            float sum = 0;
            for (int i = 0; i < classCount; i++)
            {
                sum += accuracy[i];
                results += accuracy[i] + ",";
            }
            float mean = sum / classCount;
            results += mean + "\n";
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + fileName + ".csv", results);
        }

        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath + ".bin", append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
