namespace appdechuva;

public partial class MainPage : ContentPage
{

    public MainPage()
	{
 		InitializeComponent();
	}

    public partial class MainPage
	{
		Const String Url="https://api.hgbrasil.com/weather?woeid=455927&Key=f5f447f3"
		Results Resposta;
		void Atualiza Temp();
		
	}
	
           Try
		   {
			
		   Var HttpClient=new HttpClient();
		   Var Resposta=await.HttpClient.GetAsync(Url);
		   If (Resposta.IsSuccessStatusCode);
		   }
			String Content=Resposta.Content.ReadAsStringAsync();
				Resposta=Json Serializer.Deserialize<Results>(Content);


		    {
			catch (Exception e)
			}

			{
				//Erro
		   	}
	{
		if (Results.currently=="Sol")
		{
			if (Results.rain >=50 )
				imgBackground.Source = "chuvadedia.jpg";
			else if (Results.cloudness >=50 )
				imgBackground.Source = "nublado.jpg";
			else
				imgBackground.Source = "sol.jpg";
		}
	}
		else
		{
			if (Results.currently=="Night")
		{
			if (Results.rain >=50 )
				imgBackground.Source = "chuvadenoite.jpg";
			else if (Results.cloudness >=50 )
				imgBackground.Source = "noitenublada.jpg";
			else
				imgBackground.Source = "noite.jpg";
		}

		}
}


