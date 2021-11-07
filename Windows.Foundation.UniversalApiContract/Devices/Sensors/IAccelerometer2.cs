// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Accelerometer))]
  [Guid(3908080366, 18788, 16410, 182, 2, 34, 13, 113, 83, 198, 10)]
  internal interface IAccelerometer2
  {
    DisplayOrientations ReadingTransform { set; get; }
  }
}
