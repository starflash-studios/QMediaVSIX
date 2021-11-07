// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ISensorQuaternion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3385182247, 50972, 18151, 157, 163, 54, 161, 147, 178, 50, 188)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SensorQuaternion))]
  internal interface ISensorQuaternion
  {
    float W { get; }

    float X { get; }

    float Y { get; }

    float Z { get; }
  }
}
