// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.CoreWindowResizeManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Defines a type used to manage CoreWindow.SizeChanged events. This type is used by frameworks (such as XAML) or apps that implement their own IFrameWorkView to synchronize the handover between shell drawn placholder (such as a splash screen) and the apps first drawn frame, so that there is no gap in the transition from one to the other. If your app does not implement the IFrameWorkView itself you should not participate in this synchronization as the framwork will do it for you.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICoreWindowResizeManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CoreWindowResizeManager : 
    ICoreWindowResizeManager,
    ICoreWindowResizeManagerLayoutCapability
  {
    /// <summary>Notifies the parent CoreWindow object that the new layout has completed.</summary>
    [MethodImpl]
    public extern void NotifyLayoutCompleted();

    /// <summary>Gets or sets whether the caller should wait for the new layout to complete.</summary>
    /// <returns>**true** if the caller should wait for the new layout to complete; **false** if it should not.</returns>
    public extern bool ShouldWaitForLayoutCompletion { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets an instance of CoreWindowResizeManager for the running app's current CoreWindow.</summary>
    /// <returns>An instance of CoreWindowResizeManager for the running app's current CoreWindow.</returns>
    [MethodImpl]
    public static extern CoreWindowResizeManager GetForCurrentView();
  }
}
