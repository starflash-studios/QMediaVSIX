// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IStringable
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Provides a way to represent the current object as a string.</summary>
  [Guid(2520162132, 36534, 18672, 171, 206, 193, 178, 17, 230, 39, 195)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public interface IStringable
  {
    /// <summary>Gets a string that represents the current object.</summary>
    /// <returns>A string that represents the current object.</returns>
    string ToString();
  }
}
