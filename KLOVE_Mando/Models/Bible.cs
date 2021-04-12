using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KLOVE_Mando.Models
{
    public class Bible
    {
        public enum Source { API, SELF };
        public BibleResponse response;
        public string serializedVerses;
        public string favorites;
        public string startDate;
        public string pageSize;
        public Source source;


        public Bible(string startDate = null, string pageSize = null, string favorites = null, string verses = null)
        {
            if (favorites == null)
            {
                response = JsonConvert.DeserializeObject<BibleResponse>(Request(startDate.ToString(), pageSize.ToString()));
                response.NoteFavorite();
                serializedVerses = JsonConvert.SerializeObject(response.getVerses());
                source = Source.API;
            }
            else
            {
                response = new BibleResponse(JsonConvert.DeserializeObject<Verse[]>(verses));
                response.NoteFavorite(JsonConvert.DeserializeObject<Verse[]>(favorites));
                serializedVerses = JsonConvert.SerializeObject(verses);
                source = Source.SELF;
            }
        }

        public List<Verse> GetBibleVerses()
        {
            return response.getVerses();
        }

        string Request(string requestDate, string pageSize)
        {
            const string HEADER_KEY = "ENTER HEADER KEY HERE";
            const string HEADER_VALUE = "ENTER HEADER VALUE HERE"; 
            // Create a request for the URL. 		
            WebRequest request = WebRequest.Create(String.Format("https://emfservicesstage-api.azure-api.net/bible/v1/getversesbydate?siteId=1&startdate={0}&PageSize={1}", requestDate, pageSize));
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Headers.Add(HEADER_KEY, HEADER_VALUE);
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();

            // Return content.
            return responseFromServer;
        }
    }

    public class BibleResponse
    {
        Verse[] Verses;
        public int Pagesize;
        public int PageNumber;
        public bool HasMorePages;
        public string Id;
        public string Url;

        public BibleResponse(Verse[] verses)
        {
            Verses = verses;
        }

        public List<Verse> getVerses()
        {
            return Verses.OrderBy((verse) => verse.VerseText.Length).ToList();
        }

        public void NoteFavorite(Verse[] favorites = null)
        {
            foreach (var verse in Verses)
            {
                if (favorites != null)
                {
                    if (favorites.Any((c) => c.Id == verse.Id))
                    {
                        verse.isFavorite = true;
                    }
                }
                else
                {
                    using (var db = new BibleContext())
                    {

                        if (db.Verses.Any((v) => v.Id == verse.Id))
                        {
                            verse.isFavorite = true;
                        }

                    }
                }
            }
        }
    }
}



