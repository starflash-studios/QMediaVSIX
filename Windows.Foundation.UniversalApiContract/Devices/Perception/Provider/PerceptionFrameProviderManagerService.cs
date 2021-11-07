// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  /// <summary>Static methods for managing IPerceptionFrameProvider registration and unregistration, PerceptionFaceAuthenticationGroup registration and unregistration, PerceptionControlGroup registration and unregistration, PerceptionCorrelationGroup registration and unregistration, IPerceptionFrameProvider availablity, and publishing a new PerceptionFrame for an IPerceptionFrameProvider.</summary>
  /// <deprecated type="deprecate">PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPerceptionFrameProviderManagerServiceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class PerceptionFrameProviderManagerService
  {
    /// <summary>Registers the PerceptionFrameProviderInfo in association with the given IPerceptionFrameProviderManager.</summary>
    /// <deprecated type="deprecate">PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="manager">The manager which can provide the IPerceptionFrameProvider associated with the info.</param>
    /// <param name="frameProviderInfo">The PerceptionFrameProviderInfo which identifies the available IPerceptionFrameProvider.</param>
    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void RegisterFrameProviderInfo(
      IPerceptionFrameProviderManager manager,
      PerceptionFrameProviderInfo frameProviderInfo);

    /// <summary>Unregisters the PerceptionFrameProviderInfo in association with the given IPerceptionProviderManager.</summary>
    /// <deprecated type="deprecate">PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="manager">The manager which previously registered this info.</param>
    /// <param name="frameProviderInfo">The PerceptionFrameProviderInfo which identifies the IPerceptionFrameProvider.</param>
    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void UnregisterFrameProviderInfo(
      IPerceptionFrameProviderManager manager,
      PerceptionFrameProviderInfo frameProviderInfo);

    /// <summary>Registers a PerceptionFaceAuthenticationGroup associated with the given IPerceptionProviderManager.</summary>
    /// <deprecated type="deprecate">PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="manager">The manager that owns the lifetime of the group.</param>
    /// <param name="faceAuthenticationGroup">The group of IPerceptionFrameProvider(s) to atomically control.</param>
    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void RegisterFaceAuthenticationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionFaceAuthenticationGroup faceAuthenticationGroup);

    /// <summary>Unregisters a PerceptionFaceAuthenticationGroup in association with the given IPerceptionProviderManager.</summary>
    /// <deprecated type="deprecate">PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="manager">The manager that owns the lifetime of the group.</param>
    /// <param name="faceAuthenticationGroup">The PerceptionFaceAuthenticationGroup to unregister.</param>
    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void UnregisterFaceAuthenticationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionFaceAuthenticationGroup faceAuthenticationGroup);

    /// <summary>Registers a PerceptionControlGroup associated with the IPerceptionFrameProviderManager.</summary>
    /// <deprecated type="deprecate">PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="manager">The manager that owns the lifetime of the group.</param>
    /// <param name="controlGroup">The group of IPerceptionFrameProvider(s) to control atomically.</param>
    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void RegisterControlGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionControlGroup controlGroup);

    /// <summary>Removes the registration of a previously registered PerceptionControlGroup.</summary>
    /// <deprecated type="deprecate">PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="manager">The manager that owns the lifetime of the group.</param>
    /// <param name="controlGroup">The group of IPerceptionFrameProvider(s) to prevent from being controlled.</param>
    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void UnregisterControlGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionControlGroup controlGroup);

    /// <summary>Registers a PerceptionCorrelationGroup associated with the IPerceptionFrameProviderManager.</summary>
    /// <deprecated type="deprecate">PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="manager">The manager that owns the lifetime of the group.</param>
    /// <param name="correlationGroup">The group of PerceptionCorrelations(s) to control atomically.</param>
    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void RegisterCorrelationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionCorrelationGroup correlationGroup);

    /// <summary>Unregisters a PerceptionCorrelationGroup associated with the IPerceptionFrameProviderManager.</summary>
    /// <deprecated type="deprecate">PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="manager">The manager that owns the lifetime of the group.</param>
    /// <param name="correlationGroup">The PerceptionCorrelationGroup to unregister.</param>
    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void UnregisterCorrelationGroup(
      IPerceptionFrameProviderManager manager,
      PerceptionCorrelationGroup correlationGroup);

    /// <summary>Sets whether or not the IPerceptionFrameProvider is available.</summary>
    /// <deprecated type="deprecate">PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="provider">The provider to set availability for.</param>
    /// <param name="available">Whether or not the provider is available.</param>
    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void UpdateAvailabilityForProvider(
      IPerceptionFrameProvider provider,
      bool available);

    /// <summary>Sends the PerceptionFrame to the service to tell any apps listening for frames for the provided provider. Frames aren't expected to be published before IPerceptionFrameProvider::Start() is called or after IPerceptionFrameProvider::Stop() is called.</summary>
    /// <deprecated type="deprecate">PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="provider">The IPerceptionFrameProvider which produced the frame.</param>
    /// <param name="frame">The PerceptionFrame that was produced and should be sent to apps.</param>
    [Deprecated("PerceptionFrameProviderManagerService may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern void PublishFrameForProvider(
      IPerceptionFrameProvider provider,
      PerceptionFrame frame);
  }
}
