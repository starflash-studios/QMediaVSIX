// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.MenuBarItemFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents the flyout of a MenuBar item.</summary>
  [Composable(typeof (IMenuBarItemFlyoutFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class MenuBarItemFlyout : MenuFlyout, IMenuBarItemFlyout
  {
    /// <summary>Initializes a new instance of the MenuBarItemFlyout class.</summary>
    [MethodImpl]
    public extern MenuBarItemFlyout();
  }
}
