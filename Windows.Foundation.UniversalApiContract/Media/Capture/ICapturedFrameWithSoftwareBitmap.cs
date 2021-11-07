// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.ICapturedFrameWithSoftwareBitmap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.Capture
{
  [Guid(3046017902, 34051, 18869, 158, 134, 137, 125, 38, 163, 255, 61)]
  [ExclusiveTo(typeof (CapturedFrame))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICapturedFrameWithSoftwareBitmap
  {
    SoftwareBitmap SoftwareBitmap { get; }
  }
}
