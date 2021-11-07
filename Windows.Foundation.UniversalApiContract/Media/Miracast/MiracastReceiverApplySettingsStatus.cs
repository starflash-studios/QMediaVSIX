// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverApplySettingsStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>Specifies the status of a DisconnectAllAndApplySettings or DisconnectAllAndApplySettingsAsync operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum MiracastReceiverApplySettingsStatus
  {
    /// <summary>The operation succeeded.</summary>
    Success,
    /// <summary>The operation failed for an unknown reason.</summary>
    UnknownFailure,
    /// <summary>The operation failed because Miracast is not supported on the current device.</summary>
    MiracastNotSupported,
    /// <summary>The operation failed because the app is not allowed to change the settings.</summary>
    AccessDenied,
    /// <summary>The operation failed because the number of characters in the *FriendlyName* parameter exceeded the maximum allowed value.</summary>
    FriendlyNameTooLong,
    /// <summary>The operation failed because the number of characters in the *ModelName* parameter exceeded the maximum allowed value.</summary>
    ModelNameTooLong,
    /// <summary>The operation failed because the number of characters in the *ModelNumber* parameter exceeded the maximum allowed value.</summary>
    ModelNumberTooLong,
    /// <summary>The operation failed because one or more parameters were set to an invalid value.</summary>
    InvalidSettings,
  }
}
