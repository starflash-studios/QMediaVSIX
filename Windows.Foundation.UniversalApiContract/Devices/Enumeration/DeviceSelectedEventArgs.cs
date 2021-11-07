// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.DeviceSelectedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  /// <summary>Provides data for the DeviceSelected event on the DevicePicker object.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DeviceSelectedEventArgs : IDeviceSelectedEventArgs
  {
    /// <summary>The device selected by the user in the picker.</summary>
    /// <returns>The selected device.</returns>
    public extern DeviceInformation SelectedDevice { [MethodImpl] get; }
  }
}
