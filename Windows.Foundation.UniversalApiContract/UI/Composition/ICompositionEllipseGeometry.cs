// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionEllipseGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionEllipseGeometry))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1208088708, 63149, 19347, 175, 169, 137, 123, 100, 229, 123, 31)]
  internal interface ICompositionEllipseGeometry
  {
    Vector2 Center { get; set; }

    Vector2 Radius { get; set; }
  }
}
