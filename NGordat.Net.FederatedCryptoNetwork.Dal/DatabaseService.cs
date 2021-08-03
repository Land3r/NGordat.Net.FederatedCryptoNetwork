using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGordat.Net.FederatedCryptoNetwork.Dal
{
    public class DatabaseService
    {
        private FCNDbContext _context;

        public DatabaseService(FCNDbContext context)
        {
            _context = context;
        }

        public void CreateSchemaIfNotExists()
        {
            bool isUpToDate = _context.Database.EnsureCreated();
        }

        public async Task CreateOrUpdateDataFolderAsync(string folderName, Type objectType)
        {
            var files = Directory.GetFiles("Data" + Path.DirectorySeparatorChar + folderName);
            foreach (var file in files)
            {
                if (file.EndsWith(".json"))
                {
                    var content = File.ReadAllText(file);
                    dynamic element = JsonConvert.DeserializeObject(content, objectType);
                    element = Convert.ChangeType(element, objectType);
                    if (element != null)
                    {
                        // Create or update element.
                        var item = await _context.FindAsync(objectType, element.Id);

                        if (item == null)
                        {
                            await _context.AddAsync(element);
                        }
                        else
                        {
                            item.Name = element.Name;
                            item.PublicUrl = element.PublicUrl;
                            item.AffiliateUrl = element.AffiliateUrl;
                            item.Ranking = element.Ranking;
                            item.DescriptionShort = element.DescriptionShort;
                            item.DescriptionLong = element.DescriptionLong;
                            item.Banner = element.Banner;
                            item.Icon = element.Icon;
                            item.Recommended = element.Recommended;
                            item.Active = element.Active;

                            _context.Update(item);
                        }
                    }
                }
            }

            await _context.SaveChangesAsync();

        }
    }
}
