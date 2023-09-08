namespace WebApplication1
{
    public class Company
    {
        public string name;
        public int value;
        public Company() {
            name = "test";
            value = 1;
        }
        public Company(string name, int value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
