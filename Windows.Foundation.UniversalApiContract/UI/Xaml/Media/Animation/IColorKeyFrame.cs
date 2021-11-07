// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IColorKeyFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (ColorKeyFrame))]
  [Guid(3038610137, 2320, 17801, 162, 132, 176, 201, 32, 88, 88, 233)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IColorKeyFrame
  {
    Color Value { get; set; }

    KeyTime KeyTime { get; set; }
  }
}
