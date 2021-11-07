// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextUnit
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the units in which timed a timed text style value is expressed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TimedTextUnit
  {
    /// <summary>The style value is expressed in pixels.</summary>
    Pixels,
    /// <summary>The style value is expressed as a percentage.</summary>
    Percentage,
  }
}
