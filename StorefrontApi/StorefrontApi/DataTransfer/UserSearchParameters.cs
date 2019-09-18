namespace StorefrontApi.DataTransfer
{
    public class UserSearchParameters
    {
        /// <summary>
        /// The search term for basic searches.
        /// </summary>
        public string SearchTerm { get; set; }

        /// <summary>
        /// The search term for advanced UserName searches.
        /// </summary>
        public string UserNameSearchTerm { get; set; }

        /// <summary>
        /// The search term for advanced Email searches.
        /// </summary>
        public string EmailSearchTerm { get; set; }

        /// <summary>
        /// The search term for advanced DisplayName searches.
        /// </summary>
        public string DisplayNameSearchTerm { get; set; }
    }
}
