// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.Provider.IPerceptionFrameProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception.Provider
{
  /// <summary>Represents an object that can produce PerceptionFrames.</summary>
  /// <deprecated type="deprecate">IPerceptionFrameProvider may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("IPerceptionFrameProvider may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Guid(2035251897, 45949, 15155, 161, 13, 48, 98, 100, 25, 206, 101)]
  public interface IPerceptionFrameProvider : IClosable
  {
    /// <summary>Gets the PerceptionFrameProviderInfo describing this device.</summary>
    /// <returns>The PerceptionFrameProviderInfo describing this device.</returns>
    PerceptionFrameProviderInfo FrameProviderInfo { [Deprecated("IPerceptionFrameProvider may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets a value indicating whether or not the device is ready to start producing PerceptionFrames.</summary>
    /// <returns>Whether or not the device is ready to start producing PerceptionFrames.</returns>
    bool Available { [Deprecated("IPerceptionFrameProvider may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>The properties describing the device and the frames produced by the device.</summary>
    /// <returns>The properties describing the device and the frames produced by the device. PropertyType::Inspectable is not supported as a property value.</returns>
    IPropertySet Properties { [Deprecated("IPerceptionFrameProvider may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Tells the device to start producing frames. If success is returned, PerceptionFrameProviderManagerService::PublishFrameForProvider is expected to be called by this Provider.</summary>
    /// <deprecated type="deprecate">IPerceptionFrameProvider may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    [Deprecated("IPerceptionFrameProvider may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void Start();

    /// <summary>Tells the device to stop producing frames. Called only after Start is called and only if Start returns success.</summary>
    /// <deprecated type="deprecate">IPerceptionFrameProvider may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    [Deprecated("IPerceptionFrameProvider may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void Stop();

    /// <summary>The device is requested to update one of its Properties to a new value.</summary>
    /// <deprecated type="deprecate">IPerceptionFrameProvider may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.</deprecated>
    /// <param name="value">Success or failure will be conveyed to the app.</param>
    [Deprecated("IPerceptionFrameProvider may be unavailable after Windows Creator Update. Please refer to AVStream on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    void SetProperty(PerceptionPropertyChangeRequest value);
  }
}
