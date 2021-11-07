// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ClockIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  /// <summary>Contains the clock identifiers for the supported clocks, as static properties.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IClockIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class ClockIdentifiers
  {
    /// <summary>Gets the identifier for a 12-hour clock.</summary>
    /// <returns>The string "12HourClock", which is the identifier for a 12-hour clock.</returns>
    public static extern string TwelveHour { [MethodImpl] get; }

    /// <summary>Gets the identifier for a 24-hour clock.</summary>
    /// <returns>The string "24HourClock", which is the identifier for a 24-hour clock.</returns>
    public static extern string TwentyFourHour { [MethodImpl] get; }
  }
}
