// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDragItemThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DragItemThemeAnimation))]
  [WebHostHidden]
  [Guid(209542581, 32470, 18761, 180, 230, 167, 140, 159, 79, 151, 141)]
  internal interface IDragItemThemeAnimation
  {
    string TargetName { get; set; }
  }
}
