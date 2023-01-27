namespace Color_Maker;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private bool IsRandom;

    private void Color_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (!IsRandom)
        {
            var red = slrRed.Value;
            var green = slrGreen.Value;
            var blue = slrBlue.Value;

            Color color = Color.FromRgb(red, green, blue);
            SetColor(color);
        }
    }

    private void SetColor(Color color)
    {
        btnRandom.BackgroundColor = color;
        Container.BackgroundColor = color;
        lblHex.Text = color.ToHex();
    }

    private void btnRandom_Clicked(object sender, EventArgs e)
    {
        IsRandom = true;
        Random random = new Random();
        var color = Color.FromRgb(random.Next(0, 265), random.Next(0, 265), random.Next(0, 265));

        SetColor(color);

        slrRed.Value = color.Red;
        slrGreen.Value = color.Green;
        slrBlue.Value = color.Blue;
        IsRandom = false;
    }
}

