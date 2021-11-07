// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Uri
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Defines an object that represents a Uniform Resource Identifier (URI) value and parses it into components. The Uri object is used by many other Windows Runtime APIs that are not necessarily confined to web browser scenarios.</summary>
  [Static(typeof (IUriEscapeStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IUriRuntimeClassFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  public sealed class Uri : IUriRuntimeClass, IUriRuntimeClassWithAbsoluteCanonicalUri, IStringable
  {
    /// <summary>Initializes a new Uri object from the specified Uniform Resource Identifier (URI) string. Initializing the Uri also parses the string and populates the Uri properties that represent Uniform Resource Identifier (URI) components.</summary>
    /// <param name="uri">The string from which the new Uri object is created.</param>
    [MethodImpl]
    public extern Uri(string uri);

    /// <summary>Initializes a new Uri by combining a base Uniform Resource Identifier (URI) and a relative Uniform Resource Identifier (URI). Initializing the Uri also parses the combined string and populates the Uri properties that represent Uniform Resource Identifier (URI) components.</summary>
    /// <param name="baseUri">The base Uniform Resource Identifier (URI).</param>
    /// <param name="relativeUri">The relative Uniform Resource Identifier (URI).</param>
    [MethodImpl]
    public extern Uri(string baseUri, string relativeUri);

    /// <summary>Gets the entire, non-canonical URI (It is non-canonical because it might actually be an IRI, per the Windows.Foundation.Uri encoding behavior; see Remarks.).</summary>
    /// <returns>The entire, non-canonical URI.</returns>
    public extern string AbsoluteUri { [MethodImpl] get; }

    /// <summary>Gets a representation of the Uniform Resource Identifier (URI) that can be used for display purposes.</summary>
    /// <returns>The Uniform Resource Identifier (URI) for display.</returns>
    public extern string DisplayUri { [MethodImpl] get; }

    /// <summary>Gets the domain name component, including top-level domain, from a Uniform Resource Identifier (URI).</summary>
    /// <returns>The domain name.</returns>
    public extern string Domain { [MethodImpl] get; }

    /// <summary>Gets the file name extension of the resource that is referenced in the Uri.</summary>
    /// <returns>The file name extension including the dot (.), if applicable.</returns>
    public extern string Extension { [MethodImpl] get; }

    /// <summary>Gets the text following a fragment marker (#), including the fragment marker itself.</summary>
    /// <returns>The text that represents the fragment.</returns>
    public extern string Fragment { [MethodImpl] get; }

    /// <summary>Gets the fully qualified domain name.</summary>
    /// <returns>The fully qualified domain name.</returns>
    public extern string Host { [MethodImpl] get; }

    /// <summary>Gets the password component of the Uniform Resource Identifier (URI) as stored in this Uri instance.</summary>
    /// <returns>The password.</returns>
    public extern string Password { [MethodImpl] get; }

    /// <summary>Gets the path and resource name component of the Uniform Resource Identifier (URI) as stored in this Uri instance.</summary>
    /// <returns>The path, including the resource name, and including the extension. Does not include query or fragment.</returns>
    public extern string Path { [MethodImpl] get; }

    /// <summary>Gets the query string component of the Uniform Resource Identifier (URI) as stored in this Uri instance.</summary>
    /// <returns>The query string.</returns>
    public extern string Query { [MethodImpl] get; }

    /// <summary>Gets a parsed Uniform Resource Identifier (URI) query string.</summary>
    /// <returns>The parsed query, as a new WwwFormUrlDecoder object. This is a read-only list of all name-value pairs (the form entries) as found in the query string after parsing.</returns>
    public extern WwwFormUrlDecoder QueryParsed { [MethodImpl] get; }

    /// <summary>Gets the entire original Uniform Resource Identifier (URI) string as used to construct this Uri object, before parsing, and without any encoding applied.</summary>
    /// <returns>The raw Uniform Resource Identifier (URI) string.</returns>
    public extern string RawUri { [MethodImpl] get; }

    /// <summary>Gets the protocol scheme name component of the Uniform Resource Identifier (URI) as stored in this Uri instance</summary>
    /// <returns>The protocol scheme name.</returns>
    public extern string SchemeName { [MethodImpl] get; }

    /// <summary>Gets the user name component of the Uniform Resource Identifier (URI) as stored in this Uri instance.</summary>
    /// <returns>The user name.</returns>
    public extern string UserName { [MethodImpl] get; }

    /// <summary>Gets the port number component of the Uniform Resource Identifier (URI) as stored in this Uri instance</summary>
    /// <returns>The port number.</returns>
    public extern int Port { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether parsing determined that the Uniform Resource Identifier (URI) is not well-formed.</summary>
    /// <returns>**true** if the Uniform Resource Identifier (URI) is flagged as suspicious; otherwise, **false**.</returns>
    public extern bool Suspicious { [MethodImpl] get; }

    [MethodImpl]
    public extern bool Equals(Uri pUri);

    /// <summary>Adds the specified Uniform Resource Identifier (URI) to the current Uri.</summary>
    /// <param name="relativeUri">A relative Uniform Resource Identifier (URI) specified as a string. This relative path is evaluated using the host/authority of the Uri instance where this method is called.</param>
    /// <returns>The combined Uri value.</returns>
    [MethodImpl]
    public extern Uri CombineUri(string relativeUri);

    /// <summary>Gets a fully canonical RFC-compliant representation of the current URI.</summary>
    /// <returns>The canonical URI.</returns>
    public extern string AbsoluteCanonicalUri { [MethodImpl] get; }

    /// <summary>Gets the decoded unicode characters that make up the current URI.</summary>
    /// <returns>The decoded unicode characters, when possible. Unsafe values are renamed as percent-encoded UTF-8. Characters in the hostname are decoded if they were encoded using*Punycode*.</returns>
    public extern string DisplayIri { [MethodImpl] get; }

    /// <summary>Gets a canonical string representation for the current Uri.</summary>
    /// <returns>The unescaped canonical representation of the current Uri. All characters are unescaped, except #, ?, and %.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts the specified string by replacing any escape sequences with their unescaped representation.</summary>
    /// <param name="toUnescape">The string to convert.</param>
    /// <returns>The unescaped representation of *stringToUnescape*.</returns>
    [MethodImpl]
    public static extern string UnescapeComponent(string toUnescape);

    /// <summary>Converts a Uniform Resource Identifier (URI) string to its escaped representation.</summary>
    /// <param name="toEscape">The string to convert.</param>
    /// <returns>The escaped representation of *toEscape*.</returns>
    [MethodImpl]
    public static extern string EscapeComponent(string toEscape);
  }
}
