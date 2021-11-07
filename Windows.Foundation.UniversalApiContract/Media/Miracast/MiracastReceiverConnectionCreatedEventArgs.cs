// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverConnectionCreatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>Provides data for the MiracastReceiverSession.ConnectionCreated event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  public sealed class MiracastReceiverConnectionCreatedEventArgs : 
    IMiracastReceiverConnectionCreatedEventArgs
  {
    /// <summary>Gets the MiracastReceiverConnection object of the newly created connection.</summary>
    /// <returns>The **MiracastReceiverConnection** object.</returns>
    public extern MiracastReceiverConnection Connection { [MethodImpl] get; }

    /// <summary>Getes the PIN that must be entered by the Miracast Transmitter device, or an empty string if PIN authentication is not in use.</summary>
    /// <returns>The PIN, or an empty string if PIN authentication is not used.</returns>
    public extern string Pin { [MethodImpl] get; }

    /// <summary>Defers completion of the MiracastReceiverSession.ConnectionCreated event until Deferral.Complete is invoked.</summary>
    /// <returns>The Deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
