// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidNumericControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ExclusiveTo(typeof (HidNumericControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3817476773, 13735, 19317, 137, 200, 251, 31, 40, 177, 8, 35)]
  internal interface IHidNumericControl
  {
    uint Id { get; }

    bool IsGrouped { get; }

    ushort UsagePage { get; }

    ushort UsageId { get; }

    long Value { get; set; }

    long ScaledValue { get; set; }

    HidNumericControlDescription ControlDescription { get; }
  }
}
