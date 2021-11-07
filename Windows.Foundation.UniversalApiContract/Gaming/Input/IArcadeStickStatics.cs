// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IArcadeStickStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Guid(1547155656, 14257, 19160, 148, 88, 32, 15, 26, 48, 1, 142)]
  [ExclusiveTo(typeof (ArcadeStick))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IArcadeStickStatics
  {
    event EventHandler<ArcadeStick> ArcadeStickAdded;

    event EventHandler<ArcadeStick> ArcadeStickRemoved;

    IVectorView<ArcadeStick> ArcadeSticks { get; }
  }
}
