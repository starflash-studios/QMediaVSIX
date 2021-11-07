// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextLineAlignment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the alignment of a TimedTextLine relative to the TimedTextRegion in which it is displayed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TimedTextLineAlignment
  {
    /// <summary>The text line is aligned in the direction of the start of the text.</summary>
    Start,
    /// <summary>The text line is aligned in the direction of the end of the text.</summary>
    End,
    /// <summary>The text line is aligned in the center of the region.</summary>
    Center,
  }
}
