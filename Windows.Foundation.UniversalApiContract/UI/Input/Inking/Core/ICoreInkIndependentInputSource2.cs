// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.ICoreInkIndependentInputSource2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking.Core
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [WebHostHidden]
  [Guid(675721234, 2905, 23481, 163, 197, 190, 203, 124, 240, 58, 51)]
  [ExclusiveTo(typeof (CoreInkIndependentInputSource))]
  internal interface ICoreInkIndependentInputSource2
  {
    CoreCursor PointerCursor { get; set; }
  }
}
