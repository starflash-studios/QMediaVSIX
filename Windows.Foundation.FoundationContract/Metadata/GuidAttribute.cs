// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.GuidAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Indicates the GUID for the interface or delegate.</summary>
  [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Interface)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public sealed class GuidAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="a">The first 4 bytes of the GUID.</param>
    /// <param name="b">The next 2 bytes of the GUID.</param>
    /// <param name="c">The next 2 bytes of the GUID.</param>
    /// <param name="d">The next byte of the GUID.</param>
    /// <param name="e">The next byte of the GUID.</param>
    /// <param name="f">The next byte of the GUID.</param>
    /// <param name="g">The next byte of the GUID.</param>
    /// <param name="h">The next byte of the GUID.</param>
    /// <param name="i">The next byte of the GUID.</param>
    /// <param name="j">The next byte of the GUID.</param>
    /// <param name="k">The next byte of the GUID.</param>
    [MethodImpl]
    public extern GuidAttribute(
      uint a,
      ushort b,
      ushort c,
      byte d,
      byte e,
      byte f,
      byte g,
      byte h,
      byte i,
      byte j,
      byte k);
  }
}
