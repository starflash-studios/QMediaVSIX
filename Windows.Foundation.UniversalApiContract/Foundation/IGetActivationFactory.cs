// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IGetActivationFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  /// <summary>Defines the implementation for a type that retrieves activation factories.</summary>
  [Guid(1323011810, 38621, 18855, 148, 247, 70, 7, 221, 171, 142, 60)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IGetActivationFactory
  {
    /// <summary>Retrieves the implementation of an activation factory.</summary>
    /// <param name="activatableClassId">The Activation ID (ACID) of the activatable type produced by the factory.</param>
    /// <returns>An instance of an activation factory type. This type must implement IActivationFactory.</returns>
    object GetActivationFactory(string activatableClassId);
  }
}
