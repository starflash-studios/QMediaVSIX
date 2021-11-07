// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.ILampStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Lamp))]
  [Guid(2820817260, 34949, 16414, 184, 33, 142, 139, 56, 168, 232, 236)]
  internal interface ILampStatics
  {
    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<Lamp> FromIdAsync(string deviceId);

    [RemoteAsync]
    IAsyncOperation<Lamp> GetDefaultAsync();
  }
}
