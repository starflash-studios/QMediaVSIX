// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IAppInstallerManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ExclusiveTo(typeof (AppInstallerManager))]
  [Guid(3378147029, 64601, 21302, 155, 46, 43, 7, 197, 230, 20, 52)]
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  internal interface IAppInstallerManagerStatics
  {
    AppInstallerManager GetDefault();

    AppInstallerManager GetForSystem();
  }
}
