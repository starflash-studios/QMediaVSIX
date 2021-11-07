// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IPedometerDataThresholdFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3417149264, 31316, 18027, 144, 16, 119, 161, 98, 252, 165, 215)]
  [ExclusiveTo(typeof (PedometerDataThreshold))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IPedometerDataThresholdFactory
  {
    PedometerDataThreshold Create(Pedometer sensor, int stepGoal);
  }
}
