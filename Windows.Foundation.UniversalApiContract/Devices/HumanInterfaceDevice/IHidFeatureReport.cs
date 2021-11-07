// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidFeatureReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HidFeatureReport))]
  [Guid(2216532857, 23269, 18147, 130, 239, 31, 236, 92, 137, 66, 244)]
  internal interface IHidFeatureReport
  {
    ushort Id { get; }

    IBuffer Data { get; set; }

    HidBooleanControl GetBooleanControl(ushort usagePage, ushort usageId);

    HidBooleanControl GetBooleanControlByDescription(
      HidBooleanControlDescription controlDescription);

    HidNumericControl GetNumericControl(ushort usagePage, ushort usageId);

    HidNumericControl GetNumericControlByDescription(
      HidNumericControlDescription controlDescription);
  }
}
