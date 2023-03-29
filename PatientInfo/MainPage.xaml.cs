namespace PatientInfo;

public partial class MainPage : TabbedPage
{
    public MainPage()
    {
        InitializeComponent();

        this.cbxBMI.Items.Add("Underweight");
        this.cbxBMI.Items.Add("Normal");
        this.cbxBMI.Items.Add("Overweight");

    }

    private async void btnSubmit_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtName.Text))
        {
            await DisplayAlert("Error", "Name is required", "Ok");
            return;
        }

        var response = await DisplayAlert("Confirmation", "Do you want to submit this?", "Yes", "Cancel");

        if (response)
        {
            await DisplayAlert("Information", "Info submitted", "Ok");
        }
        else
        {

        }
        SemanticScreenReader.Announce(btnSubmit.Text);
    }
}