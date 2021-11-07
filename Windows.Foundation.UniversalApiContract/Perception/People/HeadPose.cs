// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.HeadPose
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.People
{
  /// <summary>Represents the user's head gaze in relation to their surroundings.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HeadPose : IHeadPose
  {
    /// <summary>Gets the position of the user's head in the specified coordinate system.</summary>
    /// <returns>The position.</returns>
    public extern Vector3 Position { [MethodImpl] get; }

    /// <summary>Gets the forward direction of the user's head gaze in the specified coordinate system, as a unit vector.</summary>
    /// <returns>The forward direction unit vector.</returns>
    public extern Vector3 ForwardDirection { [MethodImpl] get; }

    /// <summary>Gets the up direction that orients the user's head gaze in the specified coordinate system, as a unit vector.</summary>
    /// <returns>The up direction unit vector.</returns>
    public extern Vector3 UpDirection { [MethodImpl] get; }
  }
}
