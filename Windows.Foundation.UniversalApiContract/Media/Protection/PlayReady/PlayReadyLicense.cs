// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyLicense
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Represents the properties of a PlayReady license.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayReadyLicense : IPlayReadyLicense, IPlayReadyLicense2
  {
    /// <summary>Gets the state of the license.</summary>
    /// <returns>Indicates whether this license chain is evaluated or whether this license chain may be unusable due to enumeration for all licenses (including those that are unusable) being performed. If **true**, the license chain is evaluated. If **false**, the license chain may be unusable.</returns>
    public extern bool FullyEvaluated { [MethodImpl] get; }

    /// <summary>Gets whether this license is usable for playback.</summary>
    /// <returns>**true** if this license is usable for playback, otherwise **false**.</returns>
    public extern bool UsableForPlay { [MethodImpl] get; }

    /// <summary>Gets the expiration date of the current license.</summary>
    /// <returns>The expiration date of the current license.</returns>
    public extern IReference<global::Windows.Foundation.DateTime> ExpirationDate { [MethodImpl] get; }

    /// <summary>Gets the amount of time, in seconds, before the current license expires after the media is first played.</summary>
    /// <returns>The time, in seconds, before the current license expires after the media is first played.</returns>
    public extern uint ExpireAfterFirstPlay { [MethodImpl] get; }

    /// <summary>Gets the domain account identifier to which this license is bound.</summary>
    /// <returns>The domain account identifier. If the license is not domain bound, **GUID_NULL** is returned. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public extern Guid DomainAccountID { [MethodImpl] get; }

    /// <summary>Gets the chain depth of the license chain represented by the current PlayReadyLicense class.</summary>
    /// <returns>The chain depth of the license chain.</returns>
    public extern uint ChainDepth { [MethodImpl] get; }

    /// <summary>Gets the key identifier (KID) of the license at the specified chain depth.</summary>
    /// <param name="chainDepth">The depth of the license in the chain for which to retrieve the KID. This value is a 0-based index.</param>
    /// <returns>The KID of the license. This return value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    [MethodImpl]
    public extern Guid GetKIDAtChainDepth(uint chainDepth);

    /// <summary>Gets the unique identifier of the certificate for the service that handles the server-side of the SecureStop protocol.</summary>
    /// <returns>The unique identifier of the certificate for the service that handles the server-side of the SecureStop protocol.</returns>
    public extern Guid SecureStopId { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the security level of the license.</summary>
    /// <returns>A value that indicates the security level of the license.</returns>
    public extern uint SecurityLevel { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if the license is in-memory-only.</summary>
    /// <returns>True if the license is in-memory-only; otherwise, false.</returns>
    public extern bool InMemoryOnly { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if the license can expire in the middle of playback or if only expires when attempting a fresh playback.</summary>
    /// <returns>True if the license can expire in the middle of playback; otherwise, false.</returns>
    public extern bool ExpiresInRealTime { [MethodImpl] get; }
  }
}
