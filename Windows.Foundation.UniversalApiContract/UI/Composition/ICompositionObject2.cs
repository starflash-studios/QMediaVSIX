// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionObject2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(4018622113, 23807, 19304, 158, 48, 161, 81, 157, 8, 186, 3)]
  [ExclusiveTo(typeof (CompositionObject))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ICompositionObject2
  {
    string Comment { get; set; }

    ImplicitAnimationCollection ImplicitAnimations { get; set; }

    void StartAnimationGroup(ICompositionAnimationBase value);

    void StopAnimationGroup(ICompositionAnimationBase value);
  }
}
