# Dev.to NuGet package

get posts from dev.to

## Examples
```C#
        public async Task GetListRelevantAsync()
        {
            var articles = await ArticlesWithoutAuth.GetListRelevantAsync();
        }

        [Fact]
        public async Task GetListByUserNameAsync()
        {
            var articles = await ArticlesWithoutAuth.GetListByUserNameAsync( "alexandrefreire");
        }

        [Fact]
        public async Task GetByIdAsync()
        {
            var article = await ArticlesWithoutAuth.GetByIdAsync( 987969);
        }
```
