using System.Collections.Generic;
using PopuliVoxRu.Domain.Core.Models.Shared;

namespace PopuliVoxRu.Domain.Core.Models.Identity
{
    public class UserRegisterModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int SexId { get; set; }

        public List<ListItemModel> SexList { get; set; }

        public int SkillLevelId { get; set; }

        public List<ListItemModel> SkillLevelList { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public string Password { get; set; }

        public string PasswordConfirm { get; set; }
    }
}
