// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.XamlBinaryWriter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Produces a pre-parsed binary representation of a XAML production.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IXamlBinaryWriterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class XamlBinaryWriter : IXamlBinaryWriter
  {
    [MethodImpl]
    public static extern XamlBinaryWriterErrorInformation Write(
      IVector<IRandomAccessStream> inputStreams,
      IVector<IRandomAccessStream> outputStreams,
      IXamlMetadataProvider xamlMetadataProvider);
  }
}
