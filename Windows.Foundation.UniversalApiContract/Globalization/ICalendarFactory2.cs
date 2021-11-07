// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ICalendarFactory2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [Guid(3024828300, 51838, 17808, 158, 114, 234, 43, 236, 26, 81, 21)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Calendar))]
  internal interface ICalendarFactory2
  {
    Calendar CreateCalendarWithTimeZone(
      IIterable<string> languages,
      string calendar,
      string clock,
      string timeZoneId);
  }
}
