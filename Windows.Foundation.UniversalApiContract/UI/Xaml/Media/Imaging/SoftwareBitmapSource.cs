// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.SoftwareBitmapSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.UI.Xaml.Media.Imaging
{
  /// <summary>Provides a source object, backed by a SoftwareBitmap, for properties that use a bitmap-format image source.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class SoftwareBitmapSource : ImageSource, ISoftwareBitmapSource, IClosable
  {
    /// <summary>Initializes a new instance of the SoftwareBitmapSource class.</summary>
    [MethodImpl]
    public extern SoftwareBitmapSource();

    /// <summary>Sets the source SoftwareBitmap to be used as an image source.</summary>
    /// <param name="softwareBitmap">The SoftwareBitmap to be used as an image source.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetBitmapAsync(SoftwareBitmap softwareBitmap);

    [MethodImpl]
    public extern void Close();
  }
}
