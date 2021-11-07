// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IRepositionThemeTransition2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RepositionThemeTransition))]
  [Guid(3468683364, 56298, 17412, 142, 110, 222, 85, 173, 167, 82, 57)]
  internal interface IRepositionThemeTransition2
  {
    bool IsStaggeringEnabled { get; set; }
  }
}
