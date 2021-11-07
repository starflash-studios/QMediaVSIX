// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IVisualInteractionSourceStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [Guid(2843328562, 22372, 21984, 188, 31, 7, 120, 120, 109, 207, 222)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (VisualInteractionSource))]
  internal interface IVisualInteractionSourceStatics2
  {
    VisualInteractionSource CreateFromIVisualElement(IVisualElement source);
  }
}
