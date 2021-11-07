// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IHingeAngleReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (HingeAngleReading))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2748138937, 7153, 20325, 167, 4, 226, 218, 4, 241, 130, 192)]
  internal interface IHingeAngleReading
  {
    DateTime Timestamp { get; }

    double AngleInDegrees { get; }

    IMapView<string, object> Properties { get; }
  }
}
