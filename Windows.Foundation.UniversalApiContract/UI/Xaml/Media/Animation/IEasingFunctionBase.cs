// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IEasingFunctionBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3238541375, 11266, 16721, 142, 205, 104, 221, 170, 63, 13, 155)]
  [ExclusiveTo(typeof (EasingFunctionBase))]
  internal interface IEasingFunctionBase
  {
    EasingMode EasingMode { get; set; }

    double Ease(double normalizedTime);
  }
}
