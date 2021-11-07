// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [ExclusiveTo(typeof (DisplayManager))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1322853467, 5612, 22242, 144, 114, 127, 229, 8, 74, 49, 167)]
  internal interface IDisplayManager
  {
    IVectorView<DisplayTarget> GetCurrentTargets();

    IVectorView<DisplayAdapter> GetCurrentAdapters();

    DisplayManagerResult TryAcquireTarget(DisplayTarget target);

    void ReleaseTarget(DisplayTarget target);

    DisplayManagerResultWithState TryReadCurrentStateForAllTargets();

    DisplayManagerResultWithState TryAcquireTargetsAndReadCurrentState(
      IIterable<DisplayTarget> targets);

    DisplayManagerResultWithState TryAcquireTargetsAndCreateEmptyState(
      IIterable<DisplayTarget> targets);

    DisplayManagerResultWithState TryAcquireTargetsAndCreateSubstate(
      DisplayState existingState,
      IIterable<DisplayTarget> targets);

    DisplayDevice CreateDisplayDevice(DisplayAdapter adapter);

    event TypedEventHandler<DisplayManager, DisplayManagerEnabledEventArgs> Enabled;

    event TypedEventHandler<DisplayManager, DisplayManagerDisabledEventArgs> Disabled;

    event TypedEventHandler<DisplayManager, DisplayManagerChangedEventArgs> Changed;

    event TypedEventHandler<DisplayManager, DisplayManagerPathsFailedOrInvalidatedEventArgs> PathsFailedOrInvalidated;

    void Start();

    void Stop();
  }
}
