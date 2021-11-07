// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IVideoDeviceControllerGetDevicePropertyResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3319301013, 28373, 18320, 139, 93, 14, 241, 57, 53, 208, 248)]
  [ExclusiveTo(typeof (VideoDeviceControllerGetDevicePropertyResult))]
  internal interface IVideoDeviceControllerGetDevicePropertyResult
  {
    VideoDeviceControllerGetDevicePropertyStatus Status { get; }

    object Value { [return: Variant] get; }
  }
}
