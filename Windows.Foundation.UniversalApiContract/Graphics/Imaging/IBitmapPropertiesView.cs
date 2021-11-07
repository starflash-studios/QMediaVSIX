// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapPropertiesView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Exposes methods for reading image metadata and properties.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2114971770, 14960, 18680, 156, 85, 25, 108, 245, 165, 69, 245)]
  public interface IBitmapPropertiesView
  {
    [RemoteAsync]
    IAsyncOperation<BitmapPropertySet> GetPropertiesAsync(
      IIterable<string> propertiesToRetrieve);
  }
}
