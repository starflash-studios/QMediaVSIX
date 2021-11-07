// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextDouble
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents a floating point value that is used to convey the values of timed text style properties.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct TimedTextDouble
  {
    /// <summary>The value.</summary>
    public double Value;
    /// <summary>The units of the value, either pixels or percentage.</summary>
    public TimedTextUnit Unit;
  }
}
