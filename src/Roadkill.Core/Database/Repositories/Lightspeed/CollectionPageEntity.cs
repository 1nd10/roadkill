using System;
using Mindscape.LightSpeed;

namespace Roadkill.Core.Database.LightSpeed
{
    [Table("roadkill_collectionpage")]
    public class CollectionPageEntity : Entity<Guid>
    {
        [Column("virtualpath")]
        private string _virtualPath;

        [ReverseAssociation(nameof(CollectionId))]
        private readonly EntityHolder<CollectionEntity> _collection = new EntityHolder<CollectionEntity>();

        private int _pageId;

        public CollectionEntity Collection
        {
            get => Get(_collection);
            set => Set(_collection, value);
        }

        public int CollectionId
        {
            get => Get(ref _pageId, nameof(CollectionId));
            set => Set(ref _pageId, value, nameof(CollectionId));
        }

        public string VirtualPath
        {
            get => _virtualPath;
            set => Set<string>(ref _virtualPath, value);
        }
    }
}