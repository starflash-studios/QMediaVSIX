// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionLight2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(2814171762, 62301, 16989, 155, 152, 35, 244, 32, 95, 102, 105)]
  [ExclusiveTo(typeof (CompositionLight))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ICompositionLight2
  {
    VisualUnorderedCollection ExclusionsFromTargets { get; }
  }
}
