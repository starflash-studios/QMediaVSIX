// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionControllerProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Represents state specific to motion controllers.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialInteractionControllerProperties : 
    ISpatialInteractionControllerProperties
  {
    /// <summary>Gets whether a motion controller is experiencing a touchpad touch.</summary>
    /// <returns>Whether the source is experiencing a touchpad touch.</returns>
    public extern bool IsTouchpadTouched { [MethodImpl] get; }

    /// <summary>Gets whether a motion controller is experiencing a touchpad press.</summary>
    /// <returns>Whether the source is experiencing a touchpad press.</returns>
    public extern bool IsTouchpadPressed { [MethodImpl] get; }

    /// <summary>Gets whether a motion controller is experiencing a thumbstick press.</summary>
    /// <returns>Whether the source is experiencing a thumbstick press.</returns>
    public extern bool IsThumbstickPressed { [MethodImpl] get; }

    /// <summary>Gets a value between -1.0 and 1.0 representing the horizontal position of the thumbstick.</summary>
    /// <returns>The thumbstick X value.</returns>
    public extern double ThumbstickX { [MethodImpl] get; }

    /// <summary>Gets a value between -1.0 and 1.0 representing the vertical position of the thumbstick.</summary>
    /// <returns>The thumbstick Y value.</returns>
    public extern double ThumbstickY { [MethodImpl] get; }

    /// <summary>Gets a value between -1.0 and 1.0 representing the horizontal position of the user's finger on the touchpad.</summary>
    /// <returns>The touchpad X value.</returns>
    public extern double TouchpadX { [MethodImpl] get; }

    /// <summary>Gets a value between -1.0 and 1.0 representing the vertical position of the user's finger on the touchpad.</summary>
    /// <returns>The touchpad Y value.</returns>
    public extern double TouchpadY { [MethodImpl] get; }
  }
}
