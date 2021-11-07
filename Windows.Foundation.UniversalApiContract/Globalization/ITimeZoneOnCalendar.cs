// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ITimeZoneOnCalendar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3141281253, 18127, 17175, 163, 245, 2, 98, 26, 213, 68, 120)]
  [ExclusiveTo(typeof (Calendar))]
  internal interface ITimeZoneOnCalendar
  {
    string GetTimeZone();

    void ChangeTimeZone(string timeZoneId);

    [Overload("TimeZoneAsFullString")]
    string TimeZoneAsString();

    [Overload("TimeZoneAsString")]
    string TimeZoneAsString(int idealLength);
  }
}
