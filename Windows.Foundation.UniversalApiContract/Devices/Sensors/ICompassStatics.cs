// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompassStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Compass))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2596050911, 22252, 19493, 181, 77, 64, 166, 139, 181, 178, 105)]
  internal interface ICompassStatics
  {
    Compass GetDefault();
  }
}
