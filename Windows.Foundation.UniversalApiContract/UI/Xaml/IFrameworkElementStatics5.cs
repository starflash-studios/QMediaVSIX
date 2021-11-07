// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElementStatics5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(1381841217, 2876, 19430, 153, 120, 25, 168, 2, 92, 9, 216)]
  [ExclusiveTo(typeof (FrameworkElement))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IFrameworkElementStatics5
  {
    void DeferTree(DependencyObject element);
  }
}
