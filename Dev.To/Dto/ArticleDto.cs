using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Dev.To.Dto
{
    //ArticleDto myDeserializedClass = JsonConvert.DeserializeObject<ArticleDto>(myJsonResponse);

    public class ArticleDto
    {
        [JsonProperty("type_of")]
        public string TypeOf { get; set; }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("readable_publish_date")]
        public string ReadablePublishDate { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("comments_count")]
        public int CommentsCount { get; set; }

        [JsonProperty("public_reactions_count")]
        public int PublicReactionsCount { get; set; }

        [JsonProperty("collection_id")]
        public object CollectionId { get; set; }

        [JsonProperty("published_timestamp")]
        public DateTime PublishedTimestamp { get; set; }

        [JsonProperty("positive_reactions_count")]
        public int PositiveReactionsCount { get; set; }

        [JsonProperty("cover_image")]
        public string CoverImage { get; set; }

        [JsonProperty("social_image")]
        public string SocialImage { get; set; }

        [JsonProperty("canonical_url")]
        public string CanonicalUrl { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("edited_at")]
        public DateTime? EditedAt { get; set; }

        [JsonProperty("crossposted_at")]
        public string CrosspostedAt { get; set; }

        [JsonProperty("body_markdown")]
        public string BodyMarkdown { get; set; }

        [JsonProperty("body_html")]
        public string BodyHtml { get; set; }

        [JsonProperty("published_at")]
        public DateTime? PublishedAt { get; set; }

        [JsonProperty("last_comment_at")]
        public DateTime? LastCommentAt { get; set; }

        [JsonProperty("reading_time_minutes")]
        public int ReadingTimeMinutes { get; set; }

        //[JsonProperty("tag_list")]
        //public List<string> TagList { get; set; }

        //[JsonProperty("tags")]
        //public string Tags { get; set; }

        [JsonProperty("user")]
        public UserDto UserDto { get; set; }
    }

}
