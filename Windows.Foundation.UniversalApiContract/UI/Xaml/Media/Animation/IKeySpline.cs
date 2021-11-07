// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IKeySpline
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeySpline))]
  [Guid(2007065531, 54730, 18994, 186, 11, 125, 255, 152, 142, 88, 160)]
  [WebHostHidden]
  internal interface IKeySpline
  {
    Point ControlPoint1 { get; set; }

    Point ControlPoint2 { get; set; }
  }
}
