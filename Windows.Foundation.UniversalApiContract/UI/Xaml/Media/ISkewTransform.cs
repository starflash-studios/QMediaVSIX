// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ISkewTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(1317681941, 31247, 17943, 158, 152, 30, 101, 189, 201, 33, 21)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SkewTransform))]
  [WebHostHidden]
  internal interface ISkewTransform
  {
    double CenterX { get; set; }

    double CenterY { get; set; }

    double AngleX { get; set; }

    double AngleY { get; set; }
  }
}
