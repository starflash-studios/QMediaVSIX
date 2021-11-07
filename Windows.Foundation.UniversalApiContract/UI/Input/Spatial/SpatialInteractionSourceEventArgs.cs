// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionSourceEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Provides data for the SpatialInteractionSource Source events.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialInteractionSourceEventArgs : 
    ISpatialInteractionSourceEventArgs,
    ISpatialInteractionSourceEventArgs2
  {
    /// <summary>Gets the interaction source state associated with the event.</summary>
    /// <returns>The interaction source state.</returns>
    public extern SpatialInteractionSourceState State { [MethodImpl] get; }

    /// <summary>Gets the kind of press or release associated with the event.</summary>
    /// <returns>The press kind.</returns>
    public extern SpatialInteractionPressKind PressKind { [MethodImpl] get; }
  }
}
