// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.KeyboardDeliveryInterceptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input
{
  /// <summary>Enables an app to override the system processing of raw keyboard input, including key combinations such as shortcut keys, access keys (or hot keys), accelerator keys, and application keys.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Static(typeof (IKeyboardDeliveryInterceptorStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class KeyboardDeliveryInterceptor : IKeyboardDeliveryInterceptor
  {
    /// <summary>Gets or sets whether the app overrides the system processing of raw keyboard input, including key combinations such as shortcut keys, access keys (or hot keys), accelerator keys, and application keys.</summary>
    /// <returns>True if the app processes raw keyboard input instead of the system. Otherwise, false.</returns>
    public extern bool IsInterceptionEnabledWhenInForeground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a keyboard key is pressed. State info and event data is routed through this event instead of CoreWindow.KeyDown.</summary>
    public extern event TypedEventHandler<KeyboardDeliveryInterceptor, KeyEventArgs> KeyDown;

    /// <summary>Occurs when a pressed keyboard key is released. State info and event data is routed through this event instead of CoreWindow.KeyUp.</summary>
    public extern event TypedEventHandler<KeyboardDeliveryInterceptor, KeyEventArgs> KeyUp;

    /// <summary>Retrieves a KeyboardDeliveryInterceptor object associated with the current app view.</summary>
    /// <returns>The KeyboardDeliveryInterceptor object associated with the current app.</returns>
    [MethodImpl]
    public static extern KeyboardDeliveryInterceptor GetForCurrentView();
  }
}
