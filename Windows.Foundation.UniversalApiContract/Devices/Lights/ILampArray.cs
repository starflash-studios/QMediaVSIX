// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.ILampArray
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Storage.Streams;
using Windows.System;
using Windows.UI;

namespace Windows.Devices.Lights
{
  [Guid(2060359559, 51360, 20117, 161, 224, 213, 134, 118, 83, 134, 73)]
  [ExclusiveTo(typeof (LampArray))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface ILampArray
  {
    string DeviceId { get; }

    ushort HardwareVendorId { get; }

    ushort HardwareProductId { get; }

    ushort HardwareVersion { get; }

    LampArrayKind LampArrayKind { get; }

    int LampCount { get; }

    TimeSpan MinUpdateInterval { get; }

    Vector3 BoundingBox { get; }

    bool IsEnabled { get; set; }

    double BrightnessLevel { get; set; }

    bool IsConnected { get; }

    bool SupportsVirtualKeys { get; }

    LampInfo GetLampInfo(int lampIndex);

    int[] GetIndicesForKey(VirtualKey key);

    int[] GetIndicesForPurposes(LampPurposes purposes);

    void SetColor(Color desiredColor);

    void SetColorForIndex(int lampIndex, Color desiredColor);

    void SetSingleColorForIndices(Color desiredColor, int[] lampIndexes);

    void SetColorsForIndices(Color[] desiredColors, int[] lampIndexes);

    void SetColorsForKey(Color desiredColor, VirtualKey key);

    void SetColorsForKeys(Color[] desiredColors, VirtualKey[] keys);

    void SetColorsForPurposes(Color desiredColor, LampPurposes purposes);

    [RemoteAsync]
    IAsyncAction SendMessageAsync(int messageId, IBuffer message);

    [RemoteAsync]
    IAsyncOperation<IBuffer> RequestMessageAsync(int messageId);
  }
}
