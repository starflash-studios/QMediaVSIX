// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IRestrictedLaunchActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides event information when a restricted app is launched.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3770133633, 49091, 17220, 165, 218, 25, 253, 90, 39, 186, 174)]
  public interface IRestrictedLaunchActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets information about a shared context for the restricted launch.</summary>
    /// <returns>The object that provides shared context information.</returns>
    object SharedContext { get; }
  }
}
