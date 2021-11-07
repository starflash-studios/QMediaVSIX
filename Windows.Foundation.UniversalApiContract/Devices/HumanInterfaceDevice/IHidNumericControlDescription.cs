// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidNumericControlDescription
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1670209158, 7575, 19573, 146, 127, 95, 245, 139, 160, 94, 50)]
  [ExclusiveTo(typeof (HidNumericControlDescription))]
  internal interface IHidNumericControlDescription
  {
    uint Id { get; }

    ushort ReportId { get; }

    HidReportType ReportType { get; }

    uint ReportSize { get; }

    uint ReportCount { get; }

    ushort UsagePage { get; }

    ushort UsageId { get; }

    int LogicalMinimum { get; }

    int LogicalMaximum { get; }

    int PhysicalMinimum { get; }

    int PhysicalMaximum { get; }

    uint UnitExponent { get; }

    uint Unit { get; }

    bool IsAbsolute { get; }

    bool HasNull { get; }

    IVectorView<HidCollection> ParentCollections { get; }
  }
}
