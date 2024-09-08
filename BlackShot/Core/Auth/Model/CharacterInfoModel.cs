using System.ComponentModel.DataAnnotations;

namespace Core.Auth.Model
{
    public class CharacterInfoModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Guid AccountNumber { get; set; }

        public uint CharacterID { get; set; }

        [Required]
        [StringLength(17)]
        public string? Nickname { get; set; }

        public ushort Level { get; set; }

        [Required]
        public byte Hero { get; set; }

        public uint Experience { get; set; }

        public uint BountyPoints { get; set; }

        public uint Kills { get; set; }

        public uint Deaths { get; set; }

        public uint Wins { get; set; }

        public int Losses { get; set; }

        [StringLength(17)]
        public string? ClanName { get; set; }

        public uint ClanMark { get; set; }

        [Required]
        public byte SkinColor { get; set; }

        public uint PlayerCash { get; set; }
    }
}
