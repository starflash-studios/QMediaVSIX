// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.DeprecatedAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Indicates that a type or member should be marked in metadata as deprecated. Compilers and other developer tools can read this attribute and provide info to the user about the deprecation type and possible alternates.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.RuntimeClass | AttributeTargets.Struct)]
  [AllowMultiple]
  public sealed class DeprecatedAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="message">A string message that can be used by compilers and other developer tools to explain the deprecation and provide the string names of alternate API.</param>
    /// <param name="type">A value of the enumeration. The default is **Deprecate**.</param>
    /// <param name="version">A constant that indicates the version that the deprecation applies to.</param>
    [MethodImpl]
    public extern DeprecatedAttribute(string message, DeprecationType type, uint version);

    /// <summary>Creates and initializes a new instance of the attribute, including a Platform value for targeting.</summary>
    /// <param name="message">A string message that can be used by compilers and other developer tools to explain the deprecation and provide the string names of alternate API.</param>
    /// <param name="type">A value of the enumeration. The default is **Deprecate**.</param>
    /// <param name="version">A constant that indicates the version that the deprecation applies to.</param>
    /// <param name="platform">A value of the enumeration. The default is **Windows**.</param>
    [MethodImpl]
    public extern DeprecatedAttribute(
      string message,
      DeprecationType type,
      uint version,
      Platform platform);

    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="message">A string message that can be used by compilers and other developer tools to explain the deprecation and provide the string names of alternate API.</param>
    /// <param name="type">A value of the enumeration. The default is **Deprecate**.</param>
    /// <param name="version">A constant that indicates the version that the deprecation applies to.</param>
    /// <param name="contract">A string representing the type of the API contract implementing the deprecated type or member.</param>
    [MethodImpl]
    public extern DeprecatedAttribute(
      string message,
      DeprecationType type,
      uint version,
      string contract);
  }
}
