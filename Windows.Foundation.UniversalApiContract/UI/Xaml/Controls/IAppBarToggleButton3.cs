// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarToggleButton3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppBarToggleButton))]
  [Guid(4019881445, 5887, 19826, 185, 232, 155, 134, 30, 175, 132, 168)]
  internal interface IAppBarToggleButton3
  {
    CommandBarLabelPosition LabelPosition { get; set; }
  }
}
