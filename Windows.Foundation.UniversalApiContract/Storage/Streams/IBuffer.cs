// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IBuffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Represents a referenced array of bytes used by byte stream read and write interfaces. Buffer is the class implementation of this interface.</summary>
  [Guid(2421821408, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IBuffer
  {
    /// <summary>Gets the maximum number of bytes that the buffer can hold.</summary>
    /// <returns>The maximum number of bytes that the buffer can hold.</returns>
    uint Capacity { get; }

    /// <summary>Gets the number of bytes currently in use in the buffer.</summary>
    /// <returns>The number of bytes currently in use in the buffer which is less than or equal to the capacity of the buffer.</returns>
    uint Length { get; set; }
  }
}
