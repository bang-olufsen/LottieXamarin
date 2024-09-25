namespace Lottie.Sample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Lottie.AutoPlay = false;
            if (Lottie.IsAnimating)
            {
                Lottie.PauseAnimation();
                CounterBtn.Text = "Play";
            }
            else
            {
                Lottie.ResumeAnimation();
                CounterBtn.Text = "Pause";
            }

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}