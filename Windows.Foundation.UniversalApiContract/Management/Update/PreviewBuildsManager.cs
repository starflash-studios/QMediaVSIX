// Decompiled with JetBrains decompiler
// Type: Windows.Management.Update.PreviewBuildsManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Update
{
  /// <summary>Manages the state of preview builds for the device.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Static(typeof (IPreviewBuildsManagerStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PreviewBuildsManager : IPreviewBuildsManager
  {
    /// <summary>A boolean value describing whether preview builds are allowed on the device.</summary>
    /// <returns>True if preview builds are allowed; False if preview builds are not allowed.</returns>
    public extern bool ArePreviewBuildsAllowed { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The current state of the PreviewBuildsState object.</summary>
    /// <returns>The current `PreviewBuildsState` object.</returns>
    [MethodImpl]
    public extern PreviewBuildsState GetCurrentState();

    /// <summary>Syncs the PreviewBuildsManager with the server to get current information.</summary>
    /// <returns>True if the PreviewBuildsManager object successfully synced; False otherwise.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SyncAsync();

    /// <summary>Gets the default PreviewBuildsManager from the device.</summary>
    /// <returns>The default PreviewBuildsManager. This will return `null` if the API is not supported on the platform.</returns>
    [MethodImpl]
    public static extern PreviewBuildsManager GetDefault();

    /// <summary>Determines if this API is supported on the device.</summary>
    /// <returns>True if the API is supported; False otherwise.</returns>
    [MethodImpl]
    public static extern bool IsSupported();
  }
}
