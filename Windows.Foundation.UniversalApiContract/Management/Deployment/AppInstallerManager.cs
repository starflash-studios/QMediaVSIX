// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.AppInstallerManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [Static(typeof (IAppInstallerManagerStatics), 851968, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppInstallerManager : IAppInstallerManager
  {
    [MethodImpl]
    public extern void SetAutoUpdateSettings(
      string packageFamilyName,
      AutoUpdateSettingsOptions appInstallerInfo);

    [MethodImpl]
    public extern void ClearAutoUpdateSettings(string packageFamilyName);

    [MethodImpl]
    public extern void PauseAutoUpdatesUntil(string packageFamilyName, DateTime dateTime);

    [MethodImpl]
    public static extern AppInstallerManager GetDefault();

    [MethodImpl]
    public static extern AppInstallerManager GetForSystem();
  }
}
