// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILoadedImageSurface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (LoadedImageSurface))]
  [Guid(84706067, 26423, 17850, 133, 49, 51, 9, 79, 235, 239, 85)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  internal interface ILoadedImageSurface
  {
    Size DecodedPhysicalSize { get; }

    Size DecodedSize { get; }

    Size NaturalSize { get; }

    event TypedEventHandler<LoadedImageSurface, LoadedImageSourceLoadCompletedEventArgs> LoadCompleted;
  }
}
