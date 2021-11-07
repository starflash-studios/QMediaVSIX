// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.AutoUpdateSetting
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  /// <summary>Defines the automatic app update setting values that can be returned by the AutoUpdateSetting property of the AppInstallManager class.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AutoUpdateSetting
  {
    /// <summary>Automatic app updates are disabled by the user.</summary>
    Disabled,
    /// <summary>Automatic app updates are enabled by the user.</summary>
    Enabled,
    /// <summary>Automatic app updates are disabled by policy.</summary>
    DisabledByPolicy,
    /// <summary>Automatic app updates are enabled by policy.</summary>
    EnabledByPolicy,
  }
}
