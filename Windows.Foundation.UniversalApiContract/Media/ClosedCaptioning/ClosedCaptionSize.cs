// Decompiled with JetBrains decompiler
// Type: Windows.Media.ClosedCaptioning.ClosedCaptionSize
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.ClosedCaptioning
{
  /// <summary>Specifies the size of closed caption text.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ClosedCaptionSize
  {
    /// <summary>Default text size.</summary>
    Default,
    /// <summary>50% text size.</summary>
    FiftyPercent,
    /// <summary>100% text size.</summary>
    OneHundredPercent,
    /// <summary>150% text size.</summary>
    OneHundredFiftyPercent,
    /// <summary>200% text size.</summary>
    TwoHundredPercent,
  }
}
