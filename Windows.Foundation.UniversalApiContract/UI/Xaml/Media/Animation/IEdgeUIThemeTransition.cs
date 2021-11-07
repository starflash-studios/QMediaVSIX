// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEdgeUIThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EdgeUIThemeTransition))]
  [WebHostHidden]
  [Guid(1552335259, 18903, 6636, 207, 25, 131, 167, 60, 109, 231, 94)]
  internal interface IEdgeUIThemeTransition
  {
    EdgeTransitionLocation Edge { get; set; }
  }
}
