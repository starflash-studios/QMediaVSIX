// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDragOverThemeAnimationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(342883927, 15517, 16857, 165, 255, 141, 114, 57, 81, 104, 16)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DragOverThemeAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDragOverThemeAnimationStatics
  {
    DependencyProperty TargetNameProperty { get; }

    DependencyProperty ToOffsetProperty { get; }

    DependencyProperty DirectionProperty { get; }
  }
}
