// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionMaskBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(1378676894, 48747, 20289, 190, 73, 249, 34, 109, 71, 27, 74)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CompositionMaskBrush))]
  internal interface ICompositionMaskBrush
  {
    CompositionBrush Mask { get; set; }

    CompositionBrush Source { get; set; }
  }
}
