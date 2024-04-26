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
        AtualizaTemp();
    }
    void Preenche.Tela()
{
    LabelTemp.Text=Results.Temp.ToString();
    LabelTemp.Text=Resposta.Results.Temp.ToString();
}
void AtualizaTemp()
{
    Results=Json.Serializer.Deserealizer<Results>(content);
    Resposta=Json.Serializer.Deserealizer<Resposta>;
    PreencheTela();
}