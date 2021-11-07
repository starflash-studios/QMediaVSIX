using System.Runtime.CompilerServices;

namespace QMediaVSIX.Core.Collections;

public class KeyNullException : ArgumentNullException {
	public KeyNullException( [CallerMemberName] string ParamName = null! ) : base(ParamName, "Key may not be null.") { }
}