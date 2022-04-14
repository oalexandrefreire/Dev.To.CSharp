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
        public static readonly string _userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.97 Safari/537.36";
        
        public static async Task<List<ArticleDto>> GetListRelevantAsync()
        {
            try
            {
                var articles = await _baseUrl.WithHeader("User-Agent", _userAgent).GetJsonAsync<List<ArticleDto>>();

                return articles;
            }
            catch (Exception)
            {
                return new List<ArticleDto>();
            }
        }  
        
        public static async Task<List<ArticleDto>> GetListByUserNameAsync(string username)
        {
            try
            {
                var articles = await _baseUrl.SetQueryParams(new { username }).WithHeader("User-Agent", _userAgent).GetJsonAsync<List<ArticleDto>>();

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
                var article = await _baseUrl.AppendPathSegment(id.ToString()).WithHeader("User-Agent", _userAgent).GetJsonAsync<ArticleDto>();

                return article;
            }
            catch (Exception)
            {
                return new ArticleDto();
            }
        }
    }
}
