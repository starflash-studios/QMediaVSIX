// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDragUI
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Media.Imaging;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DragUI))]
  [Guid(765188152, 31840, 18498, 145, 112, 52, 111, 225, 10, 34, 106)]
  internal interface IDragUI
  {
    [Overload("SetContentFromBitmapImage")]
    void SetContentFromBitmapImage(BitmapImage bitmapImage);

    [Overload("SetContentFromBitmapImageWithAnchorPoint")]
    void SetContentFromBitmapImage(BitmapImage bitmapImage, Point anchorPoint);

    [Overload("SetContentFromSoftwareBitmap")]
    void SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap);

    [Overload("SetContentFromSoftwareBitmapWithAnchorPoint")]
    void SetContentFromSoftwareBitmap(SoftwareBitmap softwareBitmap, Point anchorPoint);

    void SetContentFromDataPackage();
  }
}
