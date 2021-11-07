// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.PeriodicUpdateRecurrence
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Specifies the time period for subsequent polls of the tile or badge data source for new content.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PeriodicUpdateRecurrence
  {
    /// <summary>Poll every half an hour.</summary>
    HalfHour,
    /// <summary>Poll every hour.</summary>
    Hour,
    /// <summary>Poll every 6 hours.</summary>
    SixHours,
    /// <summary>Poll every 12 hours.</summary>
    TwelveHours,
    /// <summary>Poll once a day.</summary>
    Daily,
  }
}
