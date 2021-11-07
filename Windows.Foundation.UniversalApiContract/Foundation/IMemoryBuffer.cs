// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IMemoryBuffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Represents a reference counted memory buffer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4223982890, 9307, 4580, 175, 152, 104, 148, 35, 38, 12, 248)]
  public interface IMemoryBuffer : IClosable
  {
    /// <summary>Returns a new managed object that implements the IMemoryBufferReference interface.</summary>
    /// <returns>A new managed object that implements the IMemoryBufferReference interface.</returns>
    IMemoryBufferReference CreateReference();
  }
}
