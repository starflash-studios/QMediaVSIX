// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.PenDockListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  /// <summary>Provides access to docking state event notifications from a connected pen device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [DualApiPartition(version = 1)]
  [Static(typeof (IPenDockListenerStatics), 655360, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class PenDockListener : IPenDockListener
  {
    /// <summary>Retrieves whether pen docking state event notifications are currently supported.</summary>
    /// <returns>True, if currently supported. Otherwise, false.</returns>
    [MethodImpl]
    public extern bool IsSupported();

    /// <summary>Occurs when the availability of pen docking event changes (pen settings are changed by the user or system support changes).</summary>
    public extern event TypedEventHandler<PenDockListener, object> IsSupportedChanged;

    /// <summary>Occurs when the user docks a pen.</summary>
    public extern event TypedEventHandler<PenDockListener, PenDockedEventArgs> Docked;

    /// <summary>Occurs when the user undocks a pen.</summary>
    public extern event TypedEventHandler<PenDockListener, PenUndockedEventArgs> Undocked;

    /// <summary>Retrieves the default listener for pen dock events.</summary>
    /// <returns>An object that represents a listener for pen dock events in the default context.</returns>
    [MethodImpl]
    public static extern PenDockListener GetDefault();
  }
}
