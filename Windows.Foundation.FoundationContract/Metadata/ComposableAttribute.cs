// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.ComposableAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Indicates how a programming element is composed.</summary>
  [AllowMultiple]
  [ContractVersion(typeof (FoundationContract), 65536)]
  [AttributeUsage(AttributeTargets.RuntimeClass)]
  public sealed class ComposableAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="type">The type of the factory object that is used to create the programming element.</param>
    /// <param name="compositionType">One of the enumeration values.</param>
    /// <param name="version">The version.</param>
    [MethodImpl]
    public extern ComposableAttribute(Type type, CompositionType compositionType, uint version);

    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="type">The type of the factory object that is used to create the programming element.</param>
    /// <param name="compositionType">One of the enumeration values.</param>
    /// <param name="version">The version.</param>
    /// <param name="platform">A value of the enumeration. The default is **Windows**.</param>
    [MethodImpl]
    public extern ComposableAttribute(
      Type type,
      CompositionType compositionType,
      uint version,
      Platform platform);

    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="type">The type of the factory object that is used to create the programming element.</param>
    /// <param name="compositionType">One of the enumeration values.</param>
    /// <param name="version">The version of the API contract in which the composition factory was added to the runtime class's activation factory.</param>
    /// <param name="contract">A string representing the type of the API contract implementing the class.</param>
    [MethodImpl]
    public extern ComposableAttribute(
      Type type,
      CompositionType compositionType,
      uint version,
      string contract);
  }
}
