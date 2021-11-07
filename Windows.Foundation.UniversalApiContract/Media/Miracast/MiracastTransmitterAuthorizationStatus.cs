// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastTransmitterAuthorizationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>Specifies the authorization status of a Miracast Transmitter.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum MiracastTransmitterAuthorizationStatus
  {
    /// <summary>A decision has not yet been made about whether to allow or block this transmitter.</summary>
    Undecided,
    /// <summary>Connections from this transmitter are allowed.</summary>
    Allowed,
    /// <summary>Connections from this transmitter are allowed, but always ask the user to confirm a new connection.</summary>
    AlwaysPrompt,
    /// <summary>All connection attempts from this transmitter are automatically rejected.</summary>
    Blocked,
  }
}
