// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppUpdateOptions2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [Guid(4100222472, 60710, 19449, 150, 121, 72, 246, 40, 229, 61, 248)]
  [ExclusiveTo(typeof (AppUpdateOptions))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IAppUpdateOptions2
  {
    bool AutomaticallyDownloadAndInstallUpdateIfFound { get; set; }
  }
}
