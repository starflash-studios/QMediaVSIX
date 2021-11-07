// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ICalendarFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ExclusiveTo(typeof (Calendar))]
  [Guid(2213905426, 58731, 19573, 166, 110, 15, 99, 213, 119, 88, 166)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICalendarFactory
  {
    Calendar CreateCalendarDefaultCalendarAndClock(IIterable<string> languages);

    Calendar CreateCalendar(IIterable<string> languages, string calendar, string clock);
  }
}
