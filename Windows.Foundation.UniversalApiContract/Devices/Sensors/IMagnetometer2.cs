// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [Guid(3026545797, 9974, 17483, 169, 226, 162, 63, 150, 108, 211, 104)]
  [ExclusiveTo(typeof (Magnetometer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMagnetometer2
  {
    DisplayOrientations ReadingTransform { set; get; }
  }
}
