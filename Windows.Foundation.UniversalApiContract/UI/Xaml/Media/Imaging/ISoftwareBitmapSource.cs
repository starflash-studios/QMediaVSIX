// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.ISoftwareBitmapSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3537739472, 54213, 16470, 145, 181, 183, 193, 209, 232, 19, 14)]
  [ExclusiveTo(typeof (SoftwareBitmapSource))]
  [WebHostHidden]
  internal interface ISoftwareBitmapSource
  {
    [RemoteAsync]
    IAsyncAction SetBitmapAsync(SoftwareBitmap softwareBitmap);
  }
}
