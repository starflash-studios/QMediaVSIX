// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextPoint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents 2D coordinate that is used to convey the values of timed text style properties.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct TimedTextPoint
  {
    /// <summary>The X coordinate of the point.</summary>
    public double X;
    /// <summary>The Y coordinate of the point.</summary>
    public double Y;
    /// <summary>The units of the coordinates, either pixels or percentage.</summary>
    public TimedTextUnit Unit;
  }
}
