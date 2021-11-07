// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidInputReportReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  /// <summary>Represents the arguments which the HID API sends as part of an input-report event.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HidInputReportReceivedEventArgs : IHidInputReportReceivedEventArgs
  {
    /// <summary>Gets the input report.</summary>
    /// <returns>A **HidInputReport** object.</returns>
    public extern HidInputReport Report { [MethodImpl] get; }
  }
}
