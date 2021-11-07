// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkInputConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Manages which types of secondary input can be processed by the InkPresenter object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InkInputConfiguration : IInkInputConfiguration, IInkInputConfiguration2
  {
    /// <summary>Gets or sets whether input from a pen's primary barrel button is processed by the InkPresenter object.</summary>
    /// <returns>True, if input from the primary barrel button is processed; otherwise, false.</returns>
    public extern bool IsPrimaryBarrelButtonInputEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether input from a pen's eraser tip is processed by the InkPresenter object.</summary>
    /// <returns>True, if input from the eraser tip is processed; otherwise, false.</returns>
    public extern bool IsEraserInputEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPenHapticFeedbackEnabled { [MethodImpl] get; [MethodImpl] set; }
  }
}
