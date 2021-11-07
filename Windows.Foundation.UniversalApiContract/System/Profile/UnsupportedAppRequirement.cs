﻿// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.UnsupportedAppRequirement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  /// <summary>Provides a reason why a particular App Capability is not supported on a particular device</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UnsupportedAppRequirement : IUnsupportedAppRequirement
  {
    /// <summary>The name of the App Capability that is not supported</summary>
    /// <returns>
    /// </returns>
    public extern string Requirement { [MethodImpl] get; }

    /// <summary>An UnsupportedAppRequirementReasons object that explains why a particular App Capability is unsupported on the current device</summary>
    /// <returns>
    /// </returns>
    public extern UnsupportedAppRequirementReasons Reasons { [MethodImpl] get; }
  }
}