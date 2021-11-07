// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [Guid(135435041, 4533, 23730, 153, 248, 233, 11, 71, 154, 138, 29)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (DisplayState))]
  internal interface IDisplayState
  {
    bool IsReadOnly { get; }

    bool IsStale { get; }

    IVectorView<DisplayTarget> Targets { get; }

    IVectorView<DisplayView> Views { get; }

    IMap<Guid, object> Properties { get; }

    [Overload("ConnectTarget")]
    [DefaultOverload]
    DisplayPath ConnectTarget(DisplayTarget target);

    [Overload("ConnectTargetToView")]
    DisplayPath ConnectTarget(DisplayTarget target, DisplayView view);

    bool CanConnectTargetToView(DisplayTarget target, DisplayView view);

    DisplayView GetViewForTarget(DisplayTarget target);

    DisplayPath GetPathForTarget(DisplayTarget target);

    void DisconnectTarget(DisplayTarget target);

    DisplayStateOperationResult TryFunctionalize(
      DisplayStateFunctionalizeOptions options);

    DisplayStateOperationResult TryApply(DisplayStateApplyOptions options);

    DisplayState Clone();
  }
}
