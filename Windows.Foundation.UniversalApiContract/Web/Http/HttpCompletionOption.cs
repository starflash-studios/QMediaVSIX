// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpCompletionOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  /// <summary>Indicates whether asynchronous HttpClient operations are considered completed when all of the response is read, or when just the headers are read.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum HttpCompletionOption
  {
    /// <summary>The operation should complete after reading the entire response including the content.</summary>
    ResponseContentRead,
    /// <summary>The operation should complete as soon as a response is available and headers are read. The content is not read yet.</summary>
    ResponseHeadersRead,
  }
}
