﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.ConversationalAgent.IActivationSignalDetectionConfigurationCreationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.ConversationalAgent
{
  [ContractVersion(typeof (UniversalApiContract), 851968)]
  [ExclusiveTo(typeof (ActivationSignalDetectionConfigurationCreationResult))]
  [Guid(1284095003, 36114, 24136, 167, 28, 127, 107, 193, 205, 102, 224)]
  internal interface IActivationSignalDetectionConfigurationCreationResult
  {
    ActivationSignalDetectionConfigurationCreationStatus Status { get; }

    ActivationSignalDetectionConfiguration Configuration { get; }
  }
}