namespace RegisterServicesWithReflectionStudy
{
    public class Thing
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"id: {this.Id} - name: {this.Name}";
        }
    }
}