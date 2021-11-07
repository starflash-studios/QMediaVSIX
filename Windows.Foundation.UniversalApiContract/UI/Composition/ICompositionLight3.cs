// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionLight3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Guid(1259012324, 57095, 18777, 183, 164, 79, 126, 66, 51, 248, 56)]
  [ExclusiveTo(typeof (CompositionLight))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface ICompositionLight3
  {
    bool IsEnabled { get; set; }
  }
}
