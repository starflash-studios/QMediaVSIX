// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapEncoderWithSoftwareBitmap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ExclusiveTo(typeof (BitmapEncoder))]
  [Guid(1751962177, 17200, 19575, 172, 228, 3, 52, 150, 139, 23, 104)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBitmapEncoderWithSoftwareBitmap
  {
    void SetSoftwareBitmap(SoftwareBitmap bitmap);
  }
}
