// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IBitmapImage3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ExclusiveTo(typeof (BitmapImage))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4057886502, 15475, 17727, 167, 186, 155, 133, 193, 139, 55, 51)]
  [WebHostHidden]
  internal interface IBitmapImage3
  {
    bool IsAnimatedBitmap { get; }

    bool IsPlaying { get; }

    bool AutoPlay { get; set; }

    void Play();

    void Stop();
  }
}
