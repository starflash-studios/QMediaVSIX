// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authorization.AppCapabilityAccess.AppCapabilityAccessStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authorization.AppCapabilityAccess
{
  /// <summary>Describes an application’s access to a single capability.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum AppCapabilityAccessStatus
  {
    /// <summary>State: Denied by System.</summary>
    DeniedBySystem,
    /// <summary>State: Not Declared by App.</summary>
    NotDeclaredByApp,
    /// <summary>State: Denied by User.</summary>
    DeniedByUser,
    /// <summary>State: User Prompt Required</summary>
    UserPromptRequired,
    /// <summary>State: Allowed.</summary>
    Allowed,
  }
}
