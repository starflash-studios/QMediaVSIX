// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompassReadingHeadingAccuracy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3881907534, 35089, 16631, 158, 22, 110, 204, 125, 174, 197, 222)]
  [ExclusiveTo(typeof (CompassReading))]
  internal interface ICompassReadingHeadingAccuracy
  {
    MagnetometerAccuracy HeadingAccuracy { get; }
  }
}
