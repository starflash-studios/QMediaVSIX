// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionAnimation4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(1996568510, 30396, 20003, 191, 237, 254, 156, 194, 15, 110, 201)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (CompositionAnimation))]
  internal interface ICompositionAnimation4
  {
    void SetExpressionReferenceParameter(string parameterName, IAnimationObject source);
  }
}
