using System.Collections.Generic;

namespace XBMCRemoteWP.Models.Common
{
    public class ListGroup<T> : List<T>
    {
        public string Key { get; private set; }

        public ListGroup(string key)
        {
            Key = key;
        }
    }
}
