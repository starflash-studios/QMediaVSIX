// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallOptions2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2315567319, 51531, 16990, 149, 180, 191, 39, 250, 234, 238, 137)]
  [ExclusiveTo(typeof (AppInstallOptions))]
  internal interface IAppInstallOptions2
  {
    bool PinToDesktopAfterInstall { get; set; }

    bool PinToStartAfterInstall { get; set; }

    bool PinToTaskbarAfterInstall { get; set; }

    AppInstallationToastNotificationMode CompletedInstallToastNotificationMode { get; set; }

    AppInstallationToastNotificationMode InstallInProgressToastNotificationMode { get; set; }

    bool InstallForAllUsers { get; set; }

    bool StageButDoNotInstall { get; set; }

    string CampaignId { get; set; }

    string ExtendedCampaignId { get; set; }
  }
}
