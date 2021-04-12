using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KLOVE_Mando.Models
{
    public class Verse
    {
        public enum Social { FACEBOOK, TWITTER, PINTEREST };
        [Key]
        public string Id { get; set; }
        public string VerseText { get; set; }
        public string ImageLink { get; set; }
        public DateTime VerseDate { get; set; }
        public string VideoLink { get; set; }
        public string ReferenceLink { get; set; }
        public int VerseNumbers { get; set; }
        public int Chapter { get; set; }
        public string Book { get; set; }
        public string ReferenceText { get; set; }
        public string BibleReferenceLink { get; set; }
        public string FacebookShareUrl { get; set; }
        public string TwitterShareUrl { get; set; }
        public string PinterestShareUrl { get; set; }
        public bool IsValid { get; set; }
        public string Url { get; set; }
        public bool isFavorite { get; set; }

        public string getClass()
        {
            if (isFavorite)
            {
                return "btn btn-danger";
            }
            else
            {
                return "btn btn-outline-danger";
            }
        }

        public string getSocialLink(Social media)
        {
            switch (media)
            {
                case Social.FACEBOOK: return String.Format("https://www.facebook.com/sharer/sharer.php?{0}", FacebookShareUrl);
                case Social.PINTEREST: return String.Format("https://www.pinterest.com/pin/create/button/?{0}", PinterestShareUrl);
                case Social.TWITTER: return String.Format("https://twitter.com/share?{0}", TwitterShareUrl);
                default: return "https://www.klove.com/";
            }
        }
    }
}

