// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionSourceConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Represents the configuration of a VisualInteractionSource input.</summary>
  [DualApiPartition(version = 167772166)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class InteractionSourceConfiguration : 
    CompositionObject,
    IInteractionSourceConfiguration
  {
    /// <summary>Gets or sets a value that indicates how interactions are processed for this VisualInteractionSource input on the X axis.</summary>
    /// <returns>The source mode for the X axis. By default, it takes the value of VisualInteractionTracker.PositionXSourceMode.</returns>
    public extern InteractionSourceRedirectionMode PositionXSourceMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how interactions are processed for this VisualInteractionSource input on the Y axis.</summary>
    /// <returns>The source mode for the Y axis. By default, it takes the value of VisualInteractionTracker.PositionYSourceMode.</returns>
    public extern InteractionSourceRedirectionMode PositionYSourceMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how interactions are processed for this VisualInteractionSource input on the scale axis.</summary>
    /// <returns>The source mode for the scale axis. By default, it takes the value of VisualInteractionTracker.ScaleSourceMode.</returns>
    public extern InteractionSourceRedirectionMode ScaleSourceMode { [MethodImpl] get; [MethodImpl] set; }
  }
}
