namespace SuperSandwich15000.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public int SandwichId { get; set; }
        public bool PainGris { get; set; }
        public string? Commentaire { get; set; }
        public string PourQui { get; set; }
        public DateTime Date { get; set; }
        public Sandwich sandwich;
    }
}
