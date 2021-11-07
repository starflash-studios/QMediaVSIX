// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapTypedValueFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Guid(2463872409, 52755, 18107, 149, 69, 203, 58, 63, 99, 235, 139)]
  [ExclusiveTo(typeof (BitmapTypedValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBitmapTypedValueFactory
  {
    BitmapTypedValue Create(object value, PropertyType type);
  }
}
