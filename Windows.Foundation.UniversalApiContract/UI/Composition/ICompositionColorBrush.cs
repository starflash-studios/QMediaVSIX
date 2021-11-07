// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionColorBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionColorBrush))]
  [Guid(723930206, 48949, 18481, 134, 66, 207, 112, 194, 15, 255, 47)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ICompositionColorBrush
  {
    Color Color { get; set; }
  }
}
