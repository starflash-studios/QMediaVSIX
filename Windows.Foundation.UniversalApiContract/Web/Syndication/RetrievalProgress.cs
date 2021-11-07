// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.RetrievalProgress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  /// <summary>Contains progress information for a data retrieval operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct RetrievalProgress
  {
    /// <summary>The number of bytes that have been received in this data retrieval operation.</summary>
    public uint BytesRetrieved;
    /// <summary>The total number of bytes to be received during this data retrieval operation.</summary>
    public uint TotalBytesToRetrieve;
  }
}
