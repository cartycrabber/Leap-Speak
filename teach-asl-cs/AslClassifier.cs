using System;
using System.Collections.Generic;
using System.Text;

using Accord.MachineLearning;
using System.IO;

namespace TeachAslCsharp
{

    class AslClassifier
    {
        Form1.SymbolReceiver symbolCallback;

        public AslClassifier(Form1.SymbolReceiver callback)
        {
            symbolCallback = callback;
        }

        void LoadTrainingData(string path)
        {
            string[] lines = File.ReadAllLines(path);
        }

        void Train()
        {

        }

        int Predict()
        {
            return -1;
        }
    }
}
