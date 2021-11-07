// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IXamlBinaryWriterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Markup
{
  [Guid(227463290, 39810, 19112, 182, 139, 2, 111, 45, 225, 204, 134)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (XamlBinaryWriter))]
  internal interface IXamlBinaryWriterStatics
  {
    XamlBinaryWriterErrorInformation Write(
      IVector<IRandomAccessStream> inputStreams,
      IVector<IRandomAccessStream> outputStreams,
      IXamlMetadataProvider xamlMetadataProvider);
  }
}
