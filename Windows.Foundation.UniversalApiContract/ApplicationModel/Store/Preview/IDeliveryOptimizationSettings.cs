// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.IDeliveryOptimizationSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  [Guid(403766688, 59475, 22110, 184, 116, 122, 138, 123, 154, 14, 15)]
  [ExclusiveTo(typeof (DeliveryOptimizationSettings))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IDeliveryOptimizationSettings
  {
    DeliveryOptimizationDownloadMode DownloadMode { get; }

    DeliveryOptimizationDownloadModeSource DownloadModeSource { get; }
  }
}
