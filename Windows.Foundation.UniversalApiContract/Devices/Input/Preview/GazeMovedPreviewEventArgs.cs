// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.Preview.GazeMovedPreviewEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input.Preview
{
  /// <summary>Provides event data for the GazeMoved event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GazeMovedPreviewEventArgs : IGazeMovedPreviewEventArgs
  {
    /// <summary>Gets or sets a value that indicates whether the GazeMoved event has been handled.</summary>
    /// <returns>**true** to mark the event handled. **false** to leave the event unhandled, which permits the event to potentially be acted on by other handlers. The default is **false**.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the gaze pointer data from the most recent GazeMoved event.</summary>
    /// <returns>A gaze pointer object.</returns>
    public extern GazePointPreview CurrentPoint { [MethodImpl] get; }

    /// <summary>Retrieves the gaze point data for each gaze location logged since the most recent GazeMoved event, up to and including the current event.</summary>
    /// <returns>A collection of gaze point objects.</returns>
    [MethodImpl]
    public extern IVector<GazePointPreview> GetIntermediatePoints();
  }
}
