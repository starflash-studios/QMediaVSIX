using System.ComponentModel.Design;

using Microsoft.VisualStudio.Shell;

namespace QMediaVSIX.Commands; 

public class DynamicItemMenuCommand : OleMenuCommand {
	readonly Predicate<int> _Matches;

	public DynamicItemMenuCommand( CommandID RootId, Predicate<int> Matches, EventHandler InvokeHandler, EventHandler BeforeQueryStatusHandler )
		: base(InvokeHandler, null /*changeHandler*/, BeforeQueryStatusHandler, RootId) {
		_Matches = Matches ?? throw new ArgumentNullException(nameof(Matches));
	}

	public override bool DynamicItemMatch( int CMDID ) {
		// Call the supplied predicate to test whether the given CMDID is a match.
		// If it is, store the command id in MatchedCommandID
		// for use by any BeforeQueryStatus handlers, and then return that it is a match.
		// Otherwise clear any previously stored matched CMDID and return that it is not a match.
		if ( _Matches(CMDID) ) {
			MatchedCommandId = CMDID;
			return true;
		}

		MatchedCommandId = 0;
		return false;
	}
}