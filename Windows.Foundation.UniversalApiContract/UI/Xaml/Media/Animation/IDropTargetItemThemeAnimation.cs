// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDropTargetItemThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(411158888, 6180, 17963, 135, 232, 195, 87, 33, 43, 151, 123)]
  [ExclusiveTo(typeof (DropTargetItemThemeAnimation))]
  internal interface IDropTargetItemThemeAnimation
  {
    string TargetName { get; set; }
  }
}
