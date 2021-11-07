// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IRotateTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (RotateTransform))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1754180025, 7758, 17814, 134, 227, 66, 139, 39, 51, 79, 175)]
  internal interface IRotateTransform
  {
    double CenterX { get; set; }

    double CenterY { get; set; }

    double Angle { get; set; }
  }
}
