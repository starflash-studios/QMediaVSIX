// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkStrokesErasedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Contains event data for the StrokesErased event of the InkPresenter associated with an InkCanvas control.</summary>
  [MarshalingBehavior(MarshalingType.None)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class InkStrokesErasedEventArgs : IInkStrokesErasedEventArgs
  {
    /// <summary>Gets the collection of ink strokes associated with the StrokesErased event.</summary>
    /// <returns>The erased ink strokes as a collection of InkStroke objects.</returns>
    public extern IVectorView<InkStroke> Strokes { [MethodImpl] get; }
  }
}
