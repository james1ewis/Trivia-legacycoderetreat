using ApprovalTests;
using ApprovalTests.Reporters;
using ApprovalUtilities.SimpleLogger;
using NUnit.Framework;

namespace Trivia.Test
{
    [TestFixture]
<<<<<<< HEAD
    [UseReporter(typeof(WinMergeReporter))]
=======
    [UseReporter(typeof(KDiffReporter))]
>>>>>>> origin/master
    public class CharacterizationTest
    {
        [Test]
        public void TestExistingBehaviour()
        {
            var log = Logger.LogToStringBuilder();
            GameRunner.main(null);
            Approvals.Verify(log); //    maybe try approvals.approve...
        }
    }
}
