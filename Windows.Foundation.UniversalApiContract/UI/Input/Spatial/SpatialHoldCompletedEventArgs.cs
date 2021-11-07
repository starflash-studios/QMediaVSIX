// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialHoldCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Provides data for the SpatialGestureRecognizer.HoldCompleted event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialHoldCompletedEventArgs : ISpatialHoldCompletedEventArgs
  {
    /// <summary>Gets the kind of interaction source associated with this gesture.</summary>
    /// <returns>The interaction source kind.</returns>
    public extern SpatialInteractionSourceKind InteractionSourceKind { [MethodImpl] get; }
  }
}
