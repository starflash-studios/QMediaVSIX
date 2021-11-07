// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.MediaProtectionManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Contains a content protection manager object for an application that handles protected media content.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MediaProtectionManager : IMediaProtectionManager
  {
    /// <summary>Initializes a new instance of the MediaProtectionManager class.</summary>
    [MethodImpl]
    public extern MediaProtectionManager();

    /// <summary>Fires when a service is requested.</summary>
    public extern event ServiceRequestedEventHandler ServiceRequested;

    /// <summary>Fires when a reboot is needed after the component is renewed.</summary>
    public extern event RebootNeededEventHandler RebootNeeded;

    /// <summary>Fires when the load of binary data fails.</summary>
    public extern event ComponentLoadFailedEventHandler ComponentLoadFailed;

    /// <summary>Gets a PropertySet object containing any properties attached to the protection manager.</summary>
    /// <returns>The PropertySet object that contains the properties for this protection manager.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
