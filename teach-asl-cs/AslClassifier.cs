using System;
using System.Collections.Generic;
using System.Text;

using Accord.MachineLearning;
using System.IO;
using System.Linq;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;
using Accord.MachineLearning.VectorMachines;
using System.Diagnostics;
using Accord.IO;

namespace TeachAslCsharp
{
    class AslClassifier
    {
        double[][] inputs;
        int[] labels;

        MulticlassSupportVectorMachine<Gaussian> svm;

        public AslClassifier()
        {
            symbolCallback = callback;
        }

        public AslClassifier()
        { }

        public bool LoadTrainingData(string path)
        {
            Debug.WriteLine("Loading training data");
            string[] lines = File.ReadAllLines(path);
            inputs = new double[lines.Length / 5][];
            labels = new int[lines.Length / 5];

            List<double[]> inputList = new List<double[]>();
            List<int> labelList = new List<int>();

            for(int i = 0; i < lines.Length; i += 5)
            {
                try
                {
                    string[] line = lines[i].Split(' ');
                    labelList.Add(int.Parse(line[0]));
                    inputList.Add(Array.ConvertAll(line.Skip(1).ToArray(), Double.Parse));
                } catch (Exception)
                {
                    return false;
                }
            }

            inputs = inputList.ToArray();
            labels = labelList.ToArray();

            Debug.WriteLine("Done loading training data");
            return true;
        }

        public void LoadClassifier(string path)
        {
            svm = Serializer.Load<MulticlassSupportVectorMachine<Gaussian>>(path);
        }

        public void Train()
        {
            Debug.WriteLine("Training classifier");

            var trainer = new MulticlassSupportVectorLearning<Gaussian>()
            {
                Learner = p => new SequentialMinimalOptimization<Gaussian>()
                {
                    CacheSize = 2000,
                    UseKernelEstimation = true,
                    UseComplexityHeuristic = true
                }
            };

            //double[][] inputSubset = new double[10000][];
            //int[] labelSubset = new int[10000];
            //Array.Copy(inputs, 0, inputSubset, 0, 10000);
            //Array.Copy(labels, 0, labelSubset, 0, 10000);
            svm = trainer.Learn(inputs, labels);

            Serializer.Save(svm, "classifier.data");

            Debug.WriteLine("Done training classifier");
        }

        public int Predict(double[] input)
        {
            return svm.Decide(input);
        }

        public int[] Predict(double[][] inputs)
        {
            return svm.Decide(inputs);
        }
    }
}
