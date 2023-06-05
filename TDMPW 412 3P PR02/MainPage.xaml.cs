namespace TDMPW_412_3P_PR02;

public partial class MainPage : ContentPage
{
	public List<Task> tasksToShow;

	public MainPage()
	{
		Tasks.taskInstance.tasksUpdated += this.tasksUpdated;
		tasksToShow = Tasks.taskInstance.getClonedList();
		InitializeComponent();
        loadTaskToStackLayout();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new addTaskPage());
    }

	private void tasksUpdated(object sender, EventArgs e)
    {
		tasksToShow = Tasks.taskInstance.getClonedList();
        loadTaskToStackLayout();
    }

	private void loadTaskToStackLayout()
    {
        stackLayoutTasks.Clear();
        foreach (Task task in tasksToShow)
        {
            stackLayoutTasks.Add(new TaskView(task));
        }
    }
}

