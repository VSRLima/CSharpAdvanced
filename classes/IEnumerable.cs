using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CsharpAdvanced
{
    public class ClientsList: IEnumerable
    {
        private List<string> Clients = new List<string>();
        private int Index = 0;

        public void Add(string str)
        {
            this.Clients.Add(str);
            this.Index++;
        }

        // public IEnumerable<string> getClients()
        // {
        //     return this.Clients();
        // }

        public IEnumerator GetEnumerator()
        {
            foreach (var client in Clients)
            {
                yield return client; // main the state of the index
            }
        }
    }
}