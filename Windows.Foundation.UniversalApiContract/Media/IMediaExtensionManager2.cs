// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaExtensionManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1540276039, 16451, 20461, 172, 175, 84, 236, 41, 223, 177, 247)]
  [ExclusiveTo(typeof (MediaExtensionManager))]
  internal interface IMediaExtensionManager2 : IMediaExtensionManager
  {
    void RegisterMediaExtensionForAppService(
      IMediaExtension extension,
      AppServiceConnection connection);
  }
}
