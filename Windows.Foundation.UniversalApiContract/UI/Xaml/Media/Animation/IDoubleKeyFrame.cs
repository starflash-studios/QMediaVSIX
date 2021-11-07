// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDoubleKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(1732531965, 59422, 20302, 180, 173, 10, 207, 237, 158, 205, 104)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (DoubleKeyFrame))]
  internal interface IDoubleKeyFrame
  {
    double Value { get; set; }

    KeyTime KeyTime { get; set; }
  }
}
