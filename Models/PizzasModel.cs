namespace RazorPizzaShop.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PiazzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool TomatoSauce {  get; set; }
        public bool WhiteSauce {  get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Ham { get; set; }
        public bool Pinapple { get; set; }
        public bool ItalianSausage { get; set; }
        public bool Mushroom { get; set; }
        public bool Beef { get; set; }
        public bool Tuna { get; set; }

        public float FinalPrice { get; set; }

    }
}
