// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Power.IBattery
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Power
{
  [ExclusiveTo(typeof (Battery))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3163115462, 114, 18376, 139, 93, 97, 74, 170, 122, 67, 126)]
  internal interface IBattery
  {
    string DeviceId { get; }

    BatteryReport GetReport();

    event TypedEventHandler<Battery, object> ReportUpdated;
  }
}
