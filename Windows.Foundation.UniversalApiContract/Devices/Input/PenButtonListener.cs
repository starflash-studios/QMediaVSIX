// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.PenButtonListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  /// <summary>Provides access to button action event notifications from a connected pen device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Static(typeof (IPenButtonListenerStatics), 655360, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public sealed class PenButtonListener : IPenButtonListener
  {
    /// <summary>Retrieves whether pen button action event notifications are currently supported.</summary>
    /// <returns>True, if currently supported. Otherwise, false.</returns>
    [MethodImpl]
    public extern bool IsSupported();

    /// <summary>Occurs when the availability of pen button events changes (pen settings are changed by the user or system support changes).</summary>
    public extern event TypedEventHandler<PenButtonListener, object> IsSupportedChanged;

    /// <summary>Occurs when the user presses and releases (clicks) the button on the tail end of the pen.</summary>
    public extern event TypedEventHandler<PenButtonListener, PenTailButtonClickedEventArgs> TailButtonClicked;

    /// <summary>Occurs when the user presses and releases (clicks) the button on the tail end of the pen twice in quick succession.</summary>
    public extern event TypedEventHandler<PenButtonListener, PenTailButtonDoubleClickedEventArgs> TailButtonDoubleClicked;

    /// <summary>Occurs when the user presses and holds the button on the tail end of the pen.</summary>
    public extern event TypedEventHandler<PenButtonListener, PenTailButtonLongPressedEventArgs> TailButtonLongPressed;

    /// <summary>Retrieves the default listener for pen button events.</summary>
    /// <returns>An object that represents a listener for pen button events in the default context.</returns>
    [MethodImpl]
    public static extern PenButtonListener GetDefault();
  }
}
