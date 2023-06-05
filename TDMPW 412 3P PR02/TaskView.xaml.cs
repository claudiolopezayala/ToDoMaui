using Microsoft.Maui.Graphics;

namespace TDMPW_412_3P_PR02;

public partial class TaskView : ContentView
{
	private Task displayedTask;
	public TaskView(Task task)
	{
		displayedTask = task;
		InitializeComponent();
		this.title.Text = task.title;
		this.description.Text = task.description;
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (check.IsChecked)
		{
			title.TextColor = Colors.DarkGray;
			description.TextColor = Colors.DarkGray;
		}
		else
		{
			title.TextColor = Colors.Black;
			description.TextColor = Colors.Black;
		}
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		Tasks.taskInstance.removeTask(displayedTask);
    }
}