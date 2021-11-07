// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkRecognitionResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Provides properties and methods to manage InkStroke handwriting recognition data.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class InkRecognitionResult : IInkRecognitionResult
  {
    /// <summary>Gets the bounding rectangle of the InkStroke data used for handwriting recognition.</summary>
    /// <returns>The bounding rectangle of the ink strokes.</returns>
    public extern Rect BoundingRect { [MethodImpl] get; }

    /// <summary>Retrieves the collection of strings identified as potential matches for each word returned by handwriting recognition.</summary>
    /// <returns>The recognition matches as a collection of String objects. The most likely candidate is topmost in the collection.</returns>
    [MethodImpl]
    public extern IVectorView<string> GetTextCandidates();

    /// <summary>Retrieves all ink strokes used for handwriting recognition.</summary>
    /// <returns>The ink strokes used for handwriting recognition as a collection of InkStroke objects.</returns>
    [MethodImpl]
    public extern IVectorView<InkStroke> GetStrokes();
  }
}
