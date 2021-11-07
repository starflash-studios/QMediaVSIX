// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGrid2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Grid))]
  [Guid(4151245377, 14350, 17883, 190, 135, 158, 19, 38, 186, 75, 87)]
  internal interface IGrid2
  {
    Brush BorderBrush { get; set; }

    Thickness BorderThickness { get; set; }

    CornerRadius CornerRadius { get; set; }

    Thickness Padding { get; set; }
  }
}
