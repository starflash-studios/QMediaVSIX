// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemRemovedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Gets information about a RemoteSystemRemoved event, namely the RemoteSystem that was removed</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class RemoteSystemRemovedEventArgs : IRemoteSystemRemovedEventArgs
  {
    /// <summary>The RemoteSystem object representing the device that was removed from the set of discoverable devices, causing the containing RemoteSystemRemoved event to be raised.</summary>
    /// <returns>The device removed.</returns>
    public extern string RemoteSystemId { [MethodImpl] get; }
  }
}
