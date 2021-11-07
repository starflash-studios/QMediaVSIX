// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.ActivatableAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Indicates that the class is an activatable runtime class.</summary>
  [AttributeUsage(AttributeTargets.RuntimeClass)]
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AllowMultiple]
  public sealed class ActivatableAttribute : Attribute
  {
    /// <summary>Indicates that the runtime class can be activated with no parameters, starting in a particular version.</summary>
    /// <param name="version">The minimum version that can activate the runtime class with no parameters.</param>
    [MethodImpl]
    public extern ActivatableAttribute(uint version);

    /// <summary>Indicates that the runtime class can be activated with no parameters, starting in a particular version of a particular API contract.</summary>
    /// <param name="version">The version of the API contract that can activate the runtime class with no parameters. The major version is in the high-order 16-bits and the minor version is in the low-order 16 bits.</param>
    /// <param name="type">The name of the API contract that can activate the runtime class with no parameters.</param>
    [MethodImpl]
    public extern ActivatableAttribute(uint version, string type);

    /// <summary>Indicates that the runtime class can be activated with no parameters, starting in a particular version of a particular platform.</summary>
    /// <param name="version">The minimum version of the platform that can activate the runtime class with no parameters.</param>
    /// <param name="platform">The platform that can activate the runtime class with no parameters.</param>
    [MethodImpl]
    public extern ActivatableAttribute(uint version, Platform platform);

    /// <summary>Indicates that the runtime class can be activated with parameters, starting in a particular version.</summary>
    /// <param name="type">The type of the interface that is used to activate objects.</param>
    /// <param name="version">The minimum version that can activate the runtime class with the specified interface.</param>
    [MethodImpl]
    public extern ActivatableAttribute(Type type, uint version);

    /// <summary>Indicates that the runtime class can be activated with parameters, starting in a particular version of a particular API contract.</summary>
    /// <param name="type">The type of the interface that is used to activate objects.</param>
    /// <param name="version">The minimum version of the API contract that can activate the runtime class with the specified interface. The major version is in the high-order 16-bits and the minor version is in the low-order 16 bits.</param>
    /// <param name="contractName">The name of the API contract that can activate the runtime class with the specified interface.</param>
    [MethodImpl]
    public extern ActivatableAttribute(Type type, uint version, string contractName);

    /// <summary>Indicates that the runtime class can be activated with parameters, starting in a particular version of a particular platform.</summary>
    /// <param name="type">The type of the interface that is used to activate objects.</param>
    /// <param name="version">The version of the platform that can activate the runtime class with the specified interface.</param>
    /// <param name="platform">The platform that can activate the runtime class with the specified interface.</param>
    [MethodImpl]
    public extern ActivatableAttribute(Type type, uint version, Platform platform);
  }
}
