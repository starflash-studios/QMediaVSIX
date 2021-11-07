// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarToggleButton4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(3094049646, 16047, 18257, 168, 151, 0, 2, 159, 31, 106, 202)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AppBarToggleButton))]
  internal interface IAppBarToggleButton4
  {
    string KeyboardAcceleratorTextOverride { get; set; }
  }
}
