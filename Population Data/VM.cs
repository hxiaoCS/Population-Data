using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace Population_Data
{
    class VM : INotifyPropertyChanged
    {
        #region Constants
        const int BASE_YEAR = 1950;
        const int ZERO = 0;
        const int BASE_NUMBER = 1;
        #endregion 

        #region Properties
        int numberOfYear;
        public int NumberOfYear
        {
            get { return numberOfYear; }
            set { numberOfYear = value; NotifyChange(); }
        }

        int maxIncreaseYear;
        public int MaxIncreaseYear
        {
            get { return maxIncreaseYear; }
            set { maxIncreaseYear = value; NotifyChange(); }
        }

        int minIncreaseYear;
        public int MinIncreaseYear
        {
            get { return minIncreaseYear; }
            set { minIncreaseYear = value; NotifyChange(); }
        }

        int avgChange;
        public int AvgChange
        {
            get { return avgChange; }
            set { avgChange = value; NotifyChange(); }
        }

        ObservableCollection<Population> populations = new ObservableCollection<Population>();
        public ObservableCollection<Population> Populations
        {
            get { return populations; }
            set { populations = value; NotifyChange(); }
        }
        #endregion

        #region Methods
        /* public void calcValues()
         {
             //read the file
             string inputText = File.ReadAllText("USPopulation.txt");
             string[] years = inputText.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
             //calculate the maximum increase, minimum increase and the sum
             int maxIncrease = 0;
             int minIncrease = int.MaxValue;
             int sum = 0;
             int numberOfLine = 1;
             int increase = int.Parse(years[numberOfLine]) - int.Parse(years[numberOfLine-1]);
             while (numberOfLine <= numberOfYear)
             {
                 if (maxIncrease < increase)
                     MaxIncreaseYear = BASE_YEAR + (numberOfLine - 1);
                 if (minIncrease > increase)
                     MinIncreaseYear = BASE_YEAR + (numberOfLine - 1);
                 sum += int.Parse(years[numberOfLine]);
                 numberOfLine++;
             }
             AvgChange = sum / (numberOfLine + 1);
         }*/

        public void DisplayResult()
        {
            //read the file
            populations.Clear();
            string inputText = File.ReadAllText("USPopulation.txt");
            string[] years = inputText.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            // variables to be used
            int maxIncrease = ZERO;
            int minIncrease = int.MaxValue;
            int sum = ZERO;
            int numberOfLine = BASE_NUMBER;
            int increase = int.Parse(years[numberOfLine]) - int.Parse(years[numberOfLine - 1]);
            //loop for showing the result
            while (numberOfLine <= numberOfYear)
            {
                //load data to the listbox
                Population population = new Population
                {
                    Value = years[numberOfLine-BASE_NUMBER]
                };
                populations.Add(population);
                //calculate the maximum increase, minimum increase and the average change
                if (maxIncrease < increase)
                    MaxIncreaseYear = BASE_YEAR + (numberOfLine - BASE_NUMBER);
                if (minIncrease > increase)
                    MinIncreaseYear = BASE_YEAR + (numberOfLine - BASE_NUMBER);
                sum += int.Parse(years[numberOfLine]);
                //escape key
                numberOfLine++;
            }
            AvgChange = sum / (numberOfLine + 1);
        }

        public void Clear()
        {
            //clear contents to start over
            Populations.Clear();
            MinIncreaseYear = ZERO;
            MaxIncreaseYear = ZERO;
            AvgChange = ZERO;
            NumberOfYear = 0;
        }
        #endregion

        #region PropertyChange
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyChange([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
