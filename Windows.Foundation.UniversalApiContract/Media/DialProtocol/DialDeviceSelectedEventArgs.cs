// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialDeviceSelectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  /// <summary>Represents the event arguments for the DialDeviceSelected event on the DialDevicePicker object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class DialDeviceSelectedEventArgs : IDialDeviceSelectedEventArgs
  {
    /// <summary>Gets the DialDevice object that represents the remote device that has been selected by the user in a DialDevicePicker.</summary>
    /// <returns>The remote device that the user selected.</returns>
    public extern DialDevice SelectedDialDevice { [MethodImpl] get; }
  }
}
