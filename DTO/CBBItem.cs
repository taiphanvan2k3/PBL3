namespace DTO
{
    public class CBBItem
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public override string ToString()
        {
            return Value;
        }
    }
}
