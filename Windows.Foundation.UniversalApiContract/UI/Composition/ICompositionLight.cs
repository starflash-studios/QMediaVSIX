// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionLight
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(1101453250, 11869, 19393, 176, 158, 143, 10, 3, 227, 216, 211)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CompositionLight))]
  [WebHostHidden]
  internal interface ICompositionLight
  {
    VisualUnorderedCollection Targets { get; }
  }
}
