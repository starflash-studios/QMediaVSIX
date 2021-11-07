// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [Guid(43987859, 10418, 17912, 187, 22, 97, 232, 106, 127, 174, 110)]
  [ExclusiveTo(typeof (Inclinometer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInclinometer2
  {
    DisplayOrientations ReadingTransform { set; get; }

    SensorReadingType ReadingType { get; }
  }
}
