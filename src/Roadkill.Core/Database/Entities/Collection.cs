using System;

namespace Roadkill.Core.Database
{
    /// <summary>
    ///     Represents a collection's meta data in the data store.
    /// </summary>
    public class Collection : IDataStoreEntity
    {
        /// <summary>
        ///     Gets or sets the collection's unique ID.
        /// </summary>
        /// <value>
        ///     The id.
        /// </value>
        /// <remarks>
        ///     Reasons for using an int for the primary key:
        ///     + Clustered PKs without using guid.comb
        ///     + Nice URLs.
        ///     - Losing the certainty of uniqueness like a guid
        ///     - Oracle is not supported.
        /// </remarks>
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>
        ///     The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the user who created the collection.
        /// </summary>
        /// <value>
        ///     The created by user.
        /// </value>
        public string CreatedBy { get; set; }

        /// <summary>
        ///     Gets or sets the date the collection was created on.
        /// </summary>
        /// <value>
        ///     The created on date.
        /// </value>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        ///     Gets or sets the user who last modified the collection.
        /// </summary>
        /// <value>
        ///     The user who modified the collection.
        /// </value>
        public string ModifiedBy { get; set; }

        /// <summary>
        ///     Gets or sets the date the collection was last modified on.
        /// </summary>
        /// <value>
        ///     The modified on.
        /// </value>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        ///     Gets or sets the tags for the collection, in the format "tag1,tag2,tag3" (no spaces between tags).
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        ///     Gets or sets whether the collection is locked for admin-only editing.
        /// </summary>
        public bool IsLocked { get; set; }

        /// <summary>
        ///     The unique id for this object - for use with document stores that require a unique id for storage.
        /// </summary>
        public Guid ObjectId { get; set; }
    }
}