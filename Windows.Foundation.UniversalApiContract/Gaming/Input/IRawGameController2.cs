// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IRawGameController2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Haptics;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(1136705589, 47987, 18262, 167, 135, 62, 214, 190, 166, 23, 189)]
  [ExclusiveTo(typeof (RawGameController))]
  internal interface IRawGameController2 : IRawGameController, IGameController
  {
    IVectorView<SimpleHapticsController> SimpleHapticsControllers { get; }

    string NonRoamableId { get; }

    string DisplayName { get; }
  }
}
