// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManagerItemEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppInstallManagerItemEventArgs))]
  [Guid(3159381827, 18036, 19921, 149, 126, 194, 86, 130, 8, 106, 20)]
  internal interface IAppInstallManagerItemEventArgs
  {
    AppInstallItem Item { get; }
  }
}
