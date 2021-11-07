// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactChangeTracker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Provides functionality for monitoring changes to Contact objects in the ContactStore.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ContactChangeTracker : IContactChangeTracker, IContactChangeTracker2
  {
    /// <summary>Call this method to enable change tracking.</summary>
    [MethodImpl]
    public extern void Enable();

    /// <summary>Gets a ContactChangeReader that can be used to process changes.</summary>
    /// <returns>A ContactChangeReader that can be used to process changes.</returns>
    [MethodImpl]
    public extern ContactChangeReader GetChangeReader();

    /// <summary>Call this method to reset the change tracker if your app receives ContactChangeType.ChangeTrackingLost.</summary>
    [MethodImpl]
    public extern void Reset();

    /// <summary>Gets a Boolean value indicating whether change tracking is active.</summary>
    /// <returns>A Boolean value indicating whether change tracking is active.</returns>
    public extern bool IsTracking { [MethodImpl] get; }
  }
}
