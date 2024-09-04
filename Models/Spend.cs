namespace despesas_blazor_webAssembly.Models
{
    public class Spend
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string TypeSpend { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public int Parcel { get; set; }
    }
}
