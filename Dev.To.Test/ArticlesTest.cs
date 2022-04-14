using Xunit;
using System.Threading.Tasks;

namespace Dev.To.Test
{
    public class ArticlesTest
    {
        [Fact]
        public async Task GetListByUserNameAsyncTest()
        {
            var articles = await ArticlesWithoutAuth.GetListByUserNameAsync( "alexandrefreire");
            Assert.NotNull(articles);
        }

        [Fact]
        public async Task GetByIdAsyncTest()
        {
            var article = await ArticlesWithoutAuth.GetByIdAsync( 987969);
            Assert.NotNull(article);
        }
    }
}