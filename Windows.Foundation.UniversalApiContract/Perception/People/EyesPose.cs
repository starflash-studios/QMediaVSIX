// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.EyesPose
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;
using Windows.UI.Input;

namespace Windows.Perception.People
{
  /// <summary>Represents the user's eye gaze in relation to their surroundings.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IEyesPoseStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class EyesPose : IEyesPose
  {
    /// <summary>Gets whether eye gaze has been calibrated for the current user in the headset.</summary>
    /// <returns>Whether eye gaze has been calibrated for the current user.</returns>
    public extern bool IsCalibrationValid { [MethodImpl] get; }

    /// <summary>Gets the user's eye gaze in the specified coordinate system.</summary>
    /// <returns>The eye gaze, if calibration is valid for the current user and their eyes are currently detected; otherwise, null.</returns>
    public extern IReference<SpatialRay> Gaze { [MethodImpl] get; }

    /// <summary>Gets the timestamp at which this eye gaze snapshot was taken.</summary>
    /// <returns>The timestamp.</returns>
    public extern PerceptionTimestamp UpdateTimestamp { [MethodImpl] get; }

    /// <summary>Gets whether eye gaze is supported by the current headset.</summary>
    /// <returns>Whether eye gaze is supported.</returns>
    [MethodImpl]
    public static extern bool IsSupported();

    /// <summary>Requests access for an app to use spatial eye gaze. This requires the **gazeInput** capability.</summary>
    /// <returns>Operation that triggers once the user has completed any consent dialog, providing the access status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<GazeInputAccessStatus> RequestAccessAsync();
  }
}
