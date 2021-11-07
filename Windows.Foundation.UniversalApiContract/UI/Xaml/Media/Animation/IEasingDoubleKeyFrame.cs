// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEasingDoubleKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EasingDoubleKeyFrame))]
  [WebHostHidden]
  [Guid(2522536845, 39508, 16648, 180, 255, 181, 165, 33, 44, 179, 56)]
  internal interface IEasingDoubleKeyFrame
  {
    EasingFunctionBase EasingFunction { get; set; }
  }
}
