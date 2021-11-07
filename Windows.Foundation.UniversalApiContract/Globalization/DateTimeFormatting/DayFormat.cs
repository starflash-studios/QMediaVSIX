// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.DayFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  /// <summary>Specifies the intended format for the day in a DateTimeFormatter object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DayFormat
  {
    /// <summary>Do not display the day.</summary>
    None,
    /// <summary>Display the day in the most natural way. This will depend on the context, such as the language or calendar (for example, for the Hebrew calendar and Hebrew language, use the Hebrew numbering system).</summary>
    Default,
  }
}
