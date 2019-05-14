using Microsoft.AspNetCore.Identity;

namespace PopuliVoxRu.Domain.Core.Tables.Identity
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Sex { get; set; }

        public int Age { get; set; }

        public int SkillLevel { get; set; }
    }
}