// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewItemInvokedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (NavigationViewItemInvokedEventArgs))]
  [Guid(692676642, 21970, 18938, 150, 75, 241, 219, 175, 239, 133, 196)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface INavigationViewItemInvokedEventArgs
  {
    object InvokedItem { get; }

    bool IsSettingsInvoked { get; }
  }
}
