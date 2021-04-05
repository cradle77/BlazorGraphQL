// ShareEntity.cs
#nullable enable

namespace GqlDemo.Client.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class ShareEntity
    {
        public ShareEntity(
            global::System.Int32 id,
            global::System.String? companyName,
            global::System.Decimal value,
            global::StrawberryShake.EntityId? industry)
        {
            Id = id;
            CompanyName = companyName;
            Value = value;
            Industry = industry;
        }

        public global::System.Int32 Id { get; }

        public global::System.String? CompanyName { get; }

        public global::System.Decimal Value { get; }

        public global::StrawberryShake.EntityId? Industry { get; }
    }
}


// IndustryEntity.cs
#nullable enable

namespace GqlDemo.Client.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class IndustryEntity
    {
        public IndustryEntity(
            global::System.Int32 id,
            global::System.String? name)
        {
            Id = id;
            Name = name;
        }

        public global::System.Int32 Id { get; }

        public global::System.String? Name { get; }
    }
}


// GetSharesResultFactory.cs
#nullable enable

namespace GqlDemo.Client.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSharesResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::GqlDemo.Client.GetSharesResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.ShareEntity, GetShares_Shares_Nodes_Share> _getShares_Shares_Nodes_ShareFromShareEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.IndustryEntity, GetShares_Shares_Nodes_Industry_Industry> _getShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper;

        public GetSharesResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.ShareEntity, GetShares_Shares_Nodes_Share> getShares_Shares_Nodes_ShareFromShareEntityMapper,
            global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.IndustryEntity, GetShares_Shares_Nodes_Industry_Industry> getShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getShares_Shares_Nodes_ShareFromShareEntityMapper = getShares_Shares_Nodes_ShareFromShareEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getShares_Shares_Nodes_ShareFromShareEntityMapper));
            _getShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper = getShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::GqlDemo.Client.IGetSharesResult);

        public GetSharesResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetSharesResultInfo info)
            {
                return new GetSharesResult(MapIGetShares_Shares(
                    info.Shares,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetSharesResultInfo expected.");
        }

        private global::GqlDemo.Client.IGetShares_Shares? MapIGetShares_Shares(
            global::GqlDemo.Client.State.ShareConnectionData? data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (data is null)
            {
                return null;
            }

            IGetShares_Shares returnValue = default!;

            if (data?.__typename.Equals(
                    "ShareConnection",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetShares_Shares_ShareConnection(
                    data.TotalCount ?? throw new global::System.ArgumentNullException(),
                    MapIGetShares_Shares_NodesArray(
                        data.Nodes,
                        snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<global::GqlDemo.Client.IGetShares_Shares_Nodes?>? MapIGetShares_Shares_NodesArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var shares = new global::System.Collections.Generic.List<global::GqlDemo.Client.IGetShares_Shares_Nodes?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                shares.Add(MapIGetShares_Shares_Nodes(
                    child,
                    snapshot));
            }

            return shares;
        }

        private global::GqlDemo.Client.IGetShares_Shares_Nodes? MapIGetShares_Shares_Nodes(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Share",
                    global::System.StringComparison.Ordinal))
            {
                return _getShares_Shares_Nodes_ShareFromShareEntityMapper.Map(
                    snapshot.GetEntity<global::GqlDemo.Client.State.ShareEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::GqlDemo.Client.IGetShares_Shares_Nodes_Industry? MapIGetShares_Shares_Nodes_Industry(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Industry",
                    global::System.StringComparison.Ordinal))
            {
                return _getShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper.Map(
                    snapshot.GetEntity<global::GqlDemo.Client.State.IndustryEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetSharesResultInfo.cs
#nullable enable

namespace GqlDemo.Client.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSharesResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetSharesResultInfo(
            global::GqlDemo.Client.State.ShareConnectionData? shares,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            Shares = shares;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::GqlDemo.Client.State.ShareConnectionData? Shares { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetSharesResultInfo(
                Shares,
                _entityIds,
                version);
        }
    }
}


// GetSharesResult.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSharesResult
        : global::System.IEquatable<GetSharesResult>
        , IGetSharesResult
    {
        public GetSharesResult(global::GqlDemo.Client.IGetShares_Shares? shares)
        {
            Shares = shares;
        }

        public global::GqlDemo.Client.IGetShares_Shares? Shares { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetSharesResult)obj);
        }

        public global::System.Boolean Equals(GetSharesResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((Shares is null && other.Shares is null) ||Shares != null && Shares.Equals(other.Shares)));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Shares is null))
                {
                    hash ^= 397 * Shares.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetShares_Shares_ShareConnection.cs
#nullable enable

namespace GqlDemo.Client
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetShares_Shares_ShareConnection
        : global::System.IEquatable<GetShares_Shares_ShareConnection>
        , IGetShares_Shares_ShareConnection
    {
        public GetShares_Shares_ShareConnection(
            global::System.Int32 totalCount,
            global::System.Collections.Generic.IReadOnlyList<global::GqlDemo.Client.IGetShares_Shares_Nodes?>? nodes)
        {
            TotalCount = totalCount;
            Nodes = nodes;
        }

        public global::System.Int32 TotalCount { get; }

        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::GqlDemo.Client.IGetShares_Shares_Nodes?>? Nodes { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetShares_Shares_ShareConnection)obj);
        }

        public global::System.Boolean Equals(GetShares_Shares_ShareConnection? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (TotalCount == other.TotalCount)
                && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Nodes,
                        other.Nodes);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * TotalCount.GetHashCode();

                if (!(Nodes is null))
                {
                    foreach (var Nodes_elm in Nodes)
                    {
                        if (!(Nodes_elm is null))
                        {
                            hash ^= 397 * Nodes_elm.GetHashCode();
                        }
                    }
                }

                return hash;
            }
        }
    }
}


// GetShares_Shares_Nodes_ShareFromShareEntityMapper.cs
#nullable enable

namespace GqlDemo.Client.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetShares_Shares_Nodes_ShareFromShareEntityMapper
        : global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.ShareEntity, GetShares_Shares_Nodes_Share>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.IndustryEntity, GetShares_Shares_Nodes_Industry_Industry> _getShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper;

        public GetShares_Shares_Nodes_ShareFromShareEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.IndustryEntity, GetShares_Shares_Nodes_Industry_Industry> getShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper = getShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper));
        }

        public GetShares_Shares_Nodes_Share Map(
            global::GqlDemo.Client.State.ShareEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetShares_Shares_Nodes_Share(
                entity.Id,
                entity.CompanyName,
                entity.Value,
                MapIGetShares_Shares_Nodes_Industry(
                    entity.Industry,
                    snapshot));
        }

        private global::GqlDemo.Client.IGetShares_Shares_Nodes_Industry? MapIGetShares_Shares_Nodes_Industry(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Industry",
                    global::System.StringComparison.Ordinal))
            {
                return _getShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper.Map(
                    snapshot.GetEntity<global::GqlDemo.Client.State.IndustryEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetShares_Shares_Nodes_Share.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetShares_Shares_Nodes_Share
        : global::System.IEquatable<GetShares_Shares_Nodes_Share>
        , IGetShares_Shares_Nodes_Share
    {
        public GetShares_Shares_Nodes_Share(
            global::System.Int32 id,
            global::System.String? companyName,
            global::System.Decimal value,
            global::GqlDemo.Client.IGetShares_Shares_Nodes_Industry? industry)
        {
            Id = id;
            CompanyName = companyName;
            Value = value;
            Industry = industry;
        }

        public global::System.Int32 Id { get; }

        public global::System.String? CompanyName { get; }

        public global::System.Decimal Value { get; }

        public global::GqlDemo.Client.IGetShares_Shares_Nodes_Industry? Industry { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetShares_Shares_Nodes_Share)obj);
        }

        public global::System.Boolean Equals(GetShares_Shares_Nodes_Share? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && ((CompanyName is null && other.CompanyName is null) ||CompanyName != null && CompanyName.Equals(other.CompanyName))
                && Value == other.Value
                && ((Industry is null && other.Industry is null) ||Industry != null && Industry.Equals(other.Industry));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                if (!(CompanyName is null))
                {
                    hash ^= 397 * CompanyName.GetHashCode();
                }

                hash ^= 397 * Value.GetHashCode();

                if (!(Industry is null))
                {
                    hash ^= 397 * Industry.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper.cs
#nullable enable

namespace GqlDemo.Client.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper
        : global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.IndustryEntity, GetShares_Shares_Nodes_Industry_Industry>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;

        public GetShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        public GetShares_Shares_Nodes_Industry_Industry Map(
            global::GqlDemo.Client.State.IndustryEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetShares_Shares_Nodes_Industry_Industry(
                entity.Id,
                entity.Name);
        }
    }
}


// GetShares_Shares_Nodes_Industry_Industry.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetShares_Shares_Nodes_Industry_Industry
        : global::System.IEquatable<GetShares_Shares_Nodes_Industry_Industry>
        , IGetShares_Shares_Nodes_Industry_Industry
    {
        public GetShares_Shares_Nodes_Industry_Industry(
            global::System.Int32 id,
            global::System.String? name)
        {
            Id = id;
            Name = name;
        }

        public global::System.Int32 Id { get; }

        public global::System.String? Name { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetShares_Shares_Nodes_Industry_Industry)obj);
        }

        public global::System.Boolean Equals(GetShares_Shares_Nodes_Industry_Industry? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && ((Name is null && other.Name is null) ||Name != null && Name.Equals(other.Name));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                if (!(Name is null))
                {
                    hash ^= 397 * Name.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// IGetSharesResult.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSharesResult
    {
        public global::GqlDemo.Client.IGetShares_Shares? Shares { get; }
    }
}


// IGetShares_Shares.cs
#nullable enable

namespace GqlDemo.Client
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetShares_Shares
    {
        public global::System.Int32 TotalCount { get; }

        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::GqlDemo.Client.IGetShares_Shares_Nodes?>? Nodes { get; }
    }
}


// IGetShares_Shares_ShareConnection.cs
#nullable enable

namespace GqlDemo.Client
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetShares_Shares_ShareConnection
        : IGetShares_Shares
    {
    }
}


// IShare.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IShare
    {
        public global::System.Int32 Id { get; }

        public global::System.String? CompanyName { get; }

        public global::System.Decimal Value { get; }

        public global::GqlDemo.Client.IGetShares_Shares_Nodes_Industry? Industry { get; }
    }
}


// IGetShares_Shares_Nodes.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetShares_Shares_Nodes
        : IShare
    {
    }
}


// IGetShares_Shares_Nodes_Share.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetShares_Shares_Nodes_Share
        : IGetShares_Shares_Nodes
    {
    }
}


// IIndustry.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IIndustry
    {
        public global::System.Int32 Id { get; }

        public global::System.String? Name { get; }
    }
}


// IGetShares_Shares_Nodes_Industry.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetShares_Shares_Nodes_Industry
        : IIndustry
    {
    }
}


// IGetShares_Shares_Nodes_Industry_Industry.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetShares_Shares_Nodes_Industry_Industry
        : IGetShares_Shares_Nodes_Industry
    {
    }
}


// GetIndustriesResultFactory.cs
#nullable enable

namespace GqlDemo.Client.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetIndustriesResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::GqlDemo.Client.GetIndustriesResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.IndustryEntity, GetIndustries_Industries_Industry> _getIndustries_Industries_IndustryFromIndustryEntityMapper;

        public GetIndustriesResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.IndustryEntity, GetIndustries_Industries_Industry> getIndustries_Industries_IndustryFromIndustryEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getIndustries_Industries_IndustryFromIndustryEntityMapper = getIndustries_Industries_IndustryFromIndustryEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getIndustries_Industries_IndustryFromIndustryEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::GqlDemo.Client.IGetIndustriesResult);

        public GetIndustriesResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetIndustriesResultInfo info)
            {
                return new GetIndustriesResult(MapIGetIndustries_IndustriesArray(
                    info.Industries,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetIndustriesResultInfo expected.");
        }

        private global::System.Collections.Generic.IReadOnlyList<global::GqlDemo.Client.IGetIndustries_Industries?>? MapIGetIndustries_IndustriesArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var industrys = new global::System.Collections.Generic.List<global::GqlDemo.Client.IGetIndustries_Industries?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                industrys.Add(MapIGetIndustries_Industries(
                    child,
                    snapshot));
            }

            return industrys;
        }

        private global::GqlDemo.Client.IGetIndustries_Industries? MapIGetIndustries_Industries(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Industry",
                    global::System.StringComparison.Ordinal))
            {
                return _getIndustries_Industries_IndustryFromIndustryEntityMapper.Map(
                    snapshot.GetEntity<global::GqlDemo.Client.State.IndustryEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetIndustriesResultInfo.cs
#nullable enable

namespace GqlDemo.Client.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetIndustriesResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetIndustriesResultInfo(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? industries,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            Industries = industries;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? Industries { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetIndustriesResultInfo(
                Industries,
                _entityIds,
                version);
        }
    }
}


// GetIndustriesResult.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetIndustriesResult
        : global::System.IEquatable<GetIndustriesResult>
        , IGetIndustriesResult
    {
        public GetIndustriesResult(global::System.Collections.Generic.IReadOnlyList<global::GqlDemo.Client.IGetIndustries_Industries?>? industries)
        {
            Industries = industries;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::GqlDemo.Client.IGetIndustries_Industries?>? Industries { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetIndustriesResult)obj);
        }

        public global::System.Boolean Equals(GetIndustriesResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Industries,
                        other.Industries));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Industries is null))
                {
                    foreach (var Industries_elm in Industries)
                    {
                        if (!(Industries_elm is null))
                        {
                            hash ^= 397 * Industries_elm.GetHashCode();
                        }
                    }
                }

                return hash;
            }
        }
    }
}


// GetIndustries_Industries_IndustryFromIndustryEntityMapper.cs
#nullable enable

namespace GqlDemo.Client.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetIndustries_Industries_IndustryFromIndustryEntityMapper
        : global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.IndustryEntity, GetIndustries_Industries_Industry>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;

        public GetIndustries_Industries_IndustryFromIndustryEntityMapper(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        public GetIndustries_Industries_Industry Map(
            global::GqlDemo.Client.State.IndustryEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetIndustries_Industries_Industry(
                entity.Id,
                entity.Name);
        }
    }
}


// GetIndustries_Industries_Industry.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetIndustries_Industries_Industry
        : global::System.IEquatable<GetIndustries_Industries_Industry>
        , IGetIndustries_Industries_Industry
    {
        public GetIndustries_Industries_Industry(
            global::System.Int32 id,
            global::System.String? name)
        {
            Id = id;
            Name = name;
        }

        public global::System.Int32 Id { get; }

        public global::System.String? Name { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetIndustries_Industries_Industry)obj);
        }

        public global::System.Boolean Equals(GetIndustries_Industries_Industry? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && ((Name is null && other.Name is null) ||Name != null && Name.Equals(other.Name));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                if (!(Name is null))
                {
                    hash ^= 397 * Name.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// IGetIndustriesResult.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetIndustriesResult
    {
        public global::System.Collections.Generic.IReadOnlyList<global::GqlDemo.Client.IGetIndustries_Industries?>? Industries { get; }
    }
}


// IGetIndustries_Industries.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetIndustries_Industries
        : IIndustry
    {
    }
}


// IGetIndustries_Industries_Industry.cs
#nullable enable

namespace GqlDemo.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetIndustries_Industries_Industry
        : IGetIndustries_Industries
    {
    }
}


// GetSharesQueryDocument.cs
#nullable enable

namespace GqlDemo.Client
{
    /// <summary>
    /// Represents the operation service of the GetShares GraphQL operation
    /// <code>
    /// query GetShares($first: Int, $last: Int) {
    ///   shares(first: $first, last: $last) {
    ///     __typename
    ///     totalCount
    ///     nodes {
    ///       __typename
    ///       ... Share
    ///       ... on Share {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment Share on Share {
    ///   id
    ///   companyName
    ///   value
    ///   industry {
    ///     __typename
    ///     ... Industry
    ///     ... on Industry {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment Industry on Industry {
    ///   id
    ///   name
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSharesQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetSharesQueryDocument()
        {
        }

        public static GetSharesQueryDocument Instance { get; } = new GetSharesQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x53, 0x68, 0x61, 0x72, 0x65, 0x73, 0x28, 0x24, 0x66, 0x69, 0x72, 0x73, 0x74, 0x3a, 0x20, 0x49, 0x6e, 0x74, 0x2c, 0x20, 0x24, 0x6c, 0x61, 0x73, 0x74, 0x3a, 0x20, 0x49, 0x6e, 0x74, 0x29, 0x20, 0x7b, 0x20, 0x73, 0x68, 0x61, 0x72, 0x65, 0x73, 0x28, 0x66, 0x69, 0x72, 0x73, 0x74, 0x3a, 0x20, 0x24, 0x66, 0x69, 0x72, 0x73, 0x74, 0x2c, 0x20, 0x6c, 0x61, 0x73, 0x74, 0x3a, 0x20, 0x24, 0x6c, 0x61, 0x73, 0x74, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x74, 0x6f, 0x74, 0x61, 0x6c, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x20, 0x6e, 0x6f, 0x64, 0x65, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x53, 0x68, 0x61, 0x72, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x68, 0x61, 0x72, 0x65, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x53, 0x68, 0x61, 0x72, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x68, 0x61, 0x72, 0x65, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x63, 0x6f, 0x6d, 0x70, 0x61, 0x6e, 0x79, 0x4e, 0x61, 0x6d, 0x65, 0x20, 0x76, 0x61, 0x6c, 0x75, 0x65, 0x20, 0x69, 0x6e, 0x64, 0x75, 0x73, 0x74, 0x72, 0x79, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x49, 0x6e, 0x64, 0x75, 0x73, 0x74, 0x72, 0x79, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x49, 0x6e, 0x64, 0x75, 0x73, 0x74, 0x72, 0x79, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x49, 0x6e, 0x64, 0x75, 0x73, 0x74, 0x72, 0x79, 0x20, 0x6f, 0x6e, 0x20, 0x49, 0x6e, 0x64, 0x75, 0x73, 0x74, 0x72, 0x79, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "668cf2a6991de3725f59aea8582c3bd92105b15c");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetSharesQuery.cs
#nullable enable

namespace GqlDemo.Client
{
    /// <summary>
    /// Represents the operation service of the GetShares GraphQL operation
    /// <code>
    /// query GetShares($first: Int, $last: Int) {
    ///   shares(first: $first, last: $last) {
    ///     __typename
    ///     totalCount
    ///     nodes {
    ///       __typename
    ///       ... Share
    ///       ... on Share {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment Share on Share {
    ///   id
    ///   companyName
    ///   value
    ///   industry {
    ///     __typename
    ///     ... Industry
    ///     ... on Industry {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment Industry on Industry {
    ///   id
    ///   name
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSharesQuery
        : global::GqlDemo.Client.IGetSharesQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetSharesResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _intFormatter;

        public GetSharesQuery(
            global::StrawberryShake.IOperationExecutor<IGetSharesResult> operationExecutor,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _intFormatter = serializerResolver.GetInputValueFormatter("Int");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetSharesResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetSharesResult>> ExecuteAsync(
            global::System.Int32? first,
            global::System.Int32? last,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(
                first,
                last);

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetSharesResult>> Watch(
            global::System.Int32? first,
            global::System.Int32? last,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(
                first,
                last);
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(
            global::System.Int32? first,
            global::System.Int32? last)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();

            variables.Add(
                "first",
                FormatFirst(first));
            variables.Add(
                "last",
                FormatLast(last));

            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetSharesQueryDocument.Instance.Hash.Value,
                name: "GetShares",
                document: GetSharesQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default,
                variables:variables);
        }

        private global::System.Object? FormatFirst(global::System.Int32? value)
        {
            if (!(value is null))
            {
                return _intFormatter.Format(value);
            }
            else
            {
                return value;
            }
        }

        private global::System.Object? FormatLast(global::System.Int32? value)
        {
            if (!(value is null))
            {
                return _intFormatter.Format(value);
            }
            else
            {
                return value;
            }
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }
}


// IGetSharesQuery.cs
#nullable enable

namespace GqlDemo.Client
{
    /// <summary>
    /// Represents the operation service of the GetShares GraphQL operation
    /// <code>
    /// query GetShares($first: Int, $last: Int) {
    ///   shares(first: $first, last: $last) {
    ///     __typename
    ///     totalCount
    ///     nodes {
    ///       __typename
    ///       ... Share
    ///       ... on Share {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment Share on Share {
    ///   id
    ///   companyName
    ///   value
    ///   industry {
    ///     __typename
    ///     ... Industry
    ///     ... on Industry {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment Industry on Industry {
    ///   id
    ///   name
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSharesQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetSharesResult>> ExecuteAsync(
            global::System.Int32? first,
            global::System.Int32? last,
            global::System.Threading.CancellationToken cancellationToken = default);

        global::System.IObservable<global::StrawberryShake.IOperationResult<IGetSharesResult>> Watch(
            global::System.Int32? first,
            global::System.Int32? last,
            global::StrawberryShake.ExecutionStrategy? strategy = null);
    }
}


// GetIndustriesQueryDocument.cs
#nullable enable

namespace GqlDemo.Client
{
    /// <summary>
    /// Represents the operation service of the GetIndustries GraphQL operation
    /// <code>
    /// query GetIndustries {
    ///   industries {
    ///     __typename
    ///     ... Industry
    ///     ... on Industry {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment Industry on Industry {
    ///   id
    ///   name
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetIndustriesQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetIndustriesQueryDocument()
        {
        }

        public static GetIndustriesQueryDocument Instance { get; } = new GetIndustriesQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x49, 0x6e, 0x64, 0x75, 0x73, 0x74, 0x72, 0x69, 0x65, 0x73, 0x20, 0x7b, 0x20, 0x69, 0x6e, 0x64, 0x75, 0x73, 0x74, 0x72, 0x69, 0x65, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x49, 0x6e, 0x64, 0x75, 0x73, 0x74, 0x72, 0x79, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x49, 0x6e, 0x64, 0x75, 0x73, 0x74, 0x72, 0x79, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x49, 0x6e, 0x64, 0x75, 0x73, 0x74, 0x72, 0x79, 0x20, 0x6f, 0x6e, 0x20, 0x49, 0x6e, 0x64, 0x75, 0x73, 0x74, 0x72, 0x79, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "b8357879bff3049cd7f03551f2d8a21b1c43eb99");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetIndustriesQuery.cs
#nullable enable

namespace GqlDemo.Client
{
    /// <summary>
    /// Represents the operation service of the GetIndustries GraphQL operation
    /// <code>
    /// query GetIndustries {
    ///   industries {
    ///     __typename
    ///     ... Industry
    ///     ... on Industry {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment Industry on Industry {
    ///   id
    ///   name
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetIndustriesQuery
        : global::GqlDemo.Client.IGetIndustriesQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetIndustriesResult> _operationExecutor;

        public GetIndustriesQuery(global::StrawberryShake.IOperationExecutor<IGetIndustriesResult> operationExecutor)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetIndustriesResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetIndustriesResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest();

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetIndustriesResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {

            return CreateRequest(null);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetIndustriesQueryDocument.Instance.Hash.Value,
                name: "GetIndustries",
                document: GetIndustriesQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest();
        }
    }
}


// IGetIndustriesQuery.cs
#nullable enable

namespace GqlDemo.Client
{
    /// <summary>
    /// Represents the operation service of the GetIndustries GraphQL operation
    /// <code>
    /// query GetIndustries {
    ///   industries {
    ///     __typename
    ///     ... Industry
    ///     ... on Industry {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment Industry on Industry {
    ///   id
    ///   name
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetIndustriesQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetIndustriesResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default);

        global::System.IObservable<global::StrawberryShake.IOperationResult<IGetIndustriesResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null);
    }
}


// GetSharesBuilder.cs
#nullable enable

namespace GqlDemo.Client.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSharesBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::GqlDemo.Client.IGetSharesResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::GqlDemo.Client.IGetSharesResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Decimal, global::System.Decimal> _decimalParser;

        public GetSharesBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::GqlDemo.Client.IGetSharesResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _decimalParser = serializerResolver.GetLeafValueParser<global::System.Decimal, global::System.Decimal>("Decimal")
                 ?? throw new global::System.ArgumentException("No serializer for type `Decimal` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetSharesResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetSharesResult Result, GetSharesResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            try
            {
                if (response.Body != null)
                {
                    if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        data = BuildData(dataElement);
                    }
                    if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                    {
                        errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                    }
                }
            }
            catch(global::System.Exception ex)
            {
                errors = new global::StrawberryShake.IClientError[] {
                    new global::StrawberryShake.ClientError(
                        ex.Message,
                        exception: ex)
                };
            }

            return new global::StrawberryShake.OperationResult<IGetSharesResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetSharesResult, GetSharesResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::GqlDemo.Client.State.ShareConnectionData? sharesId = default!;
            _entityStore.Update(session => 
            {
                sharesId = DeserializeIGetShares_Shares(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "shares"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetSharesResultInfo(
                sharesId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::GqlDemo.Client.State.ShareConnectionData? DeserializeIGetShares_Shares(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("ShareConnection", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::GqlDemo.Client.State.ShareConnectionData(
                    typename,
                    totalCount: DeserializeNonNullableInt32(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "totalCount")),
                    nodes: UpdateIGetShares_Shares_NodesEntityArray(
                        session,
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "nodes"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? UpdateIGetShares_Shares_NodesEntityArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var shares = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                shares.Add(UpdateIGetShares_Shares_NodesEntity(
                    session,
                    child,
                    entityIds));
            }

            return shares;
        }

        private global::StrawberryShake.EntityId? UpdateIGetShares_Shares_NodesEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Share",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::GqlDemo.Client.State.ShareEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::GqlDemo.Client.State.ShareEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "companyName")),
                            DeserializeNonNullableDecimal(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "value")),
                            UpdateIGetShares_Shares_Nodes_IndustryEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "industry"),
                                entityIds)));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::GqlDemo.Client.State.ShareEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "companyName")),
                            DeserializeNonNullableDecimal(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "value")),
                            UpdateIGetShares_Shares_Nodes_IndustryEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "industry"),
                                entityIds)));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.String? DeserializeString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Decimal DeserializeNonNullableDecimal(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _decimalParser.Parse(obj.Value.GetDecimal()!);
        }

        private global::StrawberryShake.EntityId? UpdateIGetShares_Shares_Nodes_IndustryEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Industry",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::GqlDemo.Client.State.IndustryEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::GqlDemo.Client.State.IndustryEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::GqlDemo.Client.State.IndustryEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }
    }
}


// GetIndustriesBuilder.cs
#nullable enable

namespace GqlDemo.Client.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetIndustriesBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::GqlDemo.Client.IGetIndustriesResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::GqlDemo.Client.IGetIndustriesResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;

        public GetIndustriesBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::GqlDemo.Client.IGetIndustriesResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetIndustriesResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetIndustriesResult Result, GetIndustriesResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            try
            {
                if (response.Body != null)
                {
                    if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        data = BuildData(dataElement);
                    }
                    if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                    {
                        errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                    }
                }
            }
            catch(global::System.Exception ex)
            {
                errors = new global::StrawberryShake.IClientError[] {
                    new global::StrawberryShake.ClientError(
                        ex.Message,
                        exception: ex)
                };
            }

            return new global::StrawberryShake.OperationResult<IGetIndustriesResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetIndustriesResult, GetIndustriesResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? industriesId = default!;
            _entityStore.Update(session => 
            {
                industriesId = UpdateIGetIndustries_IndustriesEntityArray(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "industries"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetIndustriesResultInfo(
                industriesId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? UpdateIGetIndustries_IndustriesEntityArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var industrys = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                industrys.Add(UpdateIGetIndustries_IndustriesEntity(
                    session,
                    child,
                    entityIds));
            }

            return industrys;
        }

        private global::StrawberryShake.EntityId? UpdateIGetIndustries_IndustriesEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Industry",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::GqlDemo.Client.State.IndustryEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::GqlDemo.Client.State.IndustryEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::GqlDemo.Client.State.IndustryEntity(
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }

        private global::System.String? DeserializeString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }
    }
}


// ShareConnectionData.cs
#nullable enable

namespace GqlDemo.Client.State
{
    /// <summary>
    /// A connection to a list of items.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class ShareConnectionData
    {
        public ShareConnectionData(
            global::System.String __typename,
            global::System.Int32? totalCount = null,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? nodes = null)
        {
            this.__typename = __typename
                 ?? throw new global::System.ArgumentNullException(nameof(__typename));
            TotalCount = totalCount;
            Nodes = nodes;
        }

        public global::System.String __typename { get; }

        public global::System.Int32? TotalCount { get; }

        /// <summary>
        /// A flattened list of the nodes.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? Nodes { get; }
    }
}


// SharesClient.cs
#nullable enable

namespace GqlDemo.Client
{
    /// <summary>
    /// Represents the SharesClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SharesClient
        : global::GqlDemo.Client.ISharesClient
    {
        private readonly global::GqlDemo.Client.IGetSharesQuery _getShares;
        private readonly global::GqlDemo.Client.IGetIndustriesQuery _getIndustries;

        public SharesClient(
            global::GqlDemo.Client.IGetSharesQuery getShares,
            global::GqlDemo.Client.IGetIndustriesQuery getIndustries)
        {
            _getShares = getShares
                 ?? throw new global::System.ArgumentNullException(nameof(getShares));
            _getIndustries = getIndustries
                 ?? throw new global::System.ArgumentNullException(nameof(getIndustries));
        }

        public static global::System.String ClientName => "SharesClient";

        public global::GqlDemo.Client.IGetSharesQuery GetShares => _getShares;

        public global::GqlDemo.Client.IGetIndustriesQuery GetIndustries => _getIndustries;
    }
}


// ISharesClient.cs
#nullable enable

namespace GqlDemo.Client
{
    /// <summary>
    /// Represents the SharesClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface ISharesClient
    {
        global::GqlDemo.Client.IGetSharesQuery GetShares { get; }

        global::GqlDemo.Client.IGetIndustriesQuery GetIndustries { get; }
    }
}


// SharesClientEntityIdFactory.cs
#nullable enable

namespace GqlDemo.Client.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SharesClientEntityIdFactory
        : global::StrawberryShake.IEntityIdSerializer
    {
        private static readonly global::System.Text.Json.JsonWriterOptions _options = new global::System.Text.Json.JsonWriterOptions(){ Indented = false };

        public global::StrawberryShake.EntityId Parse(global::System.Text.Json.JsonElement obj)
        {
            global::System.String __typename = obj
                .GetProperty("__typename")
                .GetString()!;

            return __typename switch
            {
                "Share" => ParseShareEntityId(
                    obj,
                    __typename),
                "Industry" => ParseIndustryEntityId(
                    obj,
                    __typename),
                _ => throw new global::System.NotSupportedException()
            };
        }

        public global::System.String Format(global::StrawberryShake.EntityId entityId)
        {
            return entityId.Name switch
            {
                "Share" => FormatShareEntityId(entityId),
                "Industry" => FormatIndustryEntityId(entityId),
                _ => throw new global::System.NotSupportedException()
            };
        }

        private global::StrawberryShake.EntityId ParseShareEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetInt32()!);
        }

        private global::System.String FormatShareEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteNumber(
                "id",
                (global::System.Int32)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseIndustryEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetInt32()!);
        }

        private global::System.String FormatIndustryEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteNumber(
                "id",
                (global::System.Int32)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }
    }
}


// SharesClientServiceCollectionExtensions.cs
#nullable enable

namespace Microsoft.Extensions.DependencyInjection
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public static partial class SharesClientServiceCollectionExtensions
    {
        public static global::StrawberryShake.IClientBuilder<global::GqlDemo.Client.State.SharesClientStoreAccessor> AddSharesClient(
            this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var serviceCollection = ConfigureClientDefault(
                        sp,
                        strategy);

                    return new ClientServiceProvider(
                        global::Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(serviceCollection));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => new global::GqlDemo.Client.State.SharesClientStoreAccessor(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityIdSerializer>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory>>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory>>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp))));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GqlDemo.Client.GetSharesQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GqlDemo.Client.GetIndustriesQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GqlDemo.Client.SharesClient>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GqlDemo.Client.ISharesClient>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            return new global::StrawberryShake.ClientBuilder<global::GqlDemo.Client.State.SharesClientStoreAccessor>(
                "SharesClient",
                services);
        }

        private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureClientDefault(
            global::System.IServiceProvider parentServices,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            var services = new global::Microsoft.Extensions.DependencyInjection.ServiceCollection();
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IEntityStore, global::StrawberryShake.EntityStore>(services);
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IOperationStore>(
                services,
                sp => new global::StrawberryShake.OperationStore(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var clientFactory = global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Net.Http.IHttpClientFactory>(parentServices);
                    return new global::StrawberryShake.Transport.Http.HttpConnection(() => clientFactory.CreateClient("SharesClient"));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.ShareEntity, global::GqlDemo.Client.GetShares_Shares_Nodes_Share>, global::GqlDemo.Client.State.GetShares_Shares_Nodes_ShareFromShareEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.IndustryEntity, global::GqlDemo.Client.GetShares_Shares_Nodes_Industry_Industry>, global::GqlDemo.Client.State.GetShares_Shares_Nodes_Industry_IndustryFromIndustryEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::GqlDemo.Client.State.IndustryEntity, global::GqlDemo.Client.GetIndustries_Industries_Industry>, global::GqlDemo.Client.State.GetIndustries_Industries_IndustryFromIndustryEntityMapper>(services);

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.StringSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.BooleanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ShortSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IntSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.LongSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.FloatSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DecimalSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UrlSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UuidSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IdSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateTimeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteArraySerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.TimeSpanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializerResolver>(
                services,
                sp => new global::StrawberryShake.Serialization.SerializerResolver(
                    global::System.Linq.Enumerable.Concat(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            parentServices),
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            sp))));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::GqlDemo.Client.IGetSharesResult>, global::GqlDemo.Client.State.GetSharesResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::GqlDemo.Client.IGetSharesResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GqlDemo.Client.IGetSharesQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::GqlDemo.Client.IGetSharesResult>, global::GqlDemo.Client.State.GetSharesBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::GqlDemo.Client.IGetSharesResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::GqlDemo.Client.IGetSharesResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::GqlDemo.Client.IGetSharesResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::GqlDemo.Client.GetSharesQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::GqlDemo.Client.IGetSharesQuery>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GqlDemo.Client.GetSharesQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::GqlDemo.Client.IGetIndustriesResult>, global::GqlDemo.Client.State.GetIndustriesResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::GqlDemo.Client.IGetIndustriesResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GqlDemo.Client.IGetIndustriesQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::GqlDemo.Client.IGetIndustriesResult>, global::GqlDemo.Client.State.GetIndustriesBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::GqlDemo.Client.IGetIndustriesResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::GqlDemo.Client.IGetIndustriesResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::GqlDemo.Client.IGetIndustriesResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::GqlDemo.Client.GetIndustriesQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::GqlDemo.Client.IGetIndustriesQuery>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GqlDemo.Client.GetIndustriesQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityIdSerializer, global::GqlDemo.Client.State.SharesClientEntityIdFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::GqlDemo.Client.SharesClient>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::GqlDemo.Client.ISharesClient>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GqlDemo.Client.SharesClient>(sp));
            return services;
        }

        private class ClientServiceProvider
            : System.IServiceProvider
            , System.IDisposable
        {
            private readonly System.IServiceProvider _provider;

            public ClientServiceProvider(System.IServiceProvider provider)
            {
                _provider = provider;
            }

            public object? GetService(System.Type serviceType)
            {
                return _provider.GetService(serviceType);
            }

            public void Dispose()
            {
                if (_provider is System.IDisposable d)
                {
                    d.Dispose();
                }
            }
        }
    }
}


// SharesClientStoreAccessor.cs
#nullable enable

namespace GqlDemo.Client.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SharesClientStoreAccessor
        : global::StrawberryShake.StoreAccessor
    {
        public SharesClientStoreAccessor(
            global::StrawberryShake.IOperationStore operationStore,
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer entityIdSerializer,
            global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory> requestFactories,
            global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory> resultDataFactories)
            : base(
                operationStore,
                entityStore,
                entityIdSerializer,
                requestFactories,
                resultDataFactories)
        {
        }
    }
}


