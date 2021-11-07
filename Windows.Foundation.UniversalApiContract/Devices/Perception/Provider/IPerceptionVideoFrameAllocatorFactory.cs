// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionVideoFrameAllocatorFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Devices.Perception.Provider
{
  [ExclusiveTo(typeof (PerceptionVideoFrameAllocator))]
  [Guid(442020065, 59674, 18462, 184, 118, 168, 158, 43, 188, 107, 51)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  internal interface IPerceptionVideoFrameAllocatorFactory
  {
    [Deprecated("PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionVideoFrameAllocator Create(
      uint maxOutstandingFrameCountForWrite,
      BitmapPixelFormat format,
      Size resolution,
      BitmapAlphaMode alpha);
  }
}
