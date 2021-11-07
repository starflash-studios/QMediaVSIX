// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IGlobalizationPreferencesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.System.UserProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(29311782, 60727, 20118, 176, 233, 193, 52, 13, 30, 161, 88)]
  [ExclusiveTo(typeof (GlobalizationPreferences))]
  internal interface IGlobalizationPreferencesStatics
  {
    IVectorView<string> Calendars { get; }

    IVectorView<string> Clocks { get; }

    IVectorView<string> Currencies { get; }

    IVectorView<string> Languages { get; }

    string HomeGeographicRegion { get; }

    DayOfWeek WeekStartsOn { get; }
  }
}
