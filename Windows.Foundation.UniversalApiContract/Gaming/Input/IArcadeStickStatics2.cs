// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IArcadeStickStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Guid(1387648836, 48006, 17498, 181, 156, 89, 111, 14, 42, 73, 223)]
  [ExclusiveTo(typeof (ArcadeStick))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IArcadeStickStatics2 : IArcadeStickStatics
  {
    ArcadeStick FromGameController(IGameController gameController);
  }
}
