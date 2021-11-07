// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.IDateTimeFormatter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(667490950, 48554, 20432, 158, 54, 103, 29, 90, 165, 238, 3)]
  [ExclusiveTo(typeof (DateTimeFormatter))]
  internal interface IDateTimeFormatter2
  {
    [Overload("FormatUsingTimeZone")]
    string Format(DateTime datetime, string timeZoneId);
  }
}
