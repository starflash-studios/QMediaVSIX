// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.CalendarIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  /// <summary>Contains the calendar identifiers for the supported calendars, as static properties.</summary>
  [Static(typeof (ICalendarIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICalendarIdentifiersStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICalendarIdentifiersStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class CalendarIdentifiers
  {
    /// <summary>Gets the identifier for the Chinese lunisolar calendar.</summary>
    /// <returns>The string "ChineseLunarCalendar", which is the identifier for the Chinese lunar calendar.</returns>
    public static extern string ChineseLunar { [MethodImpl] get; }

    /// <summary>This name is reserved for a future update. Do not access or use this property in your code, as accessing the property will result in errors or exceptions being thrown.</summary>
    /// <returns>The string "JapaneseLunarCalendar", which is the identifier for the Japanese lunar calendar.</returns>
    public static extern string JapaneseLunar { [MethodImpl] get; }

    /// <summary>This name is reserved for a future update. Do not access or use this property in your code, as accessing the property will result in errors or exceptions being thrown.</summary>
    /// <returns>The string "KoreanLunarCalendar", which is the identifier for the Korean lunar calendar.</returns>
    public static extern string KoreanLunar { [MethodImpl] get; }

    /// <summary>This name is reserved for a future update. Do not access or use this property in your code, as accessing the property will result in errors or exceptions being thrown.</summary>
    /// <returns>The string "TaiwanLunarCalendar", which is the identifier for the Taiwan Lunar calendar.</returns>
    public static extern string TaiwanLunar { [MethodImpl] get; }

    /// <summary>This name is reserved for a future update. Do not access or use this property in your code, as accessing the property will result in errors or exceptions being thrown.</summary>
    /// <returns>The string "VietnameseLunarCalendar", which is the identifier for the Vietnamese lunar calendar.</returns>
    public static extern string VietnameseLunar { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Persian calendar.</summary>
    /// <returns>The string "PersianCalendar", which is the identifier for the Persian calendar.</returns>
    public static extern string Persian { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Gregorian calendar.</summary>
    /// <returns>The string "GregorianCalendar", which is the identifier for the Gregorian calendar.</returns>
    public static extern string Gregorian { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Hebrew calendar.</summary>
    /// <returns>The string "HebrewCalendar", which is the identifier for the Hebrew calendar.</returns>
    public static extern string Hebrew { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Hijri calendar.</summary>
    /// <returns>The string "HijriCalendar", which is the identifier for the Hijri calendar.</returns>
    public static extern string Hijri { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Japanese calendar.</summary>
    /// <returns>The string "JapaneseCalendar", which is the identifier for the Japanese calendar.</returns>
    public static extern string Japanese { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Julian calendar.</summary>
    /// <returns>The string "JulianCalendar", which is the identifier for the Julian calendar.</returns>
    public static extern string Julian { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Korean calendar.</summary>
    /// <returns>The string "KoreanCalendar", which is the identifier for the Korean calendar.</returns>
    public static extern string Korean { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Taiwan calendar.</summary>
    /// <returns>The string "TaiwanCalendar", which is the identifier for the Taiwan calendar.</returns>
    public static extern string Taiwan { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Thai calendar.</summary>
    /// <returns>The string "ThaiCalendar", which is the identifier for the Thai calendar.</returns>
    public static extern string Thai { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Um Al-Qura calendar.</summary>
    /// <returns>The string "UmAlQuraCalendar", which is the identifier for the Um Al-Qura calendar.</returns>
    public static extern string UmAlQura { [MethodImpl] get; }
  }
}
