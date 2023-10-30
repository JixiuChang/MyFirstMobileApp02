namespace MyFirstMobileApp.Models.Entities
{
    public class ActorCharacterInfo
    {
        //Properties - Initialized to an Empty String
        public string ActorName { get; set; } = string.Empty;
        public ImageSource ActorImage { get; set; } = null;
        public string CharacterName { get; set; } = string.Empty;

        public ActorCharacterInfo() 
        {
            //Constructor
        }

        public ActorCharacterInfo(string actorName, ImageSource actorImage, string characterName)
        {
            //Constructor with Parameters
            ActorName = actorName;
            ActorImage = actorImage;
            CharacterName = characterName;
        }

        ///<summary>
        /// Retrieves a list of sample character data, each representing an actor's name, an image URL, and the character they portray.
        ///</summary>
        ///<returns>A list of ActorCharacterInfo objects containing sample data.</returns>
        public static List<ActorCharacterInfo> GetSampleCharacterData()
        {
            var actors = new List<ActorCharacterInfo>
            {
                // Create ActorCharacterInfo objects with sample data
                new ActorCharacterInfo("Chris Pratt", ImageSource.FromFile("Images/GOG/starlord.jpg"), "Starlord"),
                new ActorCharacterInfo("Zoe Saldana", ImageSource.FromFile("Images/GOG/gamora.jpg"), "Gamora"),
                new ActorCharacterInfo("Vin Diesel", ImageSource.FromFile("Images/GOG/groot.jpg"), "Groot"),
                new ActorCharacterInfo("Bradley Cooper", ImageSource.FromFile("Images/GOG/rocket.jpg"), "Rocket"),
                new ActorCharacterInfo("Karen Gillan", ImageSource.FromFile("Images/GOG/nebula.jpg"), "Nebula")
            };

            return actors;
        }

        ///<summary>
        ///Retrieves a list of character names from the sample character data.
        ///</summary>
        ///<returns>A list of character names extracted from the sample data.</returns>
        public static List<string> GetCharacterNames()
        {
            // Get the sample character data
            var sampleData = GetSampleCharacterData();

            // Select and convert character names to a list
            return sampleData.Select(info => info.CharacterName).ToList();
        }

    }
}
