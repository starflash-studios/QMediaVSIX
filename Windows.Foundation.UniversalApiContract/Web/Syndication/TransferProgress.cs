// Decompiled with JetBrains decompiler
// Type: Windows.Web.Syndication.TransferProgress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Syndication
{
  /// <summary>Contains progress information for a data transfer operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct TransferProgress
  {
    /// <summary>The number of bytes sent.</summary>
    public uint BytesSent;
    /// <summary>The total number of bytes that will be sent during the transfer operation.</summary>
    public uint TotalBytesToSend;
    /// <summary>The number of bytes received.</summary>
    public uint BytesRetrieved;
    /// <summary>The total number of bytes that will be received during the transfer operation.</summary>
    public uint TotalBytesToRetrieve;
  }
}
