// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.Preview.GazeEnteredPreviewEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input.Preview
{
  /// <summary>Provides event data for the GazeEntered event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class GazeEnteredPreviewEventArgs : IGazeEnteredPreviewEventArgs
  {
    /// <summary>Gets or sets a value that indicates whether the GazeEntered has been handled.</summary>
    /// <returns>
    /// </returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the gaze pointer data from the most recent GazeEntered event.</summary>
    /// <returns>The gaze pointer data from the most recent GazeEntered event.</returns>
    public extern GazePointPreview CurrentPoint { [MethodImpl] get; }
  }
}
