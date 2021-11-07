// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IAutoUpdateSettingsOptionsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ExclusiveTo(typeof (AutoUpdateSettingsOptions))]
  [Guid(2289775485, 3077, 21712, 189, 73, 59, 183, 162, 192, 132, 203)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IAutoUpdateSettingsOptionsStatics
  {
    AutoUpdateSettingsOptions CreateFromAppInstallerInfo(
      AppInstallerInfo appInstallerInfo);
  }
}
