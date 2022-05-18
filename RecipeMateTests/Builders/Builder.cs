using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeMateTests.Builders
{
    public abstract class Builder<T, BLDR> where BLDR : Builder<T, BLDR>
                                          where T : new()
    {
        public abstract T Build();

        protected int Id { get; private set; }
        protected abstract BLDR This { get; }

        public BLDR WithId(int id)
        {
            Id = id;
            return This;
        }
    }
}
