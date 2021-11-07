// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionPathFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.UI.Composition
{
  [Guid(2619247722, 3891, 18257, 148, 55, 235, 63, 185, 211, 171, 7)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (CompositionPath))]
  internal interface ICompositionPathFactory
  {
    CompositionPath Create(IGeometrySource2D source);
  }
}
