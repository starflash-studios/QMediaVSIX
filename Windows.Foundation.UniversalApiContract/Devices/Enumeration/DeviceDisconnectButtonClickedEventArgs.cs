// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceDisconnectButtonClickedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Provides data for the DisconnectButtonClicked event on the DevicePicker object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class DeviceDisconnectButtonClickedEventArgs : 
    IDeviceDisconnectButtonClickedEventArgs
  {
    /// <summary>The device that the user clicked the disconnect button for.</summary>
    /// <returns>The device to disconnect.</returns>
    public extern DeviceInformation Device { [MethodImpl] get; }
  }
}
