// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Power.IBatteryReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System.Power;

namespace Windows.Devices.Power
{
  [ExclusiveTo(typeof (BatteryReport))]
  [Guid(3380972602, 19987, 16906, 168, 208, 36, 241, 143, 57, 84, 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBatteryReport
  {
    IReference<int> ChargeRateInMilliwatts { get; }

    IReference<int> DesignCapacityInMilliwattHours { get; }

    IReference<int> FullChargeCapacityInMilliwattHours { get; }

    IReference<int> RemainingCapacityInMilliwattHours { get; }

    BatteryStatus Status { get; }
  }
}
