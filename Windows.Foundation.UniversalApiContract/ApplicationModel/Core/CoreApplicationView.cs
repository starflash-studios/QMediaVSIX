// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.CoreApplicationView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Core;

namespace Windows.ApplicationModel.Core
{
  /// <summary>Represents an app window and its thread.</summary>
  [Muse(Version = 100794368)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class CoreApplicationView : 
    ICoreApplicationView,
    ICoreApplicationView2,
    ICoreApplicationView3,
    ICoreApplicationView5,
    ICoreApplicationView6
  {
    /// <summary>Gets the app window associated with the current view.</summary>
    /// <returns>The app window.</returns>
    public extern CoreWindow CoreWindow { [MethodImpl] get; }

    /// <summary>Occurs when the view is activated.</summary>
    public extern event TypedEventHandler<CoreApplicationView, IActivatedEventArgs> Activated;

    /// <summary>Gets a value that indicates whether this app view is the main app view or not.</summary>
    /// <returns>If **true**, this app view is the main; if **false**, it is not.</returns>
    public extern bool IsMain { [MethodImpl] get; }

    /// <summary>Gets the value that indicates whether this app view is hosted or not.</summary>
    /// <returns>If **true**, this app view is hosted; if **false**, it is not.</returns>
    public extern bool IsHosted { [MethodImpl] get; }

    /// <summary>Gets the event message dispatcher associated with the current view.</summary>
    /// <returns>The event message dispatcher.</returns>
    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    /// <summary>Gets whether the app was launched as a component that is embedded in another app.</summary>
    /// <returns>**True** if the app was launched as a component that is embedded in another app; **false** otherwise.</returns>
    public extern bool IsComponent { [MethodImpl] get; }

    /// <summary>Gets the title bar associated with the current view.</summary>
    /// <returns>The title bar associated with the current view.</returns>
    public extern CoreApplicationViewTitleBar TitleBar { [MethodImpl] get; }

    /// <summary>Indicates that the hosted view is closing. Provides an opportunity for hosted window scenarios to defer the tear down of the hosted view.</summary>
    public extern event TypedEventHandler<CoreApplicationView, HostedViewClosingEventArgs> HostedViewClosing;

    /// <summary>Gets properties that the app can associate with the view.</summary>
    /// <returns>The property bag.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }

    /// <summary>Gets the **DispatcherQueue** for the window.</summary>
    /// <returns>A **DispatcherQueue** instance.</returns>
    public extern DispatcherQueue DispatcherQueue { [MethodImpl] get; }
  }
}
