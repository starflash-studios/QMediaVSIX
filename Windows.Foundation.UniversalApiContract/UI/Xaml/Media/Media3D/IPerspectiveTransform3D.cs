// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.IPerspectiveTransform3D
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2591773482, 12537, 16545, 150, 201, 197, 157, 135, 249, 90, 195)]
  [ExclusiveTo(typeof (PerspectiveTransform3D))]
  [WebHostHidden]
  internal interface IPerspectiveTransform3D
  {
    double Depth { get; set; }

    double OffsetX { get; set; }

    double OffsetY { get; set; }
  }
}
