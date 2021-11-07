// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.ICalendarIdentifiersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2154119016, 11442, 19487, 181, 144, 240, 245, 43, 244, 253, 26)]
  [ExclusiveTo(typeof (CalendarIdentifiers))]
  internal interface ICalendarIdentifiersStatics
  {
    string Gregorian { get; }

    string Hebrew { get; }

    string Hijri { get; }

    string Japanese { get; }

    string Julian { get; }

    string Korean { get; }

    string Taiwan { get; }

    string Thai { get; }

    string UmAlQura { get; }
  }
}
