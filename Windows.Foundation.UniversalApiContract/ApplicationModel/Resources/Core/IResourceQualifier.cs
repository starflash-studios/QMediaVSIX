﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.Core.IResourceQualifier
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2019403186, 19197, 17270, 168, 136, 197, 249, 166, 183, 160, 92)]
  [ExclusiveTo(typeof (ResourceQualifier))]
  internal interface IResourceQualifier
  {
    string QualifierName { get; }

    string QualifierValue { get; }

    bool IsDefault { get; }

    bool IsMatch { get; }

    double Score { get; }
  }
}