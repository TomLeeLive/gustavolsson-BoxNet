using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxNet.GamerServices
{
    public class GamerCollection<T> : ReadOnlyCollection<T>, IEnumerable<Gamer>, IEnumerable where T : Gamer
    {
        public GamerCollection(IList<T> list) : base(list)
        { }

        IEnumerator<Gamer> IEnumerable<Gamer>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
