// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioPlaybackConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Represents a connection that allows a remote device to stream audio to a Windows device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Static(typeof (IAudioPlaybackConnectionStatics), 655360, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public sealed class AudioPlaybackConnection : IAudioPlaybackConnection, IClosable
  {
    /// <summary>Configures the system to allow connections from the remote audio source.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Asynchronously configures the system to allow connections from the remote audio source.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartAsync();

    /// <summary>Gets the unique device ID for the underlying device represented by the AudioPlaybackConnection.</summary>
    /// <returns>The unique device ID for the underlying device represented by the **AudioPlaybackConnection**.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the current connection state of the AudioPlaybackConnection.</summary>
    /// <returns>A member of the AudioPlaybackConnectionState enumeration, indicating the current connection state.</returns>
    public extern AudioPlaybackConnectionState State { [MethodImpl] get; }

    /// <summary>Attempts to connect the underlying device. If successful, this causes any audio that is playing on the remote device to be heard on the local device.</summary>
    /// <returns>An AudioPlaybackConnectionOpenResult object. The Status property of this object indicates the result of the connection attempt.</returns>
    [MethodImpl]
    public extern AudioPlaybackConnectionOpenResult Open();

    /// <summary>Asynchronously attempts to connect the underlying device. If successful, this causes any audio that is playing on the remote device to be heard on the local device.</summary>
    /// <returns>Upon completion, returns an AudioPlaybackConnectionOpenResult object. The Status property of this object indicates the result of the connection attempt.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AudioPlaybackConnectionOpenResult> OpenAsync();

    /// <summary>Occurs when the connection state of the AudioPlaybackConnection changes.</summary>
    public extern event TypedEventHandler<AudioPlaybackConnection, object> StateChanged;

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets an Advanced Query Syntax (AQS) string for that can be used to find devices for which an AudioPlaybackConnection can be created.</summary>
    /// <returns>An AQS string.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Attempts to create an AudioPlaybackConnection from the specified device ID.</summary>
    /// <param name="id">The identifier for the device for which the connection should be created.</param>
    /// <returns>If successful, returns an AudioPlaybackConnection. If the specified device does not have support for audio streaming, the return value is null.</returns>
    [MethodImpl]
    public static extern AudioPlaybackConnection TryCreateFromId(string id);
  }
}
