// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionCapabilitiesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(4156008558, 25622, 18917, 141, 223, 175, 233, 73, 226, 5, 98)]
  [ExclusiveTo(typeof (CompositionCapabilities))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ICompositionCapabilitiesStatics
  {
    CompositionCapabilities GetForCurrentView();
  }
}
