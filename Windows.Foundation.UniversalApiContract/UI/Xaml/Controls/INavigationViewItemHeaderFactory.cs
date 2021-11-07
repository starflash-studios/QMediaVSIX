// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewItemHeaderFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4077934984, 30568, 17875, 139, 176, 109, 237, 158, 67, 169, 139)]
  [ExclusiveTo(typeof (NavigationViewItemHeader))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface INavigationViewItemHeaderFactory
  {
    NavigationViewItemHeader CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
