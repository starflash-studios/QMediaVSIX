// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextCompositionCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  /// <summary>Provides data for the CompositionCompleted event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreTextCompositionCompletedEventArgs : ICoreTextCompositionCompletedEventArgs
  {
    /// <summary>Gets a value that indicates whether the operation is canceled.</summary>
    /// <returns>**true** if the operation is canceled; otherwise, **false**.</returns>
    public extern bool IsCanceled { [MethodImpl] get; }

    /// <summary>Gets a collection of CoreTextCompositionSegment objects representing the segments in the composition string. Applications can use this property, for example, to get the pre-conversion string for each composition segment.</summary>
    /// <returns>A collection of CoreTextCompositionSegment objects.</returns>
    public extern IVectorView<CoreTextCompositionSegment> CompositionSegments { [MethodImpl] get; }

    /// <summary>Requests that the operation be delayed. Call this method if your text input control is hosted on a worker thread rather than on the UI thread.</summary>
    /// <returns>A Deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
