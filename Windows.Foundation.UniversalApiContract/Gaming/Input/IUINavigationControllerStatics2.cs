// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IUINavigationControllerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3771410659, 45579, 19211, 158, 212, 243, 213, 60, 236, 13, 228)]
  [ExclusiveTo(typeof (UINavigationController))]
  internal interface IUINavigationControllerStatics2 : IUINavigationControllerStatics
  {
    UINavigationController FromGameController(IGameController gameController);
  }
}
