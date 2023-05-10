namespace Tests
{
    internal class Program
    {
        interface IDeveloper
        {
            string Tool { get; set; }

            public void Create() { }
            public void Destroy() { }
        }

        class Programmer : IDeveloper, IComparable<Programmer>
        {
            private string language;

            public string Tool { get => language; set => language = value; }

            public Programmer(string language)
            {
                this.language = language;
            }
            public int CompareTo(Programmer? other)
            {
                return string.Compare(Tool, other?.Tool);
            }
        }

        class Builder : IDeveloper, IComparable<Builder>
        {
            string tool;

            public string Tool { get; set; }

            public int CompareTo(Builder? other)
            {
                return string.Compare(Tool, other?.Tool);
            }
        }

        static void Main(string[] args)
        {
            List<Programmer> developers = new List<Programmer>();
            developers.Add(new Programmer("C#"));
            developers.Add(new Programmer("C++"));

            //foreach (var dev in developers)
            //{
            //    dev.Create();
            //    dev.Destroy();
            //}

            developers.Sort();
        }
    }
}