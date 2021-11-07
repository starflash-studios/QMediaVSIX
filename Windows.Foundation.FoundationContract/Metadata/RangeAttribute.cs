// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.RangeAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Indicates the numeric range constraints for the value of a data field.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AttributeUsage(AttributeTargets.Parameter)]
  public sealed class RangeAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute with the specified minimum and maximum values.</summary>
    /// <param name="minValue">The minimum value allowed.</param>
    /// <param name="maxValue">The maximum value allowed.</param>
    [MethodImpl]
    public extern RangeAttribute(int minValue, int maxValue);
  }
}
