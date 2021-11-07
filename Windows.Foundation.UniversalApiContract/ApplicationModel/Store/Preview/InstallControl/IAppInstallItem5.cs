// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallItem5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ExclusiveTo(typeof (AppInstallItem))]
  [Guid(1427171276, 16502, 18955, 148, 114, 194, 29, 157, 56, 14, 85)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IAppInstallItem5
  {
    bool PinToDesktopAfterInstall { get; set; }

    bool PinToStartAfterInstall { get; set; }

    bool PinToTaskbarAfterInstall { get; set; }

    AppInstallationToastNotificationMode CompletedInstallToastNotificationMode { get; set; }

    AppInstallationToastNotificationMode InstallInProgressToastNotificationMode { get; set; }
  }
}
