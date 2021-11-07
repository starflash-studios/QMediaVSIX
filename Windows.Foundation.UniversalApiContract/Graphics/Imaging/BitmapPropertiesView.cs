// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapPropertiesView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Provides read access to image properties and metadata. A particular instance of BitmapPropertiesView may represent the entire contents of the frame metadata, or any nested metadata block within the frame.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BitmapPropertiesView : IBitmapPropertiesView
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BitmapPropertySet> GetPropertiesAsync(
      IIterable<string> propertiesToRetrieve);
  }
}
