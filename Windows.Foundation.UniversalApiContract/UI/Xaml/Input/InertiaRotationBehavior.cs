// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.InertiaRotationBehavior
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Controls the deceleration of a rotation manipulation during inertia.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InertiaRotationBehavior : IInertiaRotationBehavior
  {
    /// <summary>Gets or sets the rate the rotation slows in degrees per squared millisecond.</summary>
    /// <returns>The rate the rotation slows in degrees per squared millisecond.</returns>
    public extern double DesiredDeceleration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rotation, in degrees, at the end of the inertial movement.</summary>
    /// <returns>The rotation, in degrees, at the end of the inertial movement.</returns>
    public extern double DesiredRotation { [MethodImpl] get; [MethodImpl] set; }
  }
}
