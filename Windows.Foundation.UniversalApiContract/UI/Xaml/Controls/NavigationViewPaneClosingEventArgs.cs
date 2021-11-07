// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.NavigationViewPaneClosingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides data for the NavigationView.PaneClosing event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NavigationViewPaneClosingEventArgs : INavigationViewPaneClosingEventArgs
  {
    /// <summary>Gets or sets a value that indicates whether the event should be canceled.</summary>
    /// <returns>**true** to cancel the event; otherwise, **false**. The default is **false**.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }
  }
}
