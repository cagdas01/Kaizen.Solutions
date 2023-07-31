using Moq;

namespace Kaizen.GenerateRandomCode.Test
{
    public class ProgramTest
    {
        private readonly ICodeGenerator codeGenerator;

        public ProgramTest()
        {
           var mockCodeGenerator = new Mock<ICodeGenerator>();
            mockCodeGenerator.Setup(x => x.CheckCode(It.IsAny<string>())).Returns(true);
            mockCodeGenerator.Setup(x => x.GenerateCodes(3)).Returns(new HashSet<string> { "92XF7LMX","ZH4KCPFX","TNFNZG35" });

            codeGenerator = mockCodeGenerator.Object;
        }

        [Theory]
        [InlineData("92XF7LMX")]
        public void CheckCode_ShoulReturnSuccess_WhenValidData(string code)
        {
            var result = codeGenerator.CheckCode(code);

            Assert.True(result);
        }


        [Theory]
        [InlineData(3)]
        public void GenerateCode_ShouldReturnSuccess_WhenValidThreeData(int count)
        {
            var result = codeGenerator.GenerateCodes(count);

            Assert.NotNull(result);
        }
    }
}