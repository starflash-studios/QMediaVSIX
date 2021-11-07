// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes FrameworkElement derived types (including all controls) to Microsoft UI Automation.</summary>
  [Composable(typeof (IFrameworkElementAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IFrameworkElementAutomationPeerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class FrameworkElementAutomationPeer : AutomationPeer, IFrameworkElementAutomationPeer
  {
    /// <summary>Initializes a new instance of the FrameworkElementAutomationPeer class.</summary>
    /// <param name="owner">The owner element to create for.</param>
    [MethodImpl]
    public extern FrameworkElementAutomationPeer(FrameworkElement owner);

    /// <summary>Gets the UIElement owner that is associated with this FrameworkElementAutomationPeer.</summary>
    /// <returns>The element that owns this instance of the peer class.</returns>
    public extern UIElement Owner { [MethodImpl] get; }

    /// <summary>Returns the FrameworkElementAutomationPeer for the specified UIElement.</summary>
    /// <param name="element">The UIElement that is associated with this FrameworkElementAutomationPeer.</param>
    /// <returns>The FrameworkElementAutomationPeer, or null if the FrameworkElementAutomationPeer could not be created.</returns>
    [MethodImpl]
    public static extern AutomationPeer FromElement(UIElement element);

    /// <summary>Creates a FrameworkElementAutomationPeer for the specified UIElement.</summary>
    /// <param name="element">The UIElement that is associated with this FrameworkElementAutomationPeer.</param>
    /// <returns>A FrameworkElementAutomationPeer.</returns>
    [MethodImpl]
    public static extern AutomationPeer CreatePeerForElement(UIElement element);
  }
}
