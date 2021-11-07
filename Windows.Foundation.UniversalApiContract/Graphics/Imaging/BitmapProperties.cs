// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  /// <summary>Provides read and write access to image properties and metadata.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BitmapProperties : IBitmapProperties, IBitmapPropertiesView
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetPropertiesAsync(
      IIterable<IKeyValuePair<string, BitmapTypedValue>> propertiesToSet);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BitmapPropertySet> GetPropertiesAsync(
      IIterable<string> propertiesToRetrieve);
  }
}
