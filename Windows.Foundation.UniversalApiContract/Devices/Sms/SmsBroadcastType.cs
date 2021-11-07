// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsBroadcastType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>Values that describe the type of a broadcast (emergency alert) message.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SmsBroadcastType
  {
    /// <summary>An unknown broadcast type.</summary>
    Other,
    /// <summary>A Commercial Mobile Alert System (CMAS) Presidential alert message.</summary>
    CmasPresidential,
    /// <summary>A CMAS Extreme alert message.</summary>
    CmasExtreme,
    /// <summary>A CMAS Severe alert message.</summary>
    CmasSevere,
    /// <summary>A CMAS Amber alert message.</summary>
    CmasAmber,
    /// <summary>A CMAS Test message.</summary>
    CmasTest,
    /// <summary>An EU Alert 1 message.</summary>
    EUAlert1,
    /// <summary>An EU Alert 2 message.</summary>
    EUAlert2,
    /// <summary>An EU Alert 3 message.</summary>
    EUAlert3,
    /// <summary>An EU Amber Alert message.</summary>
    EUAlertAmber,
    /// <summary>An EU informational message.</summary>
    EUAlertInfo,
    /// <summary>An Earthquake and Tsunami Warning System (ETWS) earthquake alert message.</summary>
    EtwsEarthquake,
    /// <summary>An ETWS tsunami alert message.</summary>
    EtwsTsunami,
    /// <summary>An ETWS tsunami and earthquake alert message.</summary>
    EtwsTsunamiAndEarthquake,
    /// <summary>A local LAT alert broadcast message.</summary>
    LatAlertLocal,
  }
}
