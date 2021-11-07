// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IScaleTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (ScaleTransform))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3983012237, 37742, 17323, 146, 154, 233, 205, 10, 81, 30, 82)]
  internal interface IScaleTransform
  {
    double CenterX { get; set; }

    double CenterY { get; set; }

    double ScaleX { get; set; }

    double ScaleY { get; set; }
  }
}
