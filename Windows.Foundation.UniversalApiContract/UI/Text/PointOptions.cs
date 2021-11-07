// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.PointOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Defines options for specifying or retrieving a point.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum PointOptions : uint
  {
    /// <summary>No options.</summary>
    None = 0,
    /// <summary>Add left and top insets to the left and top coordinates of the rectangle, and subtract right and bottom insets from the right and bottom coordinates.</summary>
    IncludeInset = 1,
    /// <summary>The start position of the text range.</summary>
    Start = 32, // 0x00000020
    /// <summary>Return client coordinates instead of screen coordinates.</summary>
    ClientCoordinates = 256, // 0x00000100
    /// <summary>Allow points outside of the client area.</summary>
    AllowOffClient = 512, // 0x00000200
    /// <summary>Transform coordinates using a world transform supplied by the host app.</summary>
    Transform = 1024, // 0x00000400
    /// <summary>Horizontal scrolling is disabled.</summary>
    NoHorizontalScroll = 65536, // 0x00010000
    /// <summary>Vertical scrolling is disabled.</summary>
    NoVerticalScroll = 262144, // 0x00040000
  }
}
