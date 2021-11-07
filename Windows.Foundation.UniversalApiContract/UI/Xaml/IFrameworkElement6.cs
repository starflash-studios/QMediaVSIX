// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElement6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (FrameworkElement))]
  [Guid(2032819601, 25249, 16575, 160, 206, 249, 193, 49, 252, 183, 167)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IFrameworkElement6
  {
    ElementTheme ActualTheme { get; }

    event TypedEventHandler<FrameworkElement, object> ActualThemeChanged;
  }
}
