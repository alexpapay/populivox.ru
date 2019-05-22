namespace PopuliVoxRu.Domain.Core.Utils
{
    public enum PagesEnum
    {
        Main,
        Register,
        Login,
        AddFeedback,
        AddClaim,
        AddCustomer
    }

    public enum Sex
    {
        /// <summary>
        /// Male - 0.
        /// </summary>
        Male = 0,

        /// <summary>
        /// Female - 1.
        /// </summary>
        Female = 1
    }

    public enum SkillLevel
    {
        /// <summary>
        /// Diletant - 0.
        /// </summary>
        Diletant = 0,

        /// <summary>
        /// Skilled - 1.
        /// </summary>
        Skilled = 1,

        /// <summary>
        /// Middle - 2.
        /// </summary>
        Middle = 2,

        /// <summary>
        /// Senior - 3.
        /// </summary>
        Senior = 3
    }
}