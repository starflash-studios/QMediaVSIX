// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IVisualStateGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (VisualStateGroup))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3841579428, 57384, 17630, 155, 21, 73, 41, 174, 10, 38, 194)]
  internal interface IVisualStateGroup
  {
    string Name { get; }

    IVector<VisualTransition> Transitions { get; }

    IVector<VisualState> States { get; }

    VisualState CurrentState { get; }

    event VisualStateChangedEventHandler CurrentStateChanged;

    event VisualStateChangedEventHandler CurrentStateChanging;
  }
}
