// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompassStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Compass))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(181276333, 15274, 18832, 156, 228, 190, 9, 19, 117, 78, 210)]
  internal interface ICompassStatics2
  {
    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<Compass> FromIdAsync(string deviceId);
  }
}
