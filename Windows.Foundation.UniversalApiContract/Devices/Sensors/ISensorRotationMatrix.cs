// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ISensorRotationMatrix
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(171792999, 8948, 17298, 149, 56, 101, 208, 189, 6, 74, 166)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SensorRotationMatrix))]
  internal interface ISensorRotationMatrix
  {
    float M11 { get; }

    float M12 { get; }

    float M13 { get; }

    float M21 { get; }

    float M22 { get; }

    float M23 { get; }

    float M31 { get; }

    float M32 { get; }

    float M33 { get; }
  }
}
