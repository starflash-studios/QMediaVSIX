﻿// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.DataProtection.IDataProtectionProviderFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.DataProtection
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2918399404, 18738, 19679, 172, 65, 114, 20, 51, 53, 20, 202)]
  [ExclusiveTo(typeof (DataProtectionProvider))]
  internal interface IDataProtectionProviderFactory
  {
    DataProtectionProvider CreateOverloadExplicit(string protectionDescriptor);
  }
}