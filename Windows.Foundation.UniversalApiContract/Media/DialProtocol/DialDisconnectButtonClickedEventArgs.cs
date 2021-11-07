// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialDisconnectButtonClickedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  /// <summary>Represents the event arguments for the DisconnectButtonClicked event on the DialDevicePicker object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DialDisconnectButtonClickedEventArgs : IDialDisconnectButtonClickedEventArgs
  {
    /// <summary>Gets the DialDevice object that represents the remote device that the user wants to disconnect.</summary>
    /// <returns>The device object.</returns>
    public extern DialDevice Device { [MethodImpl] get; }
  }
}
