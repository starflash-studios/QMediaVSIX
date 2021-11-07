// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Metadata.FeatureAttribute
// Assembly: Windows.Foundation.FoundationContract, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 340999F0-93F9-406F-A02A-E1F4CFB68771
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.FoundationContract.winmd

using System;
using System.Runtime.CompilerServices;

namespace Windows.Foundation.Metadata
{
  /// <summary>Expresses the state of the Windows Runtime feature associated with a Windows Runtime Type.</summary>
  [ContractVersion(typeof (FoundationContract), 196608)]
  [AttributeUsage(AttributeTargets.Delegate | AttributeTargets.Enum | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.RuntimeClass | AttributeTargets.Struct | AttributeTargets.InterfaceImpl)]
  public sealed class FeatureAttribute : Attribute
  {
    /// <summary>Creates and initializes a new instance of the attribute.</summary>
    /// <param name="featureStage">Specifies if the named feature is enabled or disabled.</param>
    /// <param name="validInAllBranches">Boolean value that indicates if the named feature is valid in all branches.</param>
    [MethodImpl]
    public extern FeatureAttribute(FeatureStage featureStage, bool validInAllBranches);
  }
}
