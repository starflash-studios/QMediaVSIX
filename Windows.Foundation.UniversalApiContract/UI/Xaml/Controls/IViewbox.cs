// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IViewbox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(86322264, 47773, 18441, 158, 195, 250, 13, 22, 113, 11, 161)]
  [ExclusiveTo(typeof (Viewbox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IViewbox
  {
    UIElement Child { get; set; }

    Stretch Stretch { get; set; }

    StretchDirection StretchDirection { get; set; }
  }
}
