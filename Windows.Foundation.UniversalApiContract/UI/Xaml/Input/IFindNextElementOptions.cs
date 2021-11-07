// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFindNextElementOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (FindNextElementOptions))]
  [WebHostHidden]
  [Guid(3632980523, 18114, 16892, 137, 126, 181, 150, 25, 119, 184, 157)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IFindNextElementOptions
  {
    DependencyObject SearchRoot { get; set; }

    Rect ExclusionRect { get; set; }

    Rect HintRect { get; set; }

    XYFocusNavigationStrategyOverride XYFocusNavigationStrategyOverride { get; set; }
  }
}
