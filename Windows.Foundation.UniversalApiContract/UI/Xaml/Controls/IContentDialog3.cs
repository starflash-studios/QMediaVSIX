// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentDialog3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ContentDialog))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(2644117662, 63828, 20190, 176, 127, 107, 6, 154, 156, 1, 128)]
  internal interface IContentDialog3
  {
    [RemoteAsync]
    [Overload("ShowAsyncWithPlacement")]
    IAsyncOperation<ContentDialogResult> ShowAsync(
      ContentDialogPlacement placement);
  }
}
