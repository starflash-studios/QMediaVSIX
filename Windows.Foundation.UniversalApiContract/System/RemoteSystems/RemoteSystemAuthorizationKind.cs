// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemAuthorizationKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains values specifying whether the client device can discover only same-user devices or other users' devices as well. Cross-user devices must be available through a proximal connection in order to be discovered (see RemoteSystemDiscoveryType for details).</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum RemoteSystemAuthorizationKind
  {
    /// <summary>The client device can only discover devices signed in by the same user.</summary>
    SameUser,
    /// <summary>The client device can discover other users' devices, provided they are available for proximal connection.</summary>
    Anonymous,
  }
}
