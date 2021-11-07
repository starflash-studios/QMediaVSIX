// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IVisualInteractionSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (VisualInteractionSource))]
  [WebHostHidden]
  [Guid(916022753, 34373, 20341, 186, 0, 100, 121, 205, 16, 200, 230)]
  internal interface IVisualInteractionSourceStatics
  {
    VisualInteractionSource Create(Visual source);
  }
}
