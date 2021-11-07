﻿// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsTimestampInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CmsTimestampInfo))]
  [Guid(794755314, 11288, 20360, 132, 53, 197, 52, 8, 96, 118, 245)]
  internal interface ICmsTimestampInfo
  {
    Certificate SigningCertificate { get; }

    IVectorView<Certificate> Certificates { get; }

    DateTime Timestamp { get; }
  }
}