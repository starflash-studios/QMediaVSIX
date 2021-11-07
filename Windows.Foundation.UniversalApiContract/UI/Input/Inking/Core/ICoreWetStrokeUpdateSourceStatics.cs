// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.ICoreWetStrokeUpdateSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Core
{
  [ExclusiveTo(typeof (CoreWetStrokeUpdateSource))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1034788026, 7485, 18094, 171, 157, 134, 71, 72, 108, 111, 144)]
  internal interface ICoreWetStrokeUpdateSourceStatics
  {
    CoreWetStrokeUpdateSource Create(InkPresenter inkPresenter);
  }
}
