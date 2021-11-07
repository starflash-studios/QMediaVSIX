// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ICalendarIdentifiersStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ExclusiveTo(typeof (CalendarIdentifiers))]
  [Guid(740447267, 8109, 16576, 147, 52, 168, 235, 144, 219, 4, 245)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ICalendarIdentifiersStatics3
  {
    string ChineseLunar { get; }

    string JapaneseLunar { get; }

    string KoreanLunar { get; }

    string TaiwanLunar { get; }

    string VietnameseLunar { get; }
  }
}
