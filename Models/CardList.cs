using System.Text.Json.Serialization;

public class CardList
{
    [JsonPropertyName("nhits")]
    public int NHits { get; set; }

    [JsonPropertyName("cards")]
    public List<Card>? Cards { get; set; }
}
