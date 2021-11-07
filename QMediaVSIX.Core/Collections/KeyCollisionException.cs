namespace QMediaVSIX.Core.Collections;

public class KeyCollisionException : ArgumentException {

	public KeyCollisionException( object? Key ) : base($"Key {Key?.ToString() ?? "<NULL>"} already exists in the dictionary.") { }
}