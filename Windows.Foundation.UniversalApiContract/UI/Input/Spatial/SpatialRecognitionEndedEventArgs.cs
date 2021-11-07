// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialRecognitionEndedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Provides data for the SpatialGestureRecognizer.RecognitionEnded event.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialRecognitionEndedEventArgs : ISpatialRecognitionEndedEventArgs
  {
    /// <summary>Gets the kind of interaction source associated with this gesture.</summary>
    /// <returns>The interaction source kind.</returns>
    public extern SpatialInteractionSourceKind InteractionSourceKind { [MethodImpl] get; }
  }
}
