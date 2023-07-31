using Moq;

namespace Kaizen.JsonParse.Test
{
    public class ProgramTest
    {
        private IJsonParseService jsonParseService;
        public ProgramTest()
        {
            var mockedService = new Mock<IJsonParseService>();

            mockedService.Setup(x => x.GetParsedDataList(It.IsAny<string>())).Returns("line text\r\n  1  TEŞEKKÜRLER\r\n  2  GUNEYDOĞU TEKS. INS SAN.LTD.STI.\r\n  3  CC.COCA COLA CAM 200 08 *5,50\r\n");

           this.jsonParseService = mockedService.Object;
        }

        [Theory]
        [InlineData(Values.RECEIPTJSONDATA)]
        public void GetParsedDataList_ShouldReturnSuccess_WhenValidJsonData(string jsondata)
        {
            var exp = "line text\r\n  1  TEŞEKKÜRLER\r\n  2  GUNEYDOĞU TEKS. INS SAN.LTD.STI.\r\n  3  CC.COCA COLA CAM 200 08 *5,50\r\n";

            var result =  this.jsonParseService.GetParsedDataList(jsondata);

            Assert.NotNull(result);
            Assert.Equal(exp, result);
        }
    }
}