// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.StaticAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Indicates an interface that contains only static methods.</summary>
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AllowMultiple]
  [AttributeUsage(AttributeTargets.RuntimeClass)]
  public sealed class StaticAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="type">The type that contains the static methods for the runtime class.</param>
    /// <param name="version">The version in which the static interface was added.</param>
    [MethodImpl]
    public extern StaticAttribute(Type type, uint version);

    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="type">The type that contains the static methods for the runtime class.</param>
    /// <param name="version">The version in which the static interface was added.</param>
    /// <param name="platform">A value of the enumeration. The default is **Windows**.</param>
    [MethodImpl]
    public extern StaticAttribute(Type type, uint version, Platform platform);

    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="type">The type that contains the static methods for the runtime class.</param>
    /// <param name="version">The version of the API Contract in which the static factory was added to the runtime class's activation factory.</param>
    /// <param name="contractName">A string representing the type of the API contract implementing the class.</param>
    [MethodImpl]
    public extern StaticAttribute(Type type, uint version, string contractName);
  }
}
