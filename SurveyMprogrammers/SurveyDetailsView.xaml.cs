namespace SurveyMprogrammers;

public partial class SurveyDetailsView : ContentPage
{
    private readonly string[] teams =
    {
        "Alianza Lima",
        "América",
        "Boca Juniors",
        "Caracas FC",
        "Colo-Colo",
        "Peñarol",
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

    private void Ok_Clicked(object sender, EventArgs e)
    {

    }
}