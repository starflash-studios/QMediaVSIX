// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IVisualTreeHelperStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [ExclusiveTo(typeof (VisualTreeHelper))]
  [Guid(1078070608, 51734, 22490, 138, 172, 148, 76, 138, 245, 119, 253)]
  internal interface IVisualTreeHelperStatics3
  {
    IVectorView<Popup> GetOpenPopupsForXamlRoot(XamlRoot xamlRoot);
  }
}
