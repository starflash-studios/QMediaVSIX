// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextLayoutBounds
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  /// <summary>Represents the screen coordinates of the bounding box for a range of text, or a text input control.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CoreTextLayoutBounds : ICoreTextLayoutBounds
  {
    /// <summary>Gets or sets the bounding box in screen coordinates of a range of text.</summary>
    /// <returns>The bounding box in screen coordinates of a range of text.</returns>
    public extern Rect TextBounds { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the bounding box in screen coordinates of a text input control.</summary>
    /// <returns>The bounding box in screen coordinates of a text input control.</returns>
    public extern Rect ControlBounds { [MethodImpl] get; [MethodImpl] set; }
  }
}
