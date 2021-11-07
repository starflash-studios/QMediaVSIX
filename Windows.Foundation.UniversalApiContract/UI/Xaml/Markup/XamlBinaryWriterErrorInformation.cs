// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.XamlBinaryWriterErrorInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  /// <summary>Records error information produced by calls to XamlBinaryWriter.Write.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct XamlBinaryWriterErrorInformation
  {
    /// <summary>The index of the stream in the original *inputStreams* parameter for XamlBinaryWriter.Write where the error occurred.</summary>
    public uint InputStreamIndex;
    /// <summary>The line number in the input XAML text representation where the error was encountered.</summary>
    public uint LineNumber;
    /// <summary>The line position in the input XAML text representation where the error was encountered.</summary>
    public uint LinePosition;
  }
}
