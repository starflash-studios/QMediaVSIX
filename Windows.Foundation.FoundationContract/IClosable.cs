// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IClosable
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Defines a method to release allocated resources.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [Guid(819308585, 32676, 16422, 131, 187, 215, 91, 174, 78, 169, 158)]
  public interface IClosable
  {
    /// <summary>Releases system resources that are exposed by a Windows Runtime object.</summary>
    void Close();
  }
}
