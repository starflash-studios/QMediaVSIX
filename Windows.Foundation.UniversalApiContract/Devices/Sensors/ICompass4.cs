// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompass4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(689864465, 60466, 24012, 191, 203, 11, 179, 158, 186, 87, 116)]
  [ExclusiveTo(typeof (Compass))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface ICompass4
  {
    CompassDataThreshold ReportThreshold { get; }
  }
}
