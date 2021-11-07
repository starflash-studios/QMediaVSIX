// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ILowLagPhotoCapture
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (LowLagPhotoCapture))]
  [Guid(2742178231, 27460, 18237, 143, 36, 247, 3, 214, 192, 236, 68)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILowLagPhotoCapture
  {
    [RemoteAsync]
    IAsyncOperation<CapturedPhoto> CaptureAsync();

    [RemoteAsync]
    IAsyncAction FinishAsync();
  }
}
