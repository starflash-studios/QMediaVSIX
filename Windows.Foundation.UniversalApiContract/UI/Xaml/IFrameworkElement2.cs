// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElement2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4052812990, 16938, 18692, 165, 47, 238, 114, 1, 4, 41, 229)]
  [ExclusiveTo(typeof (FrameworkElement))]
  internal interface IFrameworkElement2
  {
    ElementTheme RequestedTheme { get; set; }

    event TypedEventHandler<FrameworkElement, DataContextChangedEventArgs> DataContextChanged;

    BindingExpression GetBindingExpression(DependencyProperty dp);
  }
}
