// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.ILampArrayStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Lights
{
  [ExclusiveTo(typeof (LampArray))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2075707789, 24513, 17709, 187, 31, 74, 212, 16, 211, 152, 255)]
  internal interface ILampArrayStatics
  {
    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<LampArray> FromIdAsync(string deviceId);
  }
}
