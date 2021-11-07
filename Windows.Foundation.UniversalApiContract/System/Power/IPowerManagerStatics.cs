// Decompiled with JetBrains decompiler
// Type: Windows.System.Power.IPowerManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Power
{
  [Guid(328499805, 25294, 17252, 152, 213, 170, 40, 199, 251, 209, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PowerManager))]
  internal interface IPowerManagerStatics
  {
    EnergySaverStatus EnergySaverStatus { get; }

    event EventHandler<object> EnergySaverStatusChanged;

    BatteryStatus BatteryStatus { get; }

    event EventHandler<object> BatteryStatusChanged;

    PowerSupplyStatus PowerSupplyStatus { get; }

    event EventHandler<object> PowerSupplyStatusChanged;

    int RemainingChargePercent { get; }

    event EventHandler<object> RemainingChargePercentChanged;

    TimeSpan RemainingDischargeTime { get; }

    event EventHandler<object> RemainingDischargeTimeChanged;
  }
}
