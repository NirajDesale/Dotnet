using WebApp.Modules;

namespace webTest
{
    public class webTest
    {
        [Fact]
        public void DemoTest()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.True(result, "Value should be equal to 1");
        }

        [Fact]
        public void CheckAddFunction()
        {
            Functions fun = new Functions();
            int y = fun.Add(3, 2);
            bool result = false;
            if (y == 5) result = true;
            Assert.True(result, "Value should be equal to 5");

            
         var password =  "https://cdb-ing-blt-dev-nosql.documents.azure.com:443/";
         var password1 = "H1Ndaslp6JTOms6MvlzOtQkN4k5SzvUlfm2vlxT7SvKEltm87QnzTYjQNWu8PW0DP1gB5RI0DFttACDbVlG96g==";

        }
    }
}
