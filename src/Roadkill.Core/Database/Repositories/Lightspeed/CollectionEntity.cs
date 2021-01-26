using System;
using Mindscape.LightSpeed;

namespace Roadkill.Core.Database.LightSpeed
{
    [Table("roadkill_collections", IdentityMethod = IdentityMethod.IdentityColumn)]
    public class CollectionEntity : Entity<int>
    {
        [Column("name")]
        private string _name;

        [Column("description")]
        private string _description;

        [Column("createdby")]
        private string _createdBy;

        [Column("createdon")]
        private DateTime _createdOnColumn;

        [Column("modifiedby")]
        private string _modifiedBy;

        [Column("modifiedon")]
        private DateTime _modifiedOn;

        [Column("tags")]
        private string _tags;

        [Column("islocked")]
        private bool _isLocked;

        //[ReverseAssociation("CollectionPages")]
        //private readonly EntityCollection<PageContentEntity> _pageContents = new EntityCollection<PageContentEntity>();

        //public EntityCollection<PageContentEntity> CollectionPages
        //{
        //    get { return Get(_pageContents); }
        //}

        public string Name
        {
            get => _name;
            set => Set<string>(ref _name, value);
        }

        public string Description
        {
            get => _description;
            set => Set<string>(ref _description, value);
        }

        public string CreatedBy
        {
            get => _createdBy;
            set => Set<string>(ref _createdBy, value);
        }

        public DateTime CreatedOn
        {
            get => _createdOnColumn;
            set => Set<DateTime>(ref _createdOnColumn, value);
        }

        public string ModifiedBy
        {
            get => _modifiedBy;
            set => Set<string>(ref _modifiedBy, value);
        }

        public DateTime ModifiedOn
        {
            get => _modifiedOn;
            set => Set<DateTime>(ref _modifiedOn, value);
        }

        public string Tags
        {
            get => _tags;
            set => Set<string>(ref _tags, value);
        }

        public bool IsLocked
        {
            get => _isLocked;
            set => Set<bool>(ref _isLocked, value);
        }
    }
}