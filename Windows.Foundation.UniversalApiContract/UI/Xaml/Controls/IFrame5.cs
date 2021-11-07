// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFrame5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1161804078, 33461, 24467, 146, 171, 21, 52, 24, 6, 201, 218)]
  [ExclusiveTo(typeof (Frame))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IFrame5
  {
    bool IsNavigationStackEnabled { get; set; }

    bool NavigateToType(
      TypeName sourcePageType,
      object parameter,
      FrameNavigationOptions navigationOptions);
  }
}
