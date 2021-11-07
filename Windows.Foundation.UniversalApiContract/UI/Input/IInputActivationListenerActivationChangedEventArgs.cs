// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IInputActivationListenerActivationChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(1989784677, 7631, 22417, 180, 185, 108, 175, 190, 237, 32, 86)]
  [ExclusiveTo(typeof (InputActivationListenerActivationChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  internal interface IInputActivationListenerActivationChangedEventArgs
  {
    InputActivationState State { get; }
  }
}
