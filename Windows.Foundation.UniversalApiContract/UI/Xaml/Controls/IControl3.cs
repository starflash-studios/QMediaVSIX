// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControl3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(125512164, 56030, 20309, 155, 150, 9, 226, 27, 40, 235, 28)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Control))]
  internal interface IControl3
  {
    bool UseSystemFocusVisuals { get; set; }
  }
}
