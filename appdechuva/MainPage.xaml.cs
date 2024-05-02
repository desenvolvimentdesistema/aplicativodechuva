using System.Text.Json;

namespace appdechuva;

public partial class MainPage : ContentPage
{
	const String Url="https://api.hgbrasil.com/weather?woeid=455927&Key=f5f447f3";
    Results Response;
	public MainPage()
	{
 		InitializeComponent();
		AtualizaTempo();
	}

	void AtualizaTempo()
    {
        response=JsonSerializer.Deserialize<Response>(content);
        FillScreen();
    }
    void FillScreen()
    {
        LabelTempo.Text=response.Results.Tempo;
    }
	async void AtualizaTempo()
	{
		try
		{
			var httpClient=new HttpClient();
			var httpResponse=await httpClient.GetAsync(Url);
			if(httpResponse.IsSuccessStatusCode)
			{
				string content=await
		httpResponse.Content.ReadAsStringAsync();
				Response=JsonSerializer.Deserialize<Results>(content);
			}
		}
		catch (Exception e)
		{
			//Handle error
		}
		if (Response!=null)
		{
			if (Results.currently=="Sol")
		{
			if (Results.Chuva >=50 )
				imgBackground.Source = "chuvadedia.jpg";
			else if (Results.Nublado >=50 )
				imgBackground.Source = "nublado.jpg";
			else
				imgBackground.Source = "sol.jpg";
		}
	
		else
		{
			if (Results.currently=="Night")
		
			if (Results.Chuva >=50 )
				imgBackground.Source = "chuvadenoite.jpg";
			else if (Results.Nublado >=50 )
				imgBackground.Source = "noitenublada.jpg";
			else
			imgBackground.Source = "noite.jpg";
		}		
		}
	}
}