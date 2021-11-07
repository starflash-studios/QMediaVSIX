// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.DayOfWeekFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  /// <summary>Specifies the intended format for the day of the week in a DateTimeFormatter object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DayOfWeekFormat
  {
    /// <summary>Do not display the day of the week.</summary>
    None,
    /// <summary>Display the day of the week in the most natural way. It may be abbreviated or full depending on the context, such as the language or calendar that is being used.</summary>
    Default,
    /// <summary>Display an abbreviated version of the day of the week (for example, "Thur" for Thursday).</summary>
    Abbreviated,
    /// <summary>Display the day of the week in its entirety (for example, "Thursday").</summary>
    Full,
  }
}
