namespace PinPadApp;

public partial class MainPage : ContentPage
{
    private readonly List<int> _correctPinNumbers;
    private readonly List<int> _enteredPinNumbers;

    public MainPage()
    {
        InitializeComponent();
        _correctPinNumbers = new List<int>() { 0, 0, 7, 8, 9 };
        _enteredPinNumbers = new List<int>();
        LabelTitle.Text = "Enter your PIN";
    }

    private void ButtonZero_Clicked(object sender, EventArgs e)
    {
        AddNumber(0);
    }

    private void ButtonOne_Clicked(object sender, EventArgs e)
    {
        AddNumber(1);
    }

    private void ButtonTwo_Clicked(object sender, EventArgs e)
    {
        AddNumber(2);
    }

    private void ButtonThree_Clicked(object sender, EventArgs e)
    {
        AddNumber(3);
    }

    private void ButtonFour_Clicked(object sender, EventArgs e)
    {
        AddNumber(4);
    }

    private void ButtonFive_Clicked(object sender, EventArgs e)
    {
        AddNumber(5);
    }

    private void ButtonSix_Clicked(object sender, EventArgs e)
    {
        AddNumber(6);
    }

    private void ButtonSeven_Clicked(object sender, EventArgs e)
    {
        AddNumber(7);
    }

    private void ButtonEight_Clicked(object sender, EventArgs e)
    {
        AddNumber(8);
    }

    private void ButtonNine_Clicked(object sender, EventArgs e)
    {
        AddNumber(9);
    }

    private void ButtonBackspace_Clicked(object sender, EventArgs e)
    {
        if (_enteredPinNumbers.Count > 0)
        {
            _enteredPinNumbers.RemoveAt(_enteredPinNumbers.Count - 1);
        }

        if (StackLayoutPinView.Count > 0)
        {
            StackLayoutPinView.RemoveAt(StackLayoutPinView.Count - 1);
        }

        LabelTitle.Text = string.Empty;
    }

    private async void ButtonSubmit_Clicked(object sender, EventArgs e)
    {
        if (_correctPinNumbers.Count < _enteredPinNumbers.Count)
        {
            LabelTitle.Text = "Wrong PIN";
        }
        else if (_correctPinNumbers.Count > _enteredPinNumbers.Count)
        {
            LabelTitle.Text = "Wrong PIN";
        }
        else
        {
            var correctPin = string.Join(string.Empty, _correctPinNumbers);
            var enteredPin = string.Join(string.Empty, _enteredPinNumbers);

            if (correctPin == enteredPin)
            {
                LabelTitle.Text = "Enter your PIN";
                await Shell.Current.GoToAsync(nameof(CorrectPinPage));
            }
            else
            {
                LabelTitle.Text = "Wrong PIN";
            }
        }

        _enteredPinNumbers.Clear();
        StackLayoutPinView.Clear();
    }

    private void AddNumber(int number)
    {
        _enteredPinNumbers.Add(number);

        LabelTitle.Text = string.Empty;

        var boxView = new BoxView();
        boxView.CornerRadius = 5;
        boxView.Color = Color.FromRgb(255, 255, 255);
        boxView.HeightRequest = 10;
        boxView.WidthRequest = 10;

        StackLayoutPinView.Add(boxView);
    }
}

