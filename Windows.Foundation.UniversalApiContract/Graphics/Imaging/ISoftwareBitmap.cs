// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.ISoftwareBitmap
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SoftwareBitmap))]
  [Guid(1755186952, 32495, 18495, 150, 63, 218, 147, 136, 24, 224, 115)]
  internal interface ISoftwareBitmap : IClosable
  {
    BitmapPixelFormat BitmapPixelFormat { get; }

    BitmapAlphaMode BitmapAlphaMode { get; }

    int PixelWidth { get; }

    int PixelHeight { get; }

    bool IsReadOnly { get; }

    double DpiX { set; get; }

    double DpiY { set; get; }

    BitmapBuffer LockBuffer(BitmapBufferAccessMode mode);

    void CopyTo(SoftwareBitmap bitmap);

    void CopyFromBuffer(IBuffer buffer);

    void CopyToBuffer(IBuffer buffer);

    SoftwareBitmap GetReadOnlyView();
  }
}
