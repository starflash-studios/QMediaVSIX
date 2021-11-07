// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (RadialController))]
  [Guid(810930632, 57169, 17364, 178, 59, 14, 16, 55, 70, 122, 9)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRadialController
  {
    RadialControllerMenu Menu { get; }

    double RotationResolutionInDegrees { get; set; }

    bool UseAutomaticHapticFeedback { get; set; }

    event TypedEventHandler<RadialController, RadialControllerScreenContactStartedEventArgs> ScreenContactStarted;

    event TypedEventHandler<RadialController, object> ScreenContactEnded;

    event TypedEventHandler<RadialController, RadialControllerScreenContactContinuedEventArgs> ScreenContactContinued;

    event TypedEventHandler<RadialController, object> ControlLost;

    event TypedEventHandler<RadialController, RadialControllerRotationChangedEventArgs> RotationChanged;

    event TypedEventHandler<RadialController, RadialControllerButtonClickedEventArgs> ButtonClicked;

    event TypedEventHandler<RadialController, RadialControllerControlAcquiredEventArgs> ControlAcquired;
  }
}
