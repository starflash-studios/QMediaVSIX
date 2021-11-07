// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.PlayReadyDomain
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Provides access to metadata about a domain to which the current system is a member.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlayReadyDomain : IPlayReadyDomain
  {
    /// <summary>Gets the current domain account identifier property.</summary>
    /// <returns>The current domain account identifier property. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public extern Guid AccountId { [MethodImpl] get; }

    /// <summary>Gets the current domain service identifier property.</summary>
    /// <returns>The current domain service identifier property. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.</returns>
    public extern Guid ServiceId { [MethodImpl] get; }

    /// <summary>Gets the current domain revision number.</summary>
    /// <returns>The current domain revision number.</returns>
    public extern uint Revision { [MethodImpl] get; }

    /// <summary>Gets the current domain friendly name.</summary>
    /// <returns>The current domain friendly name.</returns>
    public extern string FriendlyName { [MethodImpl] get; }

    /// <summary>Gets the URL used to join the domain.</summary>
    /// <returns>The URL used to join the domain.</returns>
    public extern global::Windows.Foundation.Uri DomainJoinUrl { [MethodImpl] get; }
  }
}
