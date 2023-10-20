using ScheduleX.Core;

namespace ScheduleX.MVVM.ViewModel;

class MainViewModel : ObservableObject
{
    public RelayCommand CreateViewCommand { get; set; }
    public RelayCommand AddViewCommand { get; set; }
    public RelayCommand ObserveViewCommand { get; set; }

    public CreateViewModel CreateVM { get; set; } = new();
    public AddViewModel AddVM { get; set; } = new();
    public ObseveViewModel ObseveVM { get; set; } = new();

    private object _currentView;
    public object CurrentView
    {
        get => _currentView;
        set
        {
            _currentView = value;
            OnPropertyChanged();
        }
    }

    public MainViewModel()
    {
        CurrentView = CreateVM;
        SetViewSwitchCommands();
    }

    private void SetViewSwitchCommands()
    {
        CreateViewCommand = new(o =>
        {
            CurrentView = CreateVM;
        });

        AddViewCommand = new(o =>
        {
            CurrentView = AddVM;
        });

        ObserveViewCommand = new(o =>
        {
            CurrentView = ObseveVM;
        });
    }
}
