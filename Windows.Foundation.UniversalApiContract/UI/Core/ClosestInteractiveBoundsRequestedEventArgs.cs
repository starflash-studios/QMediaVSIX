// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ClosestInteractiveBoundsRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Provides event data for the **ClosestInteractiveBoundsRequested** event. Not intended for general use. See CoreComponentInputSource.ClosestInteractiveBoundsRequested and CoreWindow.ClosestInteractiveBoundsRequested.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class ClosestInteractiveBoundsRequestedEventArgs : 
    IClosestInteractiveBoundsRequestedEventArgs
  {
    /// <summary>Gets the client coordinates of the pointer.</summary>
    /// <returns>The position of the pointer in device-independent pixel (DIP).</returns>
    public extern Point PointerPosition { [MethodImpl] get; }

    /// <summary>Gets or sets the bounding rectangle in which to search for interactive elements.</summary>
    /// <returns>The bounding rectangle in which to search for interactive elements.</returns>
    public extern Rect SearchBounds { [MethodImpl] get; }

    /// <summary>Gets or sets the bounding rectangle of the interactive element that is within the SearchBounds and closest to the PointerPosition.</summary>
    /// <returns>The bounding rectangle of the interactive element that is within the SearchBounds and closest to the PointerPosition.</returns>
    public extern Rect ClosestInteractiveBounds { [MethodImpl] get; [MethodImpl] set; }
  }
}
