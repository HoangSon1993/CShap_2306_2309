namespace GameGPG.Models
{
    public interface IRequirement
    {
        int STR { get; set; }
        int AGI { get; set; }
        int INT { get; set; }
        int WIS { get; set; }
        int END { get; set; }
        int Level { get; set; }
    }
}