// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Gets information about a RemoteSystemUpdated event, namely the RemoteSystem that was updated.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemUpdatedEventArgs : IRemoteSystemUpdatedEventArgs
  {
    /// <summary>The RemoteSystem object representing the device in the set of discoverable devices whose properties were updated, causing the containing RemoteSystemUpdated event to be raised.</summary>
    /// <returns>The device updated.</returns>
    public extern RemoteSystem RemoteSystem { [MethodImpl] get; }
  }
}
