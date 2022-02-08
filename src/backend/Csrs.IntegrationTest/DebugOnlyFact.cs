using System.Diagnostics;
using Xunit;

namespace Csrs.IntegrationTest
{
    internal class DebugOnlyFact : FactAttribute
    {
        public DebugOnlyFact()
        {
#if !DEBUG
            Skip = "Only running in debug builds";
#endif
        }
    }
}
