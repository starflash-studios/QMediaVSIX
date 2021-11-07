// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IAppInstallerManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [Guid(3891143107, 8451, 21486, 155, 24, 104, 175, 234, 176, 3, 61)]
  [ExclusiveTo(typeof (AppInstallerManager))]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IAppInstallerManager
  {
    void SetAutoUpdateSettings(string packageFamilyName, AutoUpdateSettingsOptions appInstallerInfo);

    void ClearAutoUpdateSettings(string packageFamilyName);

    void PauseAutoUpdatesUntil(string packageFamilyName, DateTime dateTime);
  }
}
