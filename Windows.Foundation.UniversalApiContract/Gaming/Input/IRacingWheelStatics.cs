// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IRacingWheelStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [ExclusiveTo(typeof (RacingWheel))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(985738453, 22555, 18742, 159, 148, 105, 241, 230, 81, 76, 125)]
  internal interface IRacingWheelStatics
  {
    event EventHandler<RacingWheel> RacingWheelAdded;

    event EventHandler<RacingWheel> RacingWheelRemoved;

    IVectorView<RacingWheel> RacingWheels { get; }
  }
}
