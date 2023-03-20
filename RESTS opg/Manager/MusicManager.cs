using RESTS_opg.Models;

namespace RESTS_opg.Manager
{
    public class MusicManager
    {
        private static int _nextId = 1;
        private static readonly List<MusicRecords> Data = new List<MusicRecords>
        {
            new MusicRecords {Id = _nextId++, Title = "Nba Youngboy - Cans life", Duration = 3},
            new MusicRecords {Id=_nextId++, Title = "Drake - Rich Flex", Duration = 5},
            new MusicRecords {Id = _nextId++, Title = "Lil ZestyWame - Im gay", Duration = 4}
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        };

        public List<MusicRecords> GetAll(string title = null, string sortBy = null)
        // Optional parameters
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments
        {
            List<MusicRecords> musics = new List<MusicRecords>(Data);
            // copy constructor
            // Callers should no get a reference to the Data object, but rather get a copy

            if (title != null)
            {
                musics = musics.FindAll(musics => musics.Title != null && musics.Title.StartsWith(title));
            }
            if (sortBy != null)
            {
                switch (sortBy.ToLower())
                {
                    case "title":
                        musics = musics.OrderBy(musics => musics.Title).ToList();
                        break;
                    case "price":
                        musics = musics.OrderBy(musics => musics.Duration).ToList();
                        break;
                        // skip any other properties in the query string
                }
            }
            return musics;
        }

        public MusicRecords GetById(int id)
        {
            return Data.Find(musics => musics.Id == id);
        }

        public MusicRecords Add(MusicRecords newMusic)
        {
            newMusic.Id = _nextId++;
            Data.Add(newMusic);
            return newMusic;
        }

        public MusicRecords Delete(int id)
        {
            MusicRecords music = Data.Find(music1 => music1.Id == id);
            if (music == null) return null;
            Data.Remove(music);
            return music;
        }

        public MusicRecords Update(int id, MusicRecords updates)
        {
            MusicRecords music = Data.Find(music1 => music1.Id == id);
            if (music == null) return null;
            music.Title = updates.Title;
            music.Duration = updates.Duration;
            return music;
        }
    }
}