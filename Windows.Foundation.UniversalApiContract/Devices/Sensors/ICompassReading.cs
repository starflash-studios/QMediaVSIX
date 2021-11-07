// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompassReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2190545192, 20797, 19913, 183, 129, 94, 237, 251, 240, 45, 12)]
  [ExclusiveTo(typeof (CompassReading))]
  internal interface ICompassReading
  {
    DateTime Timestamp { get; }

    double HeadingMagneticNorth { get; }

    IReference<double> HeadingTrueNorth { get; }
  }
}
