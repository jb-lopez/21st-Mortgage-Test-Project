using System.ComponentModel;

namespace _21stMortgageInterviewApplication
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private NumberListModel _NumberListModel;

        private string _UserInput;
        public string UserInput
        {
            get { return _UserInput;}
            set
            {
                _UserInput = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserInput"));
            }
        }

        private string _Output;
        public string Output
        {
            get { return _Output; }
            set
            {
                _Output = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Output"));
            }
        }

        private RelayCommand _FindLargeNumberCommand;
        public RelayCommand FindLargeNumberCommand
        {
            get { return _FindLargeNumberCommand; }
            set
            {
                _FindLargeNumberCommand = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FindLargeNumberCommand"));
            }
        }

        private RelayCommand _FindSumOfOddNumbersCommand;
        public RelayCommand FindSumOfOddNumbersCommand
        {
            get { return _FindSumOfOddNumbersCommand; }
            set
            {
                _FindSumOfOddNumbersCommand = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FindSumOfOddNumbersCommand"));
            }
        }

        private RelayCommand _FindSumOfEvenNumbersCommand;
        public RelayCommand FindSumOfEvenNumbersCommand
        {
            get { return _FindSumOfEvenNumbersCommand; }
            set
            {
                _FindSumOfEvenNumbersCommand = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FindSumOfEvenNumbersCommand"));
            }
        }


        public MainWindowViewModel()
        {
            _NumberListModel            = new NumberListModel();
            FindLargeNumberCommand      = new RelayCommand(CommandFindLargestNumberExecute, CommandFindLargestNumberCanExecute);
            FindSumOfOddNumbersCommand  = new RelayCommand(CommandFindSumOfOddNumbersExecute, CommandFindSumOfOddNumbersCanExecute);
            FindSumOfEvenNumbersCommand = new RelayCommand(CommandFindSumOfEvenNumbersExecute, CommandFindSumOfEvenNumbersCanExecute);
        }

        private bool CommandFindLargestNumberCanExecute(object parameter)
        {
            _NumberListModel.FromString(parameter as string);
            return _NumberListModel.GetNumberCount() > 0;
        }

        private void CommandFindLargestNumberExecute(object parameter)
        {
            _NumberListModel.FromString(parameter as string);
            Output = _NumberListModel.GetLargestNumber().ToString();
        }

        private bool CommandFindSumOfOddNumbersCanExecute(object parameter)
        {
            _NumberListModel.FromString(parameter as string);
            return _NumberListModel.GetNumberCount() > 0;
        }

        private void CommandFindSumOfOddNumbersExecute(object parameter)
        {
            _NumberListModel.FromString(parameter as string);
            Output = _NumberListModel.GetSumOfOddNumbers().ToString();
        }

        private bool CommandFindSumOfEvenNumbersCanExecute(object parameter)
        {
            _NumberListModel.FromString(parameter as string);
            return _NumberListModel.GetNumberCount() > 0;
        }

        private void CommandFindSumOfEvenNumbersExecute(object parameter)
        {
            _NumberListModel.FromString(parameter as string);
            Output = _NumberListModel.GetSumOfEvenNumbers().ToString();
        }
    }
}
