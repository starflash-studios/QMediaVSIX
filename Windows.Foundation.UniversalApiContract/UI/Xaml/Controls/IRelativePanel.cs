// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRelativePanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(783022827, 45914, 16437, 172, 234, 60, 74, 55, 48, 104, 63)]
  [ExclusiveTo(typeof (RelativePanel))]
  internal interface IRelativePanel
  {
    Brush BorderBrush { get; set; }

    Thickness BorderThickness { get; set; }

    CornerRadius CornerRadius { get; set; }

    Thickness Padding { get; set; }
  }
}
