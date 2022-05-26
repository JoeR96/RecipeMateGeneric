namespace RecipeMateTests.Builders
{
    public abstract class Builder<T, BLDR> where BLDR : Builder<T, BLDR>
                                          where T : new()
    {
        public abstract T Build();
        protected int Id { get; private set; }
        protected abstract BLDR This { get; }
    }
}
