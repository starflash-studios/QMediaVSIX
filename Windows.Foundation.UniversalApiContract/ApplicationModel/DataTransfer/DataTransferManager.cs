// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.DataTransferManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  /// <summary>Programmatically initiates an exchange of content with other apps.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDataTransferManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IDataTransferManagerStatics3), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IDataTransferManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class DataTransferManager : IDataTransferManager, IDataTransferManager2
  {
    /// <summary>Occurs when a share operation starts.</summary>
    public extern event TypedEventHandler<DataTransferManager, DataRequestedEventArgs> DataRequested;

    /// <summary>Occurs when the user chooses a target app in the Share charm.</summary>
    public extern event TypedEventHandler<DataTransferManager, TargetApplicationChosenEventArgs> TargetApplicationChosen;

    /// <summary>An event that is triggered when the share providers are requested. This is used as a callback and providers are added by subscribing to this event and calling ShareProvidersRequestedEventArgs.Providers.Add() in the event handler.</summary>
    public extern event TypedEventHandler<DataTransferManager, ShareProvidersRequestedEventArgs> ShareProvidersRequested;

    /// <summary>Programmatically initiates the user interface for sharing content with another app.</summary>
    /// <param name="options">The options.</param>
    [Overload("ShowShareUIWithOptions")]
    [MethodImpl]
    public static extern void ShowShareUI(ShareUIOptions options);

    /// <summary>Returns true if the device supports sharing, false otherwise.</summary>
    /// <returns>True if the device supports sharing, false otherwise.</returns>
    [MethodImpl]
    public static extern bool IsSupported();

    /// <summary>Programmatically initiates the user interface for sharing content with another app.</summary>
    [MethodImpl]
    public static extern void ShowShareUI();

    /// <summary>Returns the DataTransferManager object associated with the current window.</summary>
    /// <returns>The DataTransferManager object associated with the current window.</returns>
    [MethodImpl]
    public static extern DataTransferManager GetForCurrentView();
  }
}
