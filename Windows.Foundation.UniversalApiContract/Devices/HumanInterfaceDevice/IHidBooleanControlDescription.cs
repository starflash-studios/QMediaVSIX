// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidBooleanControlDescription
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [Guid(1637279043, 10712, 18986, 134, 131, 132, 158, 32, 123, 190, 49)]
  [ExclusiveTo(typeof (HidBooleanControlDescription))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHidBooleanControlDescription
  {
    uint Id { get; }

    ushort ReportId { get; }

    HidReportType ReportType { get; }

    ushort UsagePage { get; }

    ushort UsageId { get; }

    IVectorView<HidCollection> ParentCollections { get; }
  }
}
