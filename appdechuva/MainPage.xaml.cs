namespace appdechuva;

public partial class MainPage : ContentPage
{
	int count = 0;

    public MainPage()
	{
 		InitializeComponent();
	}

    public partial class MainPage
	{
		Const String Url="https://api.hgbrasil.com/weather?woeid=455927&Key=f5f447f3"
		Resulsts Resposta;
		void Atualiza Tempo()
		
	}
           try
		   {
			
		   var httpClient=new HttpClient();
		   var Response=await HttpClient.GetAsync(Url);
		   If (Response.Is SuccessStatusCode);
		   }
			String Content=Response.Content.ReadAsStringAsync();
				Resposta=Json Serializer.Deserialize<Results>(Content);
}

		    {
			catch (Exception e)
			}

			{
				// Erro	
		   	}
	{
		if (results.currently=="Sol")
		{
			if (results.rain >=50 )
				imgBackground.Source = "chuvadedia.jpg";
			else if (results.cloudness >=50 )
				imgBackground.Source = "nublado.jpg";
			else
				imgBackground.Source = "sol.jpg";
		}
	}
		else
		{
			if (results.currently=="Night")
		{
			if (results.rain >=50 )
				imgBackground.Source = "chuvadenoite.jpg";
			else if (results.cloudness >=50 )
				imgBackground.Source = "noitenublada.jpg";
			else
				imgBackground.Source = "noite.jpg";
		}

		}
}

