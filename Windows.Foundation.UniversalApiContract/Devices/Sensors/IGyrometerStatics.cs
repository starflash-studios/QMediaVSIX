// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IGyrometerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Gyrometer))]
  [Guid(2209802185, 58525, 19257, 134, 230, 205, 85, 75, 228, 197, 193)]
  internal interface IGyrometerStatics
  {
    Gyrometer GetDefault();
  }
}
