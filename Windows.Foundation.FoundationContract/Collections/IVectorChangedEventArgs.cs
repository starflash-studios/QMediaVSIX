// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.IVectorChangedEventArgs
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Provides data for the changed event of a vector.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(1465463775, 13566, 17536, 175, 21, 7, 105, 31, 61, 93, 155)]
  public interface IVectorChangedEventArgs
  {
    /// <summary>Gets the type of change that occurred in the vector.</summary>
    /// <returns>The type of change in the vector.</returns>
    CollectionChange CollectionChange { get; }

    /// <summary>Gets the position where the change occurred in the vector.</summary>
    /// <returns>The zero-based position where the change occurred in the vector, if applicable.</returns>
    uint Index { get; }
  }
}
