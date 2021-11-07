// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ISineEasingFunction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SineEasingFunction))]
  [Guid(4055177407, 38243, 21620, 189, 19, 68, 178, 223, 75, 29, 88)]
  internal interface ISineEasingFunction
  {
    CompositionEasingFunctionMode Mode { get; }
  }
}
