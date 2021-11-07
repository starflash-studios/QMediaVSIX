// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IContentTypeProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Characterizes the format of the data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2547030181, 15257, 19945, 136, 165, 225, 29, 47, 80, 199, 149)]
  public interface IContentTypeProvider
  {
    /// <summary>Gets the format of the data.</summary>
    /// <returns>The identifier for the format of the data.</returns>
    string ContentType { get; }
  }
}
