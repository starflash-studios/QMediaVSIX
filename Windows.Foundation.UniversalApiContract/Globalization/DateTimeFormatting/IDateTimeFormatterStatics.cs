// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.IDateTimeFormatterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  [Guid(3217942464, 57164, 18990, 144, 18, 244, 125, 175, 63, 18, 18)]
  [ExclusiveTo(typeof (DateTimeFormatter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDateTimeFormatterStatics
  {
    DateTimeFormatter LongDate { get; }

    DateTimeFormatter LongTime { get; }

    DateTimeFormatter ShortDate { get; }

    DateTimeFormatter ShortTime { get; }
  }
}
