// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IStyleSelector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3507568487, 55489, 19172, 152, 240, 216, 80, 69, 2, 240, 139)]
  [ExclusiveTo(typeof (StyleSelector))]
  internal interface IStyleSelector
  {
    Style SelectStyle(object item, DependencyObject container);
  }
}
