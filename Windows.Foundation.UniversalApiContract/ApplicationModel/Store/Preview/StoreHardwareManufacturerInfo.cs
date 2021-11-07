// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.StoreHardwareManufacturerInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  /// <summary>Provides information about the manufacturer for the current device.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StoreHardwareManufacturerInfo : IStoreHardwareManufacturerInfo
  {
    /// <summary>Gets the hardware manufacture ID for the current device.</summary>
    /// <returns>The hardware manufacture ID for the current device.</returns>
    public extern string HardwareManufacturerId { [MethodImpl] get; }

    /// <summary>Gets the ID of the Microsoft Store content modifier.</summary>
    /// <returns>The ID of the Microsoft Store content modifier.</returns>
    public extern string StoreContentModifierId { [MethodImpl] get; }

    /// <summary>Gets the model name for the current device.</summary>
    /// <returns>The model name for the current device.</returns>
    public extern string ModelName { [MethodImpl] get; }

    /// <summary>Gets the name of the hardware manufacturer for the current device.</summary>
    /// <returns>The name of the hardware manufacturer for the current device.</returns>
    public extern string ManufacturerName { [MethodImpl] get; }
  }
}
