// Decompiled with JetBrains decompiler
// Type: Windows.UI.Accessibility.ScreenReaderPositionChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Accessibility
{
  /// <summary>Contains event data for the ScreenReaderPositionChanged event of a ScreenReaderService.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ScreenReaderPositionChangedEventArgs : IScreenReaderPositionChangedEventArgs
  {
    /// <summary>Gets a rectangle corresponding to the new location of the screen reader focus indicator (such as the Narrator focus highlight box).</summary>
    /// <returns>The physical screen coordinates of the upper left corner of the screen reader focus indicator, and its height and width, in pixels.</returns>
    public extern Rect ScreenPositionInRawPixels { [MethodImpl] get; }

    /// <summary>Gets whether a screen reader is currently reading a block of text.</summary>
    /// <returns>True if the screen reader is reading text; otherwise, false.</returns>
    public extern bool IsReadingText { [MethodImpl] get; }
  }
}
