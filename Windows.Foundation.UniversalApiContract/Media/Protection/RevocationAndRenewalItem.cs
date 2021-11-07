// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.RevocationAndRenewalItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Represents a component that is being revoked and renewed with a trusted component.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RevocationAndRenewalItem : IRevocationAndRenewalItem
  {
    /// <summary>Returns the reason for revocation of component.</summary>
    /// <returns>Defines reasons for the revocation and renewal of a certificate for a media component.</returns>
    public extern RevocationAndRenewalReasons Reasons { [MethodImpl] get; }

    /// <summary>Returns the header hash for the component being revoked.</summary>
    /// <returns>The string for the header hash.</returns>
    public extern string HeaderHash { [MethodImpl] get; }

    /// <summary>Returns the public key hash for the component.</summary>
    /// <returns>The public key hash.</returns>
    public extern string PublicKeyHash { [MethodImpl] get; }

    /// <summary>Returns the name for the component being revoked.</summary>
    /// <returns>The name of the component.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Returns the GUID for the renewal object.</summary>
    /// <returns>The renewal object GUID.</returns>
    public extern string RenewalId { [MethodImpl] get; }
  }
}
