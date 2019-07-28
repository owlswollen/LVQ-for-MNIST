using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LVQforMNIST
{
    [Serializable]
    class LVQ
    {
        protected float[,][] codebookVector;
        protected float distance;
        protected static int mnistSize = 28 * 28;
        protected static int classCount = 10;
        protected int iterationCount;
        protected int codebookVectorCount;
        protected float learningRate;
        protected float decay;
        protected string name;
        public float averageAccuracy;
        public float[] accuracy;

        public static int iteration = 0;

        [NonSerialized]
        protected List<float[]>[] trainData = new List<float[]>[10];
        [NonSerialized]
        protected List<float[]>[] testData = new List<float[]>[10];
        private int totalCount;

        public LVQ(List<float[]>[] _trainData, List<float[]>[] _testData, float _learningRate, int _codebookVectorCount, int _iterationCount, string _name, float _decay)
        {
            averageAccuracy = 0;
            this.trainData = _trainData;
            this.testData = _testData;
            this.learningRate = _learningRate;
            this.decay = _decay;
            this.codebookVectorCount = _codebookVectorCount;
            this.iterationCount = _iterationCount;
            this.name = _name;
            codebookVector = new float[classCount, _codebookVectorCount][];
            accuracy = new float[classCount];
        }
        public void Epoch()
        {
            int i, j, k;

            // initialization of codebook vectors
            for (i = 0; i < classCount; i++)
            {
                for (j = 0; j < codebookVectorCount; j++)
                {
                    codebookVector[i, j] = new float[mnistSize];
                    trainData[i][j].CopyTo(codebookVector[i, j], 0);
                }
            }
            // training
            for (i = 0; i < iterationCount; i++)
            {
                for (j = 0; j < classCount; j++)
                {
                    for (k = trainData[j].Count - 1; k >= 0; k--)
                    {
                        Train(trainData[j][k], j);
                    }
                }
                Form1.Loading(++iteration);
                learningRate *= decay;
            }
            // test
            totalCount = 0;
            float[] testTrueCount = new float[10];
            for (i = 0; i < classCount; i++)
            {
                testTrueCount[i] = 0;
                for (j = testData[i].Count - 1; j >= 0; j--)
                {
                    if (Check(testData[i][j]) == i)
                    {
                        testTrueCount[i]++;
                    }
                }
                accuracy[i] = testTrueCount[i] / testData[i].Count;
                averageAccuracy += testTrueCount[i];
                totalCount += testData[i].Count;
            }
            averageAccuracy /= totalCount;
            try
            {
                Data.WriteResults(accuracy, name, classCount);
            }
            catch
            {
                MessageBox.Show("Path not found.");
            }
        }
        protected float Distance(float[] a, float[] b)
        {
            float sum = 0, c;
            for (int i = 0; i < mnistSize; i++)
            {
                c = a[i] - b[i];
                sum += c * c;
            }
            return Convert.ToSingle(Math.Sqrt(sum));
        }
        protected virtual void Train(float[] data, int trueClassIndex) { }
        // Return a record's true class
        public int Check(float[] data)
        {
            float minDistance = float.MaxValue;
            int classIndex = -1;
            for (int i = 0; i < classCount; i++)
            {
                for (int j = 0; j < codebookVectorCount; j++)
                {
                    distance = Distance(data, codebookVector[i, j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        classIndex = i;
                    }
                }
            }
            return classIndex;
        }
    }
    // LVQ1
    [Serializable]
    class LVQ1 : LVQ
    {
        public LVQ1(List<float[]>[] trainData, List<float[]>[] testData, float learningRate, int codebookVectorCount, int iterationCount, string name, float decay)
        : base(trainData, testData, learningRate, codebookVectorCount, iterationCount, name, decay) { }

        protected override void Train(float[] data, int trueClassIndex)
        {
            float minDistance = float.MaxValue;
            int classIndex = -1, codebookIndex = -1;
            for (int i = 0; i < classCount; i++)
            {
                for (int j = 0; j < codebookVectorCount; j++)
                {
                    distance = Distance(codebookVector[i, j], data);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        classIndex = i;
                        codebookIndex = j;
                    }
                }
            }
            if (classIndex == trueClassIndex)
            {
                for (int i = 0; i < mnistSize; i++)
                    codebookVector[classIndex, codebookIndex][i] += learningRate * (data[i] - codebookVector[classIndex, codebookIndex][i]);
            }
            else
            {
                for (int i = 0; i < mnistSize; i++)
                    codebookVector[classIndex, codebookIndex][i] -= learningRate * (data[i] - codebookVector[classIndex, codebookIndex][i]);
            }
        }
    }
    // LVQ2.1
    // 2 codebook vectors are updated for each record - one from the same class, one from a different class
    [Serializable]
    class LVQ2 : LVQ
    {
        protected float s;
        public LVQ2(List<float[]>[] trainData, List<float[]>[] testData, float learningRate, int codebookVectorCount, int iterationCount, string name, float window, float decay)
        : base(trainData, testData, learningRate, codebookVectorCount, iterationCount, name, decay)
        {
            s = (1 - window) / (1 + window);
        }
        protected override void Train(float[] data, int trueClassIndex)
        {
            float minSameDist = float.MaxValue;
            int sameCodebookIndex = -1;
            float minDiffDist = float.MaxValue;
            int diffClassIndex = -1, diffCodebookIndex = -1;
            for (int i = 0; i < classCount; i++)
            {
                for (int j = 0; j < codebookVectorCount; j++)
                {
                    distance = Distance(codebookVector[i, j], data);
                    if (i == trueClassIndex)
                    {
                        if (minSameDist > distance)
                        {
                            minSameDist = distance;
                            sameCodebookIndex = j;
                        }
                    }
                    else
                    {
                        if (minDiffDist > distance)
                        {
                            minDiffDist = distance;
                            diffClassIndex = i;
                            diffCodebookIndex = j;
                        }
                    }
                }
            }
            float rate = minDiffDist < minSameDist ? minDiffDist / minSameDist : minSameDist / minDiffDist;
            if (rate > s)
            {
                for (int i = 0; i < mnistSize; i++)
                    codebookVector[trueClassIndex, sameCodebookIndex][i] += learningRate * (data[i] - codebookVector[trueClassIndex, sameCodebookIndex][i]);
                for (int i = 0; i < mnistSize; i++)
                    codebookVector[diffClassIndex, diffCodebookIndex][i] -= learningRate * (data[i] - codebookVector[diffClassIndex, diffCodebookIndex][i]);
            }
        }
    }
    // LVQ3
    // 2 codebook vectors are updated for each record - one from the same class, one from a different class
    [Serializable]
    class LVQ3 : LVQ
    {
        protected float s; // treshold
        protected float breaker;

        public LVQ3(List<float[]>[] trainData, List<float[]>[] testData, float learningRate, int codebookVectorCount, int iterationCount, string name, float window, float breaker, float decay)
        : base(trainData, testData, learningRate, codebookVectorCount, iterationCount, name, decay)
        {
            s = (1 - window) / (1 + window);
            this.breaker = breaker;
        }
        protected override void Train(float[] data, int trueClassIndex)
        {
            float minDist1 = float.MaxValue;
            int classIndex1 = -1, codebookIndex1 = -1;
            float minDist2 = float.MaxValue;
            int classIndex2 = -1, codebookIndex2 = -1;
            for (int i = 0; i < classCount; i++)
            {
                for (int j = 0; j < codebookVectorCount; j++)
                {
                    distance = Distance(codebookVector[i, j], data);
                    if (minDist1 > distance)
                    {
                        minDist2 = minDist1;
                        classIndex2 = classIndex1;
                        codebookIndex2 = codebookIndex1;
                        minDist1 = distance;
                        classIndex1 = i;
                        codebookIndex1 = j;
                    }
                    else if (minDist2 > distance)
                    {
                        minDist2 = distance;
                        classIndex2 = i;
                        codebookIndex2 = j;
                    }
                }
            }
            if (minDist1 / minDist2 > s)
            {
                if (classIndex1 == trueClassIndex && classIndex2 == trueClassIndex)
                {
                    for (int i = 0; i < mnistSize; i++)
                    {
                        codebookVector[classIndex1, codebookIndex1][i] += breaker * learningRate * (data[i] - codebookVector[classIndex1, codebookIndex1][i]);
                        codebookVector[classIndex2, codebookIndex2][i] += breaker * learningRate * (data[i] - codebookVector[classIndex2, codebookIndex2][i]);
                    }
                }
                else
                {
                    if (classIndex1 == trueClassIndex)
                    {
                        for (int i = 0; i < mnistSize; i++)
                        {
                            codebookVector[classIndex1, codebookIndex1][i] += learningRate * (data[i] - codebookVector[classIndex1, codebookIndex1][i]);
                            codebookVector[classIndex2, codebookIndex2][i] -= learningRate * (data[i] - codebookVector[classIndex2, codebookIndex2][i]);
                        }
                    }
                    else if (classIndex2 == trueClassIndex)
                    {
                        for (int i = 0; i < mnistSize; i++)
                        {
                            codebookVector[classIndex1, codebookIndex1][i] -= learningRate * (data[i] - codebookVector[classIndex1, codebookIndex1][i]);
                            codebookVector[classIndex2, codebookIndex2][i] += learningRate * (data[i] - codebookVector[classIndex2, codebookIndex2][i]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < mnistSize; i++)
                        {
                            codebookVector[classIndex1, codebookIndex1][i] -= learningRate * (data[i] - codebookVector[classIndex1, codebookIndex1][i]);
                            codebookVector[classIndex2, codebookIndex2][i] -= learningRate * (data[i] - codebookVector[classIndex2, codebookIndex2][i]);
                        }
                    }
                }
            }
        }
    }
    // LVQ2.1
    // as many codebook vectors as number of classes are updated for each record
    [Serializable]
    class LVQ2x : LVQ
    {
        protected float s;
        public LVQ2x(List<float[]>[] trainData, List<float[]>[] testData, float learningRate, int codebookVectorCount, int iterationCount, string name, float window, float decay)
        : base(trainData, testData, learningRate, codebookVectorCount, iterationCount, name, decay)
        {
            s = (1 - window) / (1 + window);
        }
        float[] minDistance = new float[classCount];
        int[] codebookIndex = new int[classCount];
        protected override void Train(float[] data, int trueClassIndex)
        {
            float minDist = float.MaxValue;
            float maxDist = 0;
            for (int i = 0; i < classCount; i++)
            {
                minDistance[i] = float.MaxValue;
                codebookIndex[i] = -1;
                for (int j = 0; j < codebookVectorCount; j++)
                {
                    distance = Distance(codebookVector[i, j], data);
                    if (distance < minDistance[i])
                    {
                        minDistance[i] = distance;
                        codebookIndex[i] = j;
                    }
                }
                if (minDistance[i] < minDist)
                {
                    minDist = minDistance[i];
                }
                if (minDistance[i] > maxDist)
                {
                    maxDist = minDistance[i];
                }
            }
            if (minDist / maxDist > s)
            {
                for (int i = 0; i < classCount; i++)
                {
                    if (trueClassIndex == i)
                    {
                        for (int j = 0; j < mnistSize; j++)
                        {
                            codebookVector[i, codebookIndex[i]][j] += learningRate * (data[j] - codebookVector[i, codebookIndex[i]][j]);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < mnistSize; j++)
                        {
                            codebookVector[i, codebookIndex[i]][j] -= learningRate * (data[j] - codebookVector[i, codebookIndex[i]][j]);
                        }
                    }
                }
            }
        }
    }
    // LVQ3
    // as many codebook vectors as number of classes are updated for each record
    [Serializable]
    class LVQ3x : LVQ
    {
        protected float s;
        protected float breaker;
        public LVQ3x(List<float[]>[] trainData, List<float[]>[] testData, float learningRate, int codebookVectorCount, int iterationCount, string name, float window, float breaker, float decay)
        : base(trainData, testData, learningRate, codebookVectorCount, iterationCount, name, decay)
        {
            s = (1 - window) / (1 + window);
            this.breaker = breaker;
            distances = new CodebookDistance[classCount * codebookVectorCount];
        }
        struct CodebookDistance
        {
            public int classIndex;
            public int codebookIndex;
            public bool trueClass;
            public float distance;
            public CodebookDistance(int klass, int codebook, float dis, bool t)
            {
                classIndex = klass;
                codebookIndex = codebook;
                distance = dis;
                trueClass = t;
            }
        }
        CodebookDistance[] minDistance = new CodebookDistance[classCount];
        CodebookDistance[] distances;
        protected override void Train(float[] data, int trueClassIndex)
        {
            for (int i = 0; i < classCount; i++)
            {
                for (int j = 0; j < codebookVectorCount; j++)
                {
                    distances[i * codebookVectorCount + j] = new CodebookDistance(i, j, Distance(codebookVector[i, j], data), trueClassIndex == i);
                }
            }
            Array.Sort(distances, (d1, d2) => d1.distance.CompareTo(d2.distance));


            float min = float.MaxValue;
            float max = float.MinValue;
            for (int i = 0; i < classCount; i++)
            {
                minDistance[i] = distances[i];
                if (max < distances[i].distance)
                    max = distances[i].distance;
                if (min > distances[i].distance)
                    min = distances[i].distance;
            }
            if (min / max > s)
            {
                bool sameClass = true;
                for (int i = 0; i < classCount; i++)
                    if (!minDistance[i].trueClass)
                    {
                        sameClass = false;
                        break;
                    }

                for (int i = 0; i < classCount; i++)
                {
                    if (!sameClass)
                    {
                        if (minDistance[i].trueClass)
                        {
                            for (int j = 0; j < mnistSize; j++)
                                codebookVector[minDistance[i].classIndex, minDistance[i].codebookIndex][j] += learningRate * (data[j] - codebookVector[minDistance[i].classIndex, minDistance[i].codebookIndex][j]);
                        }
                        else
                        {
                            for (int j = 0; j < mnistSize; j++)
                                codebookVector[minDistance[i].classIndex, minDistance[i].codebookIndex][j] -= learningRate * (data[j] - codebookVector[minDistance[i].classIndex, minDistance[i].codebookIndex][j]);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < mnistSize; j++)
                            codebookVector[minDistance[i].classIndex, minDistance[i].codebookIndex][j] += breaker * learningRate * (data[j] - codebookVector[minDistance[i].classIndex, minDistance[i].codebookIndex][j]);
                    }
                }
            }
        }
    }
}

