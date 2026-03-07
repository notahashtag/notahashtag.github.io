using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Card
{
    [JsonPropertyName("name_short")]
    public required string NameShort { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required string Value { get; set; }

    [JsonPropertyName("value_int")]
    public int ValueInt { get; set; }

    [JsonPropertyName("type")]
    [AllowedValues("major", "minor")]
    public required string Type { get; set; }

    [JsonPropertyName("meaning_up")]
    public required string MeaningUp { get; set; }

    [JsonPropertyName("meaning_rev")]
    public required string MeaningDown { get; set; }

    [JsonPropertyName("desc")]
    public required string Desc { get; set; }

}
