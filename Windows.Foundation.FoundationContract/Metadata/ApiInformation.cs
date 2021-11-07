// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.ApiInformation
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Enables you to detect whether a specified member, type, or API contract is present so that you can safely make API calls across a variety of devices.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IApiInformationStatics), 65536, "Windows.Foundation.FoundationContract")]
  [ContractVersion(typeof (FoundationContract), 65536)]
  public static class ApiInformation
  {
    /// <summary>Returns true or false to indicate whether a specified type is present.</summary>
    /// <param name="typeName">The namespace-qualified name of the type.</param>
    /// <returns>**True** if the specified type is present; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool IsTypePresent(string typeName);

    /// <summary>Returns true or false to indicate whether a specified method is present for a specified type.</summary>
    /// <param name="typeName">The namespace-qualified name of the type.</param>
    /// <param name="methodName">The name of the method.</param>
    /// <returns>**True** if the specified method is present for the type; otherwise, **false**.</returns>
    [Overload("IsMethodPresent")]
    [MethodImpl]
    public static extern bool IsMethodPresent(string typeName, string methodName);

    /// <summary>Returns true or false to indicate whether a specified method overload with the specified number of input parameters is present for a specified type.</summary>
    /// <param name="typeName">The namespace-qualified name of the type.</param>
    /// <param name="methodName">The name of the method.</param>
    /// <param name="inputParameterCount">The number of input parameters for the overload.</param>
    /// <returns>**True** if the specified method is present for the type; otherwise, **false**.</returns>
    [Overload("IsMethodPresentWithArity")]
    [MethodImpl]
    public static extern bool IsMethodPresent(
      string typeName,
      string methodName,
      uint inputParameterCount);

    /// <summary>Returns true or false to indicate whether a specified event is present for a specified type.</summary>
    /// <param name="typeName">The namespace-qualified name of the type.</param>
    /// <param name="eventName">The name of the event.</param>
    /// <returns>**True** if the specified event is present for the type; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool IsEventPresent(string typeName, string eventName);

    /// <summary>Returns true or false to indicate whether a specified property (writeable or read-only) is present for a specified type.</summary>
    /// <param name="typeName">The namespace-qualified name of the type.</param>
    /// <param name="propertyName">The name of the property.</param>
    /// <returns>**True** if the specified property is present for the type; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool IsPropertyPresent(string typeName, string propertyName);

    /// <summary>Returns true or false to indicate whether a specified read-only property is present for a specified type.</summary>
    /// <param name="typeName">The namespace-qualified name of the type.</param>
    /// <param name="propertyName">The name of the property.</param>
    /// <returns>**True** if the specified property is present for the type; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool IsReadOnlyPropertyPresent(string typeName, string propertyName);

    /// <summary>Returns true or false to indicate whether a specified writeable property is present for a specified type.</summary>
    /// <param name="typeName">The namespace-qualified name of the type.</param>
    /// <param name="propertyName">The name of the property.</param>
    /// <returns>**True** if the specified property is present for the type; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool IsWriteablePropertyPresent(string typeName, string propertyName);

    /// <summary>Returns true or false to indicate whether a specified named constant is present for a specified enumeration.</summary>
    /// <param name="enumTypeName">The namespace-qualified name of the type.</param>
    /// <param name="valueName">The name of the constant.</param>
    /// <returns>**True** if the specified constant is present; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool IsEnumNamedValuePresent(string enumTypeName, string valueName);

    /// <summary>Returns true or false to indicate whether the API contract with the specified name and major version number is present.</summary>
    /// <param name="contractName">The name of the API contract.</param>
    /// <param name="majorVersion">The major version number of the API contract.</param>
    /// <returns>**True** if the specified API contract is present; otherwise, **false**.</returns>
    [Overload("IsApiContractPresentByMajor")]
    [MethodImpl]
    public static extern bool IsApiContractPresent(string contractName, ushort majorVersion);

    /// <summary>Returns true or false to indicate whether the API contract with the specified name and major and minor version number is present.</summary>
    /// <param name="contractName">The name of the API contract.</param>
    /// <param name="majorVersion">The major version number of the API contract.</param>
    /// <param name="minorVersion">The minor version number of the API contract.</param>
    /// <returns>**True** if the specified API contract is present; otherwise, **false**.</returns>
    [Overload("IsApiContractPresentByMajorAndMinor")]
    [MethodImpl]
    public static extern bool IsApiContractPresent(
      string contractName,
      ushort majorVersion,
      ushort minorVersion);
  }
}
