// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextPadding
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents the size of padding around a timed text region.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct TimedTextPadding
  {
    /// <summary>The padding before the timed text region.</summary>
    public double Before;
    /// <summary>The padding after the timed text region.</summary>
    public double After;
    /// <summary>The padding towards the start of the timed text.</summary>
    public double Start;
    /// <summary>The padding towards the end of the timed text.</summary>
    public double End;
    /// <summary>The units in which the other members of the structure are expressed.</summary>
    public TimedTextUnit Unit;
  }
}
