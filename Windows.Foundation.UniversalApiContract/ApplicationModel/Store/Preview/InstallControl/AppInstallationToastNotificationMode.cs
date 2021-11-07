// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallationToastNotificationMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  /// <summary>Defines the types of toasts that can be shown by the system during and after app installation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum AppInstallationToastNotificationMode
  {
    /// <summary>The operating system chooses the appropriate toast.</summary>
    Default,
    /// <summary>A toast with a popup.</summary>
    Toast,
    /// <summary>A toast without a popup.</summary>
    ToastWithoutPopup,
    /// <summary>No toast.</summary>
    NoToast,
  }
}
