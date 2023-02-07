using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch
{

    class Branch
    {
        public List<Branch> Branches { get; set; }

        public Branch()
        {
            Branches = new List<Branch>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Branch root = new Branch();
            root.Branches.Add(new Branch()); // First layer 1
            root.Branches[0].Branches.Add(new Branch()); // Second layer 1-1
            root.Branches[0].Branches[0].Branches.Add(new Branch()); // Third layer 1-1-1

            root.Branches[0].Branches.Add(new Branch()); // Second layer 1-2
            root.Branches[0].Branches[1].Branches.Add(new Branch()); // Third layer 1-2-1
            root.Branches[0].Branches[1].Branches[0].Branches.Add(new Branch()); // Fourth layer 1-2-1-1

            root.Branches[0].Branches[1].Branches.Add(new Branch()); // Third layer 1-2-2
            root.Branches[0].Branches[1].Branches[1].Branches.Add(new Branch()); // Fourth layer 1-2-2-1
            root.Branches[0].Branches[1].Branches[1].Branches.Add(new Branch()); // Fourth Layer 1-2-2-2
            root.Branches[0].Branches[1].Branches[1].Branches[1].Branches.Add(new Branch()); // Fifth Layer 1-2-2-1-1

            root.Branches[0].Branches[1].Branches.Add(new Branch()); // Third Layer 1-2-3


            int depth = CalculateDepth(root, 0);

            Console.WriteLine("Depth: " + depth);
            Console.ReadLine();
        }

        private static int CalculateDepth(Branch branch, int currentDepth)
        {
            if (branch.Branches.Count == 0)
            {
                return currentDepth;
            }

            int maxDepth = currentDepth;
            foreach (Branch subBranch in branch.Branches)
            {
                int subBranchDepth = CalculateDepth(subBranch, currentDepth + 1);
                if (subBranchDepth > maxDepth)
                {
                    maxDepth = subBranchDepth;
                }
            }

            return maxDepth;
        }
    }
}
