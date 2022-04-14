# Dev.to NuGet package

get posts from dev.to

## Examples
```C#
        public async Task GetListRelevantAsyncTest()
        {
            var articles = await ArticlesWithoutAuth.GetListRelevantAsync();
        }

        [Fact]
        public async Task GetListByUserNameAsyncTest()
        {
            var articles = await ArticlesWithoutAuth.GetListByUserNameAsync( "alexandrefreire");
        }

        [Fact]
        public async Task GetByIdAsyncTest()
        {
            var article = await ArticlesWithoutAuth.GetByIdAsync( 987969);
        }
```