// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IInputActivationListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(1567444690, 10439, 23267, 170, 116, 201, 24, 169, 242, 67, 202)]
  [ExclusiveTo(typeof (InputActivationListener))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IInputActivationListener
  {
    InputActivationState State { get; }

    event TypedEventHandler<InputActivationListener, InputActivationListenerActivationChangedEventArgs> InputActivationChanged;
  }
}
