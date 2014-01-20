using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerableVisualizer
{
    using System.Windows.Data;

    public class Vm
    {
        public Vm(IEnumerable<object> list )
        {
            CollectionView= new ListCollectionView(list.ToList());
        }
        public ListCollectionView CollectionView { get; private set; }
    }
}
