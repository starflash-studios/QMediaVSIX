// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.KeyboardAccelerator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Represents a keyboard shortcut (or accelerator) that lets a user perform an action using the keyboard instead of navigating the app UI (directly or through access keys).</summary>
  [Static(typeof (IKeyboardAcceleratorStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IKeyboardAcceleratorFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public class KeyboardAccelerator : DependencyObject, IKeyboardAccelerator
  {
    /// <summary>Initializes a new instance of the KeyboardAccelerator class.</summary>
    [MethodImpl]
    public extern KeyboardAccelerator();

    /// <summary>Gets or sets the virtual key (used in conjunction with one or more modifier keys) for a keyboard shortcut (accelerator).</summary>
    /// <returns>The virtual key.</returns>
    public extern VirtualKey Key { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the virtual key used to modify another keypress for a keyboard shortcut (accelerator).</summary>
    /// <returns>The virtual key.</returns>
    public extern VirtualKeyModifiers Modifiers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether a keyboard shortcut (accelerator) is available to the user.</summary>
    /// <returns>**true** if the shortcut is available; otherwise, **false**.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the scope (or target) of the keyboard accelerator.</summary>
    /// <returns>The default is null (global scope).</returns>
    public extern DependencyObject ScopeOwner { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the key combination for this KeyboardAccelerator is pressed.</summary>
    public extern event TypedEventHandler<KeyboardAccelerator, KeyboardAcceleratorInvokedEventArgs> Invoked;

    /// <summary>Identifies the Key dependency property.</summary>
    /// <returns>The identifier for the Key dependency property.</returns>
    public static extern DependencyProperty KeyProperty { [MethodImpl] get; }

    /// <summary>Identifies the Modifiers dependency property.</summary>
    /// <returns>The identifier for the Modifiers dependency property.</returns>
    public static extern DependencyProperty ModifiersProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsEnabled dependency property.</summary>
    /// <returns>The identifier for the IsEnabled dependency property.</returns>
    public static extern DependencyProperty IsEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the ScopeOwner dependency property.</summary>
    /// <returns>The identifier for the ScopeOwner dependency property.</returns>
    public static extern DependencyProperty ScopeOwnerProperty { [MethodImpl] get; }
  }
}
