namespace SurveyMprogrammers;

public partial class SurveyDetailsView : ContentPage
{
    private readonly string[] teams =
    {
        "Alianza Lima",
        "Am�rica",
        "Boca Juniors",
        "Caracas FC",
        "Colo-Colo",
        "Pe�arol",
        "Real Madrid",
        "Saprissa"
    };

	public SurveyDetailsView()
	{
		InitializeComponent();
	}

   

    private async void FavoriteTeam_Clicked(object sender, EventArgs e)
    {
        var favoriteTeam = await DisplayActionSheet(Literals.FavoriteTEamTitle, null, null, teams);
        if (!string.IsNullOrWhiteSpace(favoriteTeam))
        {
            FavoriteTeamLabel.Text = favoriteTeam;
        }

    }

    private async void Ok_Clicked(object sender, EventArgs e)
    {
        //Evaluamos si los datos est�n completos
        if (string.IsNullOrWhiteSpace(NameEntry.Text) || string.IsNullOrWhiteSpace(FavoriteTeamLabel.Text))
        {
            return;
        }
        //Creamos el nuevo objeto de tipo Survey
        var NewSurvey = new Surveys()
        {
            Name = NameEntry.Text,
            Birthdate = BirthdatePicker.Date,
            FavoriteTeam = FavoriteTeamLabel.Text
        };
        //Publicamos el mensaje con el objeto de encuesta como argumento
        MessagingCenter.Send((ContentPage)this,
            Messages.NewSurveyComplete, NewSurvey);
        //Removemos la p�gina de la pila de navegaci�n para regresar inmediatamente
        await Navigation.PopAsync();
    }
}