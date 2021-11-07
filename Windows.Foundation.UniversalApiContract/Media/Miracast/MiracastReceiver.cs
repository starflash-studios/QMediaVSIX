// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiver
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>An object that allows an app to implement a Miracast Receiver (Sink) and receive incoming Miracast connections.</summary>
  [Activatable(524288, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MiracastReceiver : IMiracastReceiver
  {
    /// <summary>Creates a new instance of a MiracastReceiver object.</summary>
    [MethodImpl]
    public extern MiracastReceiver();

    /// <summary>Returns default settings for the MiracastReceiver.</summary>
    /// <returns>A MiracastReceiverSettings object containing information about the default settings for the **MiracastReceiver**.</returns>
    [MethodImpl]
    public extern MiracastReceiverSettings GetDefaultSettings();

    /// <summary>Returns the settings currently used by the MiracastReceiver.</summary>
    /// <returns>A MiracastReceiverApplySettingsResult containing information about the current settings used by the **MiracastReceiver**.</returns>
    [MethodImpl]
    public extern MiracastReceiverSettings GetCurrentSettings();

    /// <summary>Returns the settings currently used by the MiracastReceiver.</summary>
    /// <returns>An asynchronous operation that returns a MiracastReceiverApplySettingsResult object upon completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MiracastReceiverSettings> GetCurrentSettingsAsync();

    /// <summary>Disconnects all currently connected Miracast connections and applies the specified settings on the MiracastReceiver.</summary>
    /// <param name="settings">The settings that will be applied.</param>
    /// <returns>A MiracastReceiverApplySettingsResult containing information about the result of the operation.</returns>
    [MethodImpl]
    public extern MiracastReceiverApplySettingsResult DisconnectAllAndApplySettings(
      MiracastReceiverSettings settings);

    /// <summary>Asynchronously disconnects all currently connected Miracast connections and applies the specified settings on the MiracastReceiver.</summary>
    /// <param name="settings">The settings that will be applied.</param>
    /// <returns>An asynchronous operation that returns a **MiracastReceiverApplySettingsResult** object upon completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MiracastReceiverApplySettingsResult> DisconnectAllAndApplySettingsAsync(
      MiracastReceiverSettings settings);

    /// <summary>Retrieves the current status of the MiracastReceiver.</summary>
    /// <returns>A MiracastReceiverStatus object containing information about the the current status of the **MiracastReceiver**.</returns>
    [MethodImpl]
    public extern MiracastReceiverStatus GetStatus();

    /// <summary>Asynchronously retrieves the current status of the MiracastReceiver.</summary>
    /// <returns>An asynchronous operation that returns a MiracastReceiverStatus object upon completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MiracastReceiverStatus> GetStatusAsync();

    /// <summary>An event that is raised when the status of the MiracastReceiver has changed.</summary>
    public extern event TypedEventHandler<MiracastReceiver, object> StatusChanged;

    /// <summary>Creates a new MiracastReceiverSession object, needed to receive Miracast connections.</summary>
    /// <param name="view">The CoreApplicationView used by the app when displaying the Miracast video stream.</param>
    /// <returns>The new **MiracastReceiverSession** object.</returns>
    [MethodImpl]
    public extern MiracastReceiverSession CreateSession(
      CoreApplicationView view);

    /// <summary>Asynchronously creates a new MiracastReceiverSession object, needed to receive Miracast connections.</summary>
    /// <param name="view">The CoreApplicationView used by the app when displaying the Miracast video stream.</param>
    /// <returns>An asynchronous operation that returns the new **MiracastReceiverSession** object upon completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MiracastReceiverSession> CreateSessionAsync(
      CoreApplicationView view);

    /// <summary>Empties the collection of known MiracastTransmitter objects.</summary>
    [MethodImpl]
    public extern void ClearKnownTransmitters();

    /// <summary>Remove a specified MiracastTransmitter from the collection of known MiracastTransmitter objects .</summary>
    /// <param name="transmitter">The **MiracastTransmitter** to be removed.</param>
    [MethodImpl]
    public extern void RemoveKnownTransmitter(MiracastTransmitter transmitter);
  }
}
