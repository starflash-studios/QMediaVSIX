// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPointerUpThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PointerUpThemeAnimation))]
  [Guid(3924414589, 25408, 18472, 173, 18, 105, 6, 148, 185, 145, 11)]
  [WebHostHidden]
  internal interface IPointerUpThemeAnimation
  {
    string TargetName { get; set; }
  }
}
