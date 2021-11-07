// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Core.RadialControllerIndependentInputSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Core;

namespace Windows.UI.Input.Core
{
  /// <summary>Enables an app to handle radial controller input on the background thread.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IRadialControllerIndependentInputSourceStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772163)]
  public sealed class RadialControllerIndependentInputSource : 
    IRadialControllerIndependentInputSource,
    IRadialControllerIndependentInputSource2
  {
    /// <summary>Gets a reference to a wheel input device or accessory such as the Surface Dial.</summary>
    /// <returns>The wheel input device.</returns>
    public extern RadialController Controller { [MethodImpl] get; }

    /// <summary>Gets the event message dispatcher associated with the current view.</summary>
    /// <returns>The event message dispatcher.</returns>
    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    /// <summary>Gets the DispatcherQueue associated with this RadialControllerIndependentInputSource.</summary>
    /// <returns>The DispatcherQueue for managing prioritized tasks that execute in a serial fashion on a thread.</returns>
    public extern DispatcherQueue DispatcherQueue { [MethodImpl] get; }

    /// <summary>Gets an instance of RadialControllerIndependentInputSource for the running app's current CoreWindow.</summary>
    /// <param name="view">The app window and its thread.</param>
    /// <returns>The radial controller input manager.</returns>
    [MethodImpl]
    public static extern RadialControllerIndependentInputSource CreateForView(
      CoreApplicationView view);
  }
}
