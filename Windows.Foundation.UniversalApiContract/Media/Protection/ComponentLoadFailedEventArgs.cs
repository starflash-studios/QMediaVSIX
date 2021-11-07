// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.ComponentLoadFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Contains event data for a MediaProtectionManager object when the load of binary data fails.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ComponentLoadFailedEventArgs : IComponentLoadFailedEventArgs
  {
    /// <summary>Returns a list of components in the RevocationAndRenewalInformation object that need to be revoked and renewed with updated components.</summary>
    /// <returns>An object that contains a list of components to be revoked and renewed with updated components.</returns>
    public extern RevocationAndRenewalInformation Information { [MethodImpl] get; }

    /// <summary>Returns an indication of the completion of the event.</summary>
    /// <returns>An object that contains an indication of the completion of the event.</returns>
    public extern MediaProtectionServiceCompletion Completion { [MethodImpl] get; }
  }
}
