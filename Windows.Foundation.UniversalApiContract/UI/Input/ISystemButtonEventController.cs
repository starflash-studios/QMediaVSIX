// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.ISystemButtonEventController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ExclusiveTo(typeof (SystemButtonEventController))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(1505268649, 29628, 21173, 186, 65, 130, 81, 27, 44, 180, 108)]
  [WebHostHidden]
  internal interface ISystemButtonEventController
  {
    event TypedEventHandler<SystemButtonEventController, SystemFunctionButtonEventArgs> SystemFunctionButtonPressed;

    event TypedEventHandler<SystemButtonEventController, SystemFunctionButtonEventArgs> SystemFunctionButtonReleased;

    event TypedEventHandler<SystemButtonEventController, SystemFunctionLockChangedEventArgs> SystemFunctionLockChanged;

    event TypedEventHandler<SystemButtonEventController, SystemFunctionLockIndicatorChangedEventArgs> SystemFunctionLockIndicatorChanged;
  }
}
