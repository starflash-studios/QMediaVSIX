﻿// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.NetworkOperatorTetheringOperationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents the results of a StartTetheringAsync or StopTetheringAsync operation. In addition to the TetheringOperationStatus value, it can include an optional error message string that provides mobile operator specific context to the error.</summary>
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class NetworkOperatorTetheringOperationResult : 
    INetworkOperatorTetheringOperationResult
  {
    /// <summary>Indicates the result of a tethering operation. Possible values are defined by TetheringOperationStatus.</summary>
    /// <returns>The result of a tethering operation.</returns>
    public extern TetheringOperationStatus Status { [MethodImpl] get; }

    /// <summary>An optional error message string that provides mobile operator specific context to the error.</summary>
    /// <returns>The mobile operator defined error context.</returns>
    public extern string AdditionalErrorMessage { [MethodImpl] get; }
  }
}