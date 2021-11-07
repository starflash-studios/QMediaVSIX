// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawerCloseAlarm
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1811451079, 28515, 17166, 171, 59, 149, 215, 95, 251, 232, 127)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CashDrawerCloseAlarm))]
  internal interface ICashDrawerCloseAlarm
  {
    TimeSpan AlarmTimeout { set; get; }

    uint BeepFrequency { set; get; }

    TimeSpan BeepDuration { set; get; }

    TimeSpan BeepDelay { set; get; }

    event TypedEventHandler<CashDrawerCloseAlarm, object> AlarmTimeoutExpired;

    [RemoteAsync]
    IAsyncOperation<bool> StartAsync();
  }
}
