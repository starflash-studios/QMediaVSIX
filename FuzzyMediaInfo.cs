#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;

using Windows.Media.Control;

using GSMTCMediaProperties = Windows.Media.Control.GlobalSystemMediaTransportControlsSessionMediaProperties;
using GSMTCSession = Windows.Media.Control.GlobalSystemMediaTransportControlsSession;
using GSMTCSessionManager = Windows.Media.Control.GlobalSystemMediaTransportControlsSessionManager;

namespace QMediaVSIX.Commands {
    public readonly struct FuzzyMediaInfo : IEquatable<FuzzyMediaInfo> {
        public readonly string? Title, Artist;
        public readonly GlobalSystemMediaTransportControlsSessionPlaybackStatus? Status;
        public readonly TimeSpan? CurrentTime, EndTime;
        readonly bool _SuccessfullyGenerated;

        FuzzyMediaInfo(string? Title, string? Artist, GlobalSystemMediaTransportControlsSessionPlaybackStatus? Status, TimeSpan? CurrentTime, TimeSpan? EndTime, bool SuccessfullyGenerated) {
            this.Title = Title;
            this.Artist = Artist;
            this.Status = Status;
            this.CurrentTime = CurrentTime;
            this.EndTime = EndTime;
            _SuccessfullyGenerated = SuccessfullyGenerated;
        }

        public FuzzyMediaInfo(string? Title, string? Artist, GlobalSystemMediaTransportControlsSessionPlaybackStatus? Status, TimeSpan? CurrentTime, TimeSpan? EndTime) : this(Title, Artist, Status, CurrentTime, EndTime, true) { }

        public static async Task<FuzzyMediaInfo> GetAsync(GSMTCSessionManager? Manager ) => (await GetAsyncEx(Manager)).Item1;

        [SuppressMessage("Style", "VSTHRD200:Use \"Async\" suffix for async methods", Justification = "<Pending>")]
        public static async Task<(FuzzyMediaInfo, GSMTCSession?, GSMTCMediaProperties?)> GetAsyncEx(GSMTCSessionManager? Manager) {
            GSMTCSession? Session = Manager?.GetCurrentSession();
            if (Manager == null || Session == null) { return (new FuzzyMediaInfo(null, null, null, null, null, false), null, null); }
            GSMTCMediaProperties? Props = await Session.TryGetMediaPropertiesAsync();
            GlobalSystemMediaTransportControlsSessionTimelineProperties? TimeProps = Session.GetTimelineProperties();
            return (new FuzzyMediaInfo(Props?.Title, Props?.Artist, Session.GetPlaybackInfo()?.PlaybackStatus, TimeProps?.Position, TimeProps?.EndTime, Session != null), Session, Props);
        }

        public override bool Equals(object? Obj) => Obj is FuzzyMediaInfo Info && Equals(Info);

        /// <inheritdoc />
        public override int GetHashCode() {
            unchecked {
                int HashCode = (Title != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(Title) : 0);
                HashCode = (HashCode * 397) ^ (Artist != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(Artist) : 0);
                HashCode = (HashCode * 397) ^ Status.GetHashCode();
                //HashCode = (HashCode * 397) ^ CurrentTime.GetHashCode();
                HashCode = (HashCode * 397) ^ EndTime.GetHashCode();
                HashCode = (HashCode * 397) ^ _SuccessfullyGenerated.GetHashCode();
                return HashCode;
            }
        }

        public bool Equals(FuzzyMediaInfo Other) =>
            Title  == Other.Title  &&
            Artist == Other.Artist &&
            Status == Other.Status &&
            //CurrentTime            == Other.CurrentTime &&
            EndTime                == Other.EndTime &&
            _SuccessfullyGenerated == Other._SuccessfullyGenerated;

        public static bool operator ==(FuzzyMediaInfo Left, FuzzyMediaInfo Right) => Left.Equals(Right);

        public static bool operator !=(FuzzyMediaInfo Left, FuzzyMediaInfo Right) => !(Left == Right);

        public string GetHeading() {
            if (!_SuccessfullyGenerated) { return "#GEN/NULL!"; }

            StringBuilder SB = new StringBuilder();
            if (Artist != null) {
                SB.Append(Artist);
                SB.Append(" - ");
            }

            SB.Append(Title ?? "#TITLE/NULL!");
            return SB.ToString();
        }

        public string GetSubheading() {
            if (!_SuccessfullyGenerated) { return "#GEN/NULL!"; }

            bool Any = false;
            StringBuilder SB = new StringBuilder();
            if (CurrentTime.HasValue) {
                SB.Append(CurrentTime.Value.ToString("g"));
                Any = true;
            }

            if (EndTime.HasValue) {
                SB.Append(" / ");
                SB.Append(EndTime.Value.ToString("g"));
                Any = true;
            }

            if (!Any) { SB.Append("#TIME/ALL/NULL!"); }
            return SB.ToString();
        }

        public override string ToString() => GetHeading();
    }
}