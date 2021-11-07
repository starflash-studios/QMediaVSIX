// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.ICoreWetStrokeUpdateSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Core
{
  [ExclusiveTo(typeof (CoreWetStrokeUpdateSource))]
  [Guid(527535650, 61010, 19968, 130, 9, 76, 62, 91, 33, 163, 204)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ICoreWetStrokeUpdateSource
  {
    event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeStarting;

    event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeContinuing;

    event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeStopping;

    event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeCompleted;

    event TypedEventHandler<CoreWetStrokeUpdateSource, CoreWetStrokeUpdateEventArgs> WetStrokeCanceled;

    InkPresenter InkPresenter { get; }
  }
}
