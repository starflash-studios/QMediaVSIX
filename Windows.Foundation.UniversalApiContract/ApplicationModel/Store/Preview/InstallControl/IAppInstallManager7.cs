// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ExclusiveTo(typeof (AppInstallManager))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2783869744, 54756, 18851, 152, 83, 61, 176, 50, 3, 50, 29)]
  internal interface IAppInstallManager7
  {
    bool CanInstallForAllUsers { get; }
  }
}
