// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IImageCue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1384284802, 13947, 17419, 145, 22, 60, 132, 87, 13, 210, 112)]
  [ExclusiveTo(typeof (ImageCue))]
  internal interface IImageCue : IMediaCue
  {
    TimedTextPoint Position { get; set; }

    TimedTextSize Extent { get; set; }

    SoftwareBitmap SoftwareBitmap { set; get; }
  }
}
