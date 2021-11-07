// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.SceneModeControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Provides functionality for controlling the scene mode settings on a capture device.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class SceneModeControl : ISceneModeControl
  {
    /// <summary>Gets the scene modes supported on the capture device.</summary>
    /// <returns>The supported scene modes.</returns>
    public extern IVectorView<CaptureSceneMode> SupportedModes { [MethodImpl] get; }

    /// <summary>Gets the current scene mod ethe capture device is set to.</summary>
    /// <returns>The scene mode.</returns>
    public extern CaptureSceneMode Value { [MethodImpl] get; }

    /// <summary>Asynchronously sets the color temperature Value.</summary>
    /// <param name="sceneMode">The scene mode to set the Value property to.</param>
    /// <returns>The object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetValueAsync(CaptureSceneMode sceneMode);
  }
}
