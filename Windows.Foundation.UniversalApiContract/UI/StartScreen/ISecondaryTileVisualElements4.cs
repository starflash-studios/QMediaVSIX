// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTileVisualElements4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [Guid(1716936983, 46404, 16594, 141, 18, 116, 212, 236, 36, 208, 76)]
  [ExclusiveTo(typeof (SecondaryTileVisualElements))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ISecondaryTileVisualElements4
  {
    TileMixedRealityModel MixedRealityModel { get; }
  }
}
