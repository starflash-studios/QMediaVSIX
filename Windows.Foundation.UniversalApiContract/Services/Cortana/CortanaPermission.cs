// Decompiled with JetBrains decompiler
// Type: Windows.Services.Cortana.CortanaPermission
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Cortana
{
  /// <summary>Specifies the Cortana permissions available to a CortanaPermissionManager object.</summary>
  /// <deprecated type="deprecate">CortanaPermission is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Deprecated("CortanaPermission is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 655360, "Windows.Foundation.UniversalApiContract")]
  public enum CortanaPermission
  {
    /// <summary>Cortana can access the user's web browsing history.</summary>
    BrowsingHistory,
    /// <summary>Cortana can access the user's calendar.</summary>
    Calendar,
    /// <summary>Cortana can access the user's call history.</summary>
    CallHistory,
    /// <summary>Cortana can access the user's contacts.</summary>
    Contacts,
    /// <summary>Cortana can send email.</summary>
    Email,
    /// <summary>Cortana can access input personalization settings.</summary>
    InputPersonalization,
    /// <summary>Cortana can access the user's location.</summary>
    Location,
    /// <summary>Cortana can send text messages.</summary>
    Messaging,
    /// <summary>Cortana can access the microphone.</summary>
    Microphone,
    /// <summary>Cortana personalization settings are exposed.</summary>
    Personalization,
    /// <summary>Cortana can make phone calls.</summary>
    PhoneCall,
  }
}
