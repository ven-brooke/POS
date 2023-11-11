using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    internal static class FirestoreHelper
    {
        static string fireconfig = @"
        {
          ""type"": ""service_account"",
          ""project_id"": ""test-76d3d"",
          ""private_key_id"": ""14a7c264d0dfe0e512df919a0c0baaada322a54d"",
          ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQDIQ98SBBkrMGp+\ngAvJ69ow3C08NoB5c+i4qMbK9RqhfbXa0iJa1D4sIVEnWdnZmr7ierbkpeAKERsm\nxUqch41ByYz0T6lEvmigjClA5LLEhj5P3TDG1iYuJgMhhAJJejQZFrQMSIPfSQQA\nfXocdieUtglFnhFyCluoequkjrIy4/A0/iL2+qVBJl15LanG/qCKC1hSDEBVOvdU\n5paC392rDeOxFzcBxD+GHQR3vdXnwgb3y1SJFuOzRl90Dc2ssOLIClpnQ//jE0i2\nRksZE3deS+auxyvyez2n7MsweG0NP10Vo6vNE1NWuFgWLrIGCHjiWpHIFyZCJqwT\nw92yHvHTAgMBAAECggEAJs2z2t9Naydp8xHndtwKvn3jC/A5i47wcFtPjYLZgqID\nix89ReErHMzl1xybUAUiaGrDpmEXnIu8+ZGvx82iCrW9aJdI4oeMaVNPKQJHOzoR\nt9LRgS18X2PBJozYDpmtn5DdGSYx2yFgM6Icd4hTWga9nC4pDjJAmVAPkwaNM7vL\n9CDAbr8nUUg56+/Cv4LqzuuSpxce5wgicac1vmquEMAw5kABY/AO6M5Mmi6KKgFL\nsDk8UoX/ChoZI6eBDQLA5lBAuNWIEfJCeuOW06g7N95sJNd8s300qNJeR/X4Sokh\nzxhUxR5Ly3SAplaiFuY0Bw/ENT91Bni1fxptfKuVGQKBgQDt+l0l4sNFwmRER3hY\n/xDNLBh9FndiBc/e8BtZFmDTvqYDhi+IufZAh9mnDe080ujR+Elo9NmU4/p+D3qx\nWeHQeD3EHu0MmvGkdfDWdGqpDYpKZcqR1k7A5njpT9K4fweC+VjbMdj7EYbMoI5F\nm0g8qzcyd4EyHv+hfdMsY0L4CwKBgQDXbmAFr/B9WmtOXM5uVwU2+FXUaljNX3Rr\nclFtEbAMORvetQrToLXwOAHBqJwlJriTCx8BRA6qr7QAUrXKoqqA22IKnQGGW8VC\nsdpDsz5vVx+8k2yjug6/oBj9UYwq8bf9v6J7lUocj9HAyRfFdmMomsW5bdgu8fAE\nAd4X47fiWQKBgQDTyi4d6nro2YDMd2K2qYF1Z1n/8P+cQBnoiX19Qno32AL9Pe2N\n3Bo5Ae4FS1Kn//ft7e6/NrFxXZdvmy0RKzHZizlFElTbFAYb3E7TPNYzz3YUkhS+\nx6Bc8oAG++BIC91OhcS7hthZURbLg9Q6RGD8hU/hXROg3I+aVFWculY+UwKBgH1F\nTIbiGQj7dBx8MPnOllSxsU80i/DYid0U+65ds65X4xHs2p/W+xT1rGfNQQcFbhzr\nQZs91P2B8Dyj29w6HMWTTH55b/KOGLXAr/fgGfUqh2TjoS/PuFXLpdxf+A7cwi3G\nqpgMZq0XIFRnWvBS+DQbU9CQxD4AJ55c66WeoEX5AoGADcL6wPUlF1dhwaFI74dW\nsYigah/0WXKL/F12gTEho4j8iwcHhuWqyKwxAI7fZCYbkYNCcEo7tuIv4b6xcek8\nuv+m9+w/xLPLnvL2yrkusSZ5UNEMLfSfTZKpliHNaFa8KtaNuaZGkOa0k0IpPWTf\nQOqfkWF0ja4cgh0sS7RNNVk=\n-----END PRIVATE KEY-----\n"",
          ""client_email"": ""firebase-adminsdk-20awn@test-76d3d.iam.gserviceaccount.com"",
          ""client_id"": ""116750605635905580595"",
          ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
          ""token_uri"": ""https://oauth2.googleapis.com/token"",
          ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
          ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-20awn%40test-76d3d.iam.gserviceaccount.com"",
          ""universe_domain"": ""googleapis.com""
        }";

        static string filepath = "";
        public static FirestoreDb? Database { get; private set; }

        public static void SetEnvironmentVariable()
        {
            //string filepath = AppDomain.CurrentDomain.BaseDirectory + @"test-76d3d-firebase-adminsdk-20awn-14a7c264d0.json";

            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            Database = FirestoreDb.Create("test-76d3d");
            File.Delete(filepath);
        }
    }
}
