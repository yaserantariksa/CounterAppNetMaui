using System.Diagnostics;

namespace CounterApp;

public partial class MainPage : ContentPage
{
	int count = 0;
	int countNumber;

	public MainPage()
	{
		InitializeComponent();
		
	}

	private void OnIncrement(object sender, EventArgs e)
	{
		if(CounterNumber.Text == null || CounterNumber.Text == "")
		{
			count++;
		} else
		{
            Int32.TryParse(CounterNumber.Text, out countNumber);
            count += countNumber;
		}
        

        CounterDisplay.Text = $"{count}";
    }
	
	private void OnDecrement(object sender, EventArgs e)
	{
        if (CounterNumber.Text == null || CounterNumber.Text == "")
        {
            count--;
        }
        else
        {
            Int32.TryParse(CounterNumber.Text, out countNumber);
            count -= countNumber;
        }


        CounterDisplay.Text = $"{count}";
    }
}

