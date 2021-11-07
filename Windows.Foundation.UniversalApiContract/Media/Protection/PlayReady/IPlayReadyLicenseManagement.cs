// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicenseManagement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2867536193, 2391, 17413, 184, 146, 139, 243, 236, 93, 173, 217)]
  [ExclusiveTo(typeof (PlayReadyLicenseManagement))]
  internal interface IPlayReadyLicenseManagement
  {
    [RemoteAsync]
    IAsyncAction DeleteLicenses(PlayReadyContentHeader contentHeader);
  }
}
