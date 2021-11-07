// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBar2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (AppBar))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3282769843, 31447, 18038, 153, 16, 127, 227, 240, 232, 233, 147)]
  internal interface IAppBar2
  {
    AppBarClosedDisplayMode ClosedDisplayMode { get; set; }
  }
}
