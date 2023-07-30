using Plugin.Maui.Audio;

namespace MAUIDarbooka;

public partial class DarbukaAppPage : ContentPage
{
	public DarbukaAppPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		var button = (Button)sender;
       await imgDarbuka.ScaleTo(0.9,50,Easing.Linear);
       await imgDarbuka.ScaleTo(1,50,Easing.Linear);

        PlaySound(button.CommandParameter.ToString());
    }

    private async void PlaySound(string parameter)
    {
    var player =    AudioManager.Current.CreatePlayer(await FileSystem.OpenAppPackageFileAsync($"{parameter}.mp3"));
        player.Play();
    }
}