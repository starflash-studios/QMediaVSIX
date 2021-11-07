// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.ISoftwareBitmapFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3382700905, 11618, 19783, 166, 179, 79, 219, 106, 7, 253, 248)]
  [ExclusiveTo(typeof (SoftwareBitmap))]
  internal interface ISoftwareBitmapFactory
  {
    SoftwareBitmap Create(BitmapPixelFormat format, int width, int height);

    SoftwareBitmap CreateWithAlpha(
      BitmapPixelFormat format,
      int width,
      int height,
      BitmapAlphaMode alpha);
  }
}
