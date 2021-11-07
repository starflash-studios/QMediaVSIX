// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Collections.CollectionChange
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Collections
{
  /// <summary>Describes the action that causes a change to a collection.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum CollectionChange
  {
    /// <summary>The collection is changed.</summary>
    Reset,
    /// <summary>An item is added to the collection.</summary>
    ItemInserted,
    /// <summary>An item is removed from the collection.</summary>
    ItemRemoved,
    /// <summary>An item is changed in the collection.</summary>
    ItemChanged,
  }
}
