namespace TDMPW_412_3P_PR02;

public partial class addTaskPage : ContentPage
{
	public addTaskPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string title = entryTitle.Text;
        string description = entryDescription.Text;
        if(title == null || description == null)
        {
            await DisplayAlert("Error", "Title or description is empty","Ok");
            return;
        }
        Task taskToAdd = new Task(title,description);
        Tasks.taskInstance.addTask(taskToAdd);
        await Navigation.PopModalAsync();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}