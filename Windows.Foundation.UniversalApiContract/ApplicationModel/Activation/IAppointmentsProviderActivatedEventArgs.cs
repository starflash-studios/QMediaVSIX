// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IAppointmentsProviderActivatedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  /// <summary>Provides data when an app is activated.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(862241797, 37692, 20093, 160, 52, 80, 15, 184, 220, 217, 243)]
  public interface IAppointmentsProviderActivatedEventArgs : IActivatedEventArgs
  {
    /// <summary>Gets the action to be performed by the appointments provider.</summary>
    /// <returns>The action to be performed by the appointments provider.</returns>
    string Verb { get; }
  }
}
