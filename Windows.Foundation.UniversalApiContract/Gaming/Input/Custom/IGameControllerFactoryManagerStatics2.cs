// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGameControllerFactoryManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [Guid(3939391044, 6623, 16661, 179, 42, 39, 147, 226, 174, 163, 187)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GameControllerFactoryManager))]
  internal interface IGameControllerFactoryManagerStatics2 : IGameControllerFactoryManagerStatics
  {
    IGameController TryGetFactoryControllerFromGameController(
      ICustomGameControllerFactory factory,
      IGameController gameController);
  }
}
