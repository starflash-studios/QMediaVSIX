// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISensorDataThresholdTriggerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Sensors;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (SensorDataThresholdTrigger))]
  [Guid(2451564149, 32240, 19875, 151, 179, 229, 68, 238, 133, 127, 230)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISensorDataThresholdTriggerFactory
  {
    SensorDataThresholdTrigger Create(ISensorDataThreshold threshold);
  }
}
