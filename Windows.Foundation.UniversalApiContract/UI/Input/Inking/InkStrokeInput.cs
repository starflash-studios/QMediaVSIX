// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkStrokeInput
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking
{
  /// <summary>Provides properties and events for StrokeInput associated with an InkPresenter object.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class InkStrokeInput : IInkStrokeInput
  {
    /// <summary>Occurs when stroke input is first detected by an InkPresenter object.</summary>
    public extern event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeStarted;

    /// <summary>Occurs when stroke input has started (StrokeStarted ) and continues to be captured by an InkPresenter object.</summary>
    public extern event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeContinued;

    /// <summary>Occurs when stroke input has stopped being detected by an InkPresenter object.</summary>
    public extern event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeEnded;

    /// <summary>Occurs when ink input bubbles up to another system event handler, such as a context menu.</summary>
    public extern event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeCanceled;

    /// <summary>Gets the InkPresenter object associated with the ink input data.</summary>
    /// <returns>The ink presenter associated with the ink input.</returns>
    public extern InkPresenter InkPresenter { [MethodImpl] get; }
  }
}
