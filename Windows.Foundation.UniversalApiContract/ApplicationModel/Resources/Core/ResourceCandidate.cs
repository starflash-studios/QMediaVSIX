// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceCandidate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Resources.Core
{
  /// <summary>Represents a single possible value for a given NamedResource, the qualifiers associated with that resource, and how well those qualifiers match the context against which it was resolved.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ResourceCandidate : 
    IResourceCandidate,
    IResourceCandidate2,
    IResourceCandidate3
  {
    /// <summary>Gets the qualifiers associated with this ResourceCandidate.</summary>
    /// <returns>The ResourceQualifier s associated with this ResourceCandidate.</returns>
    public extern IVectorView<ResourceQualifier> Qualifiers { [MethodImpl] get; }

    /// <summary>Indicates whether this ResourceCandidate matched the ResourceContext against which it was evaluated.</summary>
    /// <returns>**TRUE** if the ResourceCandidate matched the context, **FALSE** otherwise.</returns>
    public extern bool IsMatch { [MethodImpl] get; }

    /// <summary>Indicates whether this ResourceCandidate matched the ResourceContext against which it was evaluated as a result of being a true match, a default fallback value, or a mixed match with default fallback (that is, a match in relation to some qualifiers but using default fallback values for other qualifiers).</summary>
    /// <returns>**TRUE** if this candidate is an acceptable default fallback value, **FALSE** otherwise.</returns>
    public extern bool IsMatchAsDefault { [MethodImpl] get; }

    /// <summary>Indicates whether this ResourceCandidate can be used as a default fallback value for any context.</summary>
    /// <returns>**TRUE** if this candidate can be used as a default fallback value for any context, **FALSE** otherwise.</returns>
    public extern bool IsDefault { [MethodImpl] get; }

    /// <summary>Gets the value of this ResourceCandidate, expressed as a string.</summary>
    /// <returns>The string value.</returns>
    public extern string ValueAsString { [MethodImpl] get; }

    /// <summary>Asynchronously returns a StorageFile that accesses the value of this ResourceCandidate. This only works on certain types of ResourceCandidate s that are files.</summary>
    /// <returns>An asynchronous operation to return the requested StorageFile.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> GetValueAsFileAsync();

    /// <summary>Returns the value of a qualifier, given its name.</summary>
    /// <param name="qualifierName">The name of the qualifier.</param>
    /// <returns>The value of the qualifier.</returns>
    [MethodImpl]
    public extern string GetQualifierValue(string qualifierName);

    /// <summary>Asynchronously returns an [IRandomAccessStream](https://docs.microsoft.com/previous-versions/hh438400(v=vs.85)) that accesses the value of this ResourceCandidate.</summary>
    /// <returns>An asynchronous operation to return the requested [IRandomAccessStream](https://docs.microsoft.com/previous-versions/hh438400(v=vs.85)).</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> GetValueAsStreamAsync();

    /// <summary>Gets the type of resource that is encapsulated in this ResourceCandidate.</summary>
    /// <returns>A value that specifies the type of resource that is encapsulated in this ResourceCandidate.</returns>
    public extern ResourceCandidateKind Kind { [MethodImpl] get; }
  }
}
