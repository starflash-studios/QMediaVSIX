// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ExclusiveTo(typeof (BitmapTransform))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2926924612, 57960, 19765, 173, 207, 233, 149, 211, 26, 141, 52)]
  internal interface IBitmapTransform
  {
    uint ScaledWidth { get; set; }

    uint ScaledHeight { get; set; }

    BitmapInterpolationMode InterpolationMode { get; set; }

    BitmapFlip Flip { get; set; }

    BitmapRotation Rotation { get; set; }

    BitmapBounds Bounds { get; set; }
  }
}
