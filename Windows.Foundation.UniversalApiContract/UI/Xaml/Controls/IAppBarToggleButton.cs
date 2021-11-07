// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarToggleButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(781272120, 64851, 19341, 133, 139, 54, 68, 38, 159, 142, 77)]
  [ExclusiveTo(typeof (AppBarToggleButton))]
  [WebHostHidden]
  internal interface IAppBarToggleButton
  {
    string Label { get; set; }

    IconElement Icon { get; set; }
  }
}
