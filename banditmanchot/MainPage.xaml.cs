using banditmanchot.Modeles;

namespace banditmanchot
{
    public partial class MainPage : ContentPage
    {
        Modeles.Joueur joueur;
        SlotMachine machine;

        public MainPage()
        {
            InitializeComponent();

            joueur = new Joueur("Joueur 1", 100);
            machine = new SlotMachine();

            UpdateUI();
        }

        private void OnPlayClicked(object sender, EventArgs e)
        {
            try
            {
                joueur.Miser(10);
                var results = machine.Jouer();
                
                // Mettre à jour les affichages de rouleaux avec les résultats du tirage
                Roll1.Text = results[0];
                Roll2.Text = results[1];
                Roll3.Text = results[2];


                int gains = machine.CalculerGain(results);
                joueur.RecevoirGain(gains);

                ResultLabel.Text = gains > 0 ? $"Gagné {gains} unités!" : "Perdu!";
                UpdateUI();
            }
            catch (Exception ex)
            {
                ResultLabel.Text = ex.Message;
            }
        }

        void OnNewPlayerClicked(object sender, EventArgs e)
        {
            // Logique pour ajouter un nouveau joueur
            // Cela pourrait impliquer un nouvel écran de saisie, ou une boîte de dialogue
        }

        void UpdateUI()
        {
            PlayerName.Text = joueur.GetNom();
            PlayerBalance.Text = $"Solde: {joueur.GetSolde()}";
        }
    }
}