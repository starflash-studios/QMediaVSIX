// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicense
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Contains information about a PlayReady license.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3997649998, 64060, 16717, 169, 242, 63, 252, 30, 248, 50, 212)]
  public interface IPlayReadyLicense
  {
    /// <summary>Gets the state of the license.</summary>
    /// <returns>Indicates whether this license chain is evaluated or whether this license chain may be unusable due to enumeration for all licenses (including those that are unusable) being performed. If **true**, the license chain is evaluated. If **false**, the license chain may be unusable.</returns>
    bool FullyEvaluated { get; }

    /// <summary>Gets whether this license is usable for playback.</summary>
    /// <returns>**true** if this license is usable for playback, otherwise **false**.</returns>
    bool UsableForPlay { get; }

    /// <summary>Gets the expiration date of the current license.</summary>
    /// <returns>The expiration date of the current license.</returns>
    IReference<global::Windows.Foundation.DateTime> ExpirationDate { get; }

    /// <summary>Gets the amount of time, in seconds, before the current license expires after the media is first played.</summary>
    /// <returns>The time, in seconds, before the current license expires after the media is first played.</returns>
    uint ExpireAfterFirstPlay { get; }

    /// <summary>Gets the domain account identifier to which this license is bound.</summary>
    /// <returns>The domain account identifier. If the license is not domain bound, **GUID_NULL** is returned. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    Guid DomainAccountID { get; }

    /// <summary>Gets the chain depth of the license chain represented by the current IPlayReadyLicense interface.</summary>
    /// <returns>The chain depth of the license chain.</returns>
    uint ChainDepth { get; }

    /// <summary>Gets the key identifier (KID) of the license at the specified chain depth.</summary>
    /// <param name="chainDepth">The depth of the license in the chain for which to retrieve the KID. This value is a 0-based index.</param>
    /// <returns>The KID of the license. This return value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    Guid GetKIDAtChainDepth(uint chainDepth);
  }
}
