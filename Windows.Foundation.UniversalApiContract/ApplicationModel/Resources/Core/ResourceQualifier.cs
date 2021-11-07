// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.ResourceQualifier
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  /// <summary>Defines the qualifiers associated with a ResourceCandidate.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ResourceQualifier : IResourceQualifier
  {
    /// <summary>The name of the qualifier.</summary>
    /// <returns>The name of the qualifier.</returns>
    public extern string QualifierName { [MethodImpl] get; }

    /// <summary>The value of the qualifier.</summary>
    /// <returns>The value of the qualifier.</returns>
    public extern string QualifierValue { [MethodImpl] get; }

    /// <summary>Indicates whether this qualifier should be considered as a default match when no match is found.</summary>
    /// <returns>**TRUE** if this candidate can be used as a default fallback value for any context; otherwise, **FALSE**.</returns>
    public extern bool IsDefault { [MethodImpl] get; }

    /// <summary>Indicates whether a given qualifier for a given candidate matched the context when a named resource is resolved to a candidate for some given context.</summary>
    /// <returns>**TRUE** if this qualifier matched the environment against which it was evaluated; otherwise, **FALSE**.</returns>
    public extern bool IsMatch { [MethodImpl] get; }

    /// <summary>A score that indicates how well the qualifier matched the context against which it was resolved.</summary>
    /// <returns>A score in the range 0.0– 1.0.</returns>
    public extern double Score { [MethodImpl] get; }
  }
}
