// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewPaneClosingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2505405882, 30197, 17197, 180, 155, 96, 228, 117, 82, 213, 238)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [ExclusiveTo(typeof (NavigationViewPaneClosingEventArgs))]
  internal interface INavigationViewPaneClosingEventArgs
  {
    bool Cancel { get; set; }
  }
}
