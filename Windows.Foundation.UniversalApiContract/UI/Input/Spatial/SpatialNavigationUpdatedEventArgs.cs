// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialNavigationUpdatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Provides data for the SpatialGestureRecognizer.NavigationUpdated event.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialNavigationUpdatedEventArgs : ISpatialNavigationUpdatedEventArgs
  {
    /// <summary>Gets the kind of interaction source associated with this gesture.</summary>
    /// <returns>The interaction source kind.</returns>
    public extern SpatialInteractionSourceKind InteractionSourceKind { [MethodImpl] get; }

    /// <summary>Gets the normalized offset of the hand or motion controller within the unit cube for all axes for this Navigation gesture.</summary>
    /// <returns>The normalized offset.</returns>
    public extern Vector3 NormalizedOffset { [MethodImpl] get; }
  }
}
