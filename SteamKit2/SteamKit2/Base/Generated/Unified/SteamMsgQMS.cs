// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_qms.steamclient.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Unified.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class GameSearchParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string key_name
        {
            get { return __pbn__key_name ?? ""; }
            set { __pbn__key_name = value; }
        }
        public bool ShouldSerializekey_name() => __pbn__key_name != null;
        public void Resetkey_name() => __pbn__key_name = null;
        private string __pbn__key_name;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<string> value { get; } = new global::System.Collections.Generic.List<string>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQueuedMatchmaking_SearchForGame_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(EGameSearchAction.k_EGameSearchAction_None)]
        public EGameSearchAction action
        {
            get { return __pbn__action ?? EGameSearchAction.k_EGameSearchAction_None; }
            set { __pbn__action = value; }
        }
        public bool ShouldSerializeaction() => __pbn__action != null;
        public void Resetaction() => __pbn__action = null;
        private EGameSearchAction? __pbn__action;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<GameSearchParam> @params { get; } = new global::System.Collections.Generic.List<GameSearchParam>();

        [global::ProtoBuf.ProtoMember(4)]
        public uint player_min
        {
            get { return __pbn__player_min.GetValueOrDefault(); }
            set { __pbn__player_min = value; }
        }
        public bool ShouldSerializeplayer_min() => __pbn__player_min != null;
        public void Resetplayer_min() => __pbn__player_min = null;
        private uint? __pbn__player_min;

        [global::ProtoBuf.ProtoMember(5)]
        public uint player_max
        {
            get { return __pbn__player_max.GetValueOrDefault(); }
            set { __pbn__player_max = value; }
        }
        public bool ShouldSerializeplayer_max() => __pbn__player_max != null;
        public void Resetplayer_max() => __pbn__player_max = null;
        private uint? __pbn__player_max;

        [global::ProtoBuf.ProtoMember(6, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamidlobby
        {
            get { return __pbn__steamidlobby.GetValueOrDefault(); }
            set { __pbn__steamidlobby = value; }
        }
        public bool ShouldSerializesteamidlobby() => __pbn__steamidlobby != null;
        public void Resetsteamidlobby() => __pbn__steamidlobby = null;
        private ulong? __pbn__steamidlobby;

        [global::ProtoBuf.ProtoMember(7)]
        public ulong searchid
        {
            get { return __pbn__searchid.GetValueOrDefault(); }
            set { __pbn__searchid = value; }
        }
        public bool ShouldSerializesearchid() => __pbn__searchid != null;
        public void Resetsearchid() => __pbn__searchid = null;
        private ulong? __pbn__searchid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQueuedMatchmaking_SearchForGame_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(EGameSearchResult.k_EGameSearchResult_Invalid)]
        public EGameSearchResult gamesearchresult
        {
            get { return __pbn__gamesearchresult ?? EGameSearchResult.k_EGameSearchResult_Invalid; }
            set { __pbn__gamesearchresult = value; }
        }
        public bool ShouldSerializegamesearchresult() => __pbn__gamesearchresult != null;
        public void Resetgamesearchresult() => __pbn__gamesearchresult = null;
        private EGameSearchResult? __pbn__gamesearchresult;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong searchid
        {
            get { return __pbn__searchid.GetValueOrDefault(); }
            set { __pbn__searchid = value; }
        }
        public bool ShouldSerializesearchid() => __pbn__searchid != null;
        public void Resetsearchid() => __pbn__searchid = null;
        private ulong? __pbn__searchid;

        [global::ProtoBuf.ProtoMember(3)]
        public uint seconds_time_estimate
        {
            get { return __pbn__seconds_time_estimate.GetValueOrDefault(); }
            set { __pbn__seconds_time_estimate = value; }
        }
        public bool ShouldSerializeseconds_time_estimate() => __pbn__seconds_time_estimate != null;
        public void Resetseconds_time_estimate() => __pbn__seconds_time_estimate = null;
        private uint? __pbn__seconds_time_estimate;

        [global::ProtoBuf.ProtoMember(4)]
        public uint poll_frequency
        {
            get { return __pbn__poll_frequency.GetValueOrDefault(); }
            set { __pbn__poll_frequency = value; }
        }
        public bool ShouldSerializepoll_frequency() => __pbn__poll_frequency != null;
        public void Resetpoll_frequency() => __pbn__poll_frequency = null;
        private uint? __pbn__poll_frequency;

        [global::ProtoBuf.ProtoMember(5)]
        public uint count_searching
        {
            get { return __pbn__count_searching.GetValueOrDefault(); }
            set { __pbn__count_searching = value; }
        }
        public bool ShouldSerializecount_searching() => __pbn__count_searching != null;
        public void Resetcount_searching() => __pbn__count_searching = null;
        private uint? __pbn__count_searching;

        [global::ProtoBuf.ProtoMember(6)]
        public uint players_in_match
        {
            get { return __pbn__players_in_match.GetValueOrDefault(); }
            set { __pbn__players_in_match = value; }
        }
        public bool ShouldSerializeplayers_in_match() => __pbn__players_in_match != null;
        public void Resetplayers_in_match() => __pbn__players_in_match = null;
        private uint? __pbn__players_in_match;

        [global::ProtoBuf.ProtoMember(7)]
        public uint players_accepted
        {
            get { return __pbn__players_accepted.GetValueOrDefault(); }
            set { __pbn__players_accepted = value; }
        }
        public bool ShouldSerializeplayers_accepted() => __pbn__players_accepted != null;
        public void Resetplayers_accepted() => __pbn__players_accepted = null;
        private uint? __pbn__players_accepted;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue("")]
        public string connect_string
        {
            get { return __pbn__connect_string ?? ""; }
            set { __pbn__connect_string = value; }
        }
        public bool ShouldSerializeconnect_string() => __pbn__connect_string != null;
        public void Resetconnect_string() => __pbn__connect_string = null;
        private string __pbn__connect_string;

        [global::ProtoBuf.ProtoMember(10, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamidhost
        {
            get { return __pbn__steamidhost.GetValueOrDefault(); }
            set { __pbn__steamidhost = value; }
        }
        public bool ShouldSerializesteamidhost() => __pbn__steamidhost != null;
        public void Resetsteamidhost() => __pbn__steamidhost = null;
        private ulong? __pbn__steamidhost;

        [global::ProtoBuf.ProtoMember(11)]
        public uint rtime_match_made
        {
            get { return __pbn__rtime_match_made.GetValueOrDefault(); }
            set { __pbn__rtime_match_made = value; }
        }
        public bool ShouldSerializertime_match_made() => __pbn__rtime_match_made != null;
        public void Resetrtime_match_made() => __pbn__rtime_match_made = null;
        private uint? __pbn__rtime_match_made;

        [global::ProtoBuf.ProtoMember(12)]
        public uint rtime_now
        {
            get { return __pbn__rtime_now.GetValueOrDefault(); }
            set { __pbn__rtime_now = value; }
        }
        public bool ShouldSerializertime_now() => __pbn__rtime_now != null;
        public void Resetrtime_now() => __pbn__rtime_now = null;
        private uint? __pbn__rtime_now;

        [global::ProtoBuf.ProtoMember(13, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid_canceled_search
        {
            get { return __pbn__steamid_canceled_search.GetValueOrDefault(); }
            set { __pbn__steamid_canceled_search = value; }
        }
        public bool ShouldSerializesteamid_canceled_search() => __pbn__steamid_canceled_search != null;
        public void Resetsteamid_canceled_search() => __pbn__steamid_canceled_search = null;
        private ulong? __pbn__steamid_canceled_search;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQueuedMatchmakingGameHost_SearchForPlayers_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(EGameSearchAction.k_EGameSearchAction_None)]
        public EGameSearchAction action
        {
            get { return __pbn__action ?? EGameSearchAction.k_EGameSearchAction_None; }
            set { __pbn__action = value; }
        }
        public bool ShouldSerializeaction() => __pbn__action != null;
        public void Resetaction() => __pbn__action = null;
        private EGameSearchAction? __pbn__action;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<GameSearchParam> @params { get; } = new global::System.Collections.Generic.List<GameSearchParam>();

        [global::ProtoBuf.ProtoMember(4)]
        public uint player_min
        {
            get { return __pbn__player_min.GetValueOrDefault(); }
            set { __pbn__player_min = value; }
        }
        public bool ShouldSerializeplayer_min() => __pbn__player_min != null;
        public void Resetplayer_min() => __pbn__player_min = null;
        private uint? __pbn__player_min;

        [global::ProtoBuf.ProtoMember(5)]
        public uint player_max
        {
            get { return __pbn__player_max.GetValueOrDefault(); }
            set { __pbn__player_max = value; }
        }
        public bool ShouldSerializeplayer_max() => __pbn__player_max != null;
        public void Resetplayer_max() => __pbn__player_max = null;
        private uint? __pbn__player_max;

        [global::ProtoBuf.ProtoMember(6)]
        public uint player_max_team_size
        {
            get { return __pbn__player_max_team_size.GetValueOrDefault(); }
            set { __pbn__player_max_team_size = value; }
        }
        public bool ShouldSerializeplayer_max_team_size() => __pbn__player_max_team_size != null;
        public void Resetplayer_max_team_size() => __pbn__player_max_team_size = null;
        private uint? __pbn__player_max_team_size;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue("")]
        public string connection_string
        {
            get { return __pbn__connection_string ?? ""; }
            set { __pbn__connection_string = value; }
        }
        public bool ShouldSerializeconnection_string() => __pbn__connection_string != null;
        public void Resetconnection_string() => __pbn__connection_string = null;
        private string __pbn__connection_string;

        [global::ProtoBuf.ProtoMember(8)]
        public ulong searchid
        {
            get { return __pbn__searchid.GetValueOrDefault(); }
            set { __pbn__searchid = value; }
        }
        public bool ShouldSerializesearchid() => __pbn__searchid != null;
        public void Resetsearchid() => __pbn__searchid = null;
        private ulong? __pbn__searchid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PlayerFound : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(EGameSearchAction.k_EGameSearchAction_None)]
        public EGameSearchAction action
        {
            get { return __pbn__action ?? EGameSearchAction.k_EGameSearchAction_None; }
            set { __pbn__action = value; }
        }
        public bool ShouldSerializeaction() => __pbn__action != null;
        public void Resetaction() => __pbn__action = null;
        private EGameSearchAction? __pbn__action;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<GameSearchParam> @params { get; } = new global::System.Collections.Generic.List<GameSearchParam>();

        [global::ProtoBuf.ProtoMember(4)]
        public uint team_number
        {
            get { return __pbn__team_number.GetValueOrDefault(); }
            set { __pbn__team_number = value; }
        }
        public bool ShouldSerializeteam_number() => __pbn__team_number != null;
        public void Resetteam_number() => __pbn__team_number = null;
        private uint? __pbn__team_number;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQueuedMatchmakingGameHost_SearchForPlayers_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(EGameSearchResult.k_EGameSearchResult_Invalid)]
        public EGameSearchResult gamesearchresult
        {
            get { return __pbn__gamesearchresult ?? EGameSearchResult.k_EGameSearchResult_Invalid; }
            set { __pbn__gamesearchresult = value; }
        }
        public bool ShouldSerializegamesearchresult() => __pbn__gamesearchresult != null;
        public void Resetgamesearchresult() => __pbn__gamesearchresult = null;
        private EGameSearchResult? __pbn__gamesearchresult;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong searchid
        {
            get { return __pbn__searchid.GetValueOrDefault(); }
            set { __pbn__searchid = value; }
        }
        public bool ShouldSerializesearchid() => __pbn__searchid != null;
        public void Resetsearchid() => __pbn__searchid = null;
        private ulong? __pbn__searchid;

        [global::ProtoBuf.ProtoMember(3)]
        public uint poll_frequency
        {
            get { return __pbn__poll_frequency.GetValueOrDefault(); }
            set { __pbn__poll_frequency = value; }
        }
        public bool ShouldSerializepoll_frequency() => __pbn__poll_frequency != null;
        public void Resetpoll_frequency() => __pbn__poll_frequency = null;
        private uint? __pbn__poll_frequency;

        [global::ProtoBuf.ProtoMember(4)]
        public ulong matchid
        {
            get { return __pbn__matchid.GetValueOrDefault(); }
            set { __pbn__matchid = value; }
        }
        public bool ShouldSerializematchid() => __pbn__matchid != null;
        public void Resetmatchid() => __pbn__matchid = null;
        private ulong? __pbn__matchid;

        [global::ProtoBuf.ProtoMember(5)]
        public global::System.Collections.Generic.List<PlayerFound> players { get; } = new global::System.Collections.Generic.List<PlayerFound>();

        [global::ProtoBuf.ProtoMember(6)]
        public uint rtime_match_made
        {
            get { return __pbn__rtime_match_made.GetValueOrDefault(); }
            set { __pbn__rtime_match_made = value; }
        }
        public bool ShouldSerializertime_match_made() => __pbn__rtime_match_made != null;
        public void Resetrtime_match_made() => __pbn__rtime_match_made = null;
        private uint? __pbn__rtime_match_made;

        [global::ProtoBuf.ProtoMember(7)]
        public uint rtime_now
        {
            get { return __pbn__rtime_now.GetValueOrDefault(); }
            set { __pbn__rtime_now = value; }
        }
        public bool ShouldSerializertime_now() => __pbn__rtime_now != null;
        public void Resetrtime_now() => __pbn__rtime_now = null;
        private uint? __pbn__rtime_now;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PlayerResult : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong steamid
        {
            get { return __pbn__steamid.GetValueOrDefault(); }
            set { __pbn__steamid = value; }
        }
        public bool ShouldSerializesteamid() => __pbn__steamid != null;
        public void Resetsteamid() => __pbn__steamid = null;
        private ulong? __pbn__steamid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint value
        {
            get { return __pbn__value.GetValueOrDefault(); }
            set { __pbn__value = value; }
        }
        public bool ShouldSerializevalue() => __pbn__value != null;
        public void Resetvalue() => __pbn__value = null;
        private uint? __pbn__value;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQueuedMatchmakingGameHost_SubmitPlayerResult_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong matchid
        {
            get { return __pbn__matchid.GetValueOrDefault(); }
            set { __pbn__matchid = value; }
        }
        public bool ShouldSerializematchid() => __pbn__matchid != null;
        public void Resetmatchid() => __pbn__matchid = null;
        private ulong? __pbn__matchid;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<PlayerResult> player_results { get; } = new global::System.Collections.Generic.List<PlayerResult>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQueuedMatchmakingGameHost_SubmitPlayerResult_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQueuedMatchmakingGameHost_EndGame_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get { return __pbn__appid.GetValueOrDefault(); }
            set { __pbn__appid = value; }
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong matchid
        {
            get { return __pbn__matchid.GetValueOrDefault(); }
            set { __pbn__matchid = value; }
        }
        public bool ShouldSerializematchid() => __pbn__matchid != null;
        public void Resetmatchid() => __pbn__matchid = null;
        private ulong? __pbn__matchid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CQueuedMatchmakingGameHost_EndGame_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public enum EGameSearchAction
    {
        k_EGameSearchAction_None = 0,
        k_EGameSearchAction_Accept = 1,
        k_EGameSearchAction_Decline = 2,
        k_EGameSearchAction_Cancel = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EGameSearchResult
    {
        k_EGameSearchResult_Invalid = 0,
        k_EGameSearchResult_SearchInProgress = 1,
        k_EGameSearchResult_SearchFailedNoHosts = 2,
        k_EGameSearchResult_SearchGameFound = 3,
        k_EGameSearchResult_SearchCompleteAccepted = 4,
        k_EGameSearchResult_SearchCompleteDeclined = 5,
        k_EGameSearchResult_SearchCanceled = 6,
    }

    public interface IQueuedMatchmaking
    {
        CQueuedMatchmaking_SearchForGame_Response SearchForGame(CQueuedMatchmaking_SearchForGame_Request request);
    }

    public interface IQueuedMatchmakingGameHost
    {
        CQueuedMatchmakingGameHost_SearchForPlayers_Response SearchForPlayers(CQueuedMatchmakingGameHost_SearchForPlayers_Request request);
        CQueuedMatchmakingGameHost_SubmitPlayerResult_Response SubmitPlayerResult(CQueuedMatchmakingGameHost_SubmitPlayerResult_Request request);
        CQueuedMatchmakingGameHost_EndGame_Response EndGame(CQueuedMatchmakingGameHost_EndGame_Request request);
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
