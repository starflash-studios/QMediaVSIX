// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.MenuBarAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes MenuBar types to Microsoft UI Automation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Composable(typeof (IMenuBarAutomationPeerFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class MenuBarAutomationPeer : FrameworkElementAutomationPeer, IMenuBarAutomationPeer
  {
    /// <summary>Initializes a new instance of the MenuBarAutomationPeer class using the specified MenuBar.</summary>
    /// <param name="owner">The specified MenuBar.</param>
    [MethodImpl]
    public extern MenuBarAutomationPeer(MenuBar owner);
  }
}
