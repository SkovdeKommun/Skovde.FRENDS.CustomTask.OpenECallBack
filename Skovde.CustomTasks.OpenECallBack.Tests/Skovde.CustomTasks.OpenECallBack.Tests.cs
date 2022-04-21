using NUnit.Framework;
using System;

namespace Skovde.CustomTasks.OpenECallBack.Tests
{
    [TestFixture]
    class TestClass
    {
        /// <summary>
        /// You need to run Skovde.CustomTasks.OpenECallBack.SetPaswordsEnv.ps1 before running unit test, or some other way set environment variables e.g. with GitHub Secrets.
        /// </summary>
        [Test]
        public void ThreeOpenEs()
        {
            var input = new Parameters
            {
                Message = Environment.GetEnvironmentVariable("EXAMPLE_ENVIROMENT_VARIABLE")
        };

            var options = new Options
            {
                Amount = 3,
                Delimiter = ", "
            };

            var ret = OpenE.OpenECallBack(input, options, new System.Threading.CancellationToken());

            Assert.That(ret.Replication, Is.EqualTo("foobar, foobar, foobar"));
        }
    }
}
