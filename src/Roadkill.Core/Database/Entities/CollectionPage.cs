namespace Roadkill.Core.Database.Entities
{
    /// <summary>
    ///     Represents a collection's page meta data in the data store.
    /// </summary>
    public class CollectionPage : Page
    {
        /// <summary>
        ///     Gets or sets the virtual path.
        /// </summary>
        /// <value>
        ///     The virtual path.
        /// </value>
        public string VirtualPath { get; set; }
    }
}