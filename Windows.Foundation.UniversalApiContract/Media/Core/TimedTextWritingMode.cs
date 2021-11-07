// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextWritingMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the direction timed text is written.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TimedTextWritingMode
  {
    /// <summary>Text is written from left to right within a line. Lines are written top to bottom.</summary>
    LeftRightTopBottom,
    /// <summary>Text is written from right to left within a line. Lines are written top to bottom.</summary>
    RightLeftTopBottom,
    /// <summary>Text is written from top to bottom within a line. Lines are written right to left.</summary>
    TopBottomRightLeft,
    /// <summary>Text is written from top to bottom within a line. Lines are written left to right.</summary>
    TopBottomLeftRight,
    /// <summary>Text is written from left to right within a line. Lines are written top to bottom.</summary>
    LeftRight,
    /// <summary>Text is written from right to left within a line. Lines are written top to bottom.</summary>
    RightLeft,
    /// <summary>Text is written from top to bottom within a line. Lines are written left to right.</summary>
    TopBottom,
  }
}
