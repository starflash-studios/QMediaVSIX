// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IGyrometer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Gyrometer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1675568195, 36072, 16835, 172, 68, 134, 152, 129, 11, 85, 127)]
  internal interface IGyrometer2
  {
    DisplayOrientations ReadingTransform { set; get; }
  }
}
