// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPopOutThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Guid(1200008009, 3656, 20097, 162, 229, 204, 90, 161, 158, 72, 211)]
  [ExclusiveTo(typeof (PopOutThemeAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPopOutThemeAnimation
  {
    string TargetName { get; set; }
  }
}
