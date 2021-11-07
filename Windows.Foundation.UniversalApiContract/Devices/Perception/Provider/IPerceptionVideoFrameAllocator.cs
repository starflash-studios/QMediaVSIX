// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionVideoFrameAllocator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media;

namespace Windows.Devices.Perception.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Guid(1278781402, 64984, 20180, 160, 57, 42, 111, 155, 35, 80, 56)]
  [ExclusiveTo(typeof (PerceptionVideoFrameAllocator))]
  internal interface IPerceptionVideoFrameAllocator : IClosable
  {
    [Deprecated("PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionFrame AllocateFrame();

    [Deprecated("PerceptionVideoFrameAllocator may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    PerceptionFrame CopyFromVideoFrame(VideoFrame frame);
  }
}
