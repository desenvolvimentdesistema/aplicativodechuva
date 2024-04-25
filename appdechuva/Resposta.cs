namespace appdechuva;
public class Resposta
{
    public Results Results {get;set;}
}
    Results Results;
    Resposta Resposta;
void MainPage()
    {
        InitializeComponent();
        AtualizaTempo();
    }
void PreencheTela()
{
    LabelTempo.Text=Results.Temp.ToString();
    LabelTempo.Text=Resposta.Results.Temp.ToString();
}
void AtualizaTempo()
{
    Results=JsonSerializer.Deserealizer<Results>(content);
    Resposta=JsonSerializer.Deserealizer<Resposta>;
    PreencheTela();
}