// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IWriteableBitmapFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ExclusiveTo(typeof (WriteableBitmap))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1432611761, 16114, 17093, 156, 109, 28, 245, 220, 192, 65, 255)]
  internal interface IWriteableBitmapFactory
  {
    WriteableBitmap CreateInstanceWithDimensions(int pixelWidth, int pixelHeight);
  }
}
