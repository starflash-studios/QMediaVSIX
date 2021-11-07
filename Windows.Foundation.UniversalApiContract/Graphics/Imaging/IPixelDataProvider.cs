// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IPixelDataProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Guid(3716357925, 6236, 17813, 159, 185, 204, 190, 110, 193, 138, 111)]
  [ExclusiveTo(typeof (PixelDataProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPixelDataProvider
  {
    byte[] DetachPixelData();
  }
}
