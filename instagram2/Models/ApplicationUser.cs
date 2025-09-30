using Microsoft.AspNetCore.Identity;

namespace instagram2.Models;

public class ApplicationUser : IdentityUser
{
    public string? AvatarPath { get; set; }
    public string? Name { get; set; }
    public string? Bio { get; set; }
    public string? Gender { get; set; }

    public int PostsCount { get; set; } = 0;
    public int FollowersCount { get; set; } = 0;
    public int FollowingCount { get; set; } = 0;
}