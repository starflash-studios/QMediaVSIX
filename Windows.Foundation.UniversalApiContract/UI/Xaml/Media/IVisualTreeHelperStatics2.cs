// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IVisualTreeHelperStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(129814902, 34463, 17575, 135, 151, 33, 3, 164, 195, 228, 122)]
  [ExclusiveTo(typeof (VisualTreeHelper))]
  internal interface IVisualTreeHelperStatics2
  {
    IVectorView<Popup> GetOpenPopups(Window window);
  }
}
