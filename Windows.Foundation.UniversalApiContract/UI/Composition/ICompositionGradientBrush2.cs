// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionGradientBrush2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionGradientBrush))]
  [Guid(2308822433, 46279, 19251, 161, 182, 38, 74, 221, 194, 109, 16)]
  internal interface ICompositionGradientBrush2
  {
    CompositionMappingMode MappingMode { get; set; }
  }
}
