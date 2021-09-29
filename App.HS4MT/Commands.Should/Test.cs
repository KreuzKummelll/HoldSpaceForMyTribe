// Created by Andrew McLane
// 10thmagicbridge@gmail.com
using NUnit.Framework;
using Commands;
using NSubstitute;

namespace Commands.Should
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            var invoker = Substitute.For<IInvoke>();
            var command = new SimpleCommand("Check if key is in pocket");
            invoker.SetOnStart(command);
            

            var receiver = Substitute.For<IReceive>();
            invoker.SetOnFinish(new ComplexCommand(receiver, "try unlock door", "report results"));
            invoker.DoSomethingImportant();


        }
    }
}
