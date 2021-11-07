// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverDisconnectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>Provides data for the MiracastReceiverSession.Disconnected event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class MiracastReceiverDisconnectedEventArgs : IMiracastReceiverDisconnectedEventArgs
  {
    /// <summary>Returns the MiracastReceiverConnection object of the connection that has been disconnected.</summary>
    /// <returns>The MiracastReceiverConnection object of the connection that has been disconnected.</returns>
    public extern MiracastReceiverConnection Connection { [MethodImpl] get; }
  }
}
