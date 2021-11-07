// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.IApiInformationStatics
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

namespace Windows.Foundation.Metadata
{
  [ContractVersion(typeof (FoundationContract), 65536)]
  [ExclusiveTo(typeof (ApiInformation))]
  [Guid(2574531070, 63105, 18961, 180, 22, 193, 58, 71, 232, 186, 54)]
  internal interface IApiInformationStatics
  {
    bool IsTypePresent(string typeName);

    [Overload("IsMethodPresent")]
    bool IsMethodPresent(string typeName, string methodName);

    [Overload("IsMethodPresentWithArity")]
    bool IsMethodPresent(string typeName, string methodName, uint inputParameterCount);

    bool IsEventPresent(string typeName, string eventName);

    bool IsPropertyPresent(string typeName, string propertyName);

    bool IsReadOnlyPropertyPresent(string typeName, string propertyName);

    bool IsWriteablePropertyPresent(string typeName, string propertyName);

    bool IsEnumNamedValuePresent(string enumTypeName, string valueName);

    [Overload("IsApiContractPresentByMajor")]
    bool IsApiContractPresent(string contractName, ushort majorVersion);

    [Overload("IsApiContractPresentByMajorAndMinor")]
    bool IsApiContractPresent(string contractName, ushort majorVersion, ushort minorVersion);
  }
}
