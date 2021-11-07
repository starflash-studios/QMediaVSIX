// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.INoFocusCandidateFoundEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(3962962343, 4103, 18681, 182, 179, 237, 11, 234, 83, 147, 125)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [ExclusiveTo(typeof (NoFocusCandidateFoundEventArgs))]
  internal interface INoFocusCandidateFoundEventArgs
  {
    FocusNavigationDirection Direction { get; }

    bool Handled { get; set; }

    FocusInputDeviceKind InputDevice { get; }
  }
}
