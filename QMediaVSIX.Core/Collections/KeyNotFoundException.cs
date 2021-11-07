namespace QMediaVSIX.Core.Collections;

public class KeyNotFoundException : System.Collections.Generic.KeyNotFoundException {
	public KeyNotFoundException( object? Key ) : base($"Key {Key?.ToString() ?? "<NULL>"} was not found.") { }
}