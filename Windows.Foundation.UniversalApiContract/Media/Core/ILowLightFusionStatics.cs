// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ILowLightFusionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (LowLightFusion))]
  [Guid(1392836973, 49822, 16610, 135, 169, 158, 31, 210, 241, 146, 245)]
  internal interface ILowLightFusionStatics
  {
    IVectorView<BitmapPixelFormat> SupportedBitmapPixelFormats { get; }

    int MaxSupportedFrameCount { get; }

    [RemoteAsync]
    IAsyncOperationWithProgress<LowLightFusionResult, double> FuseAsync(
      IIterable<SoftwareBitmap> frameSet);
  }
}
