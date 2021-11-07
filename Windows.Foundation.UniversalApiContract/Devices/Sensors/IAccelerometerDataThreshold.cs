// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometerDataThreshold
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(4180417384, 25376, 21879, 135, 158, 153, 66, 98, 28, 61, 217)]
  [ExclusiveTo(typeof (AccelerometerDataThreshold))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IAccelerometerDataThreshold
  {
    double XAxisInGForce { get; set; }

    double YAxisInGForce { get; set; }

    double ZAxisInGForce { get; set; }
  }
}
