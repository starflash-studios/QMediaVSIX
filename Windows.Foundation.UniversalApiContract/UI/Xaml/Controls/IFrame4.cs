// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFrame4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (Frame))]
  [WebHostHidden]
  [Guid(2602025498, 48427, 18944, 153, 235, 148, 107, 233, 97, 128, 132)]
  internal interface IFrame4
  {
    [Overload("SetNavigationStateWithNavigationControl")]
    void SetNavigationState(string navigationState, bool suppressNavigate);
  }
}
