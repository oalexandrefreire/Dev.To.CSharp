using Dev.To.Dto;
using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dev.To
{
    public static class ArticlesWithoutAuth
    {
        public static readonly string _baseUrl = "https://dev.to/api/articles";
        
        public static async Task<List<ArticleDto>> GetListByUserNameAsync(string username)
        {
            try
            {
                var articles = await _baseUrl.SetQueryParams(new { username })
                    .WithHeader("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; .NET CLR 1.1.4322)")
                    .GetJsonAsync<List<ArticleDto>>();

                return articles;
            }
            catch (Exception)
            {
                return new List<ArticleDto>();
            }
        }

        public static async Task<ArticleDto> GetByIdAsync(int id)
        {
            try
            {
                var article = await _baseUrl.AppendPathSegment(id.ToString()).GetJsonAsync<ArticleDto>();

                return article;
            }
            catch (Exception)
            {
                return new ArticleDto();
            }
        }
    }
}
