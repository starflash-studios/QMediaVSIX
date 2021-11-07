// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.TextPointer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Represents a position within a text element.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TextPointer : ITextPointer
  {
    /// <summary>Gets the logical parent that contains the current position.</summary>
    /// <returns>The logical parent that contains the current position. Can return the RichEditBox when at the top of the content stack.</returns>
    public extern DependencyObject Parent { [MethodImpl] get; }

    /// <summary>Gets the user interface (UI) element that "owns" this TextPointer.</summary>
    /// <returns>The UI element that "owns" this TextPointer.</returns>
    public extern FrameworkElement VisualParent { [MethodImpl] get; }

    /// <summary>Gets the logical direction associated with the current position, which is used to disambiguate content associated with the current position.</summary>
    /// <returns>The LogicalDirection value that is associated with the current position.</returns>
    public extern LogicalDirection LogicalDirection { [MethodImpl] get; }

    /// <summary>Gets the character index of a TextPointer within its container.</summary>
    /// <returns>The character index of a TextPointer within its container.</returns>
    public extern int Offset { [MethodImpl] get; }

    /// <summary>Returns a bounding box for content that borders the current TextPointer in the specified logical direction.</summary>
    /// <param name="direction">One of the LogicalDirection values that specifies the logical direction in which to find a content bounding box.</param>
    /// <returns>A Rect for content that borders the current TextPointer in the specified direction, or a Rect that evaluates as Empty if current and valid layout information is unavailable.</returns>
    [MethodImpl]
    public extern Rect GetCharacterRect(LogicalDirection direction);

    /// <summary>Returns a TextPointer to the position indicated by the specified offset, in symbols, from the beginning of the current TextPointer and in the specified direction.</summary>
    /// <param name="offset">An offset, in symbols, for which to calculate and return the position. If the offset is negative, the returned TextPointer precedes the current TextPointer; otherwise, it follows.</param>
    /// <param name="direction">One of the LogicalDirection values that specifies the logical direction of the returned TextPointer.</param>
    /// <returns>A TextPointer to the position indicated by the specified offset and in the direction specified by the direction parameter, or null if the offset extends past the end of the content.</returns>
    [MethodImpl]
    public extern TextPointer GetPositionAtOffset(int offset, LogicalDirection direction);
  }
}
