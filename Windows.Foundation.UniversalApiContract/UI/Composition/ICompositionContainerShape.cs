// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionContainerShape
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CompositionContainerShape))]
  [Guid(1331594651, 11867, 17576, 152, 44, 170, 15, 105, 193, 96, 89)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  internal interface ICompositionContainerShape
  {
    CompositionShapeCollection Shapes { get; }
  }
}
