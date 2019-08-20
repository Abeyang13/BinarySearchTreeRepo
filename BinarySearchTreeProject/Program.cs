using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchTree testTree = new SearchTree();

            testTree.Add(100);
            testTree.Add(90);
            testTree.Add(102);
            testTree.Add(92);
            testTree.Add(65);
            testTree.Add(113);

            testTree.Search(102);
            

        }
    }
}
