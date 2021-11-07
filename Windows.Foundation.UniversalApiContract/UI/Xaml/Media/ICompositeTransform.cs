// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ICompositeTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3366205531, 62026, 18177, 162, 101, 167, 136, 70, 241, 66, 185)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositeTransform))]
  internal interface ICompositeTransform
  {
    double CenterX { get; set; }

    double CenterY { get; set; }

    double ScaleX { get; set; }

    double ScaleY { get; set; }

    double SkewX { get; set; }

    double SkewY { get; set; }

    double Rotation { get; set; }

    double TranslateX { get; set; }

    double TranslateY { get; set; }
  }
}
