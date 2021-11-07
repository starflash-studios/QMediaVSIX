// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ISimpleOrientationSensor2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2725750680, 34928, 17726, 139, 214, 184, 245, 216, 215, 148, 27)]
  [ExclusiveTo(typeof (SimpleOrientationSensor))]
  internal interface ISimpleOrientationSensor2
  {
    DisplayOrientations ReadingTransform { set; get; }
  }
}
