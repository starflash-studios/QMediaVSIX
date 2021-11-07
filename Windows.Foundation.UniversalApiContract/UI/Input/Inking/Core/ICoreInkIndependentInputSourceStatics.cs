// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.ICoreInkIndependentInputSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Core
{
  [Guid(1944453403, 32960, 19963, 155, 102, 16, 186, 127, 63, 156, 132)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CoreInkIndependentInputSource))]
  internal interface ICoreInkIndependentInputSourceStatics
  {
    CoreInkIndependentInputSource Create(InkPresenter inkPresenter);
  }
}
