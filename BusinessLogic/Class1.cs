namespace BusinessLogic
{
    public interface IFoo
    {
        string GetName(string etEllerAndet);
    }

    public interface IBar
    {
        string GetName();
    }

    public class Foo : IFoo
    {
        string IFoo.GetName(string etEllerAndet)
        {
            return $"Foo - {etEllerAndet}";
        }
    }

    public class Bar : IBar
    {
        private readonly IFoo _foo;
        public Bar(IFoo foo)
        {
            _foo = foo;
        }

        string IBar.GetName()
        {
            return "Bar" + _foo.GetName("Det er mig der bestemmer :-)");
        }
    }
}
