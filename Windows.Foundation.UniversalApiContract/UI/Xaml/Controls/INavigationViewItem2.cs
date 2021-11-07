// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewItem2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3997732601, 60060, 24068, 178, 108, 131, 191, 150, 85, 52, 47)]
  [ExclusiveTo(typeof (NavigationViewItem))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface INavigationViewItem2
  {
    bool SelectsOnInvoked { get; set; }
  }
}
