// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapBuffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [Guid(2772305092, 14748, 17292, 178, 143, 166, 58, 107, 131, 209, 161)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BitmapBuffer))]
  internal interface IBitmapBuffer : IMemoryBuffer, IClosable
  {
    int GetPlaneCount();

    BitmapPlaneDescription GetPlaneDescription(int index);
  }
}
