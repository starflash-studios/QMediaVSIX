// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.AttributeTargets
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;

namespace Windows.Foundation.Metadata
{
  /// <summary>Specifies the programming construct to which an attribute applies.</summary>
  [Flags]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public enum AttributeTargets : uint
  {
    /// <summary>The attribute applies to all programming constructs.</summary>
    All = 4294967295, // 0xFFFFFFFF
    /// <summary>The attribute applies to a delegate.</summary>
    Delegate = 1,
    /// <summary>The attribute applies to an enumeration.</summary>
    Enum = 2,
    /// <summary>The attribute applies to an event.</summary>
    Event = 4,
    /// <summary>The attribute applies to a field.</summary>
    Field = 8,
    /// <summary>The attribute applies to an interface.</summary>
    Interface = 16, // 0x00000010
    /// <summary>The attribute applies to a method.</summary>
    Method = 64, // 0x00000040
    /// <summary>The attribute applies to a parameter.</summary>
    Parameter = 128, // 0x00000080
    /// <summary>The attribute applies to a property.</summary>
    Property = 256, // 0x00000100
    /// <summary>The attribute applies to a runtime class.</summary>
    RuntimeClass = 512, // 0x00000200
    /// <summary>The attribute applies to a struct.</summary>
    Struct = 1024, // 0x00000400
    /// <summary>The attribute applies to an implementation of an interface.</summary>
    InterfaceImpl = 2048, // 0x00000800
    /// <summary>The attribute applies to an API contract.</summary>
    ApiContract = 8192, // 0x00002000
  }
}
