// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IWriteableBitmap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (WriteableBitmap))]
  [Guid(3205201519, 57212, 19077, 132, 19, 161, 33, 98, 133, 131, 92)]
  internal interface IWriteableBitmap
  {
    IBuffer PixelBuffer { get; }

    void Invalidate();
  }
}
