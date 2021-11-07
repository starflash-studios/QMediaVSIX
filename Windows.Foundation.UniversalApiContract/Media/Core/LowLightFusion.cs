// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.LowLightFusion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.Core
{
  /// <summary>This class allows you to submit a set of image frames, captured in low-light settings and in close temporal proximity, and receieve a single image that has been processed to improve image lighting and fidelity.</summary>
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ILowLightFusionStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public static class LowLightFusion
  {
    /// <summary>Gets a list of BitmapPixelFormat values that define the supported pixel formats for the **FuseAsync** method.</summary>
    /// <returns>A list of supported pixel formats.</returns>
    public static extern IVectorView<BitmapPixelFormat> SupportedBitmapPixelFormats { [MethodImpl] get; }

    /// <summary>Gets the maximum number of frames that can be submitted to the **FuseAsync** method.</summary>
    /// <returns>The maximum number of frames that can be submitted to the **FuseAsync** method.</returns>
    public static extern int MaxSupportedFrameCount { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperationWithProgress<LowLightFusionResult, double> FuseAsync(
      IIterable<SoftwareBitmap> frameSet);
  }
}
