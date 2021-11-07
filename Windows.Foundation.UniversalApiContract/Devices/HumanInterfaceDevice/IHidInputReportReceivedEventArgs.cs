// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidInputReportReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [Guid(1884931531, 22962, 19906, 152, 92, 10, 220, 97, 54, 250, 45)]
  [ExclusiveTo(typeof (HidInputReportReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHidInputReportReceivedEventArgs
  {
    HidInputReport Report { get; }
  }
}
