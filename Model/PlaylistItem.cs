using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlaylistServices.Data;

namespace PlaylistService.Model
{
    public class PlaylistItem
    {
        [Key]
        public int Id { get; set; }

        public string? SongName { get; set; }
        public string? ArtistName { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
