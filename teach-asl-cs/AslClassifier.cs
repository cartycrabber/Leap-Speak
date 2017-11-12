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

        Form1.SymbolReceiver symbolCallback;

        public AslClassifier(Form1.SymbolReceiver callback)
        {
            symbolCallback = callback;
        }

        public AslClassifier()
        { }

        public bool LoadTrainingData(string path)
        {
            Debug.WriteLine("Loading training data");
            string[] lines = File.ReadAllLines(path);
            inputs = new double[lines.Length][];
            labels = new int[lines.Length];

            for(int i = 0; i < lines.Length; i++)
            {
                try
                {
                    string[] line = lines[i].Split(' ');
                    labels[i] = int.Parse(line[0]);
                    inputs[i] = Array.ConvertAll(line.Skip(1).ToArray(), Double.Parse);
                } catch (Exception)
                {
                    return false;
                }
            }

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
                    CacheSize = 1000,
                    UseKernelEstimation = true,
                    UseComplexityHeuristic = true
                }
            };

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
