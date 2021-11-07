// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkInputProcessingConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Manages how input is processed by the InkPresenter object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class InkInputProcessingConfiguration : IInkInputProcessingConfiguration
  {
    /// <summary>Gets or sets how the InkPresenter object renders secondrary input from a pen barrel button, pen eraser tip, right mouse button, or similar on its associated InkCanvas control.</summary>
    /// <returns>The input behavior.</returns>
    public extern InkInputProcessingMode Mode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets how the InkPresenter object handles secondary input from a pen barrel button, pen eraser tip, right mouse button, or similar.</summary>
    /// <returns>The input behavior when modified with a secondary affordance.</returns>
    public extern InkInputRightDragAction RightDragAction { [MethodImpl] get; [MethodImpl] set; }
  }
}
