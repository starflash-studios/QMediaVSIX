// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionAnimation3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(3575513869, 32164, 19415, 188, 45, 244, 81, 117, 41, 244, 58)]
  [ExclusiveTo(typeof (CompositionAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface ICompositionAnimation3
  {
    InitialValueExpressionCollection InitialValueExpressions { get; }
  }
}
