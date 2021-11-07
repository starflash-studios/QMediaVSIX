// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IArcSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (ArcSegment))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(127143007, 25595, 17513, 145, 190, 241, 9, 124, 22, 128, 82)]
  [WebHostHidden]
  internal interface IArcSegment
  {
    Point Point { get; set; }

    Size Size { get; set; }

    double RotationAngle { get; set; }

    bool IsLargeArc { get; set; }

    SweepDirection SweepDirection { get; set; }
  }
}
