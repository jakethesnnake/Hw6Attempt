using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ksu.Cis300.Graphs;

namespace Ksu.Cis300.NetworkFlow
{
    public static class FlowFinder
    {
        public static FlowNetwork ReadInputFile(string inputFileName)
        {

        }
        public static FlowNetwork FindMaxFlow(FlowNetwork network, out int maxFlowValue)
        {

        }
        public static void WriteOutputFile(string fileToBeWritten, FlowNetwork flow, int flowValue)
        {

        }
        // end of public classes

        // confused about Dictionary / Directed Graph. Which one?
        private static int FindMinCapacity(Dictionary<string, int> pathInfo, FlowNetwork graph)
        {

        }

        private static Dictionary<string, int> FindAugmentPath(FlowNetwork network)       // dictionary or directed graph?
        {

        }
        private static void AugmentTheFlow(FlowNetwork graph, FlowNetwork flow, Dictionary<string, int> pathInfo, int amountToBeAdded)
        {
            
        }

    }
}
