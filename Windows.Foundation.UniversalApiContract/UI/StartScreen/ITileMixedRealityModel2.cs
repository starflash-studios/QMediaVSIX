// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ITileMixedRealityModel2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (TileMixedRealityModel))]
  [Guid(1133801650, 55237, 16651, 131, 25, 148, 134, 162, 123, 108, 103)]
  internal interface ITileMixedRealityModel2
  {
    TileMixedRealityModelActivationBehavior ActivationBehavior { set; get; }
  }
}
