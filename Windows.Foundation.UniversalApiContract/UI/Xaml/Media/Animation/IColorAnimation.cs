// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IColorAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ColorAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3098446357, 3939, 18068, 148, 103, 189, 175, 172, 18, 83, 234)]
  [WebHostHidden]
  internal interface IColorAnimation
  {
    IReference<Color> From { get; set; }

    IReference<Color> To { get; set; }

    IReference<Color> By { get; set; }

    EasingFunctionBase EasingFunction { get; set; }

    bool EnableDependentAnimation { get; set; }
  }
}
