// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkManipulationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  /// <summary>Specifies the modes of ink input.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum InkManipulationMode
  {
    /// <summary>All points are passed to the InkStrokeBuilder and an InkStroke is created. The stroke is appended to the stroke collection of the InkManager or InkStrokeContainer.</summary>
    Inking,
    /// <summary>All strokes are hit tested against all strokes in the stroke collection. If there is an intersection, InkManager deletes the stroke automatically and returns an invalidated rectangle for processPointerUpdate calls.</summary>
    Erasing,
    /// <summary>All points are used to create a polyline. When you call processPointerUp, the polyline is hit tested against entire stroke collection and all strokes within the polyline are marked as selected.</summary>
    Selecting,
  }
}
