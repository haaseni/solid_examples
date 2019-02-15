namespace DependencyInversionPrincipleExample
{
    public class Water
    {
        public Water()
        {
            TemperatureF = 75;
        }

        public decimal Ounces { get; set; }
        public decimal TemperatureF { get; set; }
    }
}
