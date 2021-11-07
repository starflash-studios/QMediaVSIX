// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IActivitySensorTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Sensors;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Guid(3504161602, 58235, 18467, 165, 254, 107, 49, 223, 239, 222, 176)]
  [ExclusiveTo(typeof (ActivitySensorTrigger))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IActivitySensorTrigger : IBackgroundTrigger
  {
    IVector<ActivityType> SubscribedActivities { get; }

    uint ReportInterval { get; }

    IVectorView<ActivityType> SupportedActivities { get; }

    uint MinimumReportInterval { get; }
  }
}
